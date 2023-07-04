using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Resume.Models
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"
            Server=(localdb)\MSSQLLocalDB;
            DataBase = MyDataBase;
            Trusted_Connection=True;
            ");
        }
        public DbSet<Application> Applications { get; set; }
    }
}
