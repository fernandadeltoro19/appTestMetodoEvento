﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appTestMetodoEvento
{
    public partial class Form1 : Form
    {
        // Var Globales
        double valor1, valor2;
        string operacion = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void MiMetodo_Click(object sender, EventArgs e)
        {
            string textoBoton= ((Button)sender).Text;
            switch (textoBoton)

            {
                case "R":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    //Operacion = TextoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado = Math.Sqrt(valor1);
                    lblNumeros.Text = resultado + "";
                    break;

                case "COS":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado1 = Math.Cos(valor1);
                    lblNumeros.Text = resultado1 + "";
                    break;

                case "LOG":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado2 = Math.Log(valor1);
                    lblNumeros.Text = resultado2 + "";
                    break;

                case "SEN":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado3 = Math.Sin(valor1);
                    lblNumeros.Text = resultado3 + "";
                    break;

                case "TAN":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    valor1 = double.Parse(lblNumeros.Text);
                    double resultado4 = Math.Tan(valor1);
                    lblNumeros.Text = resultado4 + "";
                    break;

                case "/":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;

                case "x":
                if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;

                case "+":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;

                case "-":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    operacion = textoBoton;
                    valor1 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = "";
                    break;

                case "=":
                    if (lblNumeros.Text == "")
                    {
                        break;
                    }
                    switch (operacion)
                    {

                        case "+":
                    valor2 = double.Parse(lblNumeros.Text);
                    lblNumeros.Text = (valor1 + valor2) + "";
                            break;
                        case "-":
                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = (valor1 - valor2) + "";
                            break;
                        case "x":
                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = (valor1 * valor2) + "";
                            break;                      
                        case "/":
                            valor2 = double.Parse(lblNumeros.Text);
                            lblNumeros.Text = (valor1 / valor2) + "";
                            break;
                    }
                        break;
                        case "AC":
                        lblNumeros.Text = "";
                        break;
                        case ".":
                        if (lblNumeros.Text.IndexOf(".") == -1 )
                        {
                            lblNumeros.Text += textoBoton;
                        }
                        

                        break;

                        default:
                        lblNumeros.Text += ((Button)sender).Text;
                        break;
                
            }

            //lblNumeros.Text += ((Button)sender).Text;
         
        }

    }
}
