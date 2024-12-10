public class Dier
{
    public string Naam { get; set; }

    public int AantalPoten { get; set; }

    private string _geluid;

    public Dier(string geluid)
    {
        _geluid = geluid;
    }

    public string MaakGeluid()
    {
        return _geluid;
    }
}