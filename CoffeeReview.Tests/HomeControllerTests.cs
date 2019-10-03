using System;
using Xunit;
using CoffeeReview.Tests;
using CoffeeReview.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeReview.Tests
{
    public class HomeControllerTests
    {
        [Fact]
        public void Index_Returns_ViewResult()
        {
            var controller = new HomeController();

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
