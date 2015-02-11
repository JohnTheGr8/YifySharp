using System;
using NUnit.Framework;

namespace YifySharp.Tests
{
    public class TestMovieComments
    {
        [TestCase]
        public void TestReturnedData()
        {
            var cl = new YifyClient();
            var comments = cl.GetMovieComments(10).Comments;
            var epoch = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);

            Assert.IsNotEmpty(comments);
            comments.ForEach(c =>
                {
                    Assert.That(c, Is.Not.Null);
                    Assert.That(c, Has.Property("CommentId").Positive);
                    Assert.That(c, Has.Property("UserId").Positive);
                    Assert.That(c, Has.Property("Username").Not.Empty);
                    Assert.That(c, Has.Property("UserProfileUrl").Not.Empty);
                    Assert.That(c, Has.Property("SmallUserAvatarImage").Not.Empty);
                    Assert.That(c, Has.Property("MediumUserAvatarImage").Not.Empty);
                    Assert.That(c, Has.Property("UserGroup").Not.Empty);
                    Assert.That(c, Has.Property("LikeCount").Not.Negative);
                    Assert.That(c, Has.Property("CommentText").Not.Empty);
                    Assert.That(c, Has.Property("DateAdded").Not.Null);
                    Assert.That(c, Has.Property("DateAddedUnix").Positive);                    
                    var dt = epoch.AddSeconds(c.DateAddedUnix).ToUniversalTime();
                    Assert.That(c.DateAdded.ToUniversalTime(), Is.EqualTo(dt).Within(1).Days);
                });
        }
    }
}
