using System;
using NUnit.Framework;

namespace YifySharp.Tests
{
    public class TestParentalGuides
    {
        [TestCase]
        public void TestReturnedData()
        {
            var cl = new YifyClient();
            var data = cl.GetParentalGuides(10);
            Assert.That(data.ParentalGuideCount, Is.Not.Negative);

            var guides = data.ParentalGuides;
            Assert.IsNotEmpty(guides);
            guides.ForEach(g =>
            {
                Assert.That(g, Is.Not.Null);
                Assert.That(g, Has.Property("Type").Not.Empty);
                Assert.That(g, Has.Property("ParentalGuideText").Not.Empty);
            });
        }
    }
}
