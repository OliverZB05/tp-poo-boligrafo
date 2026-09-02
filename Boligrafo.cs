using System;

namespace Curso_de_POO___GOB_CIUDAD
{
    public class Boligrafo
    {
        // Atributos privados
        private int capacidadTintaMaxima;
        private string grosorPunta;
        private string color;
        private int cantidadTinta;

        // Propiedades públicas de solo lectura (getters)
        public int CapacidadTintaMaxima
        {
            get { return capacidadTintaMaxima; }
        }

        public string GrosorPunta
        {
            get { return grosorPunta; }
        }

        public string Color
        {
            get { return color; }
        }

        public int CantidadTinta
        {
            get { return cantidadTinta; }
            private set { cantidadTinta = value; }
        }

        // Constructor
        public Boligrafo(string color, string grosorPunta)
        {
            this.capacidadTintaMaxima = 100;
            this.cantidadTinta = 80;
            this.color = color;
            this.grosorPunta = grosorPunta;
        }

        // Método Escribir
        public string Escribir(string texto)
        {
            int tintaNecesaria = texto.Length;

            // Si el grosor es "Grueso" se duplica el gasto
            if (grosorPunta.Equals("Grueso", StringComparison.OrdinalIgnoreCase))
            {
                tintaNecesaria *= 2;
            }

            // Validar si alcanza la tinta
            if (cantidadTinta >= tintaNecesaria)
            {
                cantidadTinta -= tintaNecesaria;
                return texto;
            }
            else
            {
                return "No alcanza la tinta";
            }
        }

        // Método Recargar
        public string Recargar(int cantidad)
        {
            int totalTentativo = cantidadTinta + cantidad;

            if (totalTentativo <= capacidadTintaMaxima)
            {
                cantidadTinta = totalTentativo;
                return "Lapicera recargada";
            }
            else
            {
                int excedente = totalTentativo - capacidadTintaMaxima;
                cantidadTinta = capacidadTintaMaxima;
                return $"Se recargó la lapicera y sobró {excedente} cantidad de tinta.";
            }
        }
    }
}