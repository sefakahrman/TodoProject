using AutoMapper;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoProject.Models.Dtos.Todo;
using TodoProject.Models.Entities;
using TodoProject.Models.Entities.Enum;
using TodoProject.Repository.Repositories.Abstracts;
using TodoProject.Service.Concretes;

namespace Service.Test;

public class TodoServiceTest
{
    private TodoService _todoService;

    private Mock<ITodoRepository> _mockRepository;

    private Mock<IMapper> _mockMapper;

    private Mock<TodoBusinessRules> _mockRules;


    [SetUp]
    public void SetUp()
    {
        _mockRepository = new Mock<ITodoRepository>();
        _mockMapper = new Mock<IMapper>();
        _mockRules = new Mock<TodoBusinessRules>(_mockRepository.Object);

        _todoService = new TodoService(_mockRepository.Object, _mockMapper.Object, _mockRules.Object);
    }


    [Test]
    public async Task TodoService_WhenTodoAdded_ReturnSuccess()
    {

        // Arrange
        CreateTodoRequestDto dto = new CreateTodoRequestDto("deneme","aciklama",Priority.Normal,5);
        Todo todo = new Todo
        {
            Title = dto.Title,
            Description = dto.Description,
            Priority = dto.Priority,
            CategoryId = dto.CategoryId,
           
        };

        TodoResponseDto response = new TodoResponseDto
        {
            Id = new Guid("{EEF23537-D755-4B37-8A99-831089A5D0F1}"),
            CategoryId = 2,
            Description = "deneme",
            Priority = Priority.Low

       
        };

        _mockMapper.Setup(x => x.Map<Todo>(dto)).Returns(todo);
        _mockRepository.Setup(x => x.Add(todo)).Returns(todo);
        _mockMapper.Setup(x => x.Map<TodoResponseDto>(todo)).Returns(response);

        // Act 

        var result = await _todoService.Add(dto, "{AEF23537-D755-4B37-8A99-831089A5D0F1}");

        // Assert 
        Assert.IsTrue(result.Success);
        Assert.AreEqual(response, result.Data);
        Assert.AreEqual(200, result.Status);
        Assert.AreEqual("Görev eklendi.", result.Message);

    }

    [Test]
    public void TodoService_WhenPostIsPresent_RemovePost()
    {
        // Arrange
        Guid id = new Guid("{BEF23537-D755-4B37-8A99-831089A5D0F1}");
        Todo post = new Todo
        {
            CategoryId = 2,
            Description = "DENEME",
            Priority = Priority.Low,
            Title = "DENEMEEEE",
            StartDate = DateTime.Now,
            CreatedDate = DateTime.Now,
            
        };


        _mockRules.Setup(x => x.TodoIsPresent(id)).Returns(true);


        _mockRepository.Setup(x => x.GetById(id)).Returns(todo);
        _mockRepository.Setup(x => x.Delete(todo)).Returns(todo);


        // Act

        var result = _todoService.Delete(id);

        // Assert

        Assert.IsTrue(result.Success);
    }


}