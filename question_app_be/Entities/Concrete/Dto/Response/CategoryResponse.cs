using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete.Models;

namespace Entities.Concrete.Dto.Response
{
    public class CategoryResponse
    {
        public int Id { get; set; }
        public int parentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Question> Questions { get; set; }
    }
}
