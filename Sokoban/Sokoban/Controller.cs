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
        private GameObject tile;
        private Player truck;
        private int countDestination;
        private Player _player;

        public Controller(Maze maze)
        {
            countDestination = 0;
            tile = new GameObject(5, 2, '#');
            truck = new Player(5, 2);
            this._maze = maze;
            _outputview = new OutputView();
            DrawMaze();
        }

        public void DrawMaze()
        {
            // _outputview.drawView();
        }

        public void checkCollision()
        {
            if (!checkCratePushed())
            {
                if (truck.x + 1 != '#')
                {
                    Console.WriteLine("You are good to go on x + 1!");
                }
                if (truck.x - 1 != '#')
                {
                    Console.WriteLine("You are good to go on x - 1!");

                }
                if (truck.y + 1 != '#')
                {
                    Console.WriteLine("You are good to go on y + 1!");
                }
                if (truck.y - 1 != '#')
                {
                    Console.WriteLine("You are good to go on y - 1!");

                }
            }
            else
            {
                if (truck.x + 2 != '#')
                {
                    Console.WriteLine("You are good to go on x + 1!");
                }
                if (truck.x - 2 != '#')
                {
                    Console.WriteLine("You are good to go on x - 1!");

                }
                if (truck.y + 2 != '#')
                {
                    Console.WriteLine("You are good to go on y + 1!");
                }
                if (truck.y - 2 != '#')
                {
                    Console.WriteLine("You are good to go on y - 1!");

                }
            }
        }

        public void checkDestination()
        {
            if (checkCratePushed())
            {
                if (truck.x + 1 == 'x')
                {
                    tile.setCharacter('o');
                    countDestination++;
                }
                if (truck.x - 1 == 'x')
                {
                    tile.setCharacter('o');
                    countDestination++;
                }
                if (truck.y + 1 == 'x')
                {
                    tile.setCharacter('o');
                    countDestination++;
                }
                if (truck.y - 1 == 'x')
                {
                    tile.setCharacter('o');
                    countDestination++;
                }
            }

        }

        public Boolean checkCratePushed()
        {
            if (truck.x + 1 == 'o' || truck.x - 1 == 'o' || truck.y + 1 == 'o' || truck.y - 1 == 'o')
            {
                return true;
            }

            return false;
        }

    }


}