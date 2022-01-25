using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo2Guia1PED
{
    public partial class Form1 : Form
    {
        public Button boton1;
        public Form1()
        {
            //InitializeComponent(); Se podria eliminar sin embargo quedará en el codigo con fines demostrtivos
            boton1 = new Button();
            boton1.Size = new Size(80, 40); //Al tamaño, los valores usan dimension
            boton1.Location = new Point(30, 30); //Es la ubicacion espacial de donde quiero el objeto
            boton1.Text = "Presione aqui";
            this.Controls.Add(boton1);
            boton1.Click += new EventHandler(boton1_Click);
            //intento de creacion de boton de salida 
            //boton2 = new Button();
            //boton2.Size = new Size(80, 40); //Al tamaño, los valores usan dimension
            // boton2.Location = new Point(60, 60); //Es la ubicacion espacial de donde quiero el objeto
            //boton1.Text = "Salir";
            //this.Close.add(boton2);

        }
        private void boton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¡Usted es san paloma!, ha creado un boton por codigo");
        }
    }
}
