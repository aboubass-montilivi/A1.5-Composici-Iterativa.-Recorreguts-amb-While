using System.Globalization;

namespace Ex12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MARCA_FI = null;

            StreamReader sr;
            string linia;
            int contadorIker, contadorAlex;

            contadorAlex = 0;
            contadorIker = 0;

            sr = new StreamReader("alumnesDAMDAW.txt");

            linia = sr.ReadLine();

            while (linia != null)
            {
                if (linia == "Alex")

                    contadorAlex++;

                else if (linia == "Iker")
                    contadorIker++;

                linia = sr.ReadLine();
            }

            if (contadorIker > contadorAlex)
                Console.WriteLine("Hi ha més alumnes amb el nom de Iker");
            else if (contadorAlex > contadorIker)
                Console.WriteLine("Hi ha més alumnes amb el nom de Alex");
            else
                Console.WriteLine("Hi ha el mateix nombre d'alumnes amb el nom Iker que Alex");
        }
    }
}
