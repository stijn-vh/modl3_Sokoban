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
            ReadFile(level);


        }

        public void ReadFile(int level)
        {
            String LevelPath = @"Doolhof\doolhof" + level + ".txt";

            String[] LevelString = System.IO.File.ReadAllLines(LevelPath);

            for (int i = 0; i < LevelString.Length; i++)
            {
                for (int z = 0; z < LevelString[i].Length; z++)
                {
                    char currentItem = LevelString[i].ElementAt(z);
                    _maze.AddLevelObject(z, i, currentItem);
                }
            }
        }
    }
}