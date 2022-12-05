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
            PanelEstudiarEsconder();
            PanelExamenEsconder();
            panelP2.BringToFront();
            iconButtonCerrar.Visible = false;
            labelname.Text = Variables.Name;
            labellastname.Text = Variables.Last_name;
            labelscorecap.Text = Convert.ToString(Variables.Process);
            labelscoreexa.Text = Convert.ToString(Variables.Process);            
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
            iconButtonTemas.BackColor = Colores.BotonesS;
            iconButtonTemas.ForeColor = Colores.FuenteC;
            iconButtonTemas.IconColor = Colores.FuenteC;
            iconButtonRegresar.ForeColor = Colores.FuenteC;
            iconButtonRegresar.IconColor = Colores.FuenteC;
            iconButtonRegresar.BackColor = Colores.BotonesS;
            iconButtonEstudiar.BackColor = Colores.BotonesS;
            iconButtonEstudiar.ForeColor = Colores.FuenteC;
            iconButtonEstudiar.IconColor = Colores.FuenteC;
            labellastname.ForeColor = Colores.FuenteC;
            labelname.ForeColor = Colores.FuenteC;
            labelscorecap.ForeColor = Colores.FuenteC;
            Minimizar.IconColor = Colores.FuenteC;
            Minimizar.BackColor = Colores.PanelSuperior;
            Cerrar.IconColor = Colores.FuenteC;
            Cerrar.BackColor = Colores.PanelSuperior;
            comboBox1.BackColor = Colores.PanelLateral;
            comboBox1.ForeColor = Colores.FuenteC;
            iconButtonExa.BackColor = Colores.BotonesS;
            iconButtonExa.ForeColor = Colores.FuenteC;
            iconButtonExa.IconColor = Colores.FuenteC;
            iconButtonCerrar.BackColor = Colores.BotonesS;
            iconButtonCerrar.ForeColor = Colores.FuenteC;
            iconButtonCerrar.IconColor = Colores.FuenteC;
            iconButtonCap.BackColor = Colores.PanelSuperior;
            iconButtonCap.ForeColor = Colores.FuenteC;
            iconButtonCap.IconColor = Colores.FuenteC;
            iconButtonSena.BackColor = Colores.PanelSuperior;
            iconButtonSena.ForeColor = Colores.FuenteC;            
            iconButtonSena.IconColor = Colores.FuenteC;
            iconButtonExaley.BackColor = Colores.PanelSuperior;
            iconButtonExaley.ForeColor = Colores.FuenteC;
            iconButtonExaley.IconColor = Colores.FuenteC;
            iconButtonExasena.BackColor = Colores.PanelSuperior;
            iconButtonExasena.ForeColor = Colores.FuenteC;
            iconButtonExasena.IconColor = Colores.FuenteC;
        }

        public void Partes()
        {
            Properties.Settings.Default.Save();
            color = Properties.Settings.Default.Tema;
            Colores.ElegirColor(color);
            PanelP.BackColor = Colores.PanelPrincipal;
            PanelS.BackColor = Colores.PanelSuperior;
            PanelL.BackColor = Colores.PanelLateral;
            iconButtonTemas.BackColor = Colores.BotonesS;
            iconButtonTemas.ForeColor = Colores.FuenteC;
            iconButtonTemas.IconColor = Colores.FuenteC;
            iconButtonRegresar.ForeColor = Colores.FuenteC;
            iconButtonRegresar.IconColor = Colores.FuenteC;
            iconButtonRegresar.BackColor = Colores.BotonesS;
            iconButtonEstudiar.BackColor = Colores.BotonesS;
            iconButtonEstudiar.ForeColor = Colores.FuenteC;
            iconButtonEstudiar.IconColor = Colores.FuenteC;
            labellastname.ForeColor = Colores.FuenteC;
            labelname.ForeColor = Colores.FuenteC;
            Minimizar.BackColor = Colores.BackImagen;
            Cerrar.BackColor = Colores.BackImagen;
            comboBox1.BackColor = Colores.PanelLateral;
            comboBox1.ForeColor = Colores.FuenteC;        
        }
        #endregion

        #region->Funciones para esconder o mostrar panel de Colores y Otros
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

        public void PanelEstudiarEsconder()
        {
            iconButtonCap.Visible = false;
            iconButtonSena.Visible = false;
            panelCapi.Visible = false;
            panelEstudio.Visible = false;
        }

        public void PanelEstudiarMostrar()
        {
            iconButtonCap.Visible = true;
            iconButtonSena.Visible = true;
            panelCapi.Visible = true;
            panelEstudio.Visible = true;
        }

        public void PanelExamenEsconder()
        {
            iconButtonExaley.Visible = false;
            iconButtonExasena.Visible = false;
            panelexaley.Visible = false;
            panelexasena.Visible = false;
        }
        public void PanelExamenMostrar()
        {
            iconButtonExaley.Visible = true;
            iconButtonExasena.Visible = true;
            panelexaley.Visible = true;
            panelexasena.Visible = true;
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
            labelscorecap.Text = Convert.ToString(Variables.Process);
            try
            {
                Form formulario;
                formulario = panelP2.Controls.OfType<Form>().FirstOrDefault();
                if (formulario != null)
                {
                    formulario.Close();
                }
            }
            catch(Exception ex) {MessageBox.Show(Convert.ToString(ex));}
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
        private void iconButtonTemas_Click(object sender, EventArgs e)
        {
            Cerrarformulario();
            PanelEstudiarEsconder();
            PanelExamenEsconder();
            comboBox1.Visible = false;
            iconButtonCerrar.Visible = true;
            if (Variables.Panel == "Cap1")
            {
                Cerrarformulario();
                PanelColoresAdelante();
                panelP2.SendToBack();
            }
            if (Variables.Panel == "ExaCap")
            {
                Cerrarformulario();
                PanelColoresAdelante();
                panelP2.SendToBack();
            }
            else
            {
                Cerrarformulario();
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
            PanelEstudiarEsconder();
            PanelExamenEsconder();
            PanelColoresAtras();
            Cerrarformulario();
            labelscorecap.Text = Convert.ToString(Variables.Process);
        }

        private void iconButtonRegresar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguros de cerrar el formulario?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Form_login login = new Form_login();
                login.Show();
                this.Hide();
            }
            else;
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
            else if (comboBox1.Text == "Capítulo 7")
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

        private void iconButtonEstudiar_Click(object sender, EventArgs e)
        {
            Cerrarformulario();
            panelP2.BringToFront();
            PanelExamenEsconder();
            iconButtonCerrar.Visible = true;
            comboBox1.Visible = false;
            PanelColoresAtras();
            PanelEstudiarMostrar();
            PanelCapitulo();
            PanelEstudio();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
        }

        private void iconButtonSena_Click(object sender, EventArgs e)
        {
            Abrirformulario<Form_Senales>(Variables.Opcion);
            iconButtonCerrar.Visible = true;
            iconButtonCerrar.BringToFront();
        }

        private void iconButtonExa_Click(object sender, EventArgs e)
        {
            Cerrarformulario();
            panelP2.BringToFront();
            iconButtonCerrar.Visible = true;
            comboBox1.Visible = false;
            PanelEstudiarEsconder();
            PanelColoresAtras();
            PanelExamenMostrar();
            PanelExaley();
            PanelExasena();
        }

        private void iconButtonExaley_Click(object sender, EventArgs e)
        {
            Abrirformulario<Form_Excap>(Variables.Opcion);
        }

        private void iconButtonExasena_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonCap_MouseEnter(object sender, EventArgs e)
        {
            CapMouseEnter();
        }

        private void iconButtonCap_MouseLeave(object sender, EventArgs e)
        {
            CapMouseLeave();
        }

        private void iconButtonSena_MouseEnter(object sender, EventArgs e)
        {
            EstMouseEnter();
        }

        private void iconButtonSena_MouseLeave(object sender, EventArgs e)
        {
            EstMouseLeave();
        }

        private void iconButtonExaley_MouseEnter(object sender, EventArgs e)
        {
            ExaleyMouseEnter();
        }

        private void iconButtonExaley_MouseLeave(object sender, EventArgs e)
        {
            ExaleyMouseLeave();
        }

        private void iconButtonExasena_MouseEnter(object sender, EventArgs e)
        {
            ExasenaMouseEnter();
        }

        private void iconButtonExasena_MouseLeave(object sender, EventArgs e)
        {
            ExasenaMouseLeave();
        }
        #endregion

        #region->Funciones para crear paneles
        Panel panelCapi = new Panel();
        PictureBox pictureBoxCap = new PictureBox();
        Panel panelEstudio = new Panel();
        PictureBox pictureBoxEstudio = new PictureBox();

        public void PanelCapitulo()
        {
            panelCapi.Location = new Point(33, 105);
            panelCapi.Size = new Size(278, 343);

            pictureBoxCap.Location = new Point(4, 4);
            pictureBoxCap.Size = new Size(270, 334);
       
            panelCapi.BorderStyle = System.Windows.Forms.BorderStyle.None;

            pictureBoxCap.Image = Image.FromFile(@"C:\Users\GUEVARA-JARQUIN\source\repos\Clon\ProyectoMD\MD\Resources\Animacion 2.0.gif");
            pictureBoxCap.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxCap.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBoxCap.Click += new System.EventHandler(this.pictureBoxCap_Click);
            pictureBoxCap.MouseEnter += new System.EventHandler(this.pictureBoxCap_MouseEnter);
            pictureBoxCap.MouseLeave += new System.EventHandler(this.pictureBoxCap_MouseLeave);
            panelCapi.BackColor = Colores.PanelSuperior;
            panelCapi.Visible = true;
            panelCapi.BringToFront();
            this.panelP2.Controls.Add(panelCapi);          
            panelCapi.Controls.Add(pictureBoxCap);
        }

        private void pictureBoxCap_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
        }

        private void pictureBoxEstudio_Click(object sender, EventArgs e)
        {
            Abrirformulario<Form_Senales>(Variables.Opcion);
        }
        public void CapMouseEnter()
        {
            this.panelCapi.Size = new Size(288, 353);
            this.iconButtonCap.Size = new Size(288, 66);
            this.pictureBoxCap.Size = new Size(280, 344);
            if (Variables.Opcion == "White") { panelCapi.BackColor = Color.Black; }
            else { panelCapi.BackColor = Color.WhiteSmoke; }
        }

        public void CapMouseLeave()
        {
            this.panelCapi.Size = new Size(278, 343);
            this.iconButtonCap.Size = new Size(278, 66);
            this.pictureBoxCap.Size = new Size(270, 334);
            panelCapi.BackColor = Color.Transparent;
        }
        private void pictureBoxCap_MouseEnter(object sender, EventArgs e)
        {
            CapMouseEnter();
        }
        private void pictureBoxCap_MouseLeave(object sender, EventArgs e)
        {
            CapMouseLeave();
        }

        public void PanelEstudio()
        {          
            panelEstudio.Location = new Point(352, 105);
            panelEstudio.Size = new Size(278, 343);

            pictureBoxEstudio.Location = new Point(4, 4);
            pictureBoxEstudio.Size = new Size(270, 334);
            panelEstudio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pictureBoxEstudio.Image = Image.FromFile(@"C:\Users\GUEVARA-JARQUIN\source\repos\Clon\ProyectoMD\MD\Resources\Animacion 2.0.gif");
            pictureBoxEstudio.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxEstudio.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBoxEstudio.Click += new System.EventHandler(this.pictureBoxEstudio_Click);
            pictureBoxEstudio.MouseEnter += new System.EventHandler(this.pictureBoxEstudio_MouseEnter);
            pictureBoxEstudio.MouseLeave += new System.EventHandler(this.pictureBoxEstudio_MouseLeave);
            panelEstudio.BackColor = Colores.PanelSuperior;
            panelEstudio.Visible = true;
            panelEstudio.BringToFront();
            this.panelP2.Controls.Add(panelEstudio);
            panelEstudio.Controls.Add(pictureBoxEstudio);
        }

        public void EstMouseEnter()
        {
            this.panelEstudio.Size = new Size(288, 353);
            this.iconButtonSena.Size = new Size(288, 66);
            this.pictureBoxEstudio.Size = new Size(280, 344);
            if (Variables.Opcion == "White") { panelEstudio.BackColor = Color.Black; }
            else { panelEstudio.BackColor = Color.WhiteSmoke; }
        }

        public void EstMouseLeave()
        {
            this.panelEstudio.Size = new Size(278, 343);
            this.iconButtonSena.Size = new Size(278, 66);
            this.pictureBoxEstudio.Size = new Size(270, 334);
            panelEstudio.BackColor = Color.Transparent;
        }
        private void pictureBoxEstudio_MouseEnter(object sender, EventArgs e)
        {
            EstMouseEnter();
        }
        private void pictureBoxEstudio_MouseLeave(object sender, EventArgs e)
        {
            EstMouseLeave();
        }

        Panel panelexaley = new Panel();
        PictureBox pictureBoxexaley = new PictureBox();
        Panel panelexasena = new Panel();
        PictureBox pictureBoxexasena = new PictureBox();

        public void PanelExaley()
        {
            panelexaley.Location = new Point(33, 105);
            panelexaley.Size = new Size(278, 343);
            pictureBoxexaley.Location = new Point(4, 4);
            pictureBoxexaley.Size = new Size(270, 334);         
            panelexaley.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pictureBoxexaley.Image = Image.FromFile(@"C:\Users\GUEVARA-JARQUIN\source\repos\Clon\ProyectoMD\MD\Resources\Animacion 2.0.gif");
            pictureBoxexaley.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxexaley.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBoxexaley.Click += new System.EventHandler(this.pictureBoxexaley_Click);
            pictureBoxexaley.MouseEnter += new System.EventHandler(this.pictureBoxexaley_MouseEnter);
            pictureBoxexaley.MouseLeave += new System.EventHandler(this.pictureBoxexaley_MouseLeave);
            panelexaley.BackColor = Colores.PanelSuperior;
            panelexaley.Visible = true;
            panelexaley.BringToFront();               
            this.panelP2.Controls.Add(panelexaley);       
            panelexaley.Controls.Add(pictureBoxexaley);
        }
        private void pictureBoxexaley_Click(object sender, EventArgs e)
        {
            Abrirformulario<Form_Excap>(Variables.Opcion);
        }

        public void ExaleyMouseEnter()
        {
            this.panelexaley.Size = new Size(288, 353);
            this.iconButtonExaley.Size = new Size(288, 66);
            this.pictureBoxexaley.Size = new Size(280, 344);
            if (Variables.Opcion == "White") { panelexaley.BackColor = Color.Black; }
            else { panelexaley.BackColor = Color.WhiteSmoke; }
        }

        public void ExaleyMouseLeave()
        {
            this.panelexaley.Size = new Size(278, 343);
            this.iconButtonExaley.Size = new Size(278, 66);
            this.pictureBoxexaley.Size = new Size(270, 334);
            panelexaley.BackColor = Color.Transparent;
        }

        private void pictureBoxexaley_MouseEnter(object sender, EventArgs e)
        {
            ExaleyMouseEnter();
        }
        private void pictureBoxexaley_MouseLeave(object sender, EventArgs e)
        {
            ExaleyMouseLeave();
        }

        public void PanelExasena()
        {           
            panelexasena.Location = new Point(352, 105);
            panelexasena.Size = new Size(278, 343);
            pictureBoxexasena.Location = new Point(4, 4);
            pictureBoxexasena.Size = new Size(270, 334);
            panelexasena.BorderStyle = System.Windows.Forms.BorderStyle.None;
            pictureBoxexasena.Image = Image.FromFile(@"C:\Users\GUEVARA-JARQUIN\source\repos\Clon\ProyectoMD\MD\Resources\Animacion 2.0.gif");
            pictureBoxexasena.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxexasena.Cursor = System.Windows.Forms.Cursors.Hand;
            pictureBoxexasena.Click += new System.EventHandler(this.pictureBoxexasen_Click);
            pictureBoxexasena.MouseEnter += new System.EventHandler(this.pictureBoxexasena_MouseEnter);
            pictureBoxexasena.MouseLeave += new System.EventHandler(this.pictureBoxexasena_MouseLeave);
            panelexasena.BackColor = Colores.PanelSuperior;
            panelexasena.Visible = true;
            panelexasena.BringToFront();          
            this.panelP2.Controls.Add(panelexasena);            
            panelexasena.Controls.Add(pictureBoxexasena);
        }

        private void pictureBoxexasen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En proceso");
        }

        public void ExasenaMouseEnter()
        {
            this.panelexasena.Size = new Size(288, 353);
            this.iconButtonExasena.Size = new Size(288, 66);
            this.pictureBoxexasena.Size = new Size(280, 344);
            if (Variables.Opcion == "White") { panelexasena.BackColor = Color.Black; }
            else { panelexasena.BackColor = Color.WhiteSmoke; }
        }

        public void ExasenaMouseLeave()
        {
            this.panelexasena.Size = new Size(278, 343);
            this.iconButtonExasena.Size = new Size(278, 66);
            this.pictureBoxexasena.Size = new Size(270, 334);
            panelexasena.BackColor = Color.Transparent;
        }

        private void pictureBoxexasena_MouseEnter(object sender, EventArgs e)
        {
            ExasenaMouseEnter();
        }
        private void pictureBoxexasena_MouseLeave(object sender, EventArgs e)
        {
            ExasenaMouseLeave();
        }

        #endregion

        private void iconButtonCerrar_Click(object sender, EventArgs e)
        {
            iconButtonCerrar.Visible = false;
            comboBox1.Visible = false;
            panelP2.BringToFront();
            PanelEstudiarEsconder();
            PanelExamenEsconder();
            PanelColoresAtras();
            Cerrarformulario();
            labelscorecap.Text = Convert.ToString(Variables.Process);
        }
    }
}