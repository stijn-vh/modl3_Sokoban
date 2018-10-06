using Sokoban.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model
{
    class Floor : INonMoveableGameObject
    {
        public bool IsActive { get => isActive; set => isActive = false; }
        public IMoveableGameObject Player { get => _player; set => _player = value; }
        public IMoveableGameObject Crate { get => _crate; set => _crate = value; }

        public INonMoveableGameObject Up
        {
            get { return _Up; }
            set
            {
                _Up = value;
                if (Player != null)
                {
                    Player.Up = value;
                }

                if(Crate != null)
                {
                    Crate.Up = value;
                }
            }
        }
        public INonMoveableGameObject Right
        {
            get { return _Right; }
            set
            {
                _Right = value;
                if (Player != null)
                {
                    Player.Right = value;
                }

                if (Crate != null)
                {
                    Crate.Right = value;
                }
            }
        }
        public INonMoveableGameObject Down
        {
            get { return _Down; }
            set
            {
                _Down = value;
                if (Player != null)
                {
                    Player.Down = value;
                }

                if (Crate != null)
                {
                    Crate.Down = value;
                }
            }
        }
        public INonMoveableGameObject Left
        {
            get { return _Left; }
            set
            {
                _Left = value;
                if (Player != null)
                {
                    Player.Left = value;
                }

                if (Crate != null)
                {
                    Crate.Down = value;
                }
            }
        }
        private Boolean isActive;
        private INonMoveableGameObject _Up;
        private INonMoveableGameObject _Right;
        private INonMoveableGameObject _Down;
        private INonMoveableGameObject _Left;
        private IMoveableGameObject _player;
        private IMoveableGameObject _crate;

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

