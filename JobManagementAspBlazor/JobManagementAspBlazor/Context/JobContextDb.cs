using JobManagementAspBlazor.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobManagementAspBlazor.Context
{
    public class JobContextDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\SQLEXPRESS;Initial Catalog=JobManagementDb;Integrated Security=True");
        }
        public DbSet<Job> Jobs { get; set; }
    }
   
}
