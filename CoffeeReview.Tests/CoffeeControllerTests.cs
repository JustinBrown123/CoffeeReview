using CoffeeReview.Controllers;
using CoffeeReview.Models;
using CoffeeReview.Repositories;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CoffeeReview.Tests
{
    public class CoffeeControllerTests
    {

        [Fact]
        public void GetAll_Returns_All_Reviews()
        {
            CoffeeRepository = Substitute.For<IRepository<Coffee>>();

            underTest = new CoffeeController(CoffeeRepository);

            CoffeeRepository.GetAll().Returns(expectedCoffees);
        }
    }
}
