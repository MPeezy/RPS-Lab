using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class Rocky : Player
    {

        //set name to Rocky
        public Rocky()
        {
            Name = "Rocky"; 

        }
       
        
        //always picks rock
       public override RPSEnum GetRPS()
        {
            return RPSEnum.Rock;
        }
    }
}


