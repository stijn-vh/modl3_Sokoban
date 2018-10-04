using Sokoban.Model;
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

            IGameObject[,] levelArray = new IGameObject[width, height];
            for(int y = 0; y < height; y++) // Full Multidimensional Array
            {
                for(int x = 0; x < width; x++)
                {
                    try
                    {
                        IGameObject tempObject = null;
                        switch (readString[y].ElementAt(x))
                        {
                            case '.':
                                tempObject = new Floor();
                                break;
                            case '#':
                                tempObject = new Wall();
                                break;
                            case 'o':
                                tempObject = new Crate();
                                break;
                            case 'x':
                                tempObject = new Destination();
                                break;
                            case '@':
                                tempObject = new Player();
                                break;
                        }
                        levelArray[x, y] = tempObject;
                    }
                    catch
                    {
                        IGameObject tempObject = null;
                        levelArray[x, y] = tempObject;
                    }
                }
            } 

            IGameObject First = null;
            IGameObject NewTile = null;
            for (int y = 0; y < height; y++)
            {
                for(int x = 0; x < width; x++)
                {
                    if(First == null)
                    {
                        First = levelArray[0, 0];
                        First.Right = levelArray[1, 0];
                        First.Down = levelArray[0, 1];
                    }
                    else
                    {
                        NewTile =  levelArray[x, y];
                        if(y - 1 >= 0)
                        {
                            NewTile.Up = levelArray[x, y - 1];
                        }

                        if(x + 1 < width)
                        {
                            NewTile.Right = levelArray[x + 1, y];
                        }

                        if(y + 1 < height)
                        {
                            NewTile.Down = levelArray[x, y + 1];
                        }

                        if(x - 1 >= 0)
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
                while(current.Left != null)
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