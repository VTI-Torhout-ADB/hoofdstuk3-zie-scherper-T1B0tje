namespace Systeem_informatie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Systeeminformatie voor {Environment.UserName} op {Environment.MachineName}");
            Console.WriteLine("---------------------------------------------------");
            Console.WriteLine($"Aantal processors: {Environment.ProcessorCount}");
            Console.WriteLine($"64-bit besturingssysteem: {Environment.Is64BitOperatingSystem}");
            Console.WriteLine($"Huidige geheugen gebruik: {Environment.WorkingSet} MB");
            Console.WriteLine("---------------------------------------------------");
            
        }

    }
}
