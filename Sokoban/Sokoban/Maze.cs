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
        private List<Tile> _ItemsInMaze { get; set; }

        public Maze()
        {
            _ItemsInMaze = new List<Tile>();
        }

       public void AddLevelObject(int x, int y, char ObjectType)
       {
            _ItemsInMaze.Add(new Tile(x, y, ObjectType));
       }  

        private List<Tile> GetItemInMaze()
        {
            return _ItemsInMaze;
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