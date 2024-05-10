using Microsoft.EntityFrameworkCore;
using RezervationSystem.Components;
using RezervationSystem.Data;

namespace RezervationSystem.Services;

public class DbService
{
    private readonly ApplicationDbContext _database;
    public DbService(ApplicationDbContext database)
    {
        _database = database;
    }

    public List<BankBranch> GetBranches()
    {
        return _database.BankBranches.ToList();
    }
}