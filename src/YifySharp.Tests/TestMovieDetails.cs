using System;
using NUnit.Framework;

namespace YifySharp.Tests
{
    public class TestMovieDetails
    {
        YifyClient cl = new YifyClient();

        [TestCase]
        public void TestDefaultParameters()
        {
            var details = cl.GetMovieDetails(10);

            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

            Assert.That(details.Id, Is.Positive);
            Assert.That(details.Url, Is.Not.Empty);
            Assert.That(details.ImdbCode, Is.Not.Empty);
            Assert.That(details.Title, Is.Not.Empty);
            Assert.That(details.TitleLong, Is.Not.Empty);
            Assert.That(details.Year, Is.Positive);
            Assert.That(details.Rating, Is.Positive);
            Assert.That(details.Runtime, Is.Positive);
            Assert.That(details.Genres, Is.Not.Empty);
            Assert.That(details.Language, Is.Not.Empty);
            Assert.That(details.MpaRating, Is.Not.Empty);
            Assert.That(details.DownloadCount, Is.Positive);
            Assert.That(details.LikeCount, Is.Not.Negative);
            Assert.That(details.RtCriticsScore, Is.Positive);
            Assert.That(details.RtCriticsRating, Is.Not.Empty);
            Assert.That(details.RtAudienceScore, Is.Positive);
            Assert.That(details.RtAudienceRating, Is.Not.Empty);
            Assert.That(details.DescriptionIntro, Is.Not.Empty);
            Assert.That(details.DescriptionFull, Is.Not.Empty);
            Assert.That(details.YtTrailerCode, Is.Not.Empty);
            Assert.That(details.YoutubeTrailerLink, Is.Not.Empty);
            Assert.That(details.DateUploadedUnix, Is.Positive);
            var dt = epoch.AddSeconds(details.DateUploadedUnix).ToUniversalTime();
            Assert.That(details.DateUploaded.ToUniversalTime(), Is.EqualTo(dt).Within(1).Days);
            
            details.Torrents.ForEach(t =>
            {
                Assert.That(t.Url, Is.Not.Empty);
                Assert.That(t.Resolution, Is.Not.Empty);
                Assert.That(t.FrameRate, Is.Positive);
                Assert.That(t.Seeds, Is.Positive);
                Assert.That(t.Peers, Is.Positive);
                Assert.That(t.Size, Is.Not.Null);
                Assert.That(t.SizeBytes, Is.Positive);
                Assert.That(t.DownloadCount, Is.Positive);
                Assert.That(t.DateUploadedUnix, Is.Positive);
                dt = epoch.AddSeconds(t.DateUploadedUnix).ToUniversalTime();
                Assert.That(t.DateUploaded.ToUniversalTime(), Is.EqualTo(dt).Within(1).Days);
                Assert.That(t.MagnetUrl, Is.Not.Empty);
            });

            Assert.That(details.Images, Is.Null);
            Assert.That(details.Actors, Is.Null);
            Assert.That(details.Directors, Is.Null);
        }

        [TestCase]
        public void TestWithImages()
        {
            var details = cl.GetMovieDetails(10, true);

            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

            Assert.That(details.Id, Is.Positive);
            Assert.That(details.Url, Is.Not.Empty);
            Assert.That(details.ImdbCode, Is.Not.Empty);
            Assert.That(details.Title, Is.Not.Empty);
            Assert.That(details.TitleLong, Is.Not.Empty);
            Assert.That(details.Year, Is.Positive);
            Assert.That(details.Rating, Is.Positive);
            Assert.That(details.Runtime, Is.Positive);
            Assert.That(details.Genres, Is.Not.Empty);
            Assert.That(details.Language, Is.Not.Empty);
            Assert.That(details.MpaRating, Is.Not.Empty);
            Assert.That(details.DownloadCount, Is.Positive);
            Assert.That(details.LikeCount, Is.Not.Negative);
            Assert.That(details.RtCriticsScore, Is.Positive);
            Assert.That(details.RtCriticsRating, Is.Not.Empty);
            Assert.That(details.RtAudienceScore, Is.Positive);
            Assert.That(details.RtAudienceRating, Is.Not.Empty);
            Assert.That(details.DescriptionIntro, Is.Not.Empty);
            Assert.That(details.DescriptionFull, Is.Not.Empty);
            Assert.That(details.YtTrailerCode, Is.Not.Empty);
            Assert.That(details.YoutubeTrailerLink, Is.Not.Empty);
            Assert.That(details.DateUploadedUnix, Is.Positive);
            var dt = epoch.AddSeconds(details.DateUploadedUnix).ToUniversalTime();
            Assert.That(details.DateUploaded.ToUniversalTime(), Is.EqualTo(dt).Within(1).Days);

            details.Torrents.ForEach(t =>
            {
                Assert.That(t.Url, Is.Not.Empty);
                Assert.That(t.Resolution, Is.Not.Empty);
                Assert.That(t.FrameRate, Is.Positive);
                Assert.That(t.Seeds, Is.Positive);
                Assert.That(t.Peers, Is.Positive);
                Assert.That(t.Size, Is.Not.Null);
                Assert.That(t.SizeBytes, Is.Positive);
                Assert.That(t.DownloadCount, Is.Positive);
                Assert.That(t.DateUploadedUnix, Is.Positive);
                dt = epoch.AddSeconds(t.DateUploadedUnix).ToUniversalTime();
                Assert.That(t.DateUploaded.ToUniversalTime(), Is.EqualTo(dt).Within(1).Days);
                Assert.That(t.MagnetUrl, Is.Not.Empty);
            });

            Assert.That(details.Images, Has.Property("MediumCoverImage").Not.Empty);
            Assert.That(details.Images, Has.Property("LargeCoverImage").Not.Empty);
            Assert.That(details.Images, Has.Property("MediumScreenshotImage1").Not.Empty);
            Assert.That(details.Images, Has.Property("MediumScreenshotImage2").Not.Empty);
            Assert.That(details.Images, Has.Property("MediumScreenshotImage3").Not.Empty);
            Assert.That(details.Images, Has.Property("LargeScreenshotImage1").Not.Empty);
            Assert.That(details.Images, Has.Property("LargeScreenshotImage2").Not.Empty);
            Assert.That(details.Images, Has.Property("LargeScreenshotImage3").Not.Empty);

            Assert.That(details.Actors, Is.Null);
            Assert.That(details.Directors, Is.Null);
        }

        [TestCase]
        public void TestWithCast()
        {
            var details = cl.GetMovieDetails(10, withCast: true);

            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

            Assert.That(details.Id, Is.Positive);
            Assert.That(details.Url, Is.Not.Empty);
            Assert.That(details.ImdbCode, Is.Not.Empty);
            Assert.That(details.Title, Is.Not.Empty);
            Assert.That(details.TitleLong, Is.Not.Empty);
            Assert.That(details.Year, Is.Positive);
            Assert.That(details.Rating, Is.Positive);
            Assert.That(details.Runtime, Is.Positive);
            Assert.That(details.Genres, Is.Not.Empty);
            Assert.That(details.Language, Is.Not.Empty);
            Assert.That(details.MpaRating, Is.Not.Empty);
            Assert.That(details.DownloadCount, Is.Positive);
            Assert.That(details.LikeCount, Is.Not.Negative);
            Assert.That(details.RtCriticsScore, Is.Positive);
            Assert.That(details.RtCriticsRating, Is.Not.Empty);
            Assert.That(details.RtAudienceScore, Is.Positive);
            Assert.That(details.RtAudienceRating, Is.Not.Empty);
            Assert.That(details.DescriptionIntro, Is.Not.Empty);
            Assert.That(details.DescriptionFull, Is.Not.Empty);
            Assert.That(details.YtTrailerCode, Is.Not.Empty);
            Assert.That(details.YoutubeTrailerLink, Is.Not.Empty);
            Assert.That(details.DateUploadedUnix, Is.Positive);
            var dt = epoch.AddSeconds(details.DateUploadedUnix).ToUniversalTime();
            Assert.That(details.DateUploaded.ToUniversalTime(), Is.EqualTo(dt).Within(1).Days);

            details.Torrents.ForEach(t =>
            {
                Assert.That(t.Url, Is.Not.Empty);
                Assert.That(t.Resolution, Is.Not.Empty);
                Assert.That(t.FrameRate, Is.Positive);
                Assert.That(t.Seeds, Is.Positive);
                Assert.That(t.Peers, Is.Positive);
                Assert.That(t.Size, Is.Not.Null);
                Assert.That(t.SizeBytes, Is.Positive);
                Assert.That(t.DownloadCount, Is.Positive);
                Assert.That(t.DateUploadedUnix, Is.Positive);
                dt = epoch.AddSeconds(t.DateUploadedUnix).ToUniversalTime();
                Assert.That(t.DateUploaded.ToUniversalTime(), Is.EqualTo(dt).Within(1).Days);
                Assert.That(t.MagnetUrl, Is.Not.Empty);
            });

            Assert.IsNotEmpty(details.Actors);
            details.Actors.ForEach(a =>
            {
                Assert.That(a, Has.Property("Name").Not.Empty);
                Assert.That(a, Has.Property("CharacterName").Not.Empty);
                Assert.That(a, Has.Property("SmallImage").Not.Empty);
                Assert.That(a, Has.Property("MediumImage").Not.Empty);
            });
            Assert.IsNotEmpty(details.Directors);
            details.Directors.ForEach(d =>
            {
                Assert.That(d, Has.Property("Name").Not.Empty);
                Assert.That(d, Has.Property("SmallImage").Not.Empty);
                Assert.That(d, Has.Property("MediumImage").Not.Empty);
            });

            Assert.That(details.Images, Is.Null);
        }
    }
}
