using System;
using System.IO;
class Program
{
    static void Main()
    {
        int resultado = SumaYVerifica(50, 60);
        Console.WriteLine($"El resultado es: {resultado}");
    }
    static int SumaYVerifica(int a, int b)
    {
        int suma = a + b;
        
        // Verifica si la suma es mayor a 100
        if (suma > 100)
        {
            // Guarda el resultado en un archivo si es mayor a 100
            File.WriteAllText("resultado.txt", $"Resultado mayor a 100: {suma}");
            Console.WriteLine("La suma es mayor a 100, y el resultado se ha guardado en un archivo.");
        }
        return suma;
    }
}
