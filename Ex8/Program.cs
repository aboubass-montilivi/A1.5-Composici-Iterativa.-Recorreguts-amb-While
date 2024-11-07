using System.Globalization;

namespace Ex8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string MARCA_FI = null;
            StreamReader sr;
            int nPetit, nGran;
            int contador, num;
            string linia;
            int estabuit;

            nPetit = int.MaxValue;
            nGran = int.MinValue;

            //obrim el fitxer
            sr = new StreamReader("NUMEROS.TXT");

            contador = 0;

            //llegir la primera linia
            linia = sr.ReadLine();

            while (linia != MARCA_FI)
            {
                num = Convert.ToInt32(linia);

                if (num > nGran)
                
                    nGran = num;
                
                if (num < nPetit)
                
                    nPetit = num;
                

                linia = sr.ReadLine();
            }

          
                Console.WriteLine($"NUMERO MÉS PETIT: {nPetit}");
                Console.WriteLine($"NUMERO MÉS GRAN: {nGran}");
        }
    }
}
