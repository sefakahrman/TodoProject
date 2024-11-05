using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoProject.Repository.Contexts;
using TodoProject.Repository.Repositories.Abstracts;
using TodoProject.Repository.Repositories.Concretes;

namespace TodoProject.Repository.Repositories;

public static class RepositoryDependencies
{

    public static IServiceCollection AddRepositoryDepencdencies(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ITodoRepository, EfTodoRepository>();
        services.AddScoped<ICategoryRepository, EfCategoryRepository>();
        services.AddDbContext<BaseDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("SqlConnection")));
        return services;
    }
}