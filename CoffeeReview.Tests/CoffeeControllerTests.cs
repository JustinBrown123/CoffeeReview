using CoffeeReview.Controllers;
using CoffeeReview.Models;
using CoffeeReview.Repositories;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CoffeeReview.Tests
{
    public class CoffeeControllerTests
    {
        CoffeeController underTest;
        IRepository<Coffee> coffeeRepo;

        public CoffeeControllerTests()
        {
            coffeeRepo = Substitute.For<IRepository<Coffee>>();
            underTest = new CoffeeController(coffeeRepo);
        }
        
        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Passes_All_Coffees_To_View()
        {
            var expectedCoffees = new List<Coffee>();
            coffeeRepo.GetAll().Returns(expectedCoffees);

            var result = underTest.Index();

            Assert.Equal(expectedCoffees, result.Model);
        }

        [Fact]
        public void Details_Returns_A_View()
        {
            var result = underTest.Details(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Passes_Course_To_View()
        {
            var expectedCoffee = new Coffee();
            coffeeRepo.GetById(1).Returns(expectedCoffee);

            var result = underTest.Details(1);

            Assert.Equal(expectedCoffee, result.Model);
        }

    }
}
