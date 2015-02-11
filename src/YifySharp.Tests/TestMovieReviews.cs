using System;
using NUnit.Framework;

namespace YifySharp.Tests
{
    public class TestMovieReviews
    {
        [TestCase]
        public void TestReturnedData()
        {
            var cl = new YifyClient();
            var data = cl.GetReviews(10);
            Assert.That(data.ReviewCount, Is.Not.Negative);

            var reviews = data.Reviews;

            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

            reviews.ForEach(r =>
            {
                Assert.That(r, Is.Not.Null);
                Assert.That(r, Has.Property("Username").Not.Empty);
                Assert.That(r, Has.Property("UserRating").Not.Negative);
                Assert.That(r, Has.Property("UserLocation").Not.Empty);
                Assert.That(r, Has.Property("ReviewSummary").Not.Empty);
                Assert.That(r, Has.Property("ReviewText").Not.Empty);
                Assert.That(r, Has.Property("DateWritten").Not.Null);
                Assert.That(r, Has.Property("DateWrittenUnix").Not.Negative);
                var dt = epoch.AddSeconds(r.DateWrittenUnix).ToUniversalTime();
                Assert.That(r.DateWritten.ToUniversalTime(), Is.EqualTo(dt).Within(1).Days);
            });
        }
    }
}
