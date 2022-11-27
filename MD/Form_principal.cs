using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;

namespace MD
{
    public partial class Form_principal : Form 
    {
        public Form_principal()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            Partes2();
            panelP2.BringToFront();
            labelname.Text = Variables.Name;
            labellastname.Text = Variables.Last_name;
            labelscore.Text = Convert.ToString(Variables.Process);
        }

        #region->Color de paneles y Herramientas
        string color = Properties.Settings.Default.Tema;
        int posY = 0;
        int posX = 0;
        public void Partes2()
        {         
            Colores.ElegirColor(color);
            PanelP.BackColor = Colores.PanelPrincipal;
            PanelS.BackColor = Colores.PanelSuperior;
            PanelL.BackColor = Colores.PanelLateral;
            Tema.BackColor = Colores.BotonesS;
            Tema.ForeColor = Colores.FuenteC;
            Return.ForeColor = Colores.FuenteC;
            Return.BackColor = Colores.BotonesS;
            buttonestudio.BackColor = Colores.BotonesS;
            buttonestudio.ForeColor = Colores.FuenteC;
            labellastname.ForeColor = Colores.FuenteC;
            labelname.ForeColor = Colores.FuenteC;
            labelscore.ForeColor = Colores.FuenteC;
            Minimizar.IconColor = Colores.FuenteC;
            Minimizar.BackColor = Colores.PanelSuperior;
            Cerrar.IconColor = Colores.FuenteC;
            Cerrar.BackColor = Colores.PanelSuperior;
            comboBox1.BackColor = Colores.PanelLateral;
            comboBox1.ForeColor = Colores.FuenteC;
            button1Examen.BackColor = Colores.BotonesS;
            button1Examen.ForeColor = Colores.FuenteC;
            buttonRefresh.BackColor = Colores.BotonesS;
            buttonRefresh.ForeColor = Colores.FuenteC;         
        }

        public void Partes()
        {
            Properties.Settings.Default.Save();
            color = Properties.Settings.Default.Tema;
            Colores.ElegirColor(color);
            PanelP.BackColor = Colores.PanelPrincipal;
            PanelS.BackColor = Colores.PanelSuperior;
            PanelL.BackColor = Colores.PanelLateral;
            Tema.BackColor = Colores.BotonesS;
            Tema.ForeColor = Colores.FuenteC;
            Return.ForeColor = Colores.FuenteC;
            Return.BackColor = Colores.BotonesS;
            buttonestudio.BackColor = Colores.BotonesS;
            buttonestudio.ForeColor = Colores.FuenteC;
            labellastname.ForeColor = Colores.FuenteC;
            labelname.ForeColor = Colores.FuenteC;
            Minimizar.BackColor = Colores.BackImagen;
            Cerrar.BackColor = Colores.BackImagen;
            comboBox1.BackColor = Colores.PanelLateral;
            comboBox1.ForeColor = Colores.FuenteC;        
        }
        #endregion

        #region->Funciones para esconder o mostrar panel de Colores
        public void PanelColoresAtras()
        {
            PanelAzul.Visible = false;
            PanelCafe.Visible = false;
            PanelCeleste.Visible = false;
            PanelClaro.Visible = false;
            PanelMorado.Visible = false;
            PanelOscuro.Visible = false;
            PanelRosa.Visible = false;
            PanelRojo.Visible = false;
            PanelVerde.Visible = false;
        }

        public void PanelColoresAdelante()
        {
            PanelAzul.Visible = true;
            PanelCafe.Visible = true;
            PanelCeleste.Visible = true;
            PanelClaro.Visible = true;
            PanelMorado.Visible = true;
            PanelOscuro.Visible = true;
            PanelRosa.Visible = true;
            PanelRojo.Visible = true;
            PanelVerde.Visible = true;
        }
        #endregion

        #region->Funciones para mover el panel
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
        #endregion

        #region->Funciones para abrir o cerrar Formularios
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
            else if (Variables.Opcion == "Red")
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

        public void Cerrarformulario()
        {
            labelscore.Text = Convert.ToString(Variables.Process);
            try
            {
                Form formulario;
                formulario = panelP2.Controls.OfType<Form>().FirstOrDefault();
                if (formulario != null)
                {
                    formulario.Close();
                }
            }
            catch(Exception ex) {;}
        }

        private void Abrirformulario<MiForm>(string v) where MiForm : Form, new()
        {
            Form formulario;
            formulario = PanelP.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                //formulario.FormBorderStyle = FormBorderStyle.None;
                //formulario.Dock = DockStyle.Fill;
                //panelP2.BringToFront();
                panelP2.Controls.Add(formulario);
                panelP2.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }       
            else { formulario.BringToFront(); }
        }
        #endregion

        #region ->Funciones para cambiar Colores. Y efectos de Panel de Colores
        private void pictureBoxCafe_Click(object sender, EventArgs e)
        {
            Variables.Opcion = "Coffe";
            Properties.Settings.Default["Tema"] = "Cafe";
            Properties.Settings.Default.Save();
            color = Properties.Settings.Default.Tema;
            Partes2();
        }
        private void pictureBoxAzul_Click(object sender, EventArgs e)
        {
            Variables.Opcion = "Blue";
            Properties.Settings.Default["Tema"] = "Azul";
            Properties.Settings.Default.Save();
            color = Properties.Settings.Default.Tema;
            Partes2();

        }

        private void pictureBoxMorado_Click(object sender, EventArgs e)
        {
            Variables.Opcion = "Purple";
            Properties.Settings.Default["Tema"] = "Morado";
            Properties.Settings.Default.Save();
            color = Properties.Settings.Default.Tema;
            Partes2();

        }

        private void pictureBoxRojo_Click(object sender, EventArgs e)
        {
            Variables.Opcion = "Red";
            Properties.Settings.Default["Tema"] = "Rojo";
            Properties.Settings.Default.Save();
            color = Properties.Settings.Default.Tema;
            Partes2();

        }

        private void pictureBoxOscuro_Click(object sender, EventArgs e)
        {
            Variables.Opcion = "Dark";
            Properties.Settings.Default["Tema"] = "Oscuro";
            Properties.Settings.Default.Save();
            color = Properties.Settings.Default.Tema;
            Partes2();

        }

        private void pictureBoxClaro_Click(object sender, EventArgs e)
        {
            Variables.Opcion = "White";
            Properties.Settings.Default["Tema"] = "Claro";
            Properties.Settings.Default.Save();
            color = Properties.Settings.Default.Tema;
            Partes2();

        }

        private void pictureBoxCeleste_Click(object sender, EventArgs e)
        {
            Variables.Opcion = "light_blue";
            Properties.Settings.Default["Tema"] = "Celeste";
            Properties.Settings.Default.Save();
            color = Properties.Settings.Default.Tema;
            Partes2();

        }

        private void pictureBoxRosa_Click(object sender, EventArgs e)
        {
            Variables.Opcion = "Pink";
            Properties.Settings.Default["Tema"] = "Rosa";
            Properties.Settings.Default.Save();
            color = Properties.Settings.Default.Tema;
            Partes2();

        }
        private void pictureBoxVerde_Click(object sender, EventArgs e)
        {
            Variables.Opcion = "Green";
            Properties.Settings.Default["Tema"] = "Verde";
            Properties.Settings.Default.Save();
            color = Properties.Settings.Default.Tema;
            Partes2();

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

        #region->Funciones de los botones, combox e icconbuttons
        private void Tema_Click(object sender, EventArgs e)
        {
            Cerrarformulario();
            comboBox1.Visible = false;
            if (Variables.Panel == "Cap1" || Variables.Panel == "Estudio")
            {
                PanelColoresAdelante();
                panelP2.SendToBack();
            }
            else
            {
                PanelColoresAdelante();
                panelP2.SendToBack();
                #region -> Colores 
                Colores.ElegirColor(color);
                if (Variables.Opcion == "Amarillo") Partes();
                if (Variables.Opcion == "Coffe") Partes();
                else if (Variables.Opcion == "Blue") Partes();
                else if (Variables.Opcion == "Red") Partes();
                else if (Variables.Opcion == "Purple") Partes();
                else if (Variables.Opcion == "Dark") Partes();
                else if (Variables.Opcion == "White") Partes();
                else if (Variables.Opcion == "light_blue") Partes();
                else if (Variables.Opcion == "Pink") Partes();
                else if (Variables.Opcion == "Green") Partes();
                #endregion
            }
        }

        private void buttonestudio_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Capítulo 1")
            {
                comboBox1.Text = null;
                comboBox1.Visible = false;
                Variables.Config = "Cap1";            
                PanelColoresAtras();
                Cerrarformulario();
                Abrirformulario<Form_Capitulos>(Variables.Opcion);
            }
            else if (comboBox1.Text == "Capítulo 2" || comboBox1.Text == "Capítulo 3")
            {
                comboBox1.Text = null;
                comboBox1.Visible = false;
                Variables.Config = "Cap2";
                PanelColoresAtras();
                Cerrarformulario();
                Abrirformulario<Form_Capitulos>(Variables.Opcion);
            }
            else if (comboBox1.Text == "Capítulo 4" || comboBox1.Text == "Capítulo 5")
            {
                comboBox1.Text = null;
                comboBox1.Visible = false;
                Variables.Config = "Cap4";
                PanelColoresAtras();
                Cerrarformulario();
                Abrirformulario<Form_Capitulos>(Variables.Opcion);
            }
            else if (comboBox1.Text == "Capítulo 6")
            {
                comboBox1.Text = null;
                comboBox1.Visible = false;
                Variables.Config = "Cap6";
                PanelColoresAtras();
                Cerrarformulario();
                Abrirformulario<Form_Capitulos>(Variables.Opcion);
            }
            else if(comboBox1.Text == "Capítulo 7")
            {
                comboBox1.Text = null;
                comboBox1.Visible = false;
                Variables.Config = "Cap7";
                PanelColoresAtras();
                Cerrarformulario();
                Abrirformulario<Form_Capitulos>(Variables.Opcion);
            }
            else if (comboBox1.Text == "Capítulo 8")
            {
                comboBox1.Text = null;
                comboBox1.Visible = false;
                Variables.Config = "Cap8";
                PanelColoresAtras();
                Cerrarformulario();
                Abrirformulario<Form_Capitulos>(Variables.Opcion);
            }
            else if (comboBox1.Text == "Capítulo 9")
            {
                comboBox1.Text = null;
                comboBox1.Visible = false;
                Variables.Config = "Cap9";
                PanelColoresAtras();
                Cerrarformulario();
                Abrirformulario<Form_Capitulos>(Variables.Opcion);
            }
            else if (comboBox1.Text == "Capítulo 10")
            {
                comboBox1.Text = null;
                comboBox1.Visible = false;
                Variables.Config = "Cap10";
                PanelColoresAtras();
                Cerrarformulario();
                Abrirformulario<Form_Capitulos>(Variables.Opcion);
            }
            else if (comboBox1.Text == "Capítulo 11" || comboBox1.Text == "Capítulo 12")
            {
                comboBox1.Text = null;
                comboBox1.Visible = false;
                Variables.Config = "Cap11";
                PanelColoresAtras();
                Cerrarformulario();
                Abrirformulario<Form_Capitulos>(Variables.Opcion);
            }

        }

        private void Return_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguros de cerrar el formulario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Form_login login = new Form_login();
                login.Show();
                this.Hide();
            }
            else;
        }

        private void button1Examen_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            PanelColoresAtras();
            Abrirformulario<Form_Estudio>(Variables.Opcion);
        }

        private void iconPictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            panelP2.BringToFront();
            PanelColoresAtras();
            Cerrarformulario();
            labelscore.Text = Convert.ToString(Variables.Process);
        }
        #endregion
    }
}