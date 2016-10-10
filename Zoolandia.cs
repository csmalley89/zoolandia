using System;
using Zoolandia.Animals;
using System.Collections.Generic;

namespace Zoolandia
{ 
  class Zoolandia
  {
    static void Main(string[] args)
    {

      // Create some animals
      Odocoileus manny = new Odocoileus();
      manny.name = "Manny";
      manny.species = new OdocoileusHermionus();

      Odocoileus danny = new Odocoileus();
      danny.name = "Danny";
      danny.species = new OdocoileusVirginianus();

      Vulpes jerry = new Vulpes();
      jerry.name = "jerry";
      jerry.species = new VulpesMacrotis();

      Vulpes larry = new Vulpes();
      larry.name = "larry";
      larry.species = new VulpesVulpes();

      Ursus harry = new Ursus();
      harry.name = "harry";
      harry.species = new UrsusAmericanus();

      Ursus carrie = new Ursus();
      carrie.name = "carrie";
      carrie.species = new UrsusArctos();

      // Output the habitats in our Zoo
      Console.WriteLine()
    }
  }
}