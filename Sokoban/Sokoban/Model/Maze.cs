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

        public void InitMaze(IGameObject[,] levelArray, int width, int height)
        {

            IGameObject First = null;
            IGameObject NewTile = null;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (First == null)
                    {
                        First = levelArray[0, 0];
                        First.Right = levelArray[1, 0];
                        First.Down = levelArray[0, 1];
                    }
                    else
                    {
                        NewTile = levelArray[x, y];
                        if (y - 1 >= 0)
                        {
                            NewTile.Up = levelArray[x, y - 1];
                        }

                        if (x + 1 < width)
                        {
                            NewTile.Right = levelArray[x + 1, y];
                        }

                        if (y + 1 < height)
                        {
                            NewTile.Down = levelArray[x, y + 1];
                        }

                        if (x - 1 >= 0)
                        {
                            NewTile.Left = levelArray[x - 1, y];
                        }
                    }
                }
            }
            IGameObject current = First;

            while (current.Down != null)
            {
                while (current.Right != null)
                {
                    //System.Console.Write(current.getCharacter());
                    current = current.Right;
                }
                while (current.Left != null)
                {
                    current = current.Left;
                }
                System.Console.WriteLine("");
                current = current.Down;
            }
            System.Console.ReadLine();
        }
    }
}