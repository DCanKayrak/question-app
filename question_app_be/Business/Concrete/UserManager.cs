using Business.Abstract;
using Core.Entity.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete.Dto.Response;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Metadata;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserRepository _userRepository;
        private IHttpContextAccessor _httpContextAccessor;

        public UserManager(IUserRepository userRepository, IHttpContextAccessor httpContextAccessor)
        {
            _userRepository = userRepository;
            _httpContextAccessor = httpContextAccessor;
        }
        public IDataResult<User> Create(User entity)
        {
            _userRepository.Create(entity);
            return new SuccessDataResult<User>(entity);
        }

        public IResult Delete(int id)
        {
            _userRepository.Delete(_userRepository.Get(u=>u.Id == id));
            return new SuccessResult();
        }

        public IDataResult<User> Get(int id)
        {
            return new SuccessDataResult<User>(_userRepository.Get(u => u.Id == id));
        }

        public IDataResult<List<User>> GetAll()
        {
            return new SuccessDataResult<List<User>>(_userRepository.GetAll(null));
        }
        public User GetByMail(string email)
        {
            return _userRepository.Get(u=>u.Email == email);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userRepository.GetClaims(user);
        }

        public IResult Update(User entity)
        {
            _userRepository.Update(entity);
            return new SuccessResult();
        }

        public User GetAuthUser()
        {
            string email = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.Email).Value;
            return this.GetByMail(email);
        }
    }
}
