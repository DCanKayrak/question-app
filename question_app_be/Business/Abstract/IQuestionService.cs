using Entities.Concrete;
using Entities.Concrete.Dto.Response;
using Entities.Concrete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results.Abstract;
using System.Reflection;

namespace Business.Abstract
{
    public interface IQuestionService : ICrudService<Question,QuestionResponse>
    {
        public IDataResult<List<QuestionResponse>> GetWithString(string q);
        public IResult ChangeStatus(int id);
    }
}
