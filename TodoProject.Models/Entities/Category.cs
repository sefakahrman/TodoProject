
using Core.Entities;

namespace TodoProject.Models.Entities;

public sealed class Category : Entity<int>
{
    public string Name { get; set; }
    List<Todo> Todos { get; set; }
}
