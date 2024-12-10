public class Kat : Dier
{
    public Kat(string geluid) : base(geluid)
    {

    }

    public override string MaakGeluid()
    {
        return $"De kat maakt het geluid: {base.MaakGeluid()}";
    }
}