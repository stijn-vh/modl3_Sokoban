using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.ViewModel
{
    class Game
    {
        public Game()
        {
            Controller c = new Controller();
            Parser p = new Parser(c.AskLevel());
            c.Maze = p.ReadFile();
            c.DrawMaze();
            c.GameLoop();
        }

    }
}
