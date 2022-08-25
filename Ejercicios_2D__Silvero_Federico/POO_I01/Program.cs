using System;
using Biblioteca;

namespace POO_I01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta;
            string respuesta;


            Console.Write("Ingrese su razón social: ");
            string titular = Console.ReadLine();

            Console.Write("Ingrese su saldo inicial: ");
            float saldoInicial = float.Parse(Console.ReadLine());

            cuenta = new Cuenta(titular, saldoInicial);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Cuenta creada exitosamente!");

            do
            {
                Console.WriteLine("-----------------------------------");
                Console.WriteLine($"1. Ver saldo {Environment.NewLine}2. Ingresar dinero {Environment.NewLine}3. Retirar dinero {Environment.NewLine}4. Salir");
                Console.WriteLine("-----------------------------------");
                Console.Write("Seleccione una opción: ");
                respuesta = Console.ReadLine();
                Console.WriteLine("-----------------------------------");

                switch (respuesta)
                {

                    case "1":
                        Console.WriteLine($"Saldo disponible: {cuenta.GetCantidad().ToString()}");
                        break;


                    case "2":
                        Console.WriteLine("¿Cuánto dinero quiere ingresar? : ");
                        float montoIngresar = float.Parse(Console.ReadLine());
                        cuenta.Ingresar(montoIngresar);
                        break;


                    case "3":
                        Console.Write("¿Cuánto dinero quiere retirar? : ");
                        float montoRetirar = float.Parse(Console.ReadLine());
                        cuenta.Retirar(montoRetirar);
                        break;
                }

                Console.ReadKey();

            } while (respuesta != "4");

        }
    }
}
