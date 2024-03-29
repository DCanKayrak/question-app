﻿using AutoMapper;
using Business.Abstract;
using Business.Constants;
using Business.DependencyResolvers.Mapper;
using Core.Utilities.Results.Abstract;
using Core.Utilities.Results.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dto.Response;
using Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        private IMapper _mapper;
        public CategoryManager(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        public IDataResult<CategoryResponse> Create(Category entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<CategoryResponse> Get(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CategoryResponse>> GetAll()
        {
            return new SuccessDataResult<List<CategoryResponse>>(MapperHelper<Category,CategoryResponse>.MapList(_categoryRepository.GetAll(null)));
        }

        public IResult Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
