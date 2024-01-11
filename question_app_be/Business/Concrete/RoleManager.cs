using Business.Abstract;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RoleManager : IRoleService
    {
        private IRoleRepository _roleRepository;

        public RoleManager(
            IRoleRepository roleRepository
            )
        {
            _roleRepository = roleRepository;
        }
        public IDataResult<Role> Create(Role entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Role> Get(int id)
        {
            return new SuccessDataResult<Role>(_roleRepository.Get(r=>r.Id == id));
        }

        public IDataResult<List<Role>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Role entity)
        {
            throw new NotImplementedException();
        }
    }
}
