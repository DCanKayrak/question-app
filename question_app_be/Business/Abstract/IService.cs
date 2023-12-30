using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IService<T>
    {
        List<T> GetAll();
        T Get(int id);
        T Create(T entity);
        Boolean Update(T entity);
        Boolean Delete(int id);
    }
}
