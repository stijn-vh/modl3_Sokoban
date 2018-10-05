using Sokoban.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model
{
    class Empty : INonMoveableGameObject
    {
        public bool IsActive { get => isActive; set => isActive = false; }
        public INonMoveableGameObject Up { get => _Down; set => _Up = value; }
        public INonMoveableGameObject Right { get => _Right; set => _Right = value; }
        public INonMoveableGameObject Down { get => _Down; set => _Down = value; }
        public INonMoveableGameObject Left { get => _Left; set => _Left = value; }
        public IMoveableGameObject Player { get => _player; set => _player = value; }

        private Boolean isActive;
        private INonMoveableGameObject _Up;
        private INonMoveableGameObject _Right;
        private INonMoveableGameObject _Down;
        private INonMoveableGameObject _Left;
        private IMoveableGameObject _player;
        
        public void Active()
        {
            throw new NotImplementedException();
        }

        public void Deactivate()
        {
            throw new NotImplementedException();
        }
    }
}
