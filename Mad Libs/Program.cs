namespace Mad_Libs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Geef een naam:");
            string Naam = Console.ReadLine();
            Console.WriteLine("Geef een zelfstandig naamwoord:");
            string ZelfstandigNaamwoord = Console.ReadLine();
            Console.WriteLine("Geef een adjectief:");
            string Adjectief = Console.ReadLine();
            Console.WriteLine("Geef een werkwoord:");
            string Werkwoord = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Hier komt het");
            Console.WriteLine("");
            Console.WriteLine($"Op een dag ging {Naam} naar de AP Hogeschool. Hij zag daar een {Adjectief} {ZelfstandigNaamwoord} en vond dat zo grappig dat hij begon te {Werkwoord}.");
        }
    }
}
