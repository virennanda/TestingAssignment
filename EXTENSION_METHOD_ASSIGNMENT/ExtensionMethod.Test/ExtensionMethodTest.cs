using ConsoleApp.extension;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ExtensionMethod.Test
{
    public class ExtensionMethodTest
    {
        [Fact]
        public void Test_ChangeCase()
        {

            // 1.Return a copy of given input string with uppercase characters converted to 
            // lowercase and vice versa.
            // Arrange 2 string Inputs
            var lowerCaseString = "this is a lower case string";
            var upperCaseString = "THIS IS A UPPER CASE STRING";

            //expected Outputs
            var expectedOutputForLowerCaseString = "THIS IS A LOWER CASE STRING";
            var expectedOutputForUpperCaseString = "this is a upper case string";



            // Act 
            //store the results
            var actualResultFromLowerCaseString = lowerCaseString.ChangeCase();
            var actualResultFromUpperCaseString = upperCaseString.ChangeCase();
            
            
            // Assert
            //verify the results from our expectation
            Assert.Equal(actualResultFromLowerCaseString, expectedOutputForLowerCaseString);
            Assert.Equal(actualResultFromUpperCaseString, expectedOutputForUpperCaseString);
        }
        [Fact]
        public void Test_ChangeToTitleCase()
        {
            // 3.Converts the specified string to title case (except for words that are 
            //entirely in uppercase, which are considered to be acronyms).

            // Arrange input string with acronym 
            var titleCaseInput = "lets finish work ASAP";

            // expected output
            var expectedTitleCaseOutput = "Lets Finish Work ASAP";

            // Act
            // store outputs
            var actualTitleCaseOutput = titleCaseInput.toTitleCase();

            // Assert
            // verify the results from expectation
            Assert.Equal(actualTitleCaseOutput, expectedTitleCaseOutput);
        }
        [Fact]
        public void Test_IsLowerCaseString()
        {
            // 4.Find if all the characters from given input string are in lower case or not

            // Arrange
            // inputs
            var lowerCaseString = "this is a lower case string";
            
            // Act
            //store the output from method
            var actualOutputFromLowerCaseString = lowerCaseString.isLowerCase();


            // Assert
            // verify expectation 
            Assert.True(actualOutputFromLowerCaseString);
        }
        [Fact]
        public void Test_IsUpperCaseString()
        {
            // 6.    Find if all the characters from given input string are in upper case or not
            // Arrange
            //inputs
            var upperCaseString = "AN APPLE A DAY KEEPS DOCTOR AWAY";
            var lowerCaseString= "an apple a day keeps doctor away";
            
            // Act
            var actualOutputForUpperCaseString = upperCaseString.IsUpperCaseString();
            var actualOutputFromLowerCaseString = lowerCaseString.IsUpperCaseString();
            
            // Assert
            // verify output from expectation

            Assert.True(actualOutputForUpperCaseString);
            Assert.False(actualOutputFromLowerCaseString);
        }
        [Fact]
        public void Test_DoCapitalize()
        {
            // 5.Return a capitalized version of given input string i.e. make the first
            // character have upper case and the rest lower case.
            // Arrange
            // inputs
            var sampleInputString = "this is a sample strinG";
            
            // Expected Output
            var expectedOutputFromSampleString = "This Is A Sample String";

            // Act 
            // store actual results 
            var actualOutputFromSampleString = sampleInputString.doCapitalize();


            // Assert
            // verify expectation from actual output
            Assert.Equal(expectedOutputFromSampleString, actualOutputFromSampleString);
        }
        [Theory]
        [InlineData("56", true)]
        [InlineData("12d", false)]
        public void Test_IsValidNumericValue(string inputString, bool result)
        {
            // 7.Function to identify whether given input string can be converted to a valid 
            //numeric value or not.

            // Arrange

            // Act
            var newString = inputString.isValidNumericValue();
            // Assert
            Assert.Equal(newString, result);
        }
        [Fact]
        public void Test_RemoveLastCharacter()
        {
            // 8.Function to remove the last character from given the string

            // Arrange
            var sampleInputString = "this is a sample strinG";
            // expected outputs
            var expectedOutputFromSampleInputString = "this is a sample strin";

            // Act
            var actualOutputFromSampleInputString= sampleInputString.removeLastCharacter();
            
            
            // Assert
            Assert.Equal(expectedOutputFromSampleInputString, actualOutputFromSampleInputString);
        }
        [Fact]
        public void Test_WordCount()
        {
            // 9.Get the word count from an input string.
            // Arrange
            var sampleString = "this is a sample strinG";

            // expected output from sample string
            var expectedCountFromSampleString = 5;

            // Act
            var actualOutputForSampleString= sampleString.wordCount();
            // Assert
            Assert.Equal(actualOutputForSampleString    , expectedCountFromSampleString);
        }
        [Fact]
        public void Test_StringToInteger()
        {
            // 10.Convert an input string to integer.

            // Arrange
            // inputs
            var inputString = "123";
            
            //outputs
            var expectedOutputFromInputString = 123;

            // Act
            var actualOutputFromInputString = inputString.stringToInteger();
            // Assert
            Assert.Equal(actualOutputFromInputString, expectedOutputFromInputString);
        }
    }
}
