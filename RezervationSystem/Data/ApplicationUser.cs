using Microsoft.AspNetCore.Identity;
using RezervationSystem.Enums;

namespace RezervationSystem.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public EmployeePosition? Position { get; set; }
    public SystemRoles? Role { get; set; }
    
    public Guid? BranchId { get; set; }
    public virtual BankBranch Branch { get; set; }
}