using Sokoban.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model
{
    class Destination : INonMoveableGameObject
    {
        public bool IsActive { get => isActive; set => isActive = false; }
        public IGameObject Up { get => _Down; set => _Up = value; }
        public IGameObject Right { get => _Right; set => _Right = value; }
        public IGameObject Down { get => _Down; set => _Down = value; }
        public IGameObject Left { get => _Left; set => _Left = value; }

        private Boolean isActive;
        private IGameObject _Up;
        private IGameObject _Right;
        private IGameObject _Down;
        private IGameObject _Left;
        public void Active()
        {

        }

        public void Deactivate()
        {
        }
    }
}
