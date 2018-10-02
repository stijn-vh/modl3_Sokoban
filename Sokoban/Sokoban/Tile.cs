using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public class Tile
    {
        private char _char;
        public Tile _Up;
        public Tile _Right;
        public Tile _Down;
        public Tile _Left;


        public Tile(char _char, Tile Up, Tile Right, Tile Down, Tile Left)
        {
            this._char = _char;
            this._Up = Up;
            this._Right = Right;
            this._Down = Down;
            this._Left = Left;
        }

        public char getCharacter()
        {
            return _char;
        }

        public void setCharacter(char _char)
        {
            this._char = _char;

        }
    }
}
