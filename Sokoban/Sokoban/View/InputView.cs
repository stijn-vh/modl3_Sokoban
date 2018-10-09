using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class InputView
    {
        private int input;
        private string input2;

        public InputView()
        {
            
        }

        public int ReadLevel()
        {
            Console.WriteLine("Kies een doolhof (1-4), s = stop");
            input2 = Console.ReadLine();
            
            if(Int32.TryParse(input2, out input))
            {
                if (input > 0 && input < 5)
                {
                    Console.WriteLine("Jij wil doolhof " + input + " spelen");
                    return input;
                }
                else
                {
                    Console.WriteLine("Dat is geen geldige input!!");
                    ReadLevel();
                }

            }
            else
            {
                Console.WriteLine("Dat is geen geldige input!!");
                ReadLevel();
            }
            return 0;
        }

        public int WaitForInput()
        {
            return (int) Console.ReadKey().Key;
           
        }
    }
}