using System;

namespace Ejercicio_1__3__5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1 Cap 2.
            Console.WriteLine("Hacer un programa que calcule el perímetro de cualquier polígono regular.\n");
            string CL = "";
            string TL = "";
            float cantidadLados = 0, tamañoLados = 0, Perimetro = 0;

            Console.Write("Digite la cantidad de lados: ");
            CL = Console.ReadLine();
            cantidadLados = Convert.ToSingle(CL);

            Console.Write("Digite el tamaño de un lado: ");
            TL = Console.ReadLine();
            tamañoLados = Convert.ToSingle(TL);

            Perimetro = cantidadLados * tamañoLados;
            Console.Write("\nEl Perimetro es: ");
            Console.Write(Perimetro + "\n\n\n");

            //Ejercicio 3 Cap 2.
            Console.WriteLine("Hacer un programa que transforme de grados a radianes.\n");
            float grados = 0;
            string G = "";
            double Radianes = 0.0174533;
            double Resultado = 0;

            Console.Write("Digite la cantidad de Grados: ");
            G = Console.ReadLine();
            grados = Convert.ToSingle(G);

            Resultado = grados * Radianes;

            Console.Write("\nEl Resultado es: " + Resultado + "\n\n\n");

            //Ejercicio 5 Cap 2.
            Console.WriteLine("Hacer un programa que transforme entre dólares y euros y que también pida el tipo de cambio del día.\n");
            float cambio = 0, dolar = 0, total = 0;
            string CB = "";
            string DO = "";

            Console.Write("Digite el Cambio del Dia: ");
            CB = Console.ReadLine();
            cambio = Convert.ToSingle(CB);

            Console.Write("Digite la cantidad de Dolares: ");
            DO = Console.ReadLine();
            dolar = Convert.ToSingle(DO);

            total = cambio * dolar;

            Console.WriteLine(total + " Euros");


        }
    }
}
