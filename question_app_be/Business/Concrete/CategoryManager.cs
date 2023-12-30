using AutoMapper;
using Business.Abstract;
using Core.Utilities.ExceptionHandler;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dto.Response;
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
        public BaseResponse<Category> Create(Category entity)
        {
            try
            {
                _categoryRepository.Create(entity);
                return new BaseResponse<Category>(entity);
            }
            catch (GenericException ex)
            {
                throw ex;
            }
            
        }

        public BaseResponse<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public BaseResponse<Category> Get(int id)
        {
            throw new NotImplementedException();
        }

        public BaseResponse<List<Category>> GetAll()
        {
            throw new NotImplementedException();
        }

        public BaseResponse<bool> Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
