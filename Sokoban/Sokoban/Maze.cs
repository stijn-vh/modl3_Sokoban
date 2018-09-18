using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace Sokoban
{
    public class Maze
    {
        private int _maze;
        private int _level;
        private Player olav;

        public Maze(int level)
        {
            _level = level;
            olav = new Player(5,2);
        }

        public void ReadFile(int level)
        {
            String LevelPath = @"Doolhof\doolhof" + level + ".txt";
        }
    }
}