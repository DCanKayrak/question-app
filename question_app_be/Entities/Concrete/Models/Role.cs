using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Models
{
    public class Role : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
