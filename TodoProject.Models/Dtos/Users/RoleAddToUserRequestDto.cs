﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoProject.Models.Dtos.Users;

public sealed record RoleAddToUserRequestDto(string UserId, string RoleName);