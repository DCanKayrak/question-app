using Business.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dto.Request;
using Entities.Concrete.Dto.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class AuthManager : IAuthService
    {
        public User Create(User entity)
        {
            throw new NotImplementedException();
        }

        public Boolean Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<AuthResponse>> Login(LoginRequestDto request)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<AuthResponse>> Register(RegisterRequestDto request)
        {
            throw new NotImplementedException();
        }

        public Boolean Update(User request)
        {
            throw new NotImplementedException();
        }
    }
}
