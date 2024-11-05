
using Core.Entities;
using Microsoft.AspNetCore.Identity;
using System.Security.Principal;

namespace TodoProject.Models.Entities;

public sealed class User : IdentityUser
{
    public DateTime BirthDate { get; set; }
    public List<Todo> Todos { get; set; }
}
