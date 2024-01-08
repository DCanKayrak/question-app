using Core.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Dto.Response
{
    public class AnswerResponse : IDto
    {
        public int Id { get; set; }
        public UserResponse User { get; set; }
        public int QuestionId { get; set; }
        public string Text { get; set; }
    }
}
