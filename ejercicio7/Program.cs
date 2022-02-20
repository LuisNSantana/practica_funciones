using System;

namespace ejercicio7
{
    class MainClass
    {
        static void login()
        {
            //Console.WriteLine("Ingrese usuario: ");
            string usuario;
            //Console.WriteLine("Ingrese password: ");
            string pass; 
            int cont = 0;
            bool conexion = true;

            do
            {
                Console.WriteLine("ingrese usario: ");
                usuario = Console.ReadLine();
                Console.WriteLine("Ingrese password: ");
                pass = Console.ReadLine();

                if (usuario == "usuario1" && pass == "asdasd")
                {
                    conexion = true;
                    Console.WriteLine(conexion);
                }
                else
                {
                    cont++;
                    Console.WriteLine("El numero de intentos es: " + cont);
                }

            } while (conexion != true);

            
        }
        public static void Main(string[] args)
        {

            login();
            

           
        }
    }
}
