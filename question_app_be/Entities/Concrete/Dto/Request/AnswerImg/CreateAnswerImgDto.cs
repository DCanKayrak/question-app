using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Dto.Request
{
    public class CreateAnswerImgDto
    {
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public IFormFile file { get; set; }
    }
}
