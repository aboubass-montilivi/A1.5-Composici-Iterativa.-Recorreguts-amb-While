using System.Data.Common;
using System.Numerics;

namespace Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MARCA_FI = 0;
            int num;
            int contador;

            //inicia la variable contador per el valor de 0
            contador = 0;

            //llegir primer element 
            num = Convert.ToInt32(Console.ReadLine());

            while (num != MARCA_FI)
            {
                contador = contador + 1;
                Console.WriteLine($"La iteració {contador} has entrad el numero {num}");
                //llegir seguent element
                num = Convert.ToInt32(Console.ReadLine());
            }

            //tractament final
            Console.WriteLine($"L'usuari a entrat {contador} numeros ");
        }
    }
}
