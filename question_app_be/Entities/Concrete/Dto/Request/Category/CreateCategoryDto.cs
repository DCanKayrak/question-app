﻿using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Dto.Request.Category
{
    public class CreateCategoryDto : IDto
    {
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
