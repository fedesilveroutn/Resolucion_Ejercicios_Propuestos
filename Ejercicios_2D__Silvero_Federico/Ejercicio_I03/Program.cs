using System;

//Consigna
//Mostrar por pantalla todos los números primos que haya hasta el número
//que ingrese el usuario por consola.

//Validar que el dato ingresado por el usuario sea un número.

//Volver a pedir el dato hasta que sea válido o el usuario ingrese "salir".

//Si ingresa "salir", cerrar la consola.

//Al finalizar, preguntar al usuario si desea volver a operar.
//Si la respuesta es afirmativa, iterar. De lo contrario, cerrar la consola.

//IMPORTANTE
//Utilizar sentencias de iteración, selectivas y el operador módulo (%).

//TERMINAR

namespace Ejercicio_I03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int numeroAEvaluar;
            string datoIngresado;
            string continuarOperando = null;
            bool esUnDatoIngresadoValido;


            do
            {
                Console.Write("Ingrese un número: ");
                datoIngresado = Console.ReadLine();

                if(datoIngresado == "salir")
                {
                    break;
                }
                else
                {
                    esUnDatoIngresadoValido = int.TryParse(datoIngresado, out numeroIngresado);
                    if(esUnDatoIngresadoValido == false)
                    {
                        continuarOperando = "volverAPedir";
                    }
                    else
                    {
                        int divisor;
                        int cantidadDivisores;

                        for (numeroAEvaluar = 2; numeroAEvaluar <= numeroIngresado; numeroAEvaluar++)
                        {
                            divisor = 1;
                            cantidadDivisores = 0;

                            while (divisor <= numeroIngresado)
                            {
                                if (numeroAEvaluar % divisor == 0)
                                {
                                    cantidadDivisores++;
                                }

                                divisor++;
                            }
                            
                            if(cantidadDivisores == 2)
                            {
                                Console.WriteLine($"El número {numeroAEvaluar} es primo.");
                            }
                        }

                        Console.Write("¿Desea continuar operando? (seguir/salir): ");
                        continuarOperando = Console.ReadLine();
                    }
                }

            } while (continuarOperando != "salir");

           
        }
    }
}
