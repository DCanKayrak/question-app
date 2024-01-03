using Autofac;
using Business.Abstract;
using Business.Concrete;
using Core.Utilities.Security.JWT;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Services
            builder.RegisterType<AuthManager>().As<IAuthService>();
            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<QuestionManager>().As<IQuestionService>();
            builder.RegisterType<CategoryManager>().As<ICategoryService>();
            builder.RegisterType<AnswerManager>().As<IAnswerService>();
            builder.RegisterType<JwtHelper>().As<ITokenHelper>();

            // Repository
            builder.RegisterType<EfAuthDal>().As<IAuthRepository>();
            builder.RegisterType<EfUserDal>().As<IUserRepository>();
            builder.RegisterType<EfQuestionDal>().As<IQuestionRepository>();
            builder.RegisterType<EfAnswerDal>().As<IAnswerRepository>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryRepository>();

            base.Load(builder);
        }
    }
}
