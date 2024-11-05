namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MARCA_FI = 0;
            int num, positius, negatius;

            int hola;

            positius = 0;
            negatius = 0;

            num = Convert.ToInt32(Console.ReadLine());

            while(num != MARCA_FI)
            {
                if (num < 0)
                    negatius++;
                else
                    positius++;

                num = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine($"POSITIUS: {positius} ");
            Console.WriteLine($"NEGATIUS: {negatius}");
        }
    }
}
