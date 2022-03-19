using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.Concrete
{
    public class WeddingDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"(localdb)\mssqllocaldb;Database=WeddingDataBase;trusted_Connection=true");
        }

        public DbSet<Nisan> Nisanlar { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Kına> Kınalar { get; set; }
        public DbSet<Dugun> Dugunler { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProgramGenel> Programs { get; set; }


    }
}
