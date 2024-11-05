using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoProject.Models.Dtos.Tokens;
using TodoProject.Models.Entities;

namespace TodoProject.Service.Abstracts;

public interface IJwtService
{
    Task<TokenResponseDto> CreateToken(User user);
}