using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Interfaces
{
    interface INonMoveableGameObject : IGameObject
    {
        Boolean IsActive { get; set; }
        void Active();
        void Deactivate();
    }
}
