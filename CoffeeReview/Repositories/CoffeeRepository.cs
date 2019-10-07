using CoffeeReview.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CoffeeReview.Repositories
{
    public class CoffeeRepository : IRepository<Coffee>
    {

        public Dictionary<int, Coffee> coffeeDictionary;

        


        public CoffeeRepository()
        {
            coffeeDictionary = new Dictionary<int, Coffee>()
            {
                { 1, new Coffee(1, "Cleveland Coffee", "Bright Side Blend", "happyhappy stuff","/images/brightsideblend.jpg")},
                { 2, new Coffee(2, "Cleveland Coffee", "Tanzanian Peaberry", "really good stuff","/images/tanzanianpeaberry.jpg")},
                { 3, new Coffee(3, "Rising Star", "Apo Cooperative", "makes happy", "/images/apocooperative.jpg")},
                { 4, new Coffee(4, "Starbucks", "Komodo Dragon", "happyhappy stuff", "/images/komododragon.jpg")},
                { 5, new Coffee(5, "8 O'Clock", "The Original", "great cheap coffee","/images/theoriginal.jpg" )},
                { 6, new Coffee(6, "Brioso", "Santa Barbara Estate", "Pretty Solid","/images/colombiasantabarbara.jpg")},
                { 7, new Coffee(7, "8 O'Clock", "Red Eye Roast", "excellent for the cost","/images/redeyeroast.jpg")},
                { 8, new Coffee(8, "Peets", "Costa Rica Peaberry", "Deliciousness","/images/costaricapeaberry.jpg")},
                { 9, new Coffee(9, "Dunkin' Donuts", "Dunkin Decaf", "Horrible","/images/dunkindecaf.jpg")},
            };
        }

      
        
         
        public IEnumerable<Coffee> GetAll()
        {
            //return coffeeDictionary AsEnumerable();
            return coffeeDictionary.Values.ToList();
        }

        public Coffee GetById(int id)
        {
            //return coffeeDictionary.Single(c => c.Id == id);
            return coffeeDictionary.Values.ToList().Single(c => c.Id == id);
        }




    }
}
