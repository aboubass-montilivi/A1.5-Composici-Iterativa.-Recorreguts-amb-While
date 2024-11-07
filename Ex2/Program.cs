namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MARCA_FI = null;
            string linia;
            int contador, num;
            StreamReader sr;

            sr = new StreamReader("NUMEROS.TXT");
            contador = 0;
            linia = sr.ReadLine();

            while (linia != MARCA_FI)
            {
                contador++;
                Console.WriteLine($"A LA ITERACIÓ {contador} HI HA EL NUMERO {linia} ");
                linia = sr.ReadLine();
            }

            Console.WriteLine($"EL FITXER TÉ {contador} LINIES");
        }
    }
}
