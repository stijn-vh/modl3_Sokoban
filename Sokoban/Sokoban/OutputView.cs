using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sokoban
{
    public class OutputView
    {

        public void drawView(ArrayList LevelCharacters)
        {
            for(int i = 0; i < LevelCharacters.Count; i++)
            {
                Console.WriteLine(LevelCharacters[i]);
            }
            Console.ReadLine();
        }
    }
}