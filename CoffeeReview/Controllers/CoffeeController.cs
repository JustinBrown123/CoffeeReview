using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeReview.Models;
using CoffeeReview.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeReview.Controllers
{
    public class CoffeeController : Controller
    {
        IRepository<Coffee> coffeeRepo;
        public CoffeeController(IRepository<Coffee> coffeeRepo)
        {
            this.coffeeRepo = coffeeRepo;
        }

        public ViewResult Index()
        {
            var model = coffeeRepo.GetAll();

            return View(model);
        }


    }
}