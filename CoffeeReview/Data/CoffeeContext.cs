using CoffeeReview.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeReview
{
    public class CoffeeContext : DbContext
    {
        public DbSet<Coffee> Coffees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = "Server=(localdb)\\mssqllocaldb;Database=CoffeeTesting;Trusted_Connection=True;";

            optionsBuilder.UseSqlServer(connectionString)
                          .UseLazyLoadingProxies();

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Coffee>().HasData(

                new Coffee(1, "Cleveland Coffee", "Bright Side Blend", "happyhappy stuff", "/images/brightsideblend.jpg"),

                new Coffee()
                {
                    Id = 2,
                    Brand = "",
                    Kind = "",
                    Description = "",
                    ImageUrl = "",

                },

                new Coffee()
                {
                    Id = 3,
                    Brand = "",
                    Kind = "",
                    Description = "",
                    ImageUrl = "",
                },
                new Coffee()
                {
                    Id = 4,
                    Brand = "",
                    Kind = "",
                    Description = "",
                    ImageUrl = "",

                },
                new Coffee()
                {
                    Id = 5,
                    Brand = "",
                    Kind = "",
                    Description = "",
                    ImageUrl = "",

                },
                new Coffee()
                {
                    Id = 6,
                    Brand = "",
                    Kind = "",
                    Description = "",
                    ImageUrl = "",

                },
                new Coffee()
                {
                    Id = 7,
                    Brand = "",
                    Kind = "",
                    Description = "",
                    ImageUrl = "",

                },
                new Coffee()
                {
                    Id = 8,
                    Brand = "",
                    Kind = "",
                    Description = "",
                    ImageUrl = "",

                },
                new Coffee()
                {
                    Id = 9,
                    Brand = "",
                    Kind = "",
                    Description = "",
                    ImageUrl = "",

                }
 



            );
            base.OnModelCreating(modelBuilder);
        }
    }   
}    



    


