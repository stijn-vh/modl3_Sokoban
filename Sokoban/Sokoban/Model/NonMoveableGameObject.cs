using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model
{
    public abstract class NonMoveableGameObject : GameObject
    {
        public MoveableGameObject Player { get => _player; set => _player = value; }
        public MoveableGameObject Crate { get => _crate; set => _crate = value; }

        public bool IsActive
        {
            get
            {
                if (this.Crate != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public NonMoveableGameObject Up
        {
            get { return _Up; }
            set
            {
                _Up = value;
                if (Player != null)
                {
                    Player.Up = value;
                }

                if (Crate != null)
                {
                    Crate.Up = value;
                }
            }
        }
        public NonMoveableGameObject Right
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
        public NonMoveableGameObject Down
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
        public NonMoveableGameObject Left
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
        private NonMoveableGameObject _Up;
        private NonMoveableGameObject _Right;
        private NonMoveableGameObject _Down;
        private NonMoveableGameObject _Left;
        private MoveableGameObject _player;
        private MoveableGameObject _crate;
    }
}
