namespace Dertien_in_een_dozijn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int doosGrootte = 8;
            int aantalEieren = 124;
            int aantalEierenOver = aantalEieren - ((aantalEieren / doosGrootte) * doosGrootte);
            Console.WriteLine($"{aantalEieren} eieren passen in {aantalEieren/doosGrootte} dozen van doosgrootte:{doosGrootte}. Daarbij zal je nog {aantalEierenOver} eieren over hebben.");
        }
    }
}
