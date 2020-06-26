using System;

namespace Evie
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generador = new Random();
            int id = generador.Next();
            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.WriteLine("FACTURA ELECTRÓNICA");
            Console.WriteLine();
            Console.WriteLine();
            Persona persona = new Persona(1724690845, "Julyano", "Vera", 20, "Hombre");
            Console.WriteLine("Id: {0}", persona.Id);
            Console.WriteLine("Nombre: {0}", persona.Nombre);
            Console.WriteLine("Apellido: {0}", persona.Apellido);
            Console.WriteLine("Edad: {0}", persona.Edad);
            Console.WriteLine("Sexo: {0}", persona.Sexo);

            Console.WriteLine();
            Console.WriteLine("CAMISETAS");
            Camisetas camisetas = new Camisetas(1, "Cuello en v", "Lacoste", 38, "Negro");
            Console.WriteLine("Id: {0}", generador.Next());
            Console.WriteLine("Modelo : {0}", camisetas.Modelo);
            Console.WriteLine("Marca: {0}", camisetas.Marca);
            Console.WriteLine("Talla: {0}", camisetas.Talla);
            Console.WriteLine("Color: {0}", camisetas.Color);

            Console.WriteLine();
            Console.WriteLine("PANTALONES");
            Pantalones pantalones = new Pantalones(2, "Bluejeans", "Pull & Bear", 32, "Gris");
            Console.WriteLine("Id: {0}", generador.Next());
            Console.WriteLine("Modelo : {0}", pantalones.Modelo);
            Console.WriteLine("Marca: {0}", pantalones.Marca);
            Console.WriteLine("Talla: {0}", pantalones.Talla);
            Console.WriteLine("Color: {0}", pantalones.Color);


            Console.WriteLine("ZAPATOS");
            Zapatos zapatos = new Zapatos(3, "Deportivos", "Nike", 40, "Negro");
            Console.WriteLine("Id: {0}", generador.Next());
            Console.WriteLine("Modelo : {0}", zapatos.Modelo);
            Console.WriteLine("Marca: {0}", zapatos.Marca);
            Console.WriteLine("Talla: {0}", zapatos.Talla);
            Console.WriteLine("Color: {0}", zapatos.Color);

            Console.WriteLine();
            Console.WriteLine("POLINES");
            Polines polines = new Polines(4, "Taloneras", "Roland", 5, "Negro");
            Console.WriteLine("Id: {0}", generador.Next());
            Console.WriteLine("Modelo : {0}", polines.Modelo);
            Console.WriteLine("Marca: {0}", polines.Marca);
            Console.WriteLine("Talla: {0}", polines.Talla);
            Console.WriteLine("Color: {0}", polines.Color);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("PRESIONE CUALQUIER TECLA PARA CONFIRMAR SU FACTURA");

        }
    }
}
