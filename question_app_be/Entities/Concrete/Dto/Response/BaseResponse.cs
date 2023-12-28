using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Dto.Response
{
    public class BaseResponse<T>
    {
        public bool status { get; set; }
        public T data { get; set; }
    }
}
