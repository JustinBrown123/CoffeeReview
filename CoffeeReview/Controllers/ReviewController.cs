using CoffeeReview.Models;
using CoffeeReview.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoffeeReview.Controllers
{
    public class ReviewController : Controller
    {
        IRepository<Review> reviewRepo;
        public ReviewController(IRepository<Review> reviewRepo)
        {
            this.reviewRepo = reviewRepo;
        }

        public ViewResult Index()
        {
            var model = reviewRepo.GetAll();

            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = reviewRepo.GetById(id);
            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Review review)
        {
            reviewRepo.Create(review);
            return RedirectToAction("/Views/Review/Index");
        }



        [HttpGet]
        public ViewResult CreateByCoffeeId(int id)
        {
            ViewBag.CoffeeId = id;
            return View();
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = reviewRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Review review)
        {
            reviewRepo.Delete(review);
            return RedirectToAction("Index");
        }




    }
    

    }

