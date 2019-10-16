using NUnit.Framework;
using NSubstitute;
using CoffeeReview;
using CoffeeReview.Repositories;
using CoffeeReview.Controllers;
using CoffeeReview.Models;
using System.Collections.Generic;

namespace ControllerTests
{
    public class ControllerTests
    {
        private IEnumerable<Coffee> expectedCoffees;

      

        [Test]
        public void GetAll_Returns_All_Reviews()
        {
            CoffeeRepository = Substitute.For<IRepository<Coffee>>();
           
            underTest = new CoffeeController(CoffeeRepository);

            CoffeeRepository.GetAll().Returns(expectedCoffees);
            Assert.Pass();
        }
    }
}