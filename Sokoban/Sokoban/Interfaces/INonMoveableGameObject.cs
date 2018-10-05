using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Interfaces
{
    public interface INonMoveableGameObject : IGameObject
    {
        Boolean IsActive { get; set; }
        IMoveableGameObject Player { get; set; }
        void Active();
        void Deactivate();
    }
}
