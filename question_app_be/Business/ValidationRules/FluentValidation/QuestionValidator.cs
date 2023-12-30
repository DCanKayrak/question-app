using Entities.Concrete.Dto.Request.Question;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class QuestionValidator : AbstractValidator<CreateQuestionDto>
    {
        public int UserId { get; set; }
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public QuestionValidator()
        {
            RuleFor(c => c.UserId).GreaterThan(0);
        }
    }
}
