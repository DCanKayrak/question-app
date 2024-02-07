using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Models
{
    public class AnswerImage : IEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public string FilePath { get; set; }
        public DateTime CreationTime { get; } = DateTime.Now;
    }
}
