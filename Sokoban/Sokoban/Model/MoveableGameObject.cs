using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model
{
    public abstract class MoveableGameObject : GameObject
    {
        public bool IsActive { get => isActive; set => isActive = false; }
        public NonMoveableGameObject Up { get => _Down; set => _Up = value; }
        public NonMoveableGameObject Right { get => _Right; set => _Right = value; }
        public NonMoveableGameObject Down { get => _Down; set => _Down = value; }
        public NonMoveableGameObject Left { get => _Left; set => _Left = value; }

        private Boolean isActive;
        private NonMoveableGameObject _Up;
        private NonMoveableGameObject _Right;
        private NonMoveableGameObject _Down;
        private NonMoveableGameObject _Left;
    }
}
