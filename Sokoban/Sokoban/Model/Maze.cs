using Sokoban.Interfaces;
using Sokoban.Model;
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
        public INonMoveableGameObject First { get => first; set => first = null; }
        private INonMoveableGameObject first;
        public INonMoveableGameObject TileWithPlayer { get => tileWithPlayer; set => tileWithPlayer =  value; }
        private INonMoveableGameObject tileWithPlayer;
        public void Move()
        {
            var keySwitch = Console.ReadKey().Key;
            System.Console.WriteLine("move");
            switch (keySwitch)
            {
                case ConsoleKey.UpArrow:
                    TileWithPlayer.Up.Player = TileWithPlayer.Player;
                    TileWithPlayer.Player = null;
                    TileWithPlayer = TileWithPlayer.Up;
                    break;
                case ConsoleKey.DownArrow:
                    TileWithPlayer.Down.Player = TileWithPlayer.Player;
                    TileWithPlayer.Player = null;
                    TileWithPlayer = TileWithPlayer.Down;
                    break;
                case ConsoleKey.LeftArrow:
                    TileWithPlayer.Left.Player = TileWithPlayer.Player;
                    TileWithPlayer.Player = null;
                    TileWithPlayer = TileWithPlayer.Left;
                    break;
                case ConsoleKey.RightArrow:
                    TileWithPlayer.Right.Player = TileWithPlayer.Player;
                    TileWithPlayer.Player = null;
                    TileWithPlayer = TileWithPlayer.Right;
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

        public void InitMaze(INonMoveableGameObject[,] levelArray, int width, int height)
        {
            INonMoveableGameObject NewTile = null;
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
                        if(NewTile.Player != null)
                        {
                            TileWithPlayer = NewTile;
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