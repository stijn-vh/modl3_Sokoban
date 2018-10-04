using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    interface IGameObject
    {
        IGameObject Up { get; set; }
        IGameObject Right { get; set; }
        IGameObject Down { get; set; }
        IGameObject Left { get; set; }

    }
}
