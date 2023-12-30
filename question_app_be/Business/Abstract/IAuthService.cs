using Entities.Concrete;
using Entities.Concrete.Dto.Request.Auth;
using Entities.Concrete.Dto.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IAuthService : IService
    {
        public Task<BaseResponse<AuthResponse>> Register(RegisterRequestDto request);
        public Task<BaseResponse<AuthResponse>> Login(LoginRequestDto request);
    }
}
