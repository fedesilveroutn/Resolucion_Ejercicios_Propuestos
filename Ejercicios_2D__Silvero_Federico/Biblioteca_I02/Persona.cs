using System;

namespace Biblioteca_I02
{
    public class Persona
    {
        public string nombre;
        public DateTime fechaDeNacimiento;
        public int dni;

        public Persona(string nombre, DateTime fechaDeNacimiento, int dni)
        {
            this.nombre = nombre;
            this.fechaDeNacimiento = fechaDeNacimiento;
            this.dni = dni;
        }

        #region GETTERS
        public string GetNombre()
        {
            return this.nombre;
        }

        public DateTime GetFechaDeNacimiento()
        {
            return this.fechaDeNacimiento;
        }

        public int GetDni()
        {
            return this.dni;
        }
        #endregion

        #region SETTERS
        public void SetNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public void SetFechaDeNacimiento(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public void SetDni(int dni)
        {
            this.dni = dni;
        }
        #endregion




        private int CalcularEdad()
        {
            DateTime fechaActual = DateTime.Now;
            int edad =  fechaActual.Year - this.GetFechaDeNacimiento().Year;
            return edad;
        }


        public string Mostrar()
        {
            return $"Nombre: {this.GetNombre()} | Fecha de nacimiento: {this.GetFechaDeNacimiento()} | DNI: {this.GetDni()} | Edad: {this.CalcularEdad()}";
        }


        public string EsMayorDeEdad()
        {
            if (CalcularEdad() > 18)
            {
                return "Es mayor de edad";
            }
            else
            {
                return "Es menor";
            }
        }
    }
}
