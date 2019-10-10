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
                    new Coffee(2, "Cleveland Coffee", "Tanzanian Peaberry", "really good stuff", "/images/tanzanianpeaberry.jpg"),
                    new Coffee(3, "Rising Star", "Apo Cooperative", "makes happy", "/images/apocooperative.jpg"),
                    new Coffee(4, "Starbucks", "Komodo Dragon", "happyhappy stuff", "/images/komododragon.jpg"),
                    new Coffee(5, "8 O'Clock", "The Original", "great cheap coffee", "/images/theoriginal.jpg"),
                    new Coffee(6, "Brioso", "Santa Barbara Estate", "Pretty Solid", "/images/colombiasantabarbara.jpg"),
                    new Coffee(7, "8 O'Clock", "Red Eye Roast", "excellent for the cost", "/images/redeyeroast.jpg"),
                    new Coffee(8, "Peets", "Costa Rica Peaberry", "Deliciousness", "/images/costaricapeaberry.jpg"),
                    new Coffee(9, "Dunkin' Donuts", "Dunkin Decaf", "Horrible", "/images/dunkindecaf.jpg")
                            );

            base.OnModelCreating(modelBuilder);
        }
    }   
}    



    


