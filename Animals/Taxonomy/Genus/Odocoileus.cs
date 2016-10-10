namespace Zoolandia.Animals
{
  public class Odocoileus : Genus
  {

    private void init()
    {
      this.url = "https://en.wikipedia.org/wiki/Odocoileus";
      this.trait = "antlers";
      this.commonName = "Deer";
      this.scientificName = "Odocoileus";
    }

    public Odocoileus()
    {
      this.init();
    }
  }
}