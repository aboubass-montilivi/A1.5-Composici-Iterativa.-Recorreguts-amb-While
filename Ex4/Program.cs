namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int positiu = 0;
            int negatiu = 0;
            const string MARCA_FI = null;

            //sempre s'utilitzara linia per llegir de int a string
            string linia;
            int contador, num;

            //permet obrir arxius
            StreamReader sr;

            //obrir fitxer
            sr = new StreamReader("NUMEROS.TXT");
            contador = 0;

            //llegir cada linia del fitxer fins arribar a null
            linia = sr.ReadLine();

            //mentre la linia sigui diferent a null
            while (linia != MARCA_FI)
            {
                num = Convert.ToInt32(linia);
                contador++;
                Console.WriteLine($"A la iteració {contador} hi ha el numero {linia}");

                if (num > 0)
                    positiu++;
                else if (num < 0)
                    negatiu++;

                linia = sr.ReadLine();

            }

            Console.WriteLine($"Numeros positius: {positiu}");
            Console.WriteLine($"Numeros negatius: {negatiu}");

        }
    }
}
