using Core.Entity.Concrete;
using Entities.Concrete;
using Entities.Concrete.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Category {  get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<AnswerImage> AnswerImages { get; set; }

        private IConfiguration _configuration;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=postgres;Server=localhost;Port=5433;Database=question_app;Integrated Security=true;Pooling=true;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
