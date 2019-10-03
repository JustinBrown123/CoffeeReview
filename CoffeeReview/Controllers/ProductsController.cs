using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeReview.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeReview.Controllers
{
    public class ProductsController : Controller
    {
        public ViewResult Products(string name)
        {
            var model = new CoffeeProducts();
            model.Name = name;
            return View(model);
        }
    }
}