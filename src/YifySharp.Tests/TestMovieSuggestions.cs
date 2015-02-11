using System;
using NUnit.Framework;

namespace YifySharp.Tests
{
    public class TestMovieSuggestions
    {
        [TestCase]
        public void TestReturnedData()
        {
            var cl = new YifyClient();
            var data = cl.GetMovieSuggestions(10);
            Assert.That(data.MovieSuggestionsCount, Is.Not.Negative);

            var suggestions = data.MovieSuggestions;

            suggestions.ForEach(m => Assert.That(m, Is.Not.Null));
        }
    }
}
