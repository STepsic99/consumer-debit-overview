using ConsumerDebit.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumerDebit.Repository
{
    public class ConsumerDebitDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ConsumerDebitDbContext(DbContextOptions<ConsumerDebitDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { IDUser = "S00001", Owner = "Novakovic Petar", Password = "317D" },
                new User { IDUser = "S00002", Owner = "Miloševic Dragan", Password = "EFFC" },
                new User { IDUser = "S00003", Owner = "Bardak Željko", Password = "5110" }
            );
        }
    }
}
