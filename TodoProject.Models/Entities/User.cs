
using Core.Entities;
using System.Security.Principal;

namespace TodoProject.Models.Entities;

public sealed class User :Entity<string>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

}
