using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class OutputView
    {

        public void drawView(ArrayList LevelCharacters)
        {
            for(int i = 0; i < LevelCharacters.Count; i++)
            {
                Console.WriteLine(LevelCharacters[i]);
            }
            Console.ReadLine();
        }

        public OutputView()
        {
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("| Welkom bij Sokoban!          |   Doel van het spel     |");
            Console.WriteLine("| Betekenis van de symbolen    |                         |");
            Console.WriteLine("|                              |   Duw met de truck      |");
            Console.WriteLine("| Spatie: Outerspace           |   De krat(ten)          |");
            Console.WriteLine("|      #: Muur                 |   Naar de bestemming    |");
            Console.WriteLine("|      .: Vloer                |                         |");
            Console.WriteLine("|      O: Krat                 |                         |");
            Console.WriteLine("|      0: Krat op bestemming   |                         |");
            Console.WriteLine("|      x: Bestemming           |                         |");
            Console.WriteLine("|      @: Speler               |                         |");
            Console.WriteLine("----------------------------------------------------------");
        }
    }
}