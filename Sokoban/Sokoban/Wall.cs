using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sokoban
{
    class Wall : GameObject
    {
        public Wall(char _char, GameObject Up, GameObject Right, GameObject Down, GameObject Left) : base(_char, Up, Right, Down, Left)
        {
        }
    }
}
