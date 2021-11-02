using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorFinal
{
    abstract class Prenda
    {
        protected double precio;
        protected int cantidad;
        protected int calidad;

        public Prenda()
        {
        }

        public abstract double calcularPrecio();

        public double Precio { get => precio; set => precio = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Calidad { get => calidad; set => calidad = value; }

    }
}
