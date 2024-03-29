﻿using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Category : IEntity
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreationTime { get; } = DateTime.Now;
    }
}
