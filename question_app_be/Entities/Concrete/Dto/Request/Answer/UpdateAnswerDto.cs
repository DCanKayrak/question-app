using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Dto.Request.Answer
{
    public class UpdateAnswerDto : IDto
    {
        public int QuestionId { get; set; }
        public string Text { get; set; }
    }
}
