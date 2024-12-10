// See https://aka.ms/new-console-template for more information

Dier hond = new Dier("Woef Woef");
hond.AantalPoten = 4;
hond.Naam = "Lassie";

Console.WriteLine(hond.MaakGeluid());

Dier kat = new Dier("Miauw Miauw");
kat.AantalPoten = 4;
kat.Naam = "Mies";

Console.WriteLine($"{kat}");

Console.ReadLine();
