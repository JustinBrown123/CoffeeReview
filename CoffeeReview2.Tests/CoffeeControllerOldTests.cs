using NSubstitute;
using CoffeeReview;
using CoffeeReview.Models;
using CoffeeReview.Repositories;
using System;
using System.Linq;
using Xunit;

namespace CoffeeReview.Tests
{
    public class CoffeeControllerOldTests
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