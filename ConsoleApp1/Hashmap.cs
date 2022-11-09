using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Accept input
// Convert input to an array of characters
// if input is less than four
//      output input
// Else
//      Loop through the array and assign value of # to each index but the last four.
// Output result


namespace ConsoleApp1
{
    public class Hash
    {
        public static void hashInput ()
        {
            Console.WriteLine("Enter your string:");
            var userInput = Console.ReadLine();
            char[] splittedCharacters = userInput.ToCharArray();
            int unhashedChars = 4;
            if (splittedCharacters.Length <= unhashedChars)
            {
                Console.WriteLine(userInput);
            }
            else
            {
                for (int i = 0; i < splittedCharacters.Length - unhashedChars; i++)
                {
                    splittedCharacters[i] = '#';
                }
                Console.WriteLine(splittedCharacters);
            }
        }
    }
}
