using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Library
    {
        public static void management()
        {
            Console.WriteLine("Hello Awesome Person");
            Console.WriteLine("select c: C# books");
            Console.WriteLine("select o: Donet books");
            Console.WriteLine("select d: Clean Coding books");
            Console.WriteLine("select e: EFcore books");

            var code = Console.ReadLine().ToLower();
            switch (code)
            {
                case "c":
                    Console.WriteLine("Selected C# books");
                    break;
                case "o":
                    Console.WriteLine("Selected dotnet books");
                    break;
                case "d":
                    Console.WriteLine("Selected clean coding books");
                    break;

                case "e":
                    Console.WriteLine("Selected EFcore books");
                    break;
                default:
                    Console.WriteLine("Sorry, your selection is not in the options");
                    break;
            }
        }
    }
}
