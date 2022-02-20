using System;

namespace ejercicio3
{
    class MainClass
    {
        public static void temperatura(int tempmax, int tempmin)
        {
           int tempmedia = (tempmax + tempmin) / 2;

            Console.WriteLine("La temperatura media es: " + tempmedia);

        }
        public static void Main(string[] args)
        {
            int dias;
            Console.WriteLine("Ingrese el numero de dias que quiera calcular la temp: ");
            dias = Convert.ToInt32(Console.ReadLine());
            int contador = 0;
            int ingtemp;
            int ingtemp2;
            do
            {
                
                Console.WriteLine("Ingrese la temperatura maxima: ");
                ingtemp = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese la temperatura minima: ");
                ingtemp2 = Convert.ToInt32(Console.ReadLine());

                temperatura(ingtemp, ingtemp2);
                Console.WriteLine("Oprimir enter para continuar...");
                Console.ReadKey();
                contador++;
            } while (contador < dias);
        }
    }
}
