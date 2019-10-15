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

        public ViewResult Details(int id)
        {
            var model = coffeeRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Review review)
        {
            reviewRepo.Delete(review);
            return RedirectToAction("Delete", "Review", g);
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = reviewRepo.GetById(id);
            return View(model);
        }


    }
}