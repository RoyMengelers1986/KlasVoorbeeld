public class Hond : Dier
{
    public Hond(string geluid): base(geluid)
    {
        
    }

    public override string MaakGeluid()
    {
        return $"De hond maakt het geluid: { base.MaakGeluid()}";
    }
}