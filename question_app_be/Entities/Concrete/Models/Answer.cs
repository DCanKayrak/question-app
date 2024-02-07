using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Answer : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public string Text { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
    }
}
