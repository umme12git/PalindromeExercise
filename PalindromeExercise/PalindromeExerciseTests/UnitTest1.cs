using System;
using Xunit;
using System.Collections.Generic;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar",true)]
        [InlineData("madam",true)]
        [InlineData("there",false)]

        public void IsAPalindromeTest(string word,bool expected)
        {
            //Arrange
            var aTest = new WordSmith();


            //Act
            var actual = aTest.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);

        }
    }
}
