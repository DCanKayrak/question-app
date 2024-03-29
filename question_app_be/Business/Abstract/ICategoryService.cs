﻿using Entities.Concrete;
using Entities.Concrete.Dto.Response;
using Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService : ICrudService<Category,CategoryResponse>
    {
    }
}
