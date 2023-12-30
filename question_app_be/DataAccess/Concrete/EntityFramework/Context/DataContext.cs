using Entities.Concrete;
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
        private IConfiguration _configuration;

        public DbSet<Question> Questions { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("User ID=postgres;Password=postgres;Server=localhost;Port=5433;Database=question_app;Integrated Security=true;Pooling=true;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // User ve Question arasında bir ilişki tanımlama
            modelBuilder.Entity<Question>()
                .HasOne(u => u.User)
                .WithMany(p => p.Questions)
                .HasForeignKey(p => p.UserId)
                .OnDelete(DeleteBehavior.Cascade); // İlişkiyi silindiğinde bağlı soruları da sil
        }
    }
}
