using System.Runtime.InteropServices.JavaScript;
using Microsoft.EntityFrameworkCore;
using RezervationSystem.Data;
using RezervationSystem.Enums;

namespace RezervationSystem.Services;

public class MeetingService
{
    private readonly ApplicationDbContext _database;

    public MeetingService(ApplicationDbContext database)
    {
        _database = database;
    }

    public List<Meeting> GetFreeMeetingDates()
    {
        var meetings = _database.Meetings.Include(x => x.Branch)
            .Where(x => string.IsNullOrEmpty(x.ClientId) && string.IsNullOrEmpty(x.EmployeeId)).ToList();
        return meetings;
    }

    public List<Meeting> GetFreeMeetingsByPositionAndPlace(EmployeePosition position, Guid branchId)
    {
        var meetings = _database.Meetings.Include(x => x.Branch)
            .Where(x => string.IsNullOrEmpty(x.ClientId) && string.IsNullOrEmpty(x.EmployeeId) && x.Position == position && x.BranchId == branchId).ToList();
        return meetings;
    }
    
    public List<Meeting> GetReservedMeetingsByPositionAndPlace(EmployeePosition position, Guid branchId)
    {
        var meetings = _database.Meetings.Include(x => x.Branch)
            .Where(x => !string.IsNullOrEmpty(x.ClientId) && string.IsNullOrEmpty(x.EmployeeId) && x.Position == position).ToList();
        return meetings;
    }
    
    public List<Meeting> GetEmployeeMeetings(string employeeId)
    {
        var meetings = _database.Meetings.Include(x => x.Branch)
            .Where(x => x.EmployeeId == employeeId).ToList();
        return meetings;
    }
    
    public List<Meeting> GetFreeEmployeeMeetings()
    {
        var meetings = _database.Meetings.Include(x => x.Branch)
            .Where(x => x.ClientId != null && x.EmployeeId == null).ToList();
        return meetings;
    }
    
    public List<Meeting> GetClientMeetings(string clientId)
    {
        var meetings = _database.Meetings.Include(x => x.Branch)
            .Where(x => x.ClientId == clientId).ToList();
        return meetings;
    }

    public bool ReserveMeeting(Guid meeting, string clientId)
    {
        var meet = _database.Meetings.FirstOrDefault(x => x.Id == meeting && string.IsNullOrEmpty(x.ClientId) && string.IsNullOrEmpty(x.EmployeeId));
        if (meet == null)
            return false;

        meet.ClientId = clientId;
        _database.SaveChanges();
        return true;
    }
    public bool AgreeMeeting(Guid meeting, string employeeId)
    {
        var meet = _database.Meetings.FirstOrDefault(x => x.Id == meeting && !string.IsNullOrEmpty(x.ClientId) && string.IsNullOrEmpty(x.EmployeeId));
        if (meet == null)
            return false;

        meet.EmployeeId = employeeId;
        _database.SaveChanges();
        return true;
    }
    
    public bool UnreserveMeeting(Guid meeting, string clientId)
    {
        var meet = _database.Meetings.FirstOrDefault(x => x.Id == meeting && x.ClientId == clientId);
        if (meet == null)
            return false;

        meet.ClientId = null;
        meet.EmployeeId = null;
        _database.SaveChanges();
        return true;
    }
    public bool DisagreeMeeting(Guid meeting, string employeeId)
    {
        var meet = _database.Meetings.FirstOrDefault(x => x.Id == meeting && x.EmployeeId == employeeId);
        if (meet == null)
            return false;

        meet.ClientId = null;
        meet.EmployeeId = null;
        _database.SaveChanges();
        return true;
    }

    public void AddMeetings(List<Meeting> meetings)
    {
        foreach (var meeting in meetings)
        {
            _database.Meetings.Add(meeting);
        }

        _database.SaveChanges();
    }
}