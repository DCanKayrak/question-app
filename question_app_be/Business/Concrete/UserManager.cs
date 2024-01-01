using Business.Abstract;
using Core.Entity.Concrete;
using DataAccess.Abstract;
using Entities.Concrete.Dto.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private IUserRepository _userRepository;

        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User Create(User entity)
        {
            _userRepository.Create(entity);
            return entity;
        }

        public void Delete(int id)
        {
            _userRepository.Delete(_userRepository.Get(u=>u.Id == id));
        }

        public User Get(int id)
        {
            return _userRepository.Get(u=>u.Id == id);
        }

        public List<User> GetAll()
        {
            return _userRepository.GetAll(null);
        }
        public User GetByMail(string email)
        {
            return _userRepository.Get(u => u.Email == email);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userRepository.GetClaims(user);
        }

        public void Update(User entity)
        {
            _userRepository.Update(entity);
        }
    }
}
