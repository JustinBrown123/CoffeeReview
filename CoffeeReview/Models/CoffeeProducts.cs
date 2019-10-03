using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeReview.Models
{
    public class CoffeeProducts
    {
        public string Name { get; set; }

        public List<Coffee> coffeeProducts = new List<Coffee>();
        
        public void AddCoffee()
        {
            coffeeProducts.Add(new Coffee ("Cleveland Coffee", "Bright Side Blend"));
            coffeeProducts.Add(new Coffee("Cleveland Coffee", "Tanzanian Peaberry"));
            coffeeProducts.Add(new Coffee("Rising Star", "Apo Cooperative"));
            coffeeProducts.Add(new Coffee("Starbucks", "Komodo Dragon"));
            coffeeProducts.Add(new Coffee("8 o Clock", "The Original"));
            coffeeProducts.Add(new Coffee("Brioso", "Colombia Santa Barbara Estate"));
            coffeeProducts.Add(new Coffee("8 o Clock", "Red Eye Roast"));
            coffeeProducts.Add(new Coffee("Peets", "Costa Rica Peaberry"));
            coffeeProducts.Add(new Coffee("Dunkin' Donuts", "Dunkin' Decaf"));
        }

    }
}
