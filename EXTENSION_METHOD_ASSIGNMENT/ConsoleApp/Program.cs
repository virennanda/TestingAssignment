using ConsoleApp.extension;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            var sampleString = "this is a sample strinG";
            var lowerCaseString = "this is a lower case string";
            var upperCaseString = "THIS IS A UPPER CASE STRING";
            var checkTitleCase = "lets finish work ASAP";
            var validNumeric = "132";
            var invalidNumeric = "a12";

            // 1.Return a copy of given input string with uppercase characters converted to 
            // lowercase and vice versa.
            Console.WriteLine("Change case : --->" + "INPUT :--->" + lowerCaseString+ " OUTPUT :--->" + lowerCaseString.ChangeCase());
            Console.WriteLine("Change case : --->" + "INPUT :--->" + upperCaseString+ " OUTPUT :--->" + upperCaseString.ChangeCase());
            
            

            // 3.Converts the specified string to title case (except for words that are 
            //entirely in uppercase, which are considered to be acronyms).
            Console.WriteLine("To Title case : --->" + "INPUT :--->" + checkTitleCase + " OUTPUT :--->" + checkTitleCase.toTitleCase());

            // 4.Find if all the characters from given input string are in lower case or not
            Console.WriteLine("Is Lower Case : --->" + "INPUT :--->" + lowerCaseString + " OUTPUT :--->" + lowerCaseString.isLowerCase());

            // 5.Return a capitalized version of given input string i.e. make the first
            // character have upper case and the rest lower case.
            Console.WriteLine("Do capitalize : --->" + "INPUT :--->" + sampleString+ " OUTPUT :--->" + sampleString.doCapitalize());

            // 6.    Find if all the characters from given input string are in upper case or not
            Console.WriteLine("Is Upper case string :---> " + "INPUT :--->" + lowerCaseString + " OUTPUT :--->" + lowerCaseString.IsUpperCaseString());
            Console.WriteLine("Is Upper case string :---> " + "INPUT :--->" + upperCaseString + " OUTPUT :--->" + upperCaseString.IsUpperCaseString());

            // 7.Function to identify whether given input string can be converted to a valid 
            //numeric value or not.
            Console.WriteLine("is valid numeric value :---> " + "INPUT :--->" + validNumeric + " OUTPUT :--->" + validNumeric.isValidNumericValue());
            Console.WriteLine("is valid numeric value :---> " + "INPUT :--->" + invalidNumeric + " OUTPUT :--->" + invalidNumeric.isValidNumericValue());

            // 8.Function to remove the last character from given the string

            Console.WriteLine("remove last character :---> " + "INPUT :--->" + sampleString+ " OUTPUT :--->" + sampleString.removeLastCharacter());

            // 9.Get the word count from an input string.
            Console.WriteLine("words count :--->" + "INPUT :--->" + sampleString + " OUTPUT :--->" + sampleString.wordCount());


            // 10.Convert an input string to integer.
            Console.WriteLine("string to int:--->" + "INPUT :--->" + validNumeric + " OUTPUT :--->" + validNumeric.stringToInteger());
        }
    }
}
