using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Parser
    {

        private Maze _maze;

        public Parser(Maze maze, int level)
        {
            _maze = maze;
        }

        public void ReadFile(int level)
        {
            String LevelPath = @"Doolhof\doolhof" + level + ".txt";

            String[] readString = System.IO.File.ReadAllLines(LevelPath);

            int width = 0;
            int height = readString.Length;
            for(int i = 0; i < height; i++) // Pak de langste lengte die een lijn in het tekstbestand heeft
            {
                if(readString[i].Length > width)
                {
                    width = readString[i].Length;
                }
            }

            GameObject[,] levelArray = new GameObject[width, height];
            for(int y = 0; y < height; y++) // Full Multidimensional Array
            {
                for(int x = 0; x < width; x++)
                {
                    try
                    {
                        levelArray[x, y] = new GameObject(readString[y].ElementAt(x), null, null, null, null);
                    }
                    catch
                    {
                        levelArray[x, y] = new GameObject(' ', null, null, null, null);
                    }
                }
            } 

            GameObject First = null;
            GameObject NewTile = null;
            for (int y = 0; y < height; y++)
            {
                for(int x = 0; x < width; x++)
                {
                    if(First == null)
                    {
                        First = levelArray[0, 0];
                        First._Right = levelArray[1, 0];
                        First._Down = levelArray[0, 1];
                    }
                    else
                    {
                        NewTile =  levelArray[x, y];
                        if(y - 1 >= 0)
                        {
                            NewTile._Up = levelArray[x, y - 1];
                        }

                        if(x + 1 < width)
                        {
                            NewTile._Right = levelArray[x + 1, y];
                        }

                        if(y + 1 < height)
                        {
                            NewTile._Down = levelArray[x, y + 1];
                        }

                        if(x - 1 >= 0)
                        {
                            NewTile._Left = levelArray[x - 1, y];
                        }
                    }
                }
            }
            GameObject current = First;

            while (current._Down != null)
            {
                while (current._Right != null)
                {
                    System.Console.Write(current.getCharacter());
                    current = current._Right;
                }
                while(current._Left != null)
                {
                    current = current._Left;
                }
                System.Console.WriteLine("");
                current = current._Down;
            }
            System.Console.ReadLine();
        }
    }
}