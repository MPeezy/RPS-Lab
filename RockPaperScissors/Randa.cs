using System;
using System.Collections.Generic;
using System.Text;

namespace RockPaperScissors
{
    class Randa : Player
    {
        public Randa()
        {
            Name = "Randa";
        }

        public override RPSEnum GetRPS()
        {
            Random random = new Random();
            Type type = typeof(RPSEnum);

            Array values = type.GetEnumValues();


            for (int i = 0; i < 2; ++i)
            {
                int index = random.Next(values.Length);
                RPSEnum result = (RPSEnum)values.GetValue(index);

                Console.WriteLine(result);
            }

            //return RPSEnum.Rock;
        }



    }


}




//randomly selects, rock, paper or scissors