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
            Console.WriteLine("Wellcome players\nLet's begin!!");
            Thread.Sleep(2000);
            Console.WriteLine("First round!\nThe ship with the most badass name, wins this round.");
            Thread.Sleep(5000);
            Console.WriteLine("Start!!");
        }
        public void FirstRound(Ship player1, Ship player2)// basically the longest chars in the name is the badass one... :)
        {
            if (player1.name.Length > player2.name.Length)
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
        public void SecondRound(Ship player1, Ship player2)//TO DO: the game logic nu scade cum trebuie, tre sa gasesc 
            //o modalitate care sa scada punctual din scor fara sa afecteze stamina celuilalt cumva poate fac cu adica sa-i 
            //scada din viata, dar lui ala nu din stamina ca daca am unul care are viata mai buna ca stamina lui ala ce facem?? 
            //adica sa fac cumvasa calculez viata - stamina = rezultatul sa il tot decrementez pana la 0 si asa sa fac si cu alalat jucator
        {
            int finalStamina =  player1.power - player2.stamina;//tre sa vad aici la logica asta mai intai cum fac daca ala are mai multa stamina ca in cazul lui bismarck fata de yamamaoto cum o sa calculez loviturile.
            int tempStamina = finalStamina;
            for (int i = 1; i <= finalStamina; i++)
            {
                Console.WriteLine("Player one attack no {0}!! player two has {1} stamina left",i,tempStamina-- );
            }

            //Thread.Sleep(5000);
            //Console.WriteLine("Round two!");
            //Console.WriteLine("Rules: the ship that will stand tall after the atack will win");
            //while (0 < player2.stamina)
            //{
            //    int count = 1;
            //    Console.WriteLine("Atack no {0}!\nPlayer one hits Player two!!\nPlayer two has {1} stamina left", count, player2.stamina);
            //    count++;
            //    player2.stamina--;
            //    Thread.Sleep(4000);
            //}
            //while (0 < player1.stamina)
            //{
            //    int count = 1;
            //    Console.WriteLine("Atack no {0}!\nPlayer two hits Player one!!\nPlayer one has {1} stamina left", count, player1.stamina);
            //    count++;
            //    player1.stamina--;
            //    Thread.Sleep(4000);
            //}
            //Console.WriteLine("Round two winner is...");
            //Thread.Sleep(5000);
            //if (player1.stamina > player2.stamina)
            //{
            //    Console.WriteLine("Player one, {0}, wins this round!!", player1.name);
            //    finalScorePlayerOne += 1;
            //}
            //else
            //{
            //    Console.WriteLine("Player two, {0}, wins this round!!", player2.name);
            //    finalScorePlayerTwo += 1;
            //}
        }
    }
}
