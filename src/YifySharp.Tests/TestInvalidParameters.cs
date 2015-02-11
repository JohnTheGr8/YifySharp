using System;
using NUnit.Framework;

namespace YifySharp.Tests
{
    public class TestInvalidParameters
    {
        YifyClient cl = new YifyClient();

        [TestCase]
        [ExpectedException(typeof(ApplicationException))]
        public void TestInvalidParametersMovieDetails()
        {
            cl.GetMovieDetails(0);
        }

        [TestCase]
        [ExpectedException(typeof(ApplicationException))]
        public void TestInvalidParametersMovieSuggestions()
        {
            cl.GetMovieSuggestions(0);
        }

        [TestCase]
        [ExpectedException(typeof(ApplicationException))]
        public void TestInvalidParametersMovieComments()
        {
            cl.GetMovieComments(0);
        }

        [TestCase]
        [ExpectedException(typeof(ApplicationException))]
        public void TestInvalidParametersUserDetails()
        {
            cl.GetUserDetails(0);
        }
    }
}