namespace Ex9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int nXifres;

            nXifres = 0;
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 0)
                nXifres = 1;

            while (num != 0)
            {
                nXifres++;
                num = num / 10;
            }

            Console.WriteLine($"EL NUMERO TE {nXifres} xifres");

        }
    }
}
