using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo4Guia1PED
{
    public partial class Form1 : Form
    {
        Graphics area;
        public Form1()
        {
            InitializeComponent();
            area = areadibujo.CreateGraphics();
        }
        

        private void btndibujo_Click(object sender, EventArgs e)
        {
            Pen lapicero = new Pen(Color.Black);
            switch (cmbcolor.SelectedIndex)
            {
                case 0: lapicero = new Pen(Color.Yellow); break;
                case 1: lapicero = new Pen(Color.Red); break;
                case 2: lapicero = new Pen(Color.Blue); break;
                case 3: lapicero = new Pen(Color.Black); break;
            }
                                              
            int iteraciones = int.Parse(txtcantidad.Text);
            int espacio = int.Parse(txtespaciado.Text);


            area.Clear(Color.White);
            int puntoinicio = 50;

            for (int i = 0; i < iteraciones; i++)
            {
             area.DrawLine(lapicero, 20, puntoinicio + (espacio * i), 300, puntoinicio + (espacio * i));

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
