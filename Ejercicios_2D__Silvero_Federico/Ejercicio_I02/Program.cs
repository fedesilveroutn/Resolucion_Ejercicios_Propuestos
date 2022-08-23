using System;

//Consigna
//Ingresar un número y mostrar el cuadrado y el cubo del mismo.
//Se debe validar que el número sea mayor que cero, caso contrario,
//mostrar el mensaje: "ERROR. ¡Reingresar número!".

namespace Ejercicio_I02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            double cuadrado;
            double cubo;
            string input;
            bool validate;

            Console.Write("Ingrese un número mayor a cero: ");
            input = Console.ReadLine();
            validate = int.TryParse(input, out num);

            while (num <= 0 || validate == false)
            {
                Console.Write("Error! Reingrese un número mayor a cero: ");
                input = Console.ReadLine();
                int.TryParse(input, out num);
            }

            cuadrado = Math.Pow(num, 2);
            cubo = Math.Pow(num, 3);

            Console.WriteLine($"Número ingresado: {num} | Cuadrado: {cuadrado} | Cubo: {cubo}");
        }
    }
}
