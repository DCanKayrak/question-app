using Core.Utilities.Results.Abstract;
using Entities.Concrete.Dto.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICrudService<T> : IService
    {
        IDataResult<List<T>> GetAll();
        IDataResult<T> Get(int id);
        IDataResult<T> Create(T entity);
        IResult Update(T entity);
        IResult Delete(int id);
    }
}
