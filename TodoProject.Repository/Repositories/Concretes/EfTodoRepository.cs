
using Core.Repository;
using TodoProject.Models.Entities;
using TodoProject.Repository.Contexts;
using TodoProject.Repository.Repositories.Abstracts;

namespace TodoProject.Repository.Repositories.Concretes;

public class EfTodoRepository : EfRepositoryBase<BaseDbContext, Todo, Guid>, ITodoRepository
{
    public EfTodoRepository(BaseDbContext context) : base(context)
    {
    }
}
