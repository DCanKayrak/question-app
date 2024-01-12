using Autofac;
using Autofac.Extras.DynamicProxy;
using Business.Abstract;
using Business.Concrete;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
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
            builder.RegisterType<AnswerImageManager>().As<IAnswerImageService>();
            builder.RegisterType<RoleManager>().As<IRoleService>();
            builder.RegisterType<UserOperationManager>().As<IUserOperationClaimService>();

            // Repository
            builder.RegisterType<EfAuthDal>().As<IAuthRepository>();
            builder.RegisterType<EfUserDal>().As<IUserRepository>();
            builder.RegisterType<EfQuestionDal>().As<IQuestionRepository>();
            builder.RegisterType<EfAnswerDal>().As<IAnswerRepository>();
            builder.RegisterType<EfCategoryDal>().As<ICategoryRepository>();
            builder.RegisterType<EfAnswerImageDal>().As<IAnswerImageRepository>();
            builder.RegisterType<EfRoleDal>().As<IRoleRepository>();
            builder.RegisterType<EfUserOperationClaimDal>().As<IUserOperationClaimRepository>();

            var assembly = System.Reflection.Assembly.GetExecutingAssembly();

            builder.RegisterAssemblyTypes(assembly).AsImplementedInterfaces()
                .EnableInterfaceInterceptors(new ProxyGenerationOptions()
                {
                    Selector = new AspectInterceptorSelector()
                }).SingleInstance();
        }
    }
}
