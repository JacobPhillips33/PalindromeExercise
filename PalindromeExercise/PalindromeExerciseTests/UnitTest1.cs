using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("nope", false)]
        [InlineData("hannah", true)]
        [InlineData("madam", true)]
        [InlineData("sorry, not this one", false)]
        [InlineData("try again", false)]
        public void IsAPalindromeTest(string word, bool expected)
        {
            //Arrange
            var palindromeTester = new WordSmith();

            //Act
            var actual = palindromeTester.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
