using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public class MoveableGameObject
    {
        public MoveableGameObject _Up;
        public MoveableGameObject _Right;
        public MoveableGameObject _Down;
        public MoveableGameObject _Left;


        public MoveableGameObject(char _char, MoveableGameObject Up, MoveableGameObject Right, MoveableGameObject Down, MoveableGameObject Left)
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
