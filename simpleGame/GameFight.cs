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
        double finalScorePlayerOne;
        double finalScorePlayerTwo;

       public GameFight()
        {
            Console.WriteLine("Wellcome players\nLet's begin!!");
            Thread.Sleep(2000);
        }
        #region 3 rounds in a gameFight: 1 the length of name, 2 the power - stamina, 3 the lenght of speed
        public void FirstRound(Ship player1, Ship player2)// basically the longest word in the name is the badass one... :)
        {
            Console.WriteLine("First round!\nThe ship with the most badass name, wins this round.");
            Thread.Sleep(5000);
            Console.WriteLine("Start!!");
            if (player1.name.Length > player2.name.Length)
            {
                Console.WriteLine("Player one name: {0}, winns this round", player1.name);
                finalScorePlayerOne += 1;//adding one point to player one
            }
            else if (player1.name.Length < player2.name.Length)
            {
                Console.WriteLine("Player two name: {0}, winns this round", player2.name);
                finalScorePlayerTwo += 1;//adding one point to player two
            }
            else
            {
                Console.WriteLine("Bouth players have a bad ass name!");
                finalScorePlayerOne += 1;
                finalScorePlayerTwo += 1;
            }
        }
        public void SecondRound(Ship player1, Ship player2)
        {
            Console.WriteLine("Second Round!");
            Thread.Sleep(4000);
            //first player1 attacks player2
            Console.WriteLine("{0} sees a chance to attack {1}!", player1.name, player2.name);
            Thread.Sleep(4000);
            int player2LifeLeft;
            player2LifeLeft = player2.stamina - player1.power;
            if (player2LifeLeft < 0)//if player1 power is greater then player2 stamina, and player2.stamina = -nr
            {
                int numberofAttacks;
                numberofAttacks = player1.power - player2.stamina;
                for (int i = 1; i < numberofAttacks; i++)
                {
                    Console.WriteLine("{0} strikes hit no {1}!! {2}, has {3} stamina left!!", player1.name, i, player2.name, player2.stamina);
                    player2.stamina--;
                    Thread.Sleep(2000);
                }
                Console.WriteLine("{0} rases the white flag! he's gaving up...", player2.name);
                Thread.Sleep(2000);
                if (player2.stamina == 0)
                {
                    Console.WriteLine("After the fight {0}, dosen't have any stamina left...", player2.name);
                }
                else
                {
                    Console.WriteLine("After the fight {0}, has {1} stamina left! Good Job!", player2.name, player2.stamina);
                    finalScorePlayerTwo += 0.5;//if the player has left some stamina he desirves 0.5 points
                }
            }
            else//if player2 stamina is grater then player1 power then we shall play he fights
            {
                for (int i = 1; i < player2LifeLeft; i++)
                {
                    Console.WriteLine("{0} strikes hit no {1}!! {2}, has {3} stamina left!!", player1.name, i, player2.name, player2.stamina);
                    player2.stamina--;
                    Thread.Sleep(2000);
                }
                Console.WriteLine("{0} rases the white flag! he's gaving up...", player2.name);
                Thread.Sleep(2000);
                if (player2.stamina == 0)
                {
                    Console.WriteLine("After the fight {0}, dosen't have any stamina left...", player2.name);
                    Thread.Sleep(2000);
                }
                else
                {
                    Console.WriteLine("After the fight {0}, has {1} stamina left! Good Job!", player2.name, player2.stamina);
                    finalScorePlayerTwo += 0.5;//if the player has left some stamina he desirves 0.5 points
                }
            }
            // Thread.Sleep(4000);
            //player2 atacks player1
            Console.WriteLine("But wait! {0} sees a chance to attack {1}!!", player2.name, player1.name);
            Thread.Sleep(2000);
            int player1LifeLeft = player1.stamina - player2.power;
            if (player1LifeLeft < 0)
            {
                int numberofAttacks;
                numberofAttacks = player2.power - player1.stamina;
                for (int i = 1; i < numberofAttacks; i++)
                {
                    Console.WriteLine("{0} strikes hit no {1}!! {2}, has {3} stamina left!!", player2.name, i, player1.name, player1.stamina);
                    player1.stamina--;
                    Thread.Sleep(2000);
                }
                Console.WriteLine("{0} rases the white flag! he's gaving up...", player1.name);
                Thread.Sleep(2000);
                if (player1.stamina == 0)
                {
                    Console.WriteLine("After the fight {0}, dosen't have any stamina left...", player1.name);
                }
                else
                {
                    Console.WriteLine("After the fight {0}, has {1} stamina left! Good Job!", player1.name, player1.stamina);
                    finalScorePlayerTwo += 0.5;
                }
            }
            else
            {
                for (int i = 1; i <= player1LifeLeft; i++)
                {
                    Console.WriteLine("{0} strikes hit no {1}!! {2}, has {3} stamina left!!", player2.name, i, player1.name, player1.stamina);
                    player1.stamina--;
                    Thread.Sleep(2000);
                }
                Console.WriteLine("{0} rases the white flag! he's gaving up...", player1.name);
                if (player1.stamina == 0)
                {
                    Console.WriteLine("After the fight {0}, dosen't have any stamina left...", player1.name);
                }
                else
                {
                    Console.WriteLine("After the fight {0}, has {1} stamina left! Good Job!", player1.name, player1.stamina);
                    finalScorePlayerOne += 0.5;//if the player has left some stamina he desirves 0.5 points
                }
            }
            //now we calculate the score
            if (player1.stamina > player2.stamina)
            {
                Console.WriteLine(" The winner of round two is {0}!", player1.name);
                finalScorePlayerOne += 1;
            }
            else if (player2.stamina > player1.stamina)
            {
                Console.WriteLine("The winner of round two is {0}!", player2.name);
                finalScorePlayerTwo += 1;
            }
            else
            {
                Console.WriteLine("it's a tie! evreybody get's 1 point!!");
                finalScorePlayerOne += 1;
                finalScorePlayerTwo += 1;
            }

        }//we will find the difference between stamina and power and we will increment the result

        public void ThirdRound(Ship player1, Ship player2)//the longest distance taken by speed, winns
        {
            Console.WriteLine("Round Three!");
            Console.WriteLine("Now we have a speed contest, the ship with the longest distance taken without refuel wins this round");
            Thread.Sleep(3000);
            Console.WriteLine("First to try is {0}...", player1.name);
            for (int i = 1; i <= player1.speed; i++)
            {
                Console.Write("[__]=>");
                Thread.Sleep(1000);
            }
            Console.WriteLine(Environment.NewLine + "Now is {0} turn...", player2.name);
            for (int i = 1; i <= player2.speed; i++)
            {
                Console.Write("[__]=>");
                Thread.Sleep(1000);
            }
            Console.WriteLine(Environment.NewLine + "As you can see the winner is...");
            if (player1.speed > player2.speed)
            {
                Console.WriteLine("{0}!!", player1.name);
                finalScorePlayerOne += 1;
            }
            else if (player1.speed < player2.speed)
            {
                Console.WriteLine("{0}!!", player2.name);
                finalScorePlayerTwo += 1;
            }
            else
            {
                Console.WriteLine("None, both have won!");
                finalScorePlayerOne += 1;
                finalScorePlayerTwo += 1;
            }
        }
        #endregion
        public void SeeScore()
        {
            Console.WriteLine("The score is {0} for player one & {1} for player two.", finalScorePlayerOne, finalScorePlayerTwo);
            if (finalScorePlayerOne > finalScorePlayerTwo)
            {
                Console.WriteLine("PLAYER ONE WINNS!!");
            }
            else if (finalScorePlayerOne < finalScorePlayerTwo)
            {
                Console.WriteLine("PLAYER TWO WINNS!!");
            }
            else
            {
                Console.WriteLine("IT'S A TIE, EVERYNBODY WINNS!!");
            }
        }
    }
}
