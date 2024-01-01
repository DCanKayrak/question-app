﻿using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Dto.Request.Auth
{
    public class LoginRequestDto : IDto
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
