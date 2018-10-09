using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model
{
    public abstract class GameObject
    {
        public NonMoveableGameObject Up { get => _Up; set => _Up = value; }
        public NonMoveableGameObject Right { get => _Right; set => _Right = value; }
        public NonMoveableGameObject Down { get => _Down; set => _Down = value; }
        public NonMoveableGameObject Left { get => _Left; set => _Left = value; }

        private NonMoveableGameObject _Up;
        private NonMoveableGameObject _Right;
        private NonMoveableGameObject _Down;
        private NonMoveableGameObject _Left;
    }
}
