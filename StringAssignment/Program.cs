using System;
using System.Text;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenate three strings
            string str1 = "Hello";
            string str2 = "beautiful";
            string str3 = "world!";

            // Concatenates str1, str2, and str3 with spaces in between
            string concatenatedString = str1 + " " + str2 + " " + str3;

            // Print the concatenated string to the console
            Console.WriteLine("Concatenated String: " + concatenatedString);

            // Convert a string to uppercase
            string originalString = "this should be uppercase";

            // Convert the string to uppercase using ToUpper() method
            string upperCaseString = originalString.ToUpper();

            // Print the uppercase string to the console
            Console.WriteLine("Uppercase String: " + upperCaseString);

            // Create a StringBuilder and build a paragraph of text, one sentence at a time
            // Instantiate the StringBuilder class
            System.Text.StringBuilder sb = new StringBuilder();

            // Append the first sentence to the StringBuilder
            sb.Append("This is the first sentence. ");

            // Append the second sentence to the StringBuilder
            sb.Append("This is the second sentence. ");

            // Append the third sentence to the StringBuilder
            sb.Append("This is the third sentence.");

            // Print the constructed paragraph to the console
            Console.WriteLine("Constructed Paragraph: " + sb.ToString());

            // Prevent the console window from closing immediately
            // This will wait for the user to press Enter before closing
            Console.ReadLine();
        }
    }
}
