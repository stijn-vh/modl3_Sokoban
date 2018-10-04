using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class Program
    {
        static void Main(string[] args)
        {
            int level = 4;

            Maze maze = new Maze();
            Parser p = new Parser(maze, level);
            Controller c = new Controller(maze);

            p.ReadFile();
            c.DrawMaze();
        }
    }
}
