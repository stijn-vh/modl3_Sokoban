using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    interface IMoveableGameObject : IGameObject
    {
        void Move();
        void ChechCollision(); // Check collision, als parameter richting meegeven?
    }
}
