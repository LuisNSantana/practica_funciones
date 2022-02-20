using System;

namespace ejercicio14
{
    class MainClass
    {
       public static void mostrarVector(char[] vector)
        {
            for (int j = 0; j < vector.Length; j++)
            {

                Console.Write(vector[j] + "|");

            }
            Console.WriteLine("");
        }
       public static char[] inicializarPila(char[] arr)
        {
            for(int i = 0; i< arr.Length; i++)
            {
                arr[i] = '*';
            }
            return arr;
        }

        public static int longitudPila(char[] arr)
        {
            int cont = 0;
            for(int i = 0; i<arr.Length; i++)
            {
                if(arr[i] != '*')
                {
                    cont++;
                }
               
            }
            return cont;

            
        }
        public static bool estaVacia(char [] arr)
        {
            if(longitudPila(arr) == 0)
            {
                return true;
            }
            else
            {
                return false; 
            }
        }

        public static bool estaLlena(char [] arr)
        {
            if(longitudPila(arr) == arr.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static char[] addFila(char[] arr, char fila)
        {   //comprobamos que el array no este lleno
            if(estaLlena(arr) == true)
            {
                Console.WriteLine("Esta el array lleno");
            }
            else
            {   /*
                sino esta lleno, añadimos en el array longitudFila
                para asi tener exactos las posiciones disponibles en el array
                y que esas posiciones libres sean igual a nuestra variable fila
                que asignamos en nuestro parametro
                */
                arr[longitudPila(arr)] = fila;
            }

            return arr;

        }

        public static char sacarPila(char [] vector)
        {
            char sacarChar = ' ';

            if (estaVacia(vector) == true)
            {
                Console.WriteLine("Esta vacio el array");
            }
            else
            {
                sacarChar = vector[longitudPila(vector) - 1];
                vector[longitudPila(vector) - 1] = '*';
            }

            return sacarChar;
        }


        
        public static void Main(string[] args)
        {
            char [] cadena = new char[10];

            cadena = inicializarPila(cadena);

            mostrarVector(cadena);

            Console.WriteLine("Longitud de la pila: "+longitudPila(cadena));

            cadena[3] = 'a';
            //longitudPila(cadena);

            Console.WriteLine("Longitud de la pila: " + longitudPila(cadena));
            //la volvemos a inicializar y se vacia el array
            inicializarPila(cadena);

            Console.WriteLine("Longitud de la pila: " + longitudPila(cadena));

            addFila(cadena, 'a');
            addFila(cadena, 'b');

            mostrarVector(cadena);
        }
    }
}
