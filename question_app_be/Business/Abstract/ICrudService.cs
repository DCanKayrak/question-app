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
        BaseResponse<List<T>> GetAll();
        BaseResponse<T> Get(int id);
        BaseResponse<T> Create(T entity);
        BaseResponse<Boolean> Update(T entity);
        BaseResponse<Boolean> Delete(int id);
    }
}
