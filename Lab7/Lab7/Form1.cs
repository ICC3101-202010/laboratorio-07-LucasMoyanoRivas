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
        String ans = "";
        String historialtexto = "";
        bool operacion_botonpresionado = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            if ((Resultado.Text == "0") || (operacion_botonpresionado))
            {
                Resultado.Clear();
            }
            operacion_botonpresionado = false;
            Button boton =(Button)sender;
            if(boton.Text == ",")
            {
                if(!Resultado.Text.Contains(","))
                {
                    Resultado.Text = Resultado.Text + boton.Text;
                }
            }
            else
            {
                if(boton.Text == "Ans")
                {
                    Resultado.Text = Resultado.Text + ans;
                }
                else
                {
                    Resultado.Text = Resultado.Text + boton.Text;
                    
                }
            }

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
            ecuacion.Text = valor + " " + operacion;
            operacion_botonpresionado = true;
        }
        private void button18_Click(object sender, EventArgs e)
        {
            
            ecuacion.Text = "";
            switch (operacion)
            {
                case "+":
                    Resultado.Text = (valor + Double.Parse(Resultado.Text)).ToString();
                    ans = Resultado.Text;
                    historialtexto += valor.ToString() + " + " + Double.Parse(Resultado.Text).ToString() + " = " + Resultado.Text + " \n ";
                    break;
                case "-":
                    Resultado.Text = (valor - Double.Parse(Resultado.Text)).ToString();
                    ans = Resultado.Text;
                    historialtexto += valor.ToString() + " - " + Double.Parse(Resultado.Text).ToString() + " = " + Resultado.Text + " \n ";
                    break;
                case "x":
                    Resultado.Text = (valor * Double.Parse(Resultado.Text)).ToString();
                    ans = Resultado.Text;
                    historialtexto += valor.ToString() + " x " + Double.Parse(Resultado.Text).ToString() + " = " + Resultado.Text +  " \n ";
                    break;
                case "/":
                    if(Double.Parse(Resultado.Text) == 0)
                    {
                        Resultado.Text = "Math ERROR";
                    }
                    else
                    {
                        Resultado.Text = (valor / Double.Parse(Resultado.Text)).ToString();
                        ans = Resultado.Text;
                        historialtexto += valor.ToString() + " / " + Double.Parse(Resultado.Text).ToString() + " = " + Resultado.Text + " \n ";
                    }
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

        private void Historial(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            if(boton.Text == "Historial")
            {
                Historial1.Show();
                HistorialText2.Text = historialtexto;
            }
            if (boton.Text == "Salir Historial")
            {
                Historial1.Hide();
            }
            if (boton.Text == "Borrar Historial")
            {
                HistorialText2.Text = "";
                historialtexto = "";
            }
        }
    }
}
