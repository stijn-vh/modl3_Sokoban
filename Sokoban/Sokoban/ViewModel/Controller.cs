using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Controller
    {
        private OutputView _outputview;
        private InputView _inputView;

        public Maze Maze { get => _maze; set => _maze = value; }
        private Maze _maze;
        private int countDestination;

        public Controller()
        {
            _outputview = new OutputView();
            _inputView = new InputView();
        }

        public int AskLevel()
        {
            return _inputView.ReadLevel();
        }

        public void DrawMaze()
        {
            _outputview.PrintMaze(_maze.First);
        }

        public void GameLoop()
        {
            while(true)
            {
                _maze.Move();
                DrawMaze();
            }
        }

        //public void checkcollision()
        //{
        //    if (!checkcratepushed())
        //    {
        //        if (truck.position._right.getcharacter() != '#')
        //        {
        //            console.writeline("you are good to go on x + 1!");
        //        }
        //        if (truck.position._left.getcharacter() != '#')
        //        {
        //            console.writeline("you are good to go on x - 1!");

        //        }
        //        if (truck.position._up.getcharacter() != '#')
        //        {
        //            console.writeline("you are good to go on y + 1!");
        //        }
        //        if (truck.position._down.getcharacter() != '#')
        //        {
        //            console.writeline("you are good to go on y - 1!");

        //        }
        //    }
        //}

        //public void checkDestination()
        //{
        //    if (checkCratePushed())
        //    {
        //        if (truck.position._Right.getCharacter() == 'x')
        //        {
        //            tile.setCharacter('o');
        //            countDestination++;
        //        }
        //        if (truck.position._Left.getCharacter() == 'x')
        //        {
        //            tile.setCharacter('o');
        //            countDestination++;
        //        }
        //        if (truck.position._Up.getCharacter() == 'x')
        //        {
        //            tile.setCharacter('o');
        //            countDestination++;
        //        }
        //        if (truck.position._Down.getCharacter() == 'x')
        //        {
        //            tile.setCharacter('o');
        //            countDestination++;
        //        }
        //    }

        //}

        //public Boolean checkCratePushed()
        //{
        //    if (truck.position._Right.getCharacter() == 'o' || truck.position._Left.getCharacter() == 'o' || truck.position._Up.getCharacter() == 'o' || truck.position._Down.getCharacter() == 'o')
        //    {
        //        return true;
        //    }
        //    return false;
        //}

    }


}