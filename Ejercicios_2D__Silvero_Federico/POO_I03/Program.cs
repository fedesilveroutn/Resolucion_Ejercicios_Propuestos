using System;
using Biblioteca_I03;

namespace POO_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudiante1 = new Estudiante("Federico", "Silvero", "1000");
            Estudiante estudiante2 = new Estudiante("Valentin", "Silvero", "1002");
            Estudiante estudiante3 = new Estudiante("Constanza", "Arancio", "1003");

            estudiante1.SetNotaPrimerParcial(10);
            estudiante1.SetNotaSegundoParcial(9);

            estudiante2.SetNotaPrimerParcial(8);
            estudiante2.SetNotaSegundoParcial(10);

            estudiante3.SetNotaPrimerParcial(3);
            estudiante3.SetNotaSegundoParcial(2);


            Console.WriteLine(estudiante1.Mostrar());
            Console.WriteLine(estudiante2.Mostrar());
            Console.WriteLine(estudiante3.Mostrar()); 
        }
    }
}
