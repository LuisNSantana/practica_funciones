using System;
using System.Linq;

namespace ejercicio5
{
    class MainClass
    {
        public static void calcularMaxMin(int [] numeros)
        {

            int max = numeros[0];
            int min = numeros[0];
            int contador = 0;

            for (int i = 0; i < numeros.Length; i++)
            {

                Console.Write(numeros[i] + "|");
                

            }
            while(contador < numeros.Length)
            {
               if(numeros[contador] > max)
                {
                    max = numeros[contador];
                }

               if(numeros[contador] < min)
                {
                    min = numeros[contador];
                }
                contador++;
            }

            Console.WriteLine(" el numero mayor es: " + max);
            Console.WriteLine("el numero menor es: " + min);


        }
        public static void Main(string[] args)
        {

            int[] numer = new int[5];

            

            for (int i = 0; i < numer.Length; i++)
            {
                Console.WriteLine("ingrese un numero: ");
               numer[i] = Convert.ToInt32(Console.ReadLine());

                
            }

            calcularMaxMin(numer);

            

            
        } 
    }
}
