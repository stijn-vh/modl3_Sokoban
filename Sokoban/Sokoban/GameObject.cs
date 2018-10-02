using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public class GameObject
    {
        private char _char;
        public GameObject _Up;
        public GameObject _Right;
        public GameObject _Down;
        public GameObject _Left;


        public GameObject(char _char, GameObject Up, GameObject Right, GameObject Down, GameObject Left)
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
