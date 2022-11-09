using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class LoopControl
    {
        public static void controlState()
        {
            string text = "randomtexts";
            char[] chars = text.ToCharArray();
            int iterator = chars.Length;
            int counter = 0;

            while (counter < iterator)
            {
                if(counter == 8)
                {
                    break;
                }
                if (counter == 4)
                {
                    continue;
                }
                Console.WriteLine(chars[counter]);
                counter++;
            }
        }
    }
}
