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

            // This ensures our base constructor gets run.



        }
    }
}
