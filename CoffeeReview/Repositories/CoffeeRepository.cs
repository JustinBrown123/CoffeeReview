using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Coffee.Models;

namespace CoffeeReview.Repositories
{
    public class CoffeeRepository : IRepository<Coffee>
    {

        public Dictionary<int, Coffee> coffeeDictionary;

        


        public CoffeeRepository()
        {
            Dictionary<int, Coffee> coffeeDictionary = new Dictionary<int, Coffee>();

            coffeeDictionary.Add(1, new Coffee( "Cleveland Coffee", "Bright Side Blend", "happyhappy stuff"));



                string brand, string kind, string description)
        //    coffeeProducts.Add(new Coffee("Cleveland Coffee", "Bright Side Blend"));
        //    coffeeProducts.Add(new Coffee("Cleveland Coffee", "Tanzanian Peaberry"));
        //    coffeeProducts.Add(new Coffee("Rising Star", "Apo Cooperative"));
        //    coffeeProducts.Add(new Coffee("Starbucks", "Komodo Dragon"));
        //    coffeeProducts.Add(new Coffee("8 o Clock", "The Original"));
        //    coffeeProducts.Add(new Coffee("Brioso", "Colombia Santa Barbara Estate"));
        //    coffeeProducts.Add(new Coffee("8 o Clock", "Red Eye Roast"));
        //    coffeeProducts.Add(new Coffee("Peets", "Costa Rica Peaberry"));
        //    coffeeProducts.Add(new Coffee("Dunkin' Donuts", "Dunkin' Decaf"));
        }

        public IEnumerable<Coffee> GetAll()
        {
            return coffeeDictionary;
        }




    }
}
