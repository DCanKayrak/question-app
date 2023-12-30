using Autofac;
using Business.Abstract;
using Business.Concrete;
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
            builder.RegisterType<QuestionManager>().As<IQuestionService>();
            builder.RegisterType<CategoryManager>().As<ICategoryService>();

            // Repository
            builder.RegisterType<EfAuthDal>().As<IAuthRepository>();
            builder.RegisterType<EfQuestionDal>().As<IQuestionRepository>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryRepository>();

            base.Load(builder);
        }
    }
}
