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
        public IGameObject First { get => first; set => first = null; }
        private IGameObject first;
        private IGameObject _player;
        public void Move()
        {
            var keySwitch = Console.ReadKey().Key;
            var tempPlayer = _player;
            System.Console.WriteLine("move");
            switch (keySwitch)
            {
                case ConsoleKey.UpArrow:
                    //_player = _player.Up;
                    //tempPlayer = tempPlayer.Up;
                    first = first.Right.Right.Down.Down.Down.Down;
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
            IGameObject NewTile = null;
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    if (first == null)
                    {
                        first = levelArray[0, 0];
                        first.Right = levelArray[1, 0];
                        first.Down = levelArray[0, 1];
                    }
                    else
                    {
                        NewTile = levelArray[x, y];
                        if(NewTile.GetType().Name == "Player") // Sla op waar de speler staat
                        {
                            _player = NewTile;
                        }

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
        }
    }
}