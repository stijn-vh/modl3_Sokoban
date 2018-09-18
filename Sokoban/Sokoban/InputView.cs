using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class InputView
    {
        private int input;
        private string input2;
        public void ReadLine()
        {
            Console.WriteLine("Kies een doolhof (1-4), s = stop");
            input2 = Console.ReadLine();
            
            if(Int32.TryParse(input2, out input))
            {
                if (input > 0 && input < 5)
                {
                    Console.WriteLine("Jij wil doolhof " + input + " spelen");
                }
                else
                {
                    Console.WriteLine("Dat is geen geldige input!!");
                    ReadLine();
                }

            }
            else
            {
                Console.WriteLine("Dat is geen geldige input!!");
                ReadLine();
            }

        }
    }
}