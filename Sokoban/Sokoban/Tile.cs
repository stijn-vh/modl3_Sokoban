using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class Tile
    {
        private int _XLocation;
        private int _YLocation;
        private char _char;

        public Tile(int x, int y, char _char)
        {
            _XLocation = x;
            _YLocation = y;
            this._char = _char;
        }

        public char getCharacter()
        {
            return _char;
        }
    }
}
