using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace simpleGame
{
    class GameFight
    {
        int finalScorePlayerOne;
        int finalScorePlayerTwo;

        public GameFight()
        {
            Console.WriteLine("Wellcome players\n let's begin!!");
            Thread.Sleep(2000);
            Console.WriteLine("First round!\nThe ship with the most badass name, wins this round.");
            Thread.Sleep(2000);
            Console.WriteLine("Start!!");
        }
        public void FirstRound(Ship player1, Ship player2)// basically the longest chars in the name is the badass one... :)
        {
            if(player1.name.Length > player2.name.Length)
            {
                Console.WriteLine("Player one name: {0}, winns this rownd", player1.name);
                finalScorePlayerOne += 1;//adding one point to player one
            }
            else
            {
                Console.WriteLine("Player two name: {0}, winns this rownd", player2.name);
                finalScorePlayerTwo += 1;//adding one point to player two
            }

        }


    }
}
