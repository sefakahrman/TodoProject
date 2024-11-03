
using Microsoft.EntityFrameworkCore;
using TodoProject.Models.Entities;

namespace TodoProject.Repository.Contexts;

public class BaseDbContext : DbContext
{
    public BaseDbContext(DbContextOptions opt) : base(opt)
    {
        
    }

    public DbSet<Todo> Todos { get; set; }

}
