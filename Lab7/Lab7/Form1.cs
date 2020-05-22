using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        Double valor = 0;
        String operacion = "";
        bool operacion_botonpresionado = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button_Click(object sender, EventArgs e)
        {
            if (Resultado.Text == "0" || operacion_botonpresionado) 
            {
                Resultado.Clear();
            }
            operacion_botonpresionado = false;
            Button boton =(Button)sender;
            Resultado.Text = Resultado.Text + boton.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Resultado.Text = "0";
        }

        private void Operador_click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            operacion = boton.Text;
            valor = Double.Parse(Resultado.Text);
            operacion_botonpresionado = true;
            ecuacion.Text = valor + " " + operacion;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            
            ecuacion.Text = "";
            switch(operacion)
            {
                case "+":
                    Resultado.Text = (valor + Double.Parse(Resultado.Text)).ToString();
                    break;
                case "-":
                    Resultado.Text = (valor - Double.Parse(Resultado.Text)).ToString();
                    break;
                case "x":
                    Resultado.Text = (valor * Double.Parse(Resultado.Text)).ToString();
                    break;
                case "/":
                    Resultado.Text = (valor / Double.Parse(Resultado.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Resultado.Text = "0";
            valor = 0;
        }
    }
}
