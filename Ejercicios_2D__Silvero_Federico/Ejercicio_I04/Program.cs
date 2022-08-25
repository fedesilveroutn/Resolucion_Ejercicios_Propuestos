using System;

//Consigna
//Un número perfecto es un entero positivo, que es igual a la suma de todos 
//los enteros positivos (excluido el mismo) que son divisores del número.

//El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.

//Escribir una aplicación que encuentre los 4 primeros números perfectos.

//Al darse cuenta de que 2n – 1 es un número primo en cada caso, 
//Euclides demostró que la fórmula 2^(n–1) * (2^n – 1) genera un número 
//perfecto par siempre que 2^n – 1 es primo


namespace Ejercicio_I04
{
    public class Program
    {
        static void Main(string[] args)
        {
            double n;
            double numeroPerfecto;
            int contador = 0;

            n = 1;
            while(contador < 4)
            {               
                if(EsNumeroPrimo( (Math.Pow(2, n) - 1) ) == true)
                {
                    numeroPerfecto = Math.Pow(2, (n - 1)) * (Math.Pow(2, n) - 1);
                    Console.WriteLine($"El numero {numeroPerfecto} es perfecto");
                    contador++;
                }               
                n++;
            }
        }


        public static bool EsNumeroPrimo(double numeroAEvaluar)
        {
            int divisor = 1;
            int cantidadDivisores = 0;

            while (divisor <= numeroAEvaluar)
            {
                if (numeroAEvaluar % divisor == 0)
                {
                    cantidadDivisores++;
                }
                divisor++;
            }

            if (cantidadDivisores == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
