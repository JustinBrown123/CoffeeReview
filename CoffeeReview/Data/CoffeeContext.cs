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
        public DbSet<Coffee> Coffee { get; set; }
        public DbSet<Review> Review { get; set; }

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
                    new Coffee(1, "Cleveland Coffee", "Bright Side Blend", "Light to medium Roast Costa Rican and Dark roast Hondauran. Organic, Fair Trade, Shade Grown Balanced acidity, clean flavorful cup", "/images/brightsideblend.jpg"),
                    new Coffee(2, "Cleveland Coffee", "Tanzanian Peaberry", "Full Medium Roast Specialty Grade Crisp, Citrus tones, Nice Finish", " /images/tanzanianpeaberry.jpg"),
                    new Coffee(3, "Rising Star", "Apo Cooperative", "Eastern Highlands, Papua New Guinea. Notes of: plum, blood orange, chocolate malt. ", "/images/apocooperative.jpg"),
                    new Coffee(4, "Starbucks", "Komodo Dragon", "Region: Asia-Pacific. Notes of Cedary Spice and Herbs.  ", "/images/komododragon.jpg"),
                    new Coffee(5, "8 O'Clock", "The Original", "Medium Roast. Sweet, fruity and well balanced", "/images/theoriginal.jpg"),
                    new Coffee(6, "Brioso", "Santa Barbara Estate", "San Pascual Columbian. Notes of Fruit punch and creamy mouthfeel", "/images/colombiasantabarbara.jpg"),
                    new Coffee(7, "8 O'Clock", "Red Eye Roast", "Dark Roast. Espresso Style, Smooth, Full-Bodied","/images/redeyeroast.jpg"),
                    new Coffee(8, "Peets", "Costa Rica Peaberry", "Dark Roast from Americas. Notes of sun-ripened cherry fruit and intense, bright Meyer lemon citrus-acidity.", "/images/costaricapeaberry.jpg"),
                    new Coffee(9, "Dunkin' Donuts", "Dunkin Decaf", "Medium Roast. Decaffinated Coffee that almost tastes like normal Coffee", "/images/dunkindecaf.jpg")
                            );

            modelBuilder.Entity<Review>().HasData(
                
                new Review(1, 1, "Splendid, I must say. Gracious upon the first sip jolly ole chaps."),
                new Review(2, 2, "Quite awful in taste and overall quality mate. Do not recommend this one for a night out with the chaps"),
                new Review(3, 3,  "Good for a wee bit of a wakeup but not a particular favorite of mine"),
                new Review(4, 4, "Absolutely splendid chaps!!"), 
                new Review(5, 5,  "Golly gee, this was a wee bit AWFUL"),
                new Review(6, 6,  "I was absolutely stunned when I tried this! Will definitely be sharing with a few of my chaps"),
                new Review(7, 7, "Oh I hate to be a damper here but gosh I hated this one, an awful aftertaste ruins an otherwise ok taste"),
                new Review(8, 8, "I almost thought I enjoyed this one but after about half a cup and a crumpet, my tummy hurt. 10/10 would not recommend to the chaps"),
                new Review(9, 9, "Another favorite for my chaps and I. Good for a biscuit in the morning or a crumpet at night"),
                new Review(10, 4, "James loves this coffee"),
                new Review(11, 5, "OMG THIS IS THE BEST COFFEE EVER")
                );
        }
    }   
}    



    


