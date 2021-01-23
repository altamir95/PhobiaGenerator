using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace ScaryQuestions.Models
{
    public class ScaryQuestionsContext : DbContext
    {
        public DbSet<Question> Questions { get; set; }
        public ScaryQuestionsContext(DbContextOptions<ScaryQuestionsContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}
