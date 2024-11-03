
using Core.Repository;
using TodoProject.Models.Entities;
using TodoProject.Repository.Contexts;

namespace TodoProject.Repository.Repositories.Abstracts.Concretes;

public class EfTodoRepository : EfRepositoryBase<BaseDbContext, Todo, Guid>, ITodoRepository
{
    public EfTodoRepository(BaseDbContext context) : base(context)
    {
    }
}
