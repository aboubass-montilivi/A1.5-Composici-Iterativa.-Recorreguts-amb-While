namespace Exemple1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MARCA_FI = ".";
            string data;
            int nMissatges;
            nMissatges = 0;
            data = Console.ReadLine();

            while(data!=MARCA_FI)
            {
                nMissatges = nMissatges + 1;
                Console.WriteLine($"Iteracio {nMissatges} -->{data}");
                data = Console.ReadLine();
            }

            Console.WriteLine($"TOTAL MISSATGES: {nMissatges}");
        }
    }
}
