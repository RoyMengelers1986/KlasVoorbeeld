namespace DefaultNamespace;

public class Baas
{
    public string Naam { get; set; }
    public List<Dier> Dieren { get; set; }

    public Baas()
    {
        Dieren = new List<Dier>;
    }
}