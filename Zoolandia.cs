using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {

            VulpesVulpes WhiteTailedDeer = new VulpesVulpes("White Tailed Deer");
            WhiteTailedDeer.Name = "White Tailed Deer";
            Console.WriteLine(WhiteTailedDeer.Name + " likes to " + WhiteTailedDeer.Action());
            Console.WriteLine(WhiteTailedDeer.Welcome());

            UrsusAmericanus RedFox = new UrsusAmericanus("Red Fox");
            RedFox.Name = "Red Fox";
            Console.WriteLine(RedFox.Name + " likes to " + RedFox.Action());
            Console.WriteLine(RedFox.Welcome());

            OdocoileusVirginianus AmericanBlackBear = new OdocoileusVirginianus("American Black Bear");
            AmericanBlackBear.Name = "American Black Bear";
            Console.WriteLine(AmericanBlackBear.Name + " likes to " + AmericanBlackBear.Action());
            Console.WriteLine(AmericanBlackBear.Welcome());

        }
    }
}