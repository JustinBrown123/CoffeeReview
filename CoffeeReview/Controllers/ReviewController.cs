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

                //Create A ReviewsController Class

                //- should have a method mapped to a url that outputs all of your reviews into the model, and returns a Reviews Index View;

                //- should have a method mapped to a url including an id parameter that outputs one of your reviews into the model, forwarding 
            
                //  to a Review Details View.This method should expect an "id" query parameter in order to select a specific review.



    }
}