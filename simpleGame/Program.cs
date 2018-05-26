using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simpleGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship one = new Bismarck();
            one.ShipDesign(7, 5, "bismarck", 18);
            Ship two = new Yamamoto();
            two.ShipDesign(11, 15, "yamamoto23", 13);
            //initial gameplay
            GameFight firstFight = new GameFight();
            firstFight.FirstRound(one, two);
            firstFight.SecondRound(one, two);
            firstFight.ThirdRound(one, two);
            firstFight.SeeScore();
            Console.ReadLine();
        }
    }
}
