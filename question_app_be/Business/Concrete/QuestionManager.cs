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
        private EfQuestionDal efQuestionDal = new EfQuestionDal();

        public Question Create(Question entity)
        {
            efQuestionDal.Create(entity);
            return entity;
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public Question Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Question> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
