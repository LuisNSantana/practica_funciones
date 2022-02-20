using System;

namespace ejercicio1clase
{
    class MainClass
    {
        /// <summary>
        /// Funcion que realiza el calculo con
        /// solo el parametro sueldo.
        /// </summary>
        /// <param name="sueldo">sueldo</param>
        public static  void calculoCredito(double sueldo)
        {
            sueldo = sueldo * 1.15;

            Console.WriteLine("El credito es: " + sueldo);

        }
        public static void calculoCredito(double sueldo, int anho)
        {
           double resul= (sueldo * 1.15) + (sueldo * (0.1 * anho));
           Console.WriteLine("El credito es: " + resul);

        }

        public static void calculoCredito(double sueldo, int anho, bool empleado)
        {
            double resul = (sueldo * 1.15) + (sueldo * (0.1 * anho) * 0.20);

            if(empleado == true)
            {
                Console.WriteLine("El credito es de: " + resul);
            }
        }
        public static void Main(string[] args)
        {
            
            bool continuar=true;
            double suel;
            int antiguedad = 0;
            bool emple = true;

            do
            {
                Console.WriteLine("Ingrese el sueldo: ");
                suel = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Quiere continuar si/no: ");
                continuar = Convert.ToBoolean(Console.ReadLine());
                Console.WriteLine("Oprimir espacio para continuar");
                Console.ReadKey();
                if (continuar == true)
                {
                    Console.WriteLine("Ingrese antiguedad en la empresa: ");
                    antiguedad = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Quiere continuar si/no: ");
                    continuar = Convert.ToBoolean(Console.ReadLine());
                }
                Console.WriteLine("Oprimir espacio para continuar");
                Console.ReadKey();
                if (continuar == true)
                {
                    Console.WriteLine("Es empleado del banco? true/false: ");
                    emple = Convert.ToBoolean(Console.ReadLine());

                }

            } while (continuar != false);


            if      (suel == suel) calculoCredito(suel);
            else if (suel == suel && antiguedad == antiguedad) calculoCredito(suel, antiguedad);
            else if (suel == suel && antiguedad == antiguedad && emple == true) calculoCredito(suel, antiguedad, emple);
             
        }
    }
}
