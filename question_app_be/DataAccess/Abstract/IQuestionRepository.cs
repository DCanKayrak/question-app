﻿using DataAccess.Concrete.EntityFramework.Context;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IQuestionRepository : IEntityRepository<Question>
    {
        //public List<Question> GetAllQuestionsWithRelations();
    }
}
