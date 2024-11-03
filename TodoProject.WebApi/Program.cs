using Microsoft.AspNetCore.Identity;
using TodoProject.Repository.Repositories.Abstracts;
using TodoProject.Repository.Repositories.Abstracts.Concretes;
using TodoProject.Service.Abstracts;
using TodoProject.Service.Concretes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<ITodoService, TodoService>();
builder.Services.AddScoped<ITodoRepository, EfTodoRepository>();


builder.Services.AddScoped<IUserService, UserService>();

builder.Services.AddIdentity<UserService,IdentityRole>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
