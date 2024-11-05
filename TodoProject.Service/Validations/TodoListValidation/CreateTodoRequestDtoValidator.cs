using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoProject.Models.Dtos.Todo;

namespace TodoProject.Service.Validations.TodoListValidation;

public class CreatePostRequestDtoValidator : AbstractValidator<CreateTodoRequestDto>
{
    public CreatePostRequestDtoValidator()
    {
        RuleFor(x => x.Title).NotEmpty().WithMessage("Yapılacak işler Başlığı boş olamaz.")
            .Length(3, 35).WithMessage("Todo Başlığı Minimum 2 max 50 karakterli olmalıdır.");


        RuleFor(x => x.Description).NotEmpty().WithMessage("Todo İçeriği boş olamaz.")
            .Length(3, 100).WithMessage("Todo Açıklaması Minimum 2 max 50 karakterli olmalıdır.");
    }
}