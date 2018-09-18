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
    }
}