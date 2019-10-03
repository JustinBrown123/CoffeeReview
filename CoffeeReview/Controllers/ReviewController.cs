using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeReview.Controllers
{
    public class ReviewController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
      
    }
}