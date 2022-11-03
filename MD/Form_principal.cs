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
    public partial class Form_principal : Form
    {
        public Form_principal()
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
            if (Variables.Opcion == "Coffe")
            {
                Properties.Settings.Default["Tema"] = "Cafe";
                Properties.Settings.Default.Save();
            }
            else if (Variables.Opcion == "Blue")
            {
                Properties.Settings.Default["Tema"] = "Azul";
                Properties.Settings.Default.Save();
            }            
            else if(Variables.Opcion == "Red")
            {
                Properties.Settings.Default["Tema"] = "Rojo";
                Properties.Settings.Default.Save();
            }
            else if (Variables.Opcion == "Purple")
            {
                Properties.Settings.Default["Tema"] = "Morado";
                Properties.Settings.Default.Save();
            }
            else if (Variables.Opcion == "Dark")
            {
                Properties.Settings.Default["Tema"] = "Oscuro";
                Properties.Settings.Default.Save();
            }
            else if (Variables.Opcion == "White")
            {
                Properties.Settings.Default["Tema"] = "Claro";
                Properties.Settings.Default.Save();
            }
        }


        private void Tema_Click(object sender, EventArgs e)
        {
        }
        #region
        private void Abrirformulario<MiForm>(string v) where MiForm : Form, new()
        {
            Form formulario;
            formulario = PanelP.Controls.OfType<MiForm>().FirstOrDefault(); //Busca en la colección el formulario
            //Si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                //formulario.FormBorderStyle = FormBorderStyle.None;
                //formulario.Dock = DockStyle.Fill;
                PanelP.Controls.Add(formulario);
                PanelP.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();                
                //formulario.FormClosed += new FormClosedEventHandler(CloseForms);
            }
            //Si el formulario existe
            else
            {
                formulario.BringToFront();
            }
        }
        #endregion

        #region ->Cambiar Colores
        private void pictureBoxCafe_Click(object sender, EventArgs e)
        {
            Variables.Opcion = "Coffe";
            Properties.Settings.Default["Tema"] = "Cafe";
            Properties.Settings.Default.Save();
            color = Properties.Settings.Default.Tema;
            Colores.ElegirColor(color);
            PanelP.BackColor = Colores.PanelPrincipal;
            PanelS.BackColor = Colores.PanelSuperior;
            PanelL.BackColor = Colores.PanelLateral;
            Tema.ForeColor = Colores.Fuente;
            Minimizar.BackColor = Colores.BackImagen;
            Cerrar.BackColor = Colores.BackImagen;
            Tema.BackColor = Colores.BotonesS;
        }
        private void pictureBoxAzul_Click(object sender, EventArgs e)
        {
            Variables.Opcion = "Blue";
            Properties.Settings.Default["Tema"] = "Azul";
            Properties.Settings.Default.Save();
            color = Properties.Settings.Default.Tema;
            Colores.ElegirColor(color);
            PanelP.BackColor = Colores.PanelPrincipal;
            PanelS.BackColor = Colores.PanelSuperior;
            PanelL.BackColor = Colores.PanelLateral;
            Tema.ForeColor = Colores.Fuente;
            Minimizar.BackColor = Colores.BackImagen;
            Cerrar.BackColor = Colores.BackImagen;
            Tema.BackColor = Colores.BotonesS;
        }

        private void pictureBoxMorado_Click(object sender, EventArgs e)
        {
            Variables.Opcion = "Purple";
            Properties.Settings.Default["Tema"] = "Morado";
            Properties.Settings.Default.Save();
            color = Properties.Settings.Default.Tema;
            Colores.ElegirColor(color);
            PanelP.BackColor = Colores.PanelPrincipal;
            PanelS.BackColor = Colores.PanelSuperior;
            PanelL.BackColor = Colores.PanelLateral;
            Tema.ForeColor = Colores.Fuente;
            Minimizar.BackColor = Colores.BackImagen;
            Cerrar.BackColor = Colores.BackImagen;
            Tema.BackColor = Colores.BotonesS;
        }

        private void pictureBoxRojo_Click(object sender, EventArgs e)
        {
            Variables.Opcion = "Red";
            Properties.Settings.Default["Tema"] = "Rojo";
            Properties.Settings.Default.Save();
            color = Properties.Settings.Default.Tema;
            Colores.ElegirColor(color);
            PanelP.BackColor = Colores.PanelPrincipal;
            PanelS.BackColor = Colores.PanelSuperior;
            PanelL.BackColor = Colores.PanelLateral;
            Tema.ForeColor = Colores.Fuente;
            Minimizar.BackColor = Colores.BackImagen;
            Cerrar.BackColor = Colores.BackImagen;
            Tema.BackColor = Colores.BotonesS;
        }

        private void pictureBoxOscuro_Click(object sender, EventArgs e)
        {
            Variables.Opcion = "Dark";
            Properties.Settings.Default["Tema"] = "Oscuro";
            Properties.Settings.Default.Save();
            color = Properties.Settings.Default.Tema;
            Colores.ElegirColor(color);
            PanelP.BackColor = Colores.PanelPrincipal;
            PanelS.BackColor = Colores.PanelSuperior;
            PanelL.BackColor = Colores.PanelLateral;
            Tema.ForeColor = Colores.Fuente;
            Minimizar.BackColor = Colores.BackImagen;
            Cerrar.BackColor = Colores.BackImagen;
            Tema.BackColor = Colores.BotonesS;
        }

        private void pictureBoxClaro_Click(object sender, EventArgs e)
        {
            Variables.Opcion = "White";
            Properties.Settings.Default["Tema"] = "Claro";
            Properties.Settings.Default.Save();
            color = Properties.Settings.Default.Tema;
            Colores.ElegirColor(color);
            PanelP.BackColor = Colores.PanelPrincipal;
            PanelS.BackColor = Colores.PanelSuperior;
            PanelL.BackColor = Colores.PanelLateral;
            Tema.ForeColor = Colores.Fuente;
            Minimizar.BackColor = Colores.BackImagen;
            Cerrar.BackColor = Colores.BackImagen;
            Tema.BackColor = Colores.BotonesS;
        }       

        private void pictureBoxCafe_MouseEnter(object sender, EventArgs e)
        {
            this.PanelCafe.Size = new System.Drawing.Size(181, 97);
        }

        private void pictureBoxCafe_MouseLeave(object sender, EventArgs e)
        {
            this.PanelCafe.Size = new System.Drawing.Size(164, 79);
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.PanelAzul.Size = new System.Drawing.Size(181, 97);
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.PanelAzul.Size = new System.Drawing.Size(164, 79);
        }
        private void pictureBoxMorado_MouseLeave(object sender, EventArgs e)
        {
            this.PanelMorado.Size = new System.Drawing.Size(164, 79);
        }

        private void pictureBoxMorado_MouseEnter(object sender, EventArgs e)
        {
            this.PanelMorado.Size = new System.Drawing.Size(181, 97);
        }

        private void pictureBoxRojo_MouseEnter(object sender, EventArgs e)
        {
            this.PanelRojo.Size = new System.Drawing.Size(181, 97);

        }
        private void pictureBoxRojo_MouseLeave(object sender, EventArgs e)
        {
            this.PanelRojo.Size = new System.Drawing.Size(164, 79);
        }

        private void pictureBoxOscuro_MouseEnter(object sender, EventArgs e)
        {
            this.PanelOscuro.Size = new System.Drawing.Size(181, 97);
        }

        private void pictureBoxOscuro_MouseLeave(object sender, EventArgs e)
        {
            this.PanelOscuro.Size = new System.Drawing.Size(164, 79);
        }

        private void pictureBoxClaro_MouseEnter(object sender, EventArgs e)
        {
            this.PanelClaro.Size = new System.Drawing.Size(181, 97);
        }

        private void pictureBoxClaro_MouseLeave(object sender, EventArgs e)
        {
            this.PanelClaro.Size = new System.Drawing.Size(164, 79);
        }
        #endregion
    }
}

/*            #region -> Color
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
            if (ComboTema.Text == "Amarillo")
            {
                //panelP2.SendToBack();
                //panelP2.BringToFront();
                iconPictureBox1.SendToBack();
                PanelP.BringToFront();
                PanelL.BringToFront();
                PanelS.BringToFront();
                ComboTema.SendToBack();
                //buttonBlue.BringToFront();
                //buttonYellow.BringToFront();
            }
            //Abrirformulario<Form_Test>(Variables.Opcion="Amarillo");

            #endregion*/