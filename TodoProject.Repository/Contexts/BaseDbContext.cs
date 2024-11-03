
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TodoProject.Models.Entities;

namespace TodoProject.Repository.Contexts;

public class BaseDbContext : IdentityDbContext<User,IdentityRole,string>
{
    public BaseDbContext(DbContextOptions opt) : base(opt)
    {
        
    }

    public DbSet<Todo> Todos { get; set; }

}
