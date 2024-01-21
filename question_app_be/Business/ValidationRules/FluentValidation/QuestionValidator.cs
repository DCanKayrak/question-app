using Entities.Concrete;
using Entities.Concrete.Dto.Request.Question;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class QuestionValidator : AbstractValidator<Question>
    {
        public int CategoryId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public QuestionValidator()
        {
            RuleFor(req => req.Title).NotEmpty();
            RuleFor(req => req.Title).MinimumLength(3).WithMessage("Başlık en az 3 harften oluşmalıdır.");
            RuleFor(req => req.Description).NotEmpty();
        }
    }
}
