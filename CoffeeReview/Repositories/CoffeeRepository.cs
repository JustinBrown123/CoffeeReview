using CoffeeReview.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CoffeeReview.Repositories
{
    public class CoffeeRepository : Repository<Coffee>
    {
        public CoffeeRepository(CoffeeContext context) : base(context)
        {
            var myRepo = new Repository<Coffee>(db);
            var coffee = myRepo.GetById(1);
            coffee.Brand = 
            myRepo.Save();
            // This ensures our base constructor gets run.



        }
    }
}
