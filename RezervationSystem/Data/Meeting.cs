using RezervationSystem.Enums;

namespace RezervationSystem.Data;

public class Meeting
{
    public Guid Id { get; set; }
    public DateTime MeetingDate { get; set; }
    public EmployeePosition Position { get; set; }
    public string? ClientId { get; set; }
    public virtual ApplicationUser Client { get; set; }

    public string? EmployeeId { get; set; }
    public virtual ApplicationUser Employee { get; set; }
    
    public Guid BranchId { get; set; }
    public virtual BankBranch Branch { get; set; }
}