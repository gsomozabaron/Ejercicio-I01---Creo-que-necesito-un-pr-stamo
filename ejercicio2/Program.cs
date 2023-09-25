namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante estudianteA = new("Juan", "Perez", 101);
            Estudiante estudianteB = new("Maria", "Gomez", 102);
            Estudiante estudianteC = new("Carlos", "Lopez", 103);

            estudianteA.SetNotaPrimerParcial(7);
            estudianteA.SetNotaSegundoParcial(8);

            estudianteB.SetNotaPrimerParcial(5);
            estudianteB.SetNotaSegundoParcial(6);

            estudianteC.SetNotaPrimerParcial(3);
            estudianteC.SetNotaSegundoParcial(2);

            estudianteA.Mostrar();
            estudianteB.Mostrar();
            estudianteC.Mostrar();
        }
    }
}