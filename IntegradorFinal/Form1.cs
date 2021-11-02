using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegradorFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
     
            InitializeComponent();
        }



        int tipoPrenda;
        int calidad;
        int tipo = 1;
        int cantidad;
        double precio;
        double precioFinal;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //Camisa check
            checkBox1.Enabled = true;
            checkBox2.Enabled = false;

            tipoPrenda = 1;
            checkBox2.Checked = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //Pantalon
            checkBox1.Enabled = false;
            checkBox2.Enabled = true;

            tipoPrenda = 2;
            checkBox1.Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 2;
            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            tipo = 2;
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            calidad = 1;

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            calidad = 2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                precio = Convert.ToInt32(textBox1.Text);
                cantidad = Convert.ToInt32(textBox2.Text);
            }
            catch (Exception) {
                MessageBox.Show("Recuerde ingresar numeros y completar todos los campos." );
            }
            //MessageBox.Show(""+precio);
            switch (tipoPrenda)
            {
                case 1:
                    Camisa miCamisa = new Camisa(tipo);
                    miCamisa.Cantidad = cantidad;
                    miCamisa.Calidad = calidad;
                    miCamisa.Precio = precio;
                    precioFinal = miCamisa.calcularPrecio();
                    label1.Text = "$ " + precioFinal;
                    MessageBox.Show("Precio = $ " + precioFinal);
                    break;
                case 2:
                    Pantalon miPantalon = new Pantalon(tipo);
                    miPantalon.Cantidad = cantidad;
                    miPantalon.Calidad = calidad;
                    miPantalon.Precio = precio;
                    precioFinal = miPantalon.calcularPrecio();
                    label1.Text = "$ " + precioFinal;
                    MessageBox.Show("Precio = $ " + precioFinal);
                    break;


            }
        }
    }
}
