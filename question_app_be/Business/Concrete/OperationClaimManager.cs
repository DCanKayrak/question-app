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
using Core.Entity.Concrete;

namespace Business.Concrete
{
    public class OperationClaimManager : IRoleService
    {
        private IOperationClaimRepository _operationClaimRepository;

        public OperationClaimManager(
            IOperationClaimRepository operationClaimRepository
            )
        {
            _operationClaimRepository = operationClaimRepository;
        }
        public IDataResult<OperationClaim> Get(string name)
        {
            return new SuccessDataResult<OperationClaim>(_operationClaimRepository.Get(c => c.Name == name));
        }

        public IDataResult<List<OperationClaim>> GetAll()
        {
            return new SuccessDataResult<List<OperationClaim>>(_operationClaimRepository.GetAll(null));
        }

        public IDataResult<OperationClaim> Get(int id)
        {
            return new SuccessDataResult<OperationClaim>(_operationClaimRepository.Get(c => c.Id == id));
        }

        public IDataResult<OperationClaim> Create(OperationClaim entity)
        {
            throw new NotImplementedException();
        }

        public IResult Update(OperationClaim entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
