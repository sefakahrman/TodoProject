

using TodoProject.Models.Entities.Enum;
using TodoProject.Models.Entities;

namespace TodoProject.Models.Dtos.Todo;

public sealed record CreateTodoRequestDto(string Title, string Description, Priority Priority, int CategoryId);
