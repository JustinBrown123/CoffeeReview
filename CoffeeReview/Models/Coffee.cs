using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeReview.Models
{
    public class Coffee
    {
        public int Id { get; set; }

        public string Brand { get; set; }

        public string Kind { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }
        

        public Coffee()
        {

        }
       
        public Coffee(int id, string brand, string kind, string description, string imageUrl)
        {
            Id = id;
            Brand = brand;
            Kind = kind;
            Description = description;
            ImageUrl = imageUrl;
        }
    }
}
