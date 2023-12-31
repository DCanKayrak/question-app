﻿using Core.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.Dto.Response
{
    public class QuestionResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public CategoryResponse Category { get; set; }
        public AnswerResponse Answer { get; set; }
        public UserResponse User { get; set; }
        public Boolean Status { get; set; }
    }
}
