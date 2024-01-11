using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Dto.Request.AnswerImg
{
    public class UpdateAnswerImgDto
    {
        public int UserId { get; set; }
        public int QuestionId { get; set; }
        public string FilePath { get; set; }
    }
}
