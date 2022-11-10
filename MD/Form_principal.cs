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
            Tema.ForeColor = Colores.FuenteC;
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
            else if (Variables.Opcion == "light_blue")
            {
                Properties.Settings.Default["Tema"] = "Celeste";
                Properties.Settings.Default.Save();
            }
            else if (Variables.Opcion == "Pink")
            {
                Properties.Settings.Default["Tema"] = "Rosa";
                Properties.Settings.Default.Save();
            }
            else if (Variables.Opcion == "Green")
            {
                Properties.Settings.Default["Tema"] = "Verde";
                Properties.Settings.Default.Save();
            }
        }


        private void Tema_Click(object sender, EventArgs e)
        {
            Variables.Opcion = "light_blue";
            Properties.Settings.Default["Tema"] = "Celeste";
            Properties.Settings.Default.Save();
            color = Properties.Settings.Default.Tema;
            Colores.ElegirColor(color);
            PanelP.BackColor = Colores.PanelPrincipal;
            PanelS.BackColor = Colores.PanelSuperior;
            PanelL.BackColor = Colores.PanelLateral;
            Tema.ForeColor = Colores.FuenteC;
            Minimizar.BackColor = Colores.BackImagen;
            Cerrar.BackColor = Colores.BackImagen;
            Tema.BackColor = Colores.BotonesS;
            Tema.Visible = false;
            pictureBoxAzul.Visible = false;
            pictureBoxCafe.Visible = false;
            pictureBoxClaro.Visible = false;
            pictureBoxMorado.Visible = false;
            pictureBoxOscuro.Visible = false;
            pictureBoxRojo.Visible = false;
            iconPictureBox1.Visible = false;
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
            Tema.ForeColor = Colores.FuenteC;
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
            Tema.ForeColor = Colores.FuenteC;
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
            Tema.ForeColor = Colores.FuenteC;
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
            Tema.ForeColor = Colores.FuenteC;
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
            Tema.ForeColor = Colores.FuenteC;
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
            Tema.ForeColor = Colores.FuenteC;
            Minimizar.BackColor = Colores.BackImagen;
            Cerrar.BackColor = Colores.BackImagen;
            Tema.BackColor = Colores.BotonesS;
        }

        private void pictureBoxCeleste_Click(object sender, EventArgs e)
        {
            Variables.Opcion = "light_blue";
            Properties.Settings.Default["Tema"] = "Celeste";
            Properties.Settings.Default.Save();
            color = Properties.Settings.Default.Tema;
            Colores.ElegirColor(color);
            PanelP.BackColor = Colores.PanelPrincipal;
            PanelS.BackColor = Colores.PanelSuperior;
            PanelL.BackColor = Colores.PanelLateral;
            Tema.ForeColor = Colores.FuenteC;
            Minimizar.BackColor = Colores.BackImagen;
            Cerrar.BackColor = Colores.BackImagen;
            Tema.BackColor = Colores.BotonesS;
        }

        private void pictureBoxRosa_Click(object sender, EventArgs e)
        {
            Variables.Opcion = "Pink";
            Properties.Settings.Default["Tema"] = "Rosa";
            Properties.Settings.Default.Save();
            color = Properties.Settings.Default.Tema;
            Colores.ElegirColor(color);
            PanelP.BackColor = Colores.PanelPrincipal;
            PanelS.BackColor = Colores.PanelSuperior;
            PanelL.BackColor = Colores.PanelLateral;
            Tema.ForeColor = Colores.FuenteC;
            Minimizar.BackColor = Colores.BackImagen;
            Cerrar.BackColor = Colores.BackImagen;
            Tema.BackColor = Colores.BotonesS;
        }
        private void pictureBoxVerde_Click(object sender, EventArgs e)
        {
            Variables.Opcion = "Green";
            Properties.Settings.Default["Tema"] = "Verde";
            Properties.Settings.Default.Save();
            color = Properties.Settings.Default.Tema;
            Colores.ElegirColor(color);
            PanelP.BackColor = Colores.PanelPrincipal;
            PanelS.BackColor = Colores.PanelSuperior;
            PanelL.BackColor = Colores.PanelLateral;
            Tema.ForeColor = Colores.FuenteC;
            Minimizar.BackColor = Colores.BackImagen;
            Cerrar.BackColor = Colores.BackImagen;
            Tema.BackColor = Colores.BotonesS;
        }
        private void pictureBoxCafe_MouseEnter(object sender, EventArgs e)
        {
            this.PanelCafe.Size = new Size(181, 97);
            this.pictureBoxCafe.Size = new Size(171, 87);
            if(Variables.Opcion == "White")
            {
                PanelCafe.BackColor = Color.Black;
            }
            else PanelCafe.BackColor = Color.WhiteSmoke;
        }

        private void pictureBoxCafe_MouseLeave(object sender, EventArgs e)
        {
            this.PanelCafe.Size = new Size(168, 84);
            this.pictureBoxCafe.Size = new Size(160, 75);
            PanelCafe.BackColor = Color.Transparent;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.PanelAzul.Size = new Size(181, 97);
            this.pictureBoxAzul.Size = new Size(171, 87);
            if(Variables.Opcion == "White")
            {
                PanelAzul.BackColor = Color.Black;
            }
            else PanelAzul.BackColor = Color.WhiteSmoke;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.PanelAzul.Size = new Size(168, 84);
            this.pictureBoxAzul.Size = new Size(160, 75);
            PanelAzul.BackColor = Color.Transparent;
        }
        private void pictureBoxMorado_MouseLeave(object sender, EventArgs e)
        {
            this.PanelMorado.Size = new Size(168, 84);
            this.pictureBoxMorado.Size = new Size(160, 75);
            PanelMorado.BackColor = Color.Transparent;
        }

        private void pictureBoxMorado_MouseEnter(object sender, EventArgs e)
        {
            this.PanelMorado.Size = new Size(181, 97);
            this.pictureBoxMorado.Size = new Size(171, 87);
            if (Variables.Opcion == "White")
            {
                PanelMorado.BackColor = Color.Black;
            }
            else PanelMorado.BackColor = Color.WhiteSmoke;

        }

        private void pictureBoxRojo_MouseEnter(object sender, EventArgs e)
        {
            this.PanelRojo.Size = new Size(181, 97);
            this.pictureBoxRojo.Size = new Size(171, 87);
            if (Variables.Opcion == "White")
            {
                PanelRojo.BackColor = Color.Black;
            }
            else PanelRojo.BackColor = Color.WhiteSmoke;


        }
        private void pictureBoxRojo_MouseLeave(object sender, EventArgs e)
        {
            this.PanelRojo.Size = new Size(168, 84);
            this.pictureBoxRojo.Size = new Size(160, 75);
            PanelRojo.BackColor = Color.Transparent;
        }

        private void pictureBoxOscuro_MouseEnter(object sender, EventArgs e)
        {
            this.PanelOscuro.Size = new Size(181, 97);
            this.pictureBoxOscuro.Size = new Size(171, 87);
            if (Variables.Opcion == "White")
            {
                PanelOscuro.BackColor = Color.Black;
            }
            else PanelOscuro.BackColor = Color.WhiteSmoke;
        }

        private void pictureBoxOscuro_MouseLeave(object sender, EventArgs e)
        {
            this.PanelOscuro.Size = new Size(168, 84);
            this.pictureBoxOscuro.Size = new Size(160, 75);
            PanelOscuro.BackColor = Color.Transparent;
        }

        private void pictureBoxClaro_MouseEnter(object sender, EventArgs e)
        {
            this.PanelClaro.Size = new Size(181, 97);
            this.pictureBoxClaro.Size = new Size(171, 87);
            if(Variables.Opcion == "White")
            {
                PanelClaro.BackColor = Color.Black;
            }
            else PanelClaro.BackColor = Color.WhiteSmoke;
        }

        private void pictureBoxClaro_MouseLeave(object sender, EventArgs e)
        {
            this.PanelClaro.Size = new Size(168, 84);
            this.pictureBoxOscuro.Size = new Size(160, 75);
            PanelClaro.BackColor = Color.Transparent;
        }

        private void pictureBoxCeleste_MouseEnter(object sender, EventArgs e)
        {
            this.PanelCeleste.Size = new Size(181, 97);
            this.pictureBoxCeleste.Size = new Size(171, 87);
            if (Variables.Opcion == "White")
            {
                PanelCeleste.BackColor = Color.Black;
            }
            else PanelCeleste.BackColor = Color.WhiteSmoke;
        }

        private void pictureBoxCeleste_MouseLeave(object sender, EventArgs e)
        {
            this.PanelCeleste.Size = new Size(168, 84);
            this.pictureBoxCeleste.Size = new Size(160, 75);
            PanelCeleste.BackColor = Color.Transparent;
        }

        private void pictureBoxRosa_MouseEnter(object sender, EventArgs e)
        {
            this.PanelRosa.Size = new Size(181, 97);
            this.pictureBoxRosa.Size = new Size(171, 87);
            if (Variables.Opcion == "White")
            {
                PanelRosa.BackColor = Color.Black;
            }
            else PanelRosa.BackColor = Color.WhiteSmoke;
        }

        private void pictureBoxRosa_MouseLeave(object sender, EventArgs e)
        {
            this.PanelRosa.Size = new Size(168, 84);
            this.pictureBoxRosa.Size = new Size(160, 75);
            PanelRosa.BackColor = Color.Transparent;
        }

        private void pictureBoxVerde_MouseEnter(object sender, EventArgs e)
        {
            this.PanelVerde.Size = new Size(181, 97);
            this.pictureBoxVerde.Size = new Size(171, 87);
            if (Variables.Opcion == "White")
            {
                PanelVerde.BackColor = Color.Black;
            }
            else PanelVerde.BackColor = Color.WhiteSmoke;
        }

        private void pictureBoxVerde_MouseLeave(object sender, EventArgs e)
        {
            this.PanelVerde.Size = new Size(168, 84);
            this.pictureBoxVerde.Size = new Size(160, 75);
            PanelVerde.BackColor = Color.Transparent;
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguros de cerrar el formulario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close(); Form_login login = new Form_login(); login.Show();
        }
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