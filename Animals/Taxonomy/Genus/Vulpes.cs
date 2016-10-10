namespace Zoolandia.Animals
{
  public class Vulpes : Genus
  {

    private void init()
    {
      this.url = "https://en.wikipedia.org/wiki/Vulpes";
      this.trait = "short lifespan usually less then 5 years";
      this.commonName = "Fox";
      this.scientificName = "Vulpes";
    }

    public Vulpes()
    {
      this.init();
    }
  }
}