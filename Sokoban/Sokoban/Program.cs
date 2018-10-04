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
            Maze maze = new Maze();
            Parser p = new Parser(maze, 4);
            p.ReadFile(4);
            //Controller cont = new Controller(maze);
            //OutputView view = new OutputView();
            //InputView view2 = new InputView();
            //view2.ReadLine();
            //Parser pars = new Parser(maze, 3);
            //Controller cont = new Controller(maze);
            OutputView view = new OutputView();
            InputView view2 = new InputView();

            view2.ReadLine();
            
            while (true)
            {
                maze.Move();

            }
        }
    }
}
