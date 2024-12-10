public class Dier
{
    public string Naam { get; set; }

    public int AantalPoten { get; set; }

    public string Geluid { get; private set; }

    public Dier(string geluid)
    {
        Geluid = geluid;
    }

    public virtual string MaakGeluid()
    {
        return Geluid;
    }
}