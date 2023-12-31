﻿using Core.Entity.Concrete;
using Entities.Concrete.Dto.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService : ICrudService<User,UserResponse>
    {
        List<OperationClaim> GetClaims(User user);
        User GetAuthUser();
        User GetByMail(string email);
    }
}
