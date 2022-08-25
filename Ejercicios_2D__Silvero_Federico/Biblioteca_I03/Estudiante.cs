using System;
using System.Text;

namespace Biblioteca_I03
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;



        static Estudiante() 
        {
            random = new Random();
        }

        public Estudiante(string nombre, string apellido, string legajo) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }


        private float CalcularPromedio() 
        {
            return (this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }



        public double CalcularNotaFinal() 
        {
            double retorno = -1;
            if(this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                retorno = random.Next(6, 10);
            }
            return retorno;
        }


        public string Mostrar() 
        {
            StringBuilder infoEstudiante = new StringBuilder();
            double notaFinal;

            infoEstudiante.AppendLine($"{this.nombre} {this.apellido} | Legajo Nro: {this.legajo}");
            infoEstudiante.AppendLine($"Primer parcial: {this.notaPrimerParcial} | Segundo parcial: {this.notaSegundoParcial}");
            infoEstudiante.AppendLine($"Promedio: {this.CalcularPromedio()}");

            notaFinal = CalcularNotaFinal();
            if(notaFinal != -1)
            {
                infoEstudiante.AppendLine($"Nota final: {notaFinal}");
            }
            else
            {
                infoEstudiante.AppendLine("Alumno desaprobado");
            }

            return infoEstudiante.ToString();
        }




       

        


        


    }
}
