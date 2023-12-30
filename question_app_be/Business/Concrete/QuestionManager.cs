using Business.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class QuestionManager : IQuestionService
    {
        private EfQuestionDal _efQuestionDal = new EfQuestionDal();

        public Question Create(Question entity)
        {
            _efQuestionDal.Create(entity);
            return entity;
        }

        public Boolean Delete(int id)
        {
            _efQuestionDal.Delete(_efQuestionDal.Get(p => p.Id == id));
            return true;
        }

        public Question Get(int id)
        {
            return _efQuestionDal.Get(q => q.Id == id);
        }

        public List<Question> GetAll()
        {
            return _efQuestionDal.GetAll(null);
        }

        public Boolean Update(Question request)
        {
            _efQuestionDal.Update(request);
            return true;
        }
    }
}
