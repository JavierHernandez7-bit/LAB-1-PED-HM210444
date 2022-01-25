using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1Guia1PED
{
    public partial class Ejemplo1 : Form
    {
        bool inicio = true;
        double primero;
        double segundo;
        double resultado;
        string operador;
        public Ejemplo1()
        {
            InitializeComponent();
        }
        clase_Operaciones obj5 = new clase_Operaciones();

        clase_Sum obj = new clase_Sum();
        clase_Resta obj2 = new clase_Resta();
        clase_Multi obj3 = new clase_Multi();
        clase_Div obj4 = new clase_Div();

        private void Ejemplo1_Load(object sender, EventArgs e)
        {

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text == "0")
            {
                return;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "0";
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Pantalla.Text = "";
                Pantalla.Text = "1";
                inicio = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "1";
                inicio = false;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Pantalla.Text = "";
                Pantalla.Text = "2";
                inicio = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "2";
                inicio = false;
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Pantalla.Text = "";
                Pantalla.Text = "3";
                inicio = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "3";
                inicio = false;
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Pantalla.Text = "";
                Pantalla.Text = "4";
                inicio = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "4";
                inicio = false;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Pantalla.Text = "";
                Pantalla.Text = "5";
                inicio = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "5";
                inicio = false;
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Pantalla.Text = "";
                Pantalla.Text = "6";
                inicio = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "6";
                inicio = false;
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Pantalla.Text = "";
                Pantalla.Text = "7";
                inicio = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "7";
                inicio = false;
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Pantalla.Text = "";
                Pantalla.Text = "8";
                inicio = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "8";
                inicio = false;
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (inicio)
            {
                Pantalla.Text = "";
                Pantalla.Text = "9";
                inicio = false;
            }
            else
            {
                Pantalla.Text = Pantalla.Text + "9";
                inicio = false;
            }
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            primero = double.Parse(Pantalla.Text);
            //tbxPrevio.Text = tbxPrevio.Text + tbxScreen.Text + "+";
            Pantalla.Clear();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            operador = "-";
            primero = double.Parse(Pantalla.Text);
            //tbxPrevio.Text = tbxPrevio.Text + tbxScreen.Text + "+";
            Pantalla.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            operador = "/";
            primero = double.Parse(Pantalla.Text);
            //tbxPrevio.Text = tbxPrevio.Text + tbxScreen.Text + "+";
            Pantalla.Clear();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            operador = "*";
            primero = double.Parse(Pantalla.Text);
            //tbxPrevio.Text = tbxPrevio.Text + tbxScreen.Text + "+";
            Pantalla.Clear();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(Pantalla.Text);

            double Sum;
            double Res;
            double Mul;
            double Div;

            switch (operador)
            {
                case "+":
                    Sum = obj5.Suma((primero), (segundo));
                    Pantalla.Text = Sum.ToString();
                    break;
                case "-":
                    Res = obj5.Resta((primero), (segundo));                 
                    Pantalla.Text = Res.ToString();
                    break;
                case "*":
                    Mul = obj5.Multiplicacion((primero), (segundo));                   
                    Pantalla.Text = Mul.ToString();
                    break;
                case "/":
                    Div = obj5.Division((primero), (segundo));                   
                    Pantalla.Text = Div.ToString();
                    break;
            }
        }

        private void btnExp_Click(object sender, EventArgs e)
        {
            primero = double.Parse(Pantalla.Text);
            resultado = primero;

            Pantalla.Text = Math.Pow(primero, 3).ToString();
        }

        private void btncos_Click(object sender, EventArgs e)
        {
            primero = double.Parse(Pantalla.Text);
            resultado = primero;
           
            Pantalla.Text = Math.Cos(primero).ToString();
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            primero = double.Parse(Pantalla.Text);
            resultado = primero;
            
            Pantalla.Text = Math.Sin(primero).ToString();
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            primero = double.Parse(Pantalla.Text);
            resultado = primero;
           
            Pantalla.Text = Math.Tan(primero).ToString();
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            primero = double.Parse(Pantalla.Text);
            resultado = primero;
           
            Pantalla.Text = Math.Log(primero).ToString();
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            primero = double.Parse(Pantalla.Text);
            resultado = primero;

            Pantalla.Text = Math.Log(primero).ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Contains("."))
            {

            }
            else
            {
                Pantalla.Text = Pantalla.Text + ".";
            }

        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            Pantalla.Clear();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (Pantalla.Text.Length == 1)
                Pantalla.Text = "0";
            else
                Pantalla.Text = Pantalla.Text.Substring(0, Pantalla.Text.Length - 1);
        }
    }
}
