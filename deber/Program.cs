using System;

namespace NuevaAppDeProgramacion
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                Console.WriteLine(args[0]);
            }
            Console.WriteLine("BIENVENIDO INGRESA SUSDATOS");
            Console.WriteLine("Nombre y Apellido:");
            string datosleidos = Console.ReadLine();
            Console.WriteLine("ESTADO CIVIL:");
            string datosLeidos4 = Console.ReadLine();
            Console.WriteLine("EDAD:");
            string datosleidos1 = Console.ReadLine();
            Console.WriteLine("TELEFONO:");
            string datosleidos2 = Console.ReadLine();
            Console.WriteLine("CUIDAD DONDE VIVE:");
            string datosLeidos3 = Console.ReadLine();
            Console.WriteLine("OCUPACION");
            string datosLeidos5 = Console.ReadLine();
            Console.WriteLine("HOLA  "+ datosleidos +" "+"Bienvenido al sistema "+" "+ datosLeidos4 +" "+"edad"+" "+ datosleidos1 +" "+"Telefono "+" "+ datosleidos2+
            " "+"Cuidad de recidencia"+" "+ datosLeidos3+" "+"ocupacion"+" "+datosLeidos5);
        }
    }
}
