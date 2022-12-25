using System.Diagnostics;

namespace Lab03_search;
class LinearSearch
{
    static void Main1(string[] args)
    {
        //Hora de Inicio
        DateTime start = DateTime.Now;
        Console.WriteLine("Algoritmo de busqueda Lineal\n" + "Inicio ejecución: " + start.Hour + ":" + start.Minute
         + ":" + start.Second + ":" + start.Millisecond);
        int[] A = { 79, 21, 15, 99, 88, 65, 75, 85, 76, 46, 84, 24, 54, 77, 28, 47, 98, 78, 60, 20 };
        int n = A.Length;
        Console.WriteLine("Arreglo Desordenado");
        Console.WriteLine("Posicion \t valor");
        for (int i = 0; i < n; i++)
        {
            Console.Write(i + " \t\t  " + A[i] + ", \n");
        }
        Console.WriteLine();
        Console.Write("Ingrese el valor a buscar: ");
        int valorABuscar = Int32.Parse(Console.ReadLine());
        Stopwatch tiempoAMedir = new Stopwatch();
        tiempoAMedir.Start();
        int posicionEncontrada = BusquedaLinealID(A, n, valorABuscar); // 65 es el elemento a buscar
        tiempoAMedir.Stop();
        if (posicionEncontrada != -1){
            Console.WriteLine($"Elemento Encontrado en posición: {posicionEncontrada} y el elemento es: {A[posicionEncontrada]}");

        }else{
            Console.WriteLine("No se encontró el elemento");
        }


        DateTime end = DateTime.Now;
        Console.WriteLine("Fin de ejecución: " + end.Hour + ":" + end.Minute + ":" + end.Second + ":" + end.Millisecond);
        Console.WriteLine($"Fin De busqueda: {tiempoAMedir.Elapsed.TotalMilliseconds} ms");
    }

    private static int BusquedaLinealID(int[] a, int n, int clave)
    {
        int i;
        for (i = 0; i < n; i++)
            if (a[i] == clave)
                return i;
        return -1;
    }
}

