using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MD
{
    public partial class Form_Senales : Form
    {
        public Form_Senales()
        {
            InitializeComponent();
        }
        string color = Properties.Settings.Default.Tema;

        public void Imagenes()
        {
            pictureBoxPolialto.Image = Image.FromFile(@"C:\Users\GUEVARA-JARQUIN\source\repos\Clon\ProyectoMD\MD\Resources\pixil-frame-0.png");           
            pictureBoxPolialto.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPolicontinua.Image = Image.FromFile(@"C:\Users\GUEVARA-JARQUIN\source\repos\Clon\ProyectoMD\MD\Resources\pixil-frame-0 (1).png");
            pictureBoxPolicontinua.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxPoliPare.Image = Image.FromFile(@"C:\Users\GUEVARA-JARQUIN\source\repos\Clon\ProyectoMD\MD\Resources\pixil-frame-0 (3).png");
            pictureBoxPoliPare.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox45km.Image = Image.FromFile(@"C:\Users\GUEVARA-JARQUIN\source\repos\Clon\ProyectoMD\MD\Resources\pixil-frame-0 (2).png");
            pictureBox45km.SizeMode = PictureBoxSizeMode.StretchImage;
            label4.Text = "Límite de velocidad de 45km \nen calles y avenidas";            
        }

        private void Form_Leyes_Load(object sender, EventArgs e)
        {
            Colores.ElegirColor(color);
            panelPrincipal.BackColor = Colores.PanelPrincipal;
            panelL.BackColor = Colores.PanelPrincipal;
            label1.BackColor = Colores.PanelPrincipal;
            label36.BackColor = Colores.PanelPrincipal;
            label37.BackColor = Colores.PanelPrincipal;
            label2.BackColor = Colores.PanelPrincipal;
            label3.BackColor = Colores.PanelPrincipal;
            label4.BackColor = Colores.PanelPrincipal;         
            label1.ForeColor = Colores.FuenteC;
            label2.ForeColor = Colores.FuenteC;
            label3.ForeColor = Colores.FuenteC;
            label36.ForeColor = Colores.FuenteC;
            label37.ForeColor = Colores.FuenteC;
            label4.ForeColor = Colores.FuenteC;            
            Imagenes();
            //label4.BackColor = Colores.PanelPrincipal;
            //label5.BackColor = Colores.PanelPrincipal;
        }
    }
}
