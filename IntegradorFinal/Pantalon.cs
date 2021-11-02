using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorFinal
{
    class Pantalon : Prenda
    {
        private int _tipo;
        public Pantalon(int tipo) : base()
        {
            this._tipo = tipo;
        }
        override public double calcularPrecio()
        {
            if (_tipo == 2)
            {
                precio = precio - precio * 0.2;
            }
            if (calidad == 2)
            {
                precio = precio * 1.3;
            }

            return precio * cantidad;
        }
    }
}
