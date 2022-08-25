using System;

namespace Biblioteca
{
    public class Cuenta
    {
        private string titular;
        private float cantidad;


        public Cuenta(string titular, float cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string GetTitular()
        {
            return this.titular;
        }

        public float GetCantidad()
        {
            return this.cantidad;
        }

        public string Mostrar()
        {
            return $"Titular: {GetTitular()} | Cantidad: {GetCantidad()}";
        }

        public void Ingresar(float montoIngresar)
        {
            if(montoIngresar > 0)
            {
                this.cantidad += montoIngresar;
                Console.WriteLine("Dinero ingresado exitosamente!");
            }
        }

        public void Retirar(float montoRetirar)
        {
            this.cantidad -= montoRetirar;
            Console.WriteLine($"Se han retirado {montoRetirar} de la cuenta!");
        }

    }
}
