using AspNet_Project_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet_Project_Api.DAL.ApiContext
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MEHMETCAN-PC\\SQLEXPRESS;database=dbPortfoliosInside;integrated security=true");
        }
        public DbSet<Category> Categories{ get; set; }
    }
}
