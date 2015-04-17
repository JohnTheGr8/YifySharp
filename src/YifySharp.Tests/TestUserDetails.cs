using System;
using NUnit.Framework;

namespace YifySharp.Tests
{
    public class TestUserDetails
    {
        YifyClient cl = new YifyClient();

        [TestCase]
        public void TestReturnedData()
        {
            var details = cl.GetUserDetails(16);

            Assert.AreEqual(details.Id, 16);
            Assert.AreEqual(details.Username, "YIFY");
            Assert.AreEqual(details.Group, "administrator");
            Assert.AreEqual(details.Url, "https://yts.to/user/yify");
            Assert.Greater(details.AboutText.Length, 0);
            Assert.IsNotNullOrEmpty(details.SmallAvatarImage);
            Assert.IsNotNullOrEmpty(details.MediumAvatarImage);
            Assert.AreEqual(details.DateJoined, DateTime.Parse("2011-06-24 00:22:25"));
            Assert.Greater(details.DateLastSeen, details.DateJoined);
            Assert.AreEqual(details.DateJoinedUnix, 1308831745);
            Assert.Greater(details.DateLastSeenUnix, 0);
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
            var dt = epoch.AddSeconds(details.DateLastSeenUnix).ToUniversalTime();
            Assert.That(details.DateLastSeen.ToUniversalTime(), Is.EqualTo(dt).Within(1).Days);
        }
    }
}
