﻿using Core.Entity.Abstract;
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
        public string Message { get; set; }
        public T Data { get; set; }

        public BaseResponse(T data)
        {
            Data = data;
        }
    }
}
