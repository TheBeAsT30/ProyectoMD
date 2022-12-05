using MD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Moderno
{
    public partial class FormPresentacion : Form
    {
        public FormPresentacion()
        {
            InitializeComponent();
        }
        string color = MD.Properties.Settings.Default.Tema;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1) this.Opacity += 0.05;
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 300;
            progressBar1.Value += 10;
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                timer2.Start();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            /*this.Opacity -= 0.1;
            if (this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }*/
            timer2.Stop();
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
        }
        private void CargarUsuario()
        {
            labelNamePresentacion.Text = Variables.Name;
            label1.Text = Variables.Last_name;
        }

        private void FormPresentacion_Load_1(object sender, EventArgs e)
        {
            CargarUsuario();
            pictureBox1.Image = Image.FromFile(@"C:\Users\GUEVARA-JARQUIN\source\repos\Clon\ProyectoMD\MD\Resources\Animacion 2.0.gif");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            Colores.ElegirColor(color);
            panel1.BackColor = Colores.PanelPrincipal;
            panel2.BackColor = Colores.PanelSuperior;
            label1.BackColor = Colores.PanelPrincipal;
            label1.ForeColor = Colores.FuenteC;
            label2.ForeColor = Colores.FuenteC;
            label2.BackColor = Colores.PanelPrincipal;
            labelNamePresentacion.BackColor = Colores.PanelPrincipal;
            labelNamePresentacion.ForeColor = Colores.FuenteC;
        }

    }
}
