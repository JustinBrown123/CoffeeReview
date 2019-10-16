using CoffeeReview.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NSubstitute;

namespace CoffeeReview.Repositories
{
    public class ReviewRepository : Repository<Review>
    {
        public ReviewRepository(CoffeeContext context) : base(context)
        {

        }
    }
}
