using System;
using NUnit.Framework;
using YifySharp.Extensions;
using YifySharp.Models;
using System.Linq;

namespace YifySharp.Tests
{
    public class TestMovieList
    {
        YifyClient cl = new YifyClient();

        [TestCase]
        public void TestDefaultParameters()
        {
            var list = cl.GetMovieList();

            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

            Assert.AreEqual(list.Limit, 20);
            Assert.AreEqual(list.PageNumber, 1);

            list.Movies.ForEach(details =>
            {
                Assert.That(details.Id, Is.Positive);
                Assert.That(details.Url, Is.Not.Empty);
                Assert.That(details.ImdbCode, Is.Not.Empty);
                Assert.That(details.Title, Is.Not.Empty);
                Assert.That(details.TitleLong, Is.Not.Empty);
                Assert.That(details.Year, Is.Positive);
                Assert.That(details.Rating, Is.Positive);
                Assert.That(details.Runtime, Is.Not.Negative);
                Assert.That(details.Genres, Is.Not.Empty);
                Assert.That(details.Language, Is.Not.Empty);
                Assert.That(details.MpaRating, Is.Not.Null);
                Assert.That(details.SmallCoverImage, Is.Not.Empty);
                Assert.That(details.MediumCoverImage, Is.Not.Empty);
                Assert.That(details.DateUploadedUnix, Is.Positive);
                var dt = epoch.AddSeconds(details.DateUploadedUnix).ToUniversalTime();
                Assert.That(details.DateUploaded.ToUniversalTime(), Is.EqualTo(dt).Within(1).Days);

                details.Torrents.ForEach(t =>
                {
                    Assert.That(t.Url, Is.Not.Empty);
                    // Resolution, FrameRate and DownloadCount are not returned 
                    // in the list-movie call. But the API seems to change so
                    // they might be added in in the near future.
                    //Assert.That(t.Resolution, Is.Not.Empty);
                    //Assert.That(t.FrameRate, Is.Positive);
                    //Assert.That(t.DownloadCount, Is.Positive);
                    Assert.That(t.Seeds, Is.Not.Negative);
                    Assert.That(t.Peers, Is.Not.Negative);
                    Assert.That(t.Size, Is.Not.Empty);
                    Assert.That(t.SizeBytes, Is.Positive);
                    Assert.That(t.DateUploadedUnix, Is.Positive);
                    dt = epoch.AddSeconds(t.DateUploadedUnix).ToUniversalTime();
                    Assert.That(t.DateUploaded.ToUniversalTime(), Is.EqualTo(dt).Within(1).Days);
                    Assert.That(t.MagnetUrl, Is.Not.Empty);
                });
            });
        }

        [TestCase]
        public void TestWithParameters()
        {
            var list = cl.GetMovieList(limit:10, page:3, genre:"Drama", sortBy:MovieSortOption.Rating, orderBy:MovieOrderOption.Ascending, quality:MovieQuality.FullHD1080p, minimumRating:7);

            Assert.AreEqual(list.Limit, 10);
            Assert.AreEqual(list.PageNumber, 3);

            Assert.That(list.Movies, Is.Ordered.By("Rating"));

            list.Movies.ForEach(res =>
                {
                    Assert.GreaterOrEqual(res.Rating, 7);
                    CollectionAssert.Contains(res.Genres, "Drama");
                });
            Assert.IsTrue(list.Movies.All(x => x.Torrents.Any(t => t.Quality == MovieQuality.FullHD1080p.GetDescription())));
        }
    }
}
