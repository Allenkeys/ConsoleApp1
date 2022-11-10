using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class UpperCase
    {
        public static void getUpperCase()
        {
            Console.WriteLine("Input any string");
            string words = Console.ReadLine();

            //List<int> CapitalLetterList = new List<int>();

            for (int i = 0; i < words.Length; i++)
            {

                if (Char.IsUpper(words[i]))
                {
                    Console.WriteLine(words.IndexOf(words[i]));
                }

            }
        }
    }
}
