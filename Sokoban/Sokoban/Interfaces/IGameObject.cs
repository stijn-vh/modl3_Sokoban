using Sokoban.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    public interface IGameObject
    {
        INonMoveableGameObject Up { get; set; }
        INonMoveableGameObject Right { get; set; }
        INonMoveableGameObject Down { get; set; }
        INonMoveableGameObject Left { get; set; }

    }
}
