using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Maze
    {
        private int _maze;
        private int _level;

        public Maze(int level)
        {
            _level = level;


        }

        public void ReadFile(int level)
        {
            String LevelPath = @"Doolhof\doolhof" + level + ".txt";
        }
    }
}