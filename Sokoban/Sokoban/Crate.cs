using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class Crate : GameObject
    {
        public Crate(char _char, GameObject Up, GameObject Right, GameObject Down, GameObject Left) : base(_char, Up, Right, Down, Left)
        {
        }
    }
}