using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public interface IMoveableGameObject : IGameObject
    {
        void Move();
        bool CheckCollision(int dir); // Check collision, als parameter richting meegeven?
    }
}
