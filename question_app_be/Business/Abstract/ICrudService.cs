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
        List<T> GetAll();
        T Get(int id);
        T Create(T entity);
        void Update(T entity);
        void Delete(int id);
    }
}
