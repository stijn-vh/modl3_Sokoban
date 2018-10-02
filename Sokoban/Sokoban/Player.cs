using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sokoban
{
    public class Player
    {
        public Tile Position { get; set; }

        public Player(Tile position)
        {
            this.Position = position;
        }

    }
}

