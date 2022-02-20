using System;

namespace practicaFunciones
{
    class MainClass
    {
        public static void esMultiplo(int n1, int n2)
        {
            if(n1%n2 == 0)
            {
                Console.WriteLine("El primero es multiplo del segundo");
            }
           

        }
        public static void Main(string[] args)
        {
            
            Console.WriteLine("Escribe un numero: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escribe un numero: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            esMultiplo(n1, n2);

            if (n2 % n1 == 0) Console.WriteLine("n2 es multiplo de n1");
        }
    }
}
