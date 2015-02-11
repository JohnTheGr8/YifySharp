using System;
using NUnit.Framework;

namespace YifySharp.Tests
{
    public class TestUpcomingList
    {
        [TestCase]
        public void TestReturnedData()
        {
            var cl = new YifyClient();
            var data = cl.GetUpcomingList();
            Assert.That(data.UpcomingMoviesCount, Is.Not.Negative);

            var upcoming = data.UpcomingMovies;

            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

            upcoming.ForEach(u =>
            {
                Assert.That(u, Is.Not.Null);
                Assert.That(u, Has.Property("Title").Not.Empty);
                Assert.That(u, Has.Property("Year").Positive);
                Assert.That(u, Has.Property("ImdbCode").Not.Empty);
                Assert.That(u, Has.Property("MediumCoverImage").Not.Empty);
                Assert.That(u, Has.Property("DateAdded").Not.Null);
                Assert.That(u, Has.Property("DateAddedUnix").Positive);
                var dt = epoch.AddSeconds(u.DateAddedUnix).ToUniversalTime();
                Assert.That(u.DateAdded.ToUniversalTime(), Is.EqualTo(dt).Within(1).Days);
            });
        }
    }
}
