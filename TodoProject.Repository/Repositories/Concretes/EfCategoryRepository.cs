using Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoProject.Models.Entities;
using TodoProject.Repository.Contexts;
using TodoProject.Repository.Repositories.Abstracts;

namespace TodoProject.Repository.Repositories.Concretes;
public class EfCategoryRepository : EfRepositoryBase<BaseDbContext, Category, int>, ICategoryRepository
{

    public EfCategoryRepository(BaseDbContext context) : base(context)
    {

    }
}