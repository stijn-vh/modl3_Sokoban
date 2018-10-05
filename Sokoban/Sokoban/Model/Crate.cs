using Sokoban.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    class Crate : IMoveableGameObject
    {
        public bool IsActive { get => isActive; set => isActive = false; }
        public INonMoveableGameObject Up { get => _Down; set => _Up = value; }
        public INonMoveableGameObject Right { get => _Right; set => _Right = value; }
        public INonMoveableGameObject Down { get => _Down; set => _Down = value; }
        public INonMoveableGameObject Left { get => _Left; set => _Left = value; }

        private Boolean isActive;
        private INonMoveableGameObject _Up;
        private INonMoveableGameObject _Right;
        private INonMoveableGameObject _Down;
        private INonMoveableGameObject _Left;

        public void Move()
        {
            throw new NotImplementedException();
        }

        public void ChechCollision()
        {
            throw new NotImplementedException();
        }
    
    }
}