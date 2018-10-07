using Sokoban.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class OutputView
    {
        private bool finished;

    public OutputView()
        {
            finished = true;
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

        public Boolean PrintMaze(NonMoveableGameObject first)
        {
            Console.Clear();
            NonMoveableGameObject current = first;
            finished = true;
            while (current.Down != null) // Loop down the list
            {
                while (current.Right != null) // Loop to the last item
                {
                    finished = PrintSymbol(current);
                    current = current.Right;
                }
                finished = PrintSymbol(current);
                while (current.Left != null) // Loop back to begin
                {
                    current = current.Left;
                }
                System.Console.WriteLine("");
                current = current.Down;
            }
            while (current.Right != null) // Loop to the last item
            {
                finished = PrintSymbol(current);
                current = current.Right;
            }
            finished = PrintSymbol(current);
            return finished;
        }

        public Boolean PrintSymbol(NonMoveableGameObject current)
        {
            if(current.GetType().Name == "Destination" && !current.IsActive)
            {
                finished = false;
            }
            if(current.Player != null)
            {
                System.Console.Write(GetSymbol("Player"));
            }
            else if(current.GetType().Name == "Destination" && current.IsActive)
            {
                System.Console.Write("0");
            }
            else if (current.Crate != null)
            {
                System.Console.Write(GetSymbol("Crate"));
            }
            else
            {
                System.Console.Write(GetSymbol(current.GetType().Name));
            }
            return finished;
        }
        public char GetSymbol(String className)
        {
            char symbol = ' ';
            switch (className)
            {
                case "Floor":
                    symbol = '.';
                    break;
                case "Wall":
                    symbol = '#';
                    break;
                case "Crate":
                    symbol = 'o';
                    break;
                case "Player":
                    symbol = '@';
                    break;
                case "Destination":
                    symbol = 'x';
                    break;
            }
            return symbol;
        }

        public void FinishedGame()
        {
            Console.Clear();
            System.Console.WriteLine("You finished the Level, Congratz!");
            System.Console.WriteLine("Press <Enter> to exit the game.");
            Console.ReadLine();
        }
    }
}