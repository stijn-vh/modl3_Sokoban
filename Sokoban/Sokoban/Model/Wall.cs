using Sokoban.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class Wall : INonMoveableGameObject
    {
        public IGameObject Up { get => _Down; set => _Up = value; }
        public IGameObject Right { get => _Right; set => _Right = value; }
        public IGameObject Down { get => _Down; set => _Down = value; }
        public IGameObject Left { get => _Left; set => _Left = value; }
        public bool IsActive { get => isActive; set => isActive = false; }

        private Boolean isActive;
        private IGameObject _Up;
        private IGameObject _Right;
        private IGameObject _Down;
        private IGameObject _Left;

        public void Active()
        {
            throw new NotImplementedException();
        }

        public void ChechCollision()
        {
            throw new NotImplementedException();
        }

        public void Deactivate()
        {
            throw new NotImplementedException();
        }

        public void Move()
        {
            throw new NotImplementedException();
        }
    }
}
