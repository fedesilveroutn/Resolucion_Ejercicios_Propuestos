using System;
using Biblioteca_I02;

//Consigna
//Crear una aplicación de consola y una biblioteca de clases que contenga la clase Persona.

//Deberá tener los atributos:

//nombre
//fechaDeNacimiento
//dni
//Deberá tener un constructor que inicialice todos los atributos.

//Construir los siguientes métodos para la clase:

//Setter y getter para cada uno de los atributos.
//CalcularEdad será privado y retornará la edad de la persona calculándola a partir de la fecha de nacimiento.
//Mostrar retornará una cadena de texto con todos los datos de la persona, incluyendo la edad actual.
//EsMayorDeEdad si es mayor de edad devuelve el valor “Es mayor de edad", sino devuelve “es menor”.
//Instanciar 3 objetos de tipo Persona en el método Main.
//Mostrar quiénes son mayores de edad y quiénes no.




namespace POO_I02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Persona persona1 = new Persona("Federico", new DateTime(1997, 08, 26), 40763296);
            Persona persona2 = new Persona("Valentin", new DateTime(2001, 11, 21), 43223344);
            Persona persona3 = new Persona("Juan Ignacio", new DateTime(2008, 01, 04), 46223344);

            Persona[] personas = new Persona[] { persona1, persona2, persona3 };

            foreach(Persona item in personas)
            {
                Console.WriteLine($"{item.GetNombre()} {item.EsMayorDeEdad()}");
            }
        }
    }
}
