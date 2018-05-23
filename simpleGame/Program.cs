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
            one.ShipDesign(11, 15, "bismarck");
            Ship two = new Yamamoto();
            two.ShipDesign(8, 5, "yamamoto");
            //initial gameplay
            GameFight firstFight = new GameFight();
            firstFight.FirstRound(one, two);
            Console.ReadLine();
            firstFight.SecondRound(one, two);
            Console.ReadLine();
            
        }
    }
}
