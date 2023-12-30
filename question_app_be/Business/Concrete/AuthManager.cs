using Business.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dto.Request.Auth;
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

        public Task<BaseResponse<AuthResponse>> Login(LoginRequestDto request)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResponse<AuthResponse>> Register(RegisterRequestDto request)
        {
            throw new NotImplementedException();
        }
    }
}
