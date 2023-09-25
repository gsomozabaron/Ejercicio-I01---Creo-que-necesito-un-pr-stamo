using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase_3.Ejercicio1
{
    internal class Cuenta
    {
        /// <summary>
        /// atributos clase cuenta
        /// </summary>
        private string _titular;
        private decimal _cantidad;

        /// <summary>
        /// constructor cuenta
        /// </summary>
        /// <param name="titular">titular de la cuenta</param>
        /// <param name="cantidad">saldo</param>
        public Cuenta(string titular, decimal cantidad)
        {
            _titular = titular;
            _cantidad = cantidad;
        }
        /// <summary>
        /// obtener titular
        /// </summary>
        /// <returns>titular</returns>
        public string getTitular()
        {
            return _titular;
        }
        /// <summary>
        /// obtener saldo
        /// </summary>
        /// <returns>saldo</returns>
        public decimal getCantidad()
        {
            return _cantidad;
        }

        /// <summary>
        /// mostrar titular y saldo
        /// </summary>
        /// <returns>str titular - saldo</returns>
        public string CuentaToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Titular: {_titular}, Saldo: ${_cantidad}");
            return sb.ToString();
        }
        /// <summary>
        /// sumar monto al saldo existente
        /// </summary>
        /// si monto es negativo no hace ninguna accion
        /// <param name="monto">monto a sumar</param>
        public void IngresarDinero(decimal monto)
        {
            if (monto > 0)
            {
                _cantidad += monto;
                Console.WriteLine($"Se ha ingresado ${monto} a la cuenta.");
            }
        }
        /// <summary>
        /// restar monto al saldo existente
        /// </summary>
        /// si monto es negativo lo transforma en positivo
        ///<param name="monto">monto a restar</param>
        public void RetirarDinero(decimal monto)
        {
            if (monto < 1)
            {
                monto *= -1;
            }
            _cantidad -= monto;
            Console.WriteLine($"Se ha retirado ${monto} de la cuenta.");
        }











        /*
         Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.

        Deberá tener los atributos:
        titular: que contendrá la razón social del titular de la cuenta.
        cantidad:  que será un número decimal que representa al monto actual de monto en la cuenta.
        Construir los siguientes métodos para la clase:
        Un constructor que permita inicializar todos los atributos.
        Un método getter para cada atributo.
        CuentaToString: retornará una cadena de texto con todos los datos de la cuenta.
        Ingresarmonto: recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
        Retirarmonto: recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.

        En el método Main, simular depósitos y extracciones de monto de la cuenta, e ir mostrando cómo va variando el saldo.







        Crear una aplicación de consola y una biblioteca de clases que contenga la clase del siguiente diagrama:

        Diagrama de clases



        La clase Estudiante:

        Tendrá un constructor estático que inicializará el atributo estático random.
        Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
        El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
        El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
        El método privado CalcularPromedio retornará el promedio de las dos notas.
        El método CalcularNotaFinal deberá retornar la nota del final con un número aleatorio entre 6 y 10 incluidos siempre y cuando las notas del primer y segundo parcial sean mayores o iguales a 4, caso contrario la inicializará con el valor -1.
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
