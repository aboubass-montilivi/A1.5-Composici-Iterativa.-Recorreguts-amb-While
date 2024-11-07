namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int MARCA_FI = 0;

            int num, contador, suma;
            double mitjana;

            contador = 0;
            suma = 0;

            num = Convert.ToInt32(Console.ReadLine());

            while (num != MARCA_FI)
            {
                suma = suma + num;
                contador++;

                num = Convert.ToInt32(Console.ReadLine());

               

            }

            if (contador == 0)
            {
                Console.WriteLine("No has entrat cap num");
            }
            else
            {
                mitjana = 1.0 * suma / contador;
                Console.WriteLine($"La mitjana es {mitjana:0:00}");
            }
        }
    }
}
