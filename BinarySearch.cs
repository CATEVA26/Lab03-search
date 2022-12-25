using System.Diagnostics;

namespace Lab03_search;
class BinarySearch
{
    static void Main2(string[] args)
    {
        //Hora de Inicio
        DateTime start = DateTime.Now;
        Console.WriteLine("Algoritmo de búsqueda Binaria\n" + "Inicio ejecución: " + start.Hour + ":" + start.Minute
         + ":" + start.Second + ":" + start.Millisecond);
        int[] A = { -8, 4, 5, 9, 12, 18, 25, 40, 60, 55, 48, 78, 98, 35, 14, 7, 2, 0, 3, 89 };
        int n = A.Length;
        Console.WriteLine("Arreglo Desordenado");
        imprimirArray(A, n);
        Console.WriteLine("Arreglo Ordenado");
        Array.Sort(A);
        imprimirArray(A, n);
        Console.Write("Ingrese el valor a buscar: ");
        int valorABuscar = Int32.Parse(Console.ReadLine());
        Stopwatch tiempoAMedir = new Stopwatch();
        tiempoAMedir.Start();
        int posicionEncontrada = BúsquedaBinaria(A, n, valorABuscar); // 65 es el elemento a buscar
        tiempoAMedir.Stop();
        if (posicionEncontrada != -1)
        {
            Console.WriteLine($"Elemento Encontrado en posición: {posicionEncontrada} y el elemento es: {A[posicionEncontrada]}");

        }
        else
        {
            Console.WriteLine("No se encontró el elemento");
        }
        DateTime end = DateTime.Now;
        Console.WriteLine("Fin de ejecución: " + end.Hour + ":" + end.Minute + ":" + end.Second + ":" + end.Millisecond);
        Console.WriteLine($"Fin De busqueda: {tiempoAMedir.Elapsed.TotalMilliseconds} ms");
    }

    private static void imprimirArray(int[] A, int n)
    {
        Console.WriteLine("Posicion \t valor");
        for (int i = 0; i < n; i++)
        {
            Console.Write(i + " \t\t  " + A[i] + ", \n");
        }
        Console.WriteLine();
    }

    private static int BúsquedaBinaria(int[] lista, int n, int clave)
    {
        int bajo = 0, alto = n - 1, central = 0;
        bool encontrado = false;
        while ((bajo <= alto) && (!encontrado))
        {
            central = (bajo + alto) / 2;
            if (lista[central] == clave)
                encontrado = true;             // éxito en la búsqueda
            else if (clave < lista[central]) // a lo bajo del central
                alto = central - 1;
            else                            // a la alto del central
                bajo = central + 1;
        }
        return encontrado ? central : -1; // central si encontrado -1 otro caso

    }
}

