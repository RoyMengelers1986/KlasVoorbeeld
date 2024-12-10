// See https://aka.ms/new-console-template for more information

Hond hond = new Hond("Woef Woef");
hond.AantalPoten = 4;
hond.Naam = "Lassie";

Console.WriteLine(hond.MaakGeluid());

Kat kat = new Kat("Miauw Miauw");
kat.AantalPoten = 4;
kat.Naam = "Mies";

Console.WriteLine($"{kat.MaakGeluid()}");

List<Dier> dieren = new List<Dier>();
dieren.Add(hond);
dieren.Add(kat);

foreach (Dier dier in dieren)
{
    if (dier.GetType() == typeof(Hond))
    {
        Console.WriteLine("ik heb een hond in mijn lijst");
    }
}

Console.ReadLine();
