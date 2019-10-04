using System;
using System.Collections;
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

            coffeeDictionary.Add(1, new Coffee(1, "Cleveland Coffee", "Bright Side Blend", "happyhappy stuff"));
            coffeeDictionary.Add(2, new Coffee(2, "Cleveland Coffee", "Tanzanian Peaberry", "really good stuff"));
            coffeeDictionary.Add(3, new Coffee(3, "Rising Star", "Apo Cooperative", "makes happy"));
            coffeeDictionary.Add(4, new Coffee(4, "Starbucks", "Komodo Dragon", "happyhappy stuff"));
            coffeeDictionary.Add(5, new Coffee(5, "8 O'Clock", "The Original", "great cheap coffee"));
            coffeeDictionary.Add(6, new Coffee(6, "Brioso", "Bright Side Blend", "Pretty Solid"));
            coffeeDictionary.Add(7, new Coffee(7, "8 O'Clock", "Red Eye Roast", "excellent for the cost"));
            coffeeDictionary.Add(8, new Coffee(8, "Peets", "Costa Rica Peaberry", "Deliciousness"));
            coffeeDictionary.Add(9, new Coffee(9, "Dunkin' Donuts", "Dunkin Decaf", "Horrible"));
        }
         
        public IEnumerable<Coffee> GetAll()
        {
            return coffeeDictionary AsEnumerable();
        }

        public Coffee GetById(int id)
        {
            return coffeeDictionary.Single(c => c.Id == id);
        }




    }
}
