using System;

static void ejemplo1()
{
    int[] calificaciones;

    calificaciones = new int[] { 85, 92, 77, 68, 94 };

    Console.Writeline(calificaciones[2]);

    foreach (int calificacion in calificaciones)
    {
        Console.Writeline(calificacion);
    }

}


//--------------------------------------------------------------------------------------------------------------------------

using System;

class Program
{
    static void Main(string[] args)
    {
        Ejemplo1();
    }

    static void Ejemplo1()
    {
        int[] calificaciones = { 85, 92, 77, 68, 94 };

        Console.WriteLine("Calificaciones:");
        foreach (int calificacion in calificaciones)
        {
            Console.WriteLine(calificacion);
        }

        int suma = 0;
        foreach (int calificacion in calificaciones)
        {
            suma += calificacion;
        }

        double promedio = (double)suma / calificaciones.Length;
        Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
    }
}


//----------------------------------------------------------------------------------------------------------------------


using System;

class Program
{
    static void Main(string[] args)
    {
        Ejemplo1();
    }

    static void Ejemplo1()
    {
        int[] calificaciones = new int[] { 85, 92, 77, 68, 94, 60, 25, 80, 40, 56 };
        Console.WriteLine("Calificaciones:");
        foreach (int calificacion in calificaciones)
        {
            Console.WriteLine(calificacion);
        }

        double promedio = CalcularPromedio(calificaciones);
        Console.WriteLine($"El promedio de las calificaciones es: {promedio}");
    }

    static double CalcularPromedio(int[] calificaciones)
    {
        int suma = 0;
        for (int i = 0; i < calificaciones.Length; i++)
        {
            suma += calificaciones[i];
        }
        return (double)suma / calificaciones.Length;
    }