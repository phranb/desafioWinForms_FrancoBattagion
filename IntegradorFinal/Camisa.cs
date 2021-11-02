using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegradorFinal
{
    class Camisa : Prenda
    {
        private int _tipo;
        public Camisa(int tipo):base()
        {
            this._tipo = tipo;
        }

        public override double calcularPrecio()
        {
            if(_tipo == 2)
            {
                precio = precio - precio * 0.1;
            }
            if (calidad == 2)
            {
                precio = precio * 1.3;
            }
            return precio * cantidad;
        }

    }
}
