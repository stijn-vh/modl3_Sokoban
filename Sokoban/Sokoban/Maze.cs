using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Sokoban
{
    public class Maze
    {

       public void AddTile(int x, int y, char ObjectType, Tile Up, Tile Right, Tile Down, Tile Left)
       {
            new Tile(ObjectType, Up, Right, Down, Left);
       }  

        public void Move()
        {
            var keySwitch = Console.ReadKey().Key;

            switch (keySwitch)
            {
                case ConsoleKey.UpArrow:
                    Console.WriteLine("Up");
                    break;
                case ConsoleKey.DownArrow:
                    Console.WriteLine("Down");
                    break;
                case ConsoleKey.LeftArrow:
                    Console.WriteLine("Left");
                    break;
                case ConsoleKey.RightArrow:
                    Console.WriteLine("Right");
                    break;
                case ConsoleKey.S:
                    Console.WriteLine("SHUTDOWN");
                    System.Threading.Thread.Sleep(1000);
                    System.Environment.Exit(1);
                    break;
                default:
                    break;
            }
        }
    }
}