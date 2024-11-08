﻿using TodoProject.Models.Entities;
using TodoProject.Models.Entities.Enum;

namespace TodoProject.Models.Dtos.Todo;
public record TodoResponseDto(Guid Id, string Title, string Description, Priority Priority, int CategoryId);