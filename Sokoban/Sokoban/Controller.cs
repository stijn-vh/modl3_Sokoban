using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Controller
    {
        private Maze _maze;
        private InputView _inputview;
        private OutputView _outputview;

        public Controller(Maze maze)
        {
            this._maze = maze;
            _outputview = new OutputView();
            DrawMaze();
        }

        public void DrawMaze()
        {
            _outputview.drawView();
        }
    }


}