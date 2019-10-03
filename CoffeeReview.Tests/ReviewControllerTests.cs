using System;
using Xunit;
using CoffeeReview.Tests;
using CoffeeReview.Controllers;
using Microsoft.AspNetCore.Mvc;
using CoffeeReview.Models;

namespace CoffeeReview.Tests
{
    public class ReviewControllerTests
    {
        [Fact]
        public void Review_Returns_ViewResult()
        {
            var controller = new ReviewController();

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Review_Passes_ReviewModels_To_View()
        {
            var controller = new ReviewController();

            var result = controller.Index();

            Assert.IsType<ReviewModels>(result.Model);
        }
    }
}
