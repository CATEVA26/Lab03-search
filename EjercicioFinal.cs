using System.Diagnostics;

namespace Lab03_search;
class EjercicioFinal
{
    static void Main(string[] args)
    {
        //Hora de Inicio
        Console.WriteLine("Algoritmo de Ejercicio Final");
        int[] ArregloCienEnteros = new int[100];
        int[] Arreglo50Aleatorios = new int[50];
        float numeroDeExitos = 0;
        float numeroDeFallos = 0;
        LlenarArregloConNumAleatorios(ArregloCienEnteros);
        LlenarArregloConNumAleatorios(Arreglo50Aleatorios);

        imprimirArray(ArregloCienEnteros);
        imprimirArray(Arreglo50Aleatorios); 

        for (int i = 0; i < Arreglo50Aleatorios.Length; i++)
        {
            if(BusquedaLinealID(ArregloCienEnteros,ArregloCienEnteros.Length,Arreglo50Aleatorios[i]) != -1){
                numeroDeExitos +=1; 
            };
        }
        numeroDeFallos = 50-numeroDeExitos; //Como se hacen 50 pruebas entonces el numero fallas sera el total de experimentos menos los exitos
        Console.WriteLine("Busquedas: \t exito \t fallidas \t % exitos \t % fallidas");
        Console.WriteLine($"\t\t  {numeroDeExitos} \t  {numeroDeFallos} \t\t  {(numeroDeExitos/50)*100}% \t\t     {(numeroDeFallos/50)*100}%"); 
        

    }

    private static int BusquedaLinealID(int[] a, int n, int clave)
    {
        int i;
        for (i = 0; i < n; i++)
            if (a[i] == clave)
                return i;
        return -1;
    }

    private static void LlenarArregloConNumAleatorios(int[] array)
    {
        
        Random rnd = new Random();
        for (int i = 0; i < array.Length; i++)

        {
            array[i] = rnd.Next(1, 201); // Lena numeros alatorios desde el 1 hasta el 200, 
        }
    }
    private static void imprimirArray(int[] A)
    {
        Array.Sort(A);
        Console.WriteLine("Posicion \t valor");
        for (int i = 0; i < A.Length; i++)
        {
            Console.Write(i + " \t\t  " + A[i] + ", \n");
        }
        Console.WriteLine();
    }

}

