using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban.Model
{
    public abstract class GameObject
    {
        NonMoveableGameObject Up { get; set; }
        NonMoveableGameObject Right { get; set; }
        NonMoveableGameObject Down { get; set; }
        NonMoveableGameObject Left { get; set; }
    }
}
