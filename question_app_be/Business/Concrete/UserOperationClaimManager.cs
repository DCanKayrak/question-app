﻿using Business.Abstract;
using Core.Entity.Concrete;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserOperationClaimManager : IUserOperationClaimService
    {
        private IUserOperationClaimRepository _userOperationClaimRepository;

        public UserOperationClaimManager(
            IUserOperationClaimRepository userOperationClaimRepository
            )
        {
            _userOperationClaimRepository = userOperationClaimRepository;
        }
        public IDataResult<UserOperationClaim> Create(UserOperationClaim entity)
        {
            _userOperationClaimRepository.Create(entity);
            return new SuccessDataResult<UserOperationClaim>( entity );
        }

        public IResult Delete(int id)
        {
            _userOperationClaimRepository.Delete(this.Get(id).Data);
            return new SuccessResult();
        }

        public IDataResult<UserOperationClaim> Get(int id)
        {
            return new SuccessDataResult<UserOperationClaim>(_userOperationClaimRepository.Get(o=>o.Id == id));
        }

        public IDataResult<List<UserOperationClaim>> GetAll()
        {
            return new SuccessDataResult<List<UserOperationClaim>>(_userOperationClaimRepository.GetAll(null));
        }

        public IResult Update(UserOperationClaim entity)
        {
            _userOperationClaimRepository.Update(entity);
            return new SuccessResult();
        }
    }
}
