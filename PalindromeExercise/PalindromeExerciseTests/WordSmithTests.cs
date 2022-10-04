using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class WordSmithTests
    {
        [Theory]
        [InlineData("Racecar", true)]
        [InlineData("nOpe", false)]
        [InlineData("hAnNaH", true)]
        [InlineData("MADam", true)]
        [InlineData("soRry, Not thiS one", false)]
        [InlineData("trY agAin", false)]
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
