using Sokoban.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Sokoban
{
    class Player : IMoveableGameObject
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

        public bool CheckCollision(int dir) // 1: up, 2: right, 3: down, 4: left
        {
            INonMoveableGameObject tileOfDir = null;
            switch (dir)
            {
                case 1:
                    tileOfDir = _Up;
                    break;
                case 2:
                    tileOfDir = _Right;
                    break;
                case 3:
                    tileOfDir = _Down;
                    break;
                case 4:
                    tileOfDir = _Left;
                    break;
            }
            Console.WriteLine(tileOfDir.GetType().Name);
            if(tileOfDir.GetType().Name == "Wall")
            {
                if(tileOfDir.Crate != null)
                {

                }
                return false;
            }
            return true;
        }

    }
}

