using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfQuestionDal : EfEntityRepository<Question, DataContext>, IQuestionRepository
    {
        /*public List<Question> GetAllQuestionsWithRelations()
        {
            using (var context = new DataContext())
            {
                return context.Questions.Include(q => q.Category).Include(q => q.User).ToList();
            }
        }*/
    }
}
