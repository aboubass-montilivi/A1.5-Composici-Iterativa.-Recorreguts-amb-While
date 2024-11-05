using System.Globalization;

namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MARCA_FI = 0;
            int num, nPetit, nGran, contador;

            //truco quillo 
            nPetit = int.MaxValue;
            nGran = int.MinValue;
            contador = 0;

            num = Convert.ToInt32(Console.ReadLine());

            while (num != MARCA_FI)
            {
                //hay que incrementar el contador para que no muestre siempre 0
                contador++;

                if (num >nGran)
                {
                    nGran = num;
                }

                if (num <nPetit)
                {
                    nPetit = num;


                }
                num = Convert.ToInt32(Console.ReadLine());
               
            }
            if (contador == 0)
            {
                Console.WriteLine("NO HAS ENTRAT CAP NUMERO");
            }
            else
            {
                Console.WriteLine($"NUMERO MÉS GRAN {nGran}");
                Console.WriteLine($"NUMERO MES PETIT {nPetit}");
            }
        }
    }
}
