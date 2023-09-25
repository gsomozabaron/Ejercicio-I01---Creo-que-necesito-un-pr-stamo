namespace clase_3.Ejercicio1
{
    internal class ejercicio1
    {
        static void Main(string[] args)
        {
            // crear cuenta nueva
            Cuenta miCuenta = new Cuenta("coop lavalle", 500);

            //obtener saldo
            decimal cantidad = miCuenta.getCantidad();

            //obtener titular
            string titular = miCuenta.getTitular();

            //mostrar titular y saldo
            Console.WriteLine($"cuenta {cantidad}");
            Console.WriteLine($"tiular {titular}");

            //estado original
            Console.WriteLine("Estado inicial de la cuenta:");
            Console.WriteLine(miCuenta.CuentaToString());

            // Simular operaciones
            miCuenta.IngresarDinero(-500.0m); //ingreso positivo no hace nada
            miCuenta.RetirarDinero(-500.0m);  //egreso negativo, multiplica * -1 y resta al total
            miCuenta.IngresarDinero(100.0m);  //ingreso positivo, suma al total
            miCuenta.RetirarDinero(600.0m);   //egreso positivo, resta al total

            //imprimir estado
            Console.WriteLine("Estado final de la cuenta:");
            Console.WriteLine(miCuenta.CuentaToString());




            /*
             Crear una aplicación de consola y una biblioteca de clases que contenga la clase Cuenta.

            Deberá tener los atributos:

            titular: que contendrá la razón social del titular de la cuenta.
            cantidad:  que será un número decimal que representa al monto actual de dinero en la cuenta.

            Construir los siguientes métodos para la clase:

            Un constructor que permita inicializar todos los atributos.
            Un método getter para cada atributo.

            CuentaToString: retornará una cadena de texto con todos los datos de la cuenta.
            
            IngresarDinero: recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
            
            RetirarDinero: recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.

            En el método Main, simular depósitos y extracciones de dinero de la cuenta, e ir mostrando cómo va variando el saldo.

           
            

           

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
}


