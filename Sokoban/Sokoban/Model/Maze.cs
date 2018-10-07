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
        public NonMoveableGameObject First { get => first; set => first = null; }
        private NonMoveableGameObject first;
        public NonMoveableGameObject TileWithPlayer { get => tileWithPlayer; set => tileWithPlayer =  value; }
        private NonMoveableGameObject tileWithPlayer;

        public void UpdatePlayerPosition()
        {
            TileWithPlayer.Player.Up = TileWithPlayer.Up;
            TileWithPlayer.Player.Right = TileWithPlayer.Right;
            TileWithPlayer.Player.Down = TileWithPlayer.Down;
            TileWithPlayer.Player.Left = TileWithPlayer.Left;
        }

        public void InitMaze(NonMoveableGameObject[,] levelArray, int width, int height)
        {
            NonMoveableGameObject NewTile = null;
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