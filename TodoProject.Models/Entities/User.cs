
using Core.Entities;
using Microsoft.AspNetCore.Identity;
using System.Security.Principal;

namespace TodoProject.Models.Entities;

public sealed class User : IdentityUser
{
    public List<Todo> Todos { get; set; }
}
