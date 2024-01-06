using Core.Utilities.Results.Abstract;
using Entities.Concrete.Dto.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICrudService<TEntity,TDto> : IService
    {
        IDataResult<List<TDto>> GetAll();
        IDataResult<TDto> Get(int id);
        IDataResult<TDto> Create(TEntity entity);
        IResult Update(TEntity entity);
        IResult Delete(int id);
    }
}
