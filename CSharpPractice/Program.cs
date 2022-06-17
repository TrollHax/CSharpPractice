
string name = PlanetRadius.Earth.ToString();
int radius = (int)PlanetRadius.Earth;
double volume = Volume(PlanetRadius.Earth);

Console.WriteLine("Planet: " + name);
Console.WriteLine("Radius: " + radius + "km");
Console.WriteLine("Volume: " + volume + "km^3");

static double Volume(PlanetRadius radius)
{
    double volume = Math.Round(((4 * Math.PI * Math.Pow((int)radius, 3)) / 3));
    return volume;
}

Console.ReadKey();

enum PlanetRadius
{
    Mercury = 2439,
    Venus = 6051,
    Earth = 6371,
    Mars = 3389,
    Jupiter = 69911,
    Saturn = 58232,
    Uranus = 25362,
    Neptune = 24622,
    Pluto = 1188
}
