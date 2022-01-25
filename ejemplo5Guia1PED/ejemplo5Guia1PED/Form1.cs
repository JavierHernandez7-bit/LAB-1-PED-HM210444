using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo5Guia1PED
{
    public partial class Form1 : Form
    {
        enum Posicion //define un set de constantes que pueden ser asignados a una variable
        {
            izquierda, derecha, arriba, abajo
        }
        private int x; //coordenada en x
        private int y; //coordenada en y
        private Posicion objposicion; // variable del enum Posicion

        
        public Form1()
        {
            InitializeComponent();
            x = 50; //inicializa en x = 50
            y = 50; //inicializa en y 50
            objposicion= Posicion.abajo; //por defecto definimos que se mueve hacia abajo 
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(new Bitmap("cat_eye_silhouette_hand_drawn_abstraction_icon_177445.png"), x, y, 65, 80);

        }

        private void timermov_Tick(object sender, EventArgs e)
        {
            if (objposicion == Posicion.derecha)
            { x += 10; } //desplazarse 10 pixeles a la derecha
            else if (objposicion == Posicion.izquierda)
            { x -= 10; } //desplazarse 10 pixeles a la izquierda
            else if (objposicion == Posicion.arriba)
            { y = -10; }
            else if (objposicion == Posicion.abajo)
            { y += 10; } //10 pixeles hacia abajo
            
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Left)
{
                objposicion = Posicion.izquierda;
            }
            else if (e.KeyCode== Keys.Right)    
            {
                objposicion = Posicion.derecha;
            }
            else if (e.KeyCode == Keys.Up) //si se presiona la tecla flecha arriba
            {
                objposicion = Posicion.arriba;
            }
            else if (e.KeyCode == Keys.Down) //si se presiona la tecla flecha abajo
            {
                objposicion = Posicion.abajo;
            }
              

        }
    }
}
