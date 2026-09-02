using System;

namespace Curso_de_POO___GOB_CIUDAD
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo boligrafoAzul = new Boligrafo("Azul", "Fino");
            Boligrafo boligrafoRojo = new Boligrafo("Roja", "Grueso");

            // ---------- Bolígrafo Azul (Fino) ----------
            Console.WriteLine("=== Bolígrafo Azul (Fino) ===");
            Console.Write("Ingrese el texto a escribir: ");
            string textoAzul = Console.ReadLine();

            // Escribir y mostrar resultado
            Console.WriteLine(boligrafoAzul.Escribir(textoAzul));
            Console.WriteLine($"Tinta restante: {boligrafoAzul.CantidadTinta}");

            // Recargar
            Console.Write("Ingrese la cantidad a recargar: ");
            int recargaAzul = int.Parse(Console.ReadLine());
            Console.WriteLine(boligrafoAzul.Recargar(recargaAzul));
            Console.WriteLine($"Tinta actual: {boligrafoAzul.CantidadTinta}");

            Console.WriteLine();

            // ---------- Bolígrafo Rojo (Grueso) ----------
            Console.WriteLine("=== Bolígrafo Rojo (Grueso) ===");
            Console.Write("Ingrese el texto a escribir: ");
            string textoRojo = Console.ReadLine();

            Console.WriteLine(boligrafoRojo.Escribir(textoRojo));
            Console.WriteLine($"Tinta restante: {boligrafoRojo.CantidadTinta}");

            Console.Write("Ingrese la cantidad a recargar: ");
            int recargaRojo = int.Parse(Console.ReadLine());
            Console.WriteLine(boligrafoRojo.Recargar(recargaRojo));
            Console.WriteLine($"Tinta actual: {boligrafoRojo.CantidadTinta}");
        }
    }
}