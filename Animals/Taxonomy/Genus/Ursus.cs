namespace Zoolandia.Animals
{
  public class Ursus : Genus
  {

    private void init()
    {
      this.url = "https://en.wikipedia.org/wiki/Bear";
      this.trait = "hibernates";
      this.commonName = "Bear";
      this.scientificName = "Ursus";
    }

    public Ursus()
    {
      this.init();
    }
  }
}