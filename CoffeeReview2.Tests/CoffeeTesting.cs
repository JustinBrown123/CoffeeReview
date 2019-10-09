using System;
using Xunit;

namespace CoffeeReview2.Tests
{
    public class SongRepositoryTests : IDisposable
    {
        private CoffeeContext db;
        private CoffeeRepository underTest;

        public SongRepositoryTests()
        {
            db = new MusicContext();
            db.Database.BeginTransaction();

            underTest = new SongRepository(db);
        }

        public void Dispose()
        {
            db.Database.RollbackTransaction();
        }

        [Fact]
        public void Count_Starts_At_Zero()
        {
            var count = underTest.Count();

            Assert.Equal(0, count);
        }

        [Fact]
        public void Create_Increases_Count()
        {
            underTest.Create(new Song() { Title = "Foo" });

            var count = underTest.Count();
            Assert.Equal(1, count);
        }

        [Fact]
        public void GetById_Returns_Created_Item()
        {
            var expectedSong = new Song() { Title = "Baby Shark" };
            underTest.Create(expectedSong);

            var result = underTest.GetById(expectedSong.Id);  // The Id was set by EF when we call Create above.

            Assert.Equal(expectedSong.Title, result.Title);
        }

        [Fact]
        public void Delete_Reduces_Count()
        {
            var song = new Song() { Title = "Baby Shark" };
            underTest.Create(song);

            underTest.Delete(song);
            var count = underTest.Count();

            Assert.Equal(0, count);
        }

        [Fact]
        public void GetAll_Returns_All()
        {
            underTest.Create(new Song() { Title = "Baby Shark" });
            underTest.Create(new Song() { Title = "Never gonna give you up" });

            var all = underTest.GetAll();

            Assert.Equal(2, all.Count());
        }

        // Save or Update?
    }
}
