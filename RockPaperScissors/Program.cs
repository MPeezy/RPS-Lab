using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Rocky r = new Rocky();
            Console.WriteLine("Rocky selects " + r.GetRPS());

            UserPlayer p = new UserPlayer();
            RPSEnum result = p.GetRPS();
            Console.WriteLine("User selects " + result);
          
            Randa ra = new Randa();
            Console.WriteLine("Randa selects " + ra.GetRPS());

           

        }
    }
}


