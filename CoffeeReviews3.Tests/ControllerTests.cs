using NUnit.Framework;
using NSubstitute;

namespace ControllerTests
{
    public class ControllerTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            ReviewRepo = Substitute.For<IRepository<Review>>();
           
            underTest = new ReviewController(ReviewRepo);

            ReviewRepo.GetAll().Returns(expectedReviews);
            Assert.Pass();
        }
    }
}