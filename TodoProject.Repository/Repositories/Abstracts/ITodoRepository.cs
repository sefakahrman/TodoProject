
using Core.Repository;
using TodoProject.Models.Entities;

namespace TodoProject.Repository.Repositories.Abstracts;

public interface ITodoRepository : IRepository<Todo,Guid>
{

}
