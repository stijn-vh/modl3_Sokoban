﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Controller
    {
        private Maze _maze;
        private OutputView _outputview;
        private GameObject tile;
        private Player truck;
        private int countDestination;

        public Controller(Maze maze)
        {
            countDestination = 0;
            tile = new GameObject('#', tile,tile,tile,tile);
            truck = new Player(tile);
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
                if (truck.position._Right.getCharacter() != '#')
                {
                    Console.WriteLine("You are good to go on x + 1!");
                }
                if (truck.position._Left.getCharacter() != '#')
                {
                    Console.WriteLine("You are good to go on x - 1!");

                }
                if (truck.position._Up.getCharacter() != '#')
                {
                    Console.WriteLine("You are good to go on y + 1!");
                }
                if (truck.position._Down.getCharacter() != '#')
                {
                    Console.WriteLine("You are good to go on y - 1!");

                }
            }
        }

        public void checkDestination()
        {
            if (checkCratePushed())
            {
                if (truck.position._Right.getCharacter() == 'x')
                {
                    tile.setCharacter('o');
                    countDestination++;
                }
                if (truck.position._Left.getCharacter() == 'x')
                {
                    tile.setCharacter('o');
                    countDestination++;
                }
                if (truck.position._Up.getCharacter() == 'x')
                {
                    tile.setCharacter('o');
                    countDestination++;
                }
                if (truck.position._Down.getCharacter() == 'x')
                {
                    tile.setCharacter('o');
                    countDestination++;
                }
            }

        }

        public Boolean checkCratePushed()
        {
            if (truck.position._Right.getCharacter() == 'o' || truck.position._Left.getCharacter() == 'o' || truck.position._Up.getCharacter() == 'o' || truck.position._Down.getCharacter() == 'o')
            {
                return true;
            }

            return false;
        }

    }


}