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

        public DbSet<Traffic> Traffics { get; set; }

        public ConsumerDebitDbContext()
        {

        }

        protected override void OnConfiguring(Microsoft.EntityFrameworkCore.DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=consumerCard;User Id=postgres;Password=admin");
        }

        public ConsumerDebitDbContext(DbContextOptions<ConsumerDebitDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { IDUser = "S00001", Owner = "Novakovic Petar", Password = "317D" },
                new User { IDUser = "S00002", Owner = "Miloševic Dragan", Password = "EFFC" },
                new User { IDUser = "S00003", Owner = "Bardak Željko", Password = "5110" }
            );

            modelBuilder.Entity<Traffic>().HasData(
                new Traffic { ID = 1, UserId = "S00001", Date = new DateTime(2021,1,1), Document= "Početno stanje", Owes= 580, Claims = 0 },
                new Traffic { ID = 2, UserId = "S00002", Date = new DateTime(2021, 1, 1), Document = "Početno stanje", Owes = 0, Claims = 581 },
                new Traffic { ID = 3, UserId = "S00003", Date = new DateTime(2021, 1, 1), Document = "Početno stanje", Owes = 1154, Claims = 0 }
            );
        }
    }
}
