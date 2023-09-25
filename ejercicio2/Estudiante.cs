using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Estudiante
    {
        public static Random random = new Random();

        public string nombre;
        public string apellido;
        public int legajo;
        public int notaPrimerParcial;
        public int notaSegundoParcial;


        public Estudiante(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.notaPrimerParcial = -1; // Inicializamos con -1
            this.notaSegundoParcial = -1; // Inicializamos con -1
        }

        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }

        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }

        private double CalcularPromedio()
        {
            return (notaPrimerParcial + notaSegundoParcial) / 2.0;
        }

        public int CalcularNotaFinal()
        {
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                return random.Next(6, 11); // Genera un número aleatorio entre 6 y 10 (incluidos)
            }
            else
            {
                return -1;
            }
        }

        public void Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + nombre);
            sb.AppendLine("Apellido: " + apellido);
            sb.AppendLine("Legajo: " + legajo);
            sb.AppendLine("Nota del primer parcial: " + notaPrimerParcial);
            sb.AppendLine("Nota del segundo parcial: " + notaSegundoParcial);
            double promedio = CalcularPromedio();
            sb.AppendLine("Promedio: " + promedio);

            int notaFinal = CalcularNotaFinal();
            if (notaFinal != -1)
            {
                sb.AppendLine("Nota final: " + notaFinal);
            }
            else
            {
                sb.AppendLine("Alumno desaprobado");
            }

            Console.WriteLine(sb.ToString());



















            /*Crear una aplicación de consola y una biblioteca de clases que contenga la clase del siguiente diagrama:

            Diagrama de clases
            La clase Estudiante:

            Tendrá un constructor estático que inicializará el atributo estático random.
            Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
            El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
            El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
            El método privado CalcularPromedio retornará el promedio de las dos notas.
            El método CalcularNotaFinal deberá retornar la nota del final con un número aleatorio entre 6 y 10 incluidos 
            siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4, 
            caso contrario la inicializará con el valor -1.

            El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
            Nombre, apellido y legajo.
            Nota del primer y segundo parcial.
            Promedio.
            Nota final. Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".

            Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.
            Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.
            Mostrar los datos de todos los alumnos.

            */
        }
    }
}
