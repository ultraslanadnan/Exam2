using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Exam.Models
{
    public class MyDbContext : DbContext
    {
    

       public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
            
        }
        public DbSet<yazilar> yazilar { get; set; }
        public DbSet<sinavlar> sinavlar { get; set; }
        public DbSet<musteri> musteri { get; set; }
    }
    
}
