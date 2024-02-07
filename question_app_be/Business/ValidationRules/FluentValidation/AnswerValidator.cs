using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Microsoft.AspNetCore.Http;

namespace Business.ValidationRules.FluentValidation
{
    public class AnswerValidator : AbstractValidator<Answer>
    {
        private IUserService _userService;
        private IQuestionRepository _questionRepository;

        private int UserId { get; set; }
        public int QuestionId { get; set; }
        public string Text { get; set; }
        
        public AnswerValidator()
        {
            RuleFor(a => a.Text).MinimumLength(3).WithMessage("Cevabınız minimum 3 harften oluşmalıdır.");
            //RuleFor(a => a.UserId).Must(CheckUser).WithMessage("Kullanıcı bulunamadı!");
            //RuleFor(a => a.QuestionId).Must(CheckQuestion).WithMessage("Soru bulunamadı!");
        }

        /*public Boolean CheckQuestion(int id)
        {
            var q = _questionRepository.Get(u => u.Id == id);
            return q != null;
        }
        public Boolean CheckUser(int id)
        {
                var user = _userRepository.Get(u => u.Id == id);
                return user != null;
        }*/
    }
}
