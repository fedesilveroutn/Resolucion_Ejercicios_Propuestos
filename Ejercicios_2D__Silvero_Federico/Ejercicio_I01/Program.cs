using System;

//Consigna
//Ingresar 5 números por consola, guardándolos en una variable escalar.
//Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.


namespace Ejercicio_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            int acumulador = 0;
            int flag = 0;
            float promedio = 0;

            Console.WriteLine("Ingrese cinco números enteros...");
            for(int i = 0; i < 5; i++)
            {
                string numeroIngresado = Console.ReadLine();
                int.TryParse(numeroIngresado, out numero);

                if(flag == 0)
                {
                    maximo = numero;
                    minimo = numero;
                    flag = 1;
                }

                if(numero > maximo)
                {
                    maximo = numero;
                }

                if(numero < minimo)
                {
                    minimo = numero;
                }

                acumulador += numero;
            }

            promedio = (float)acumulador / 5;
            Console.WriteLine($"Máximo: {maximo} | Mínimo: {minimo} | Promedio: {promedio}");
        }
    }
}
