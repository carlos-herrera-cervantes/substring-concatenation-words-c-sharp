using System.Collections.Generic;
using SubstringConcatenationDomain.Models;
using Xunit;

namespace SubstringConcatenationTests.Models
{
    public class SuperStringTests
    {
        [Fact]
        public void FindSubstring_Should_Return_Indices()
        {
            var str = "barfoothefoobarman";
            var words = new [] { "foo", "bar" };
            var expectedResult = new List<int> { 0, 9 };

            List<int> result = SuperString.FindSubstring(str, words);

            Assert.Equal(result, expectedResult);
        }

        [Fact]
        public void FindSubstring_Should_Return_Empty_List()
        {
            var str = "wordgoodgoodgoodbestword";
            var words = new [] { "word", "good", "best", "word" };

            List<int> result = SuperString.FindSubstring(str, words);

            Assert.True(result.Count == 0);
        }
    }
}