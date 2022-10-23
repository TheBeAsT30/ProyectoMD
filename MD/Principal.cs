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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }
        string color = Properties.Settings.Default.Tema;
        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            #region ->Color
            Colores.ElegirColor(color);
            PanelP.BackColor = Colores.PanelPrincipal;
            PanelS.BackColor = Colores.PanelSuperior;
            PanelL.BackColor = Colores.PanelLateral;
            Tema.ForeColor = Colores.Fuente;
            Minimizar.BackColor = Colores.BackImagen;
            Cerrar.BackColor = Colores.BackImagen;
            Tema.BackColor = Colores.BotonesS;
            Prueba.BackColor = Colores.BotonesP;
            Prueba.ForeColor = Colores.Fuente;
            #endregion
        }
        int posY = 0;
        int posX = 0;

        private void PanelS_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void PanelP_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void PanelL_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                posX = e.X;
                posY = e.Y;
            }
            else
            {
                Left = Left + (e.X - posX);
                Top = Top + (e.Y - posY);
            }
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default["Tema"] = ComboTema.Text;
            Properties.Settings.Default.Save();
        }

        private void ComboTema_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region -> Color
            Properties.Settings.Default["Tema"] = ComboTema.Text;
            Properties.Settings.Default.Save();
            color = Properties.Settings.Default.Tema;
            Colores.ElegirColor(color);
            PanelP.BackColor = Colores.PanelPrincipal;
            PanelS.BackColor = Colores.PanelSuperior;
            PanelL.BackColor = Colores.PanelLateral;
            Tema.ForeColor = Colores.Fuente;
            Tema.BackColor = Colores.BotonesS;
            Minimizar.BackColor = Colores.BackImagen;
            Cerrar.BackColor = Colores.BackImagen;
            Prueba.BackColor = Colores.BotonesP;
            Prueba.ForeColor = Colores.Fuente;
            #endregion
        }

        private void Tema_Click(object sender, EventArgs e)
        {
            ComboTema.Visible = true;
        }
    }
}
