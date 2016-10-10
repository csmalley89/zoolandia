using System;
using Zoolandia.Species;

namespace Zoolandia
{
    public class Program
    {
        public static void Main(string[] args)
        {

            OdocoileusVirginianus WhiteTailedDeer = new OdocoileusVirginianus("White Tailed Deer");
            WhiteTailedDeer.Name = "White Tailed Deer";
            Console.WriteLine(WhiteTailedDeer.Name + " likes to " + WhiteTailedDeer.Action());
            Console.WriteLine(WhiteTailedDeer.Welcome());

            OdocoileusHermionus MuleDeer = new OdocoileusHermionus("Mule Deer");
            MuleDeer.Name = "Mule Deer";
            Console.WriteLine(MuleDeer.Name + " likes to " + MuleDeer.Action());
            Console.WriteLine(MuleDeer.Welcome());

            VulpesVulpes RedFox = new VulpesVulpes("Red Fox");
            RedFox.Name = "Red Fox";
            Console.WriteLine(RedFox.Name + " likes to " + RedFox.Action());
            Console.WriteLine(RedFox.Welcome());

            VulpesMacrotis KitFox = new VulpesMacrotis("Kit Fox");
            KitFox.Name = "Kit Fox";
            Console.WriteLine(KitFox.Name + " likes to " + KitFox.Action());
            Console.WriteLine(KitFox.Welcome());

            UrsusAmericanus AmericanBlackBear = new UrsusAmericanus("American Black Bear");
            AmericanBlackBear.Name = "American Black Bear";
            Console.WriteLine(AmericanBlackBear.Name + " likes to " + AmericanBlackBear.Action());
            Console.WriteLine(AmericanBlackBear.Welcome());

            UrsusArctos BrownBear = new UrsusArctos("Brown Bear");
            BrownBear.Name = "Brown Bear";
            Console.WriteLine (BrownBear.Name + " likes to " + BrownBear.Action());
            Console.WriteLine (BrownBear.Welcome());

        }
    }
}