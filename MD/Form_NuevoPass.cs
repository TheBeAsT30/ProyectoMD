using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace MD
{
    public partial class Form_NuevoPass : Form
    {
        public Form_NuevoPass()
        {
            InitializeComponent();
        }
        string color = Properties.Settings.Default.Tema;

        private void Form_NuevoPass_Load(object sender, EventArgs e)
        {
            Contraseña.PasswordChar = '\0';
            ConfirmarPass.PasswordChar = '\0';
            Colores.ElegirColor(color);
            Modificar1.BackColor = Colores.PanelLateral;
            iconButtonRegresar.BackColor = Colores.PanelLateral;
            panel1.BackColor = Colores.PanelPrincipal;
            Modificar1.ForeColor = Colores.FuenteC;
            Modificar1.IconColor = Colores.FuenteC;                             
            Contraseña.BackColor = Colores.PanelLateral;
            ConfirmarPass.BackColor = Colores.PanelLateral;
            iconButtonRegresar.BackColor = Colores.PanelLateral;
            iconButtonRegresar.ForeColor = Colores.FuenteC;
            iconButtonRegresar.IconColor = Colores.FuenteC;
            iconPictureBox2.BackColor = Colores.PanelLateral;
            iconPictureBox2.IconColor = Colores.FuenteC;
            iconPictureBoxVer1.BackColor = Colores.PanelLateral;
            iconPictureBoxVer1.IconColor = Colores.FuenteC;
            iconPictureBoxNVer1.BackColor = Colores.PanelLateral;
            iconPictureBoxNVer1.IconColor = Colores.FuenteC;
            iconPictureBoxVer2.BackColor = Colores.PanelLateral;
            iconPictureBoxVer2.IconColor = Colores.FuenteC;
            iconPictureBoxNVer2.BackColor = Colores.PanelLateral;
            iconPictureBoxNVer2.IconColor = Colores.FuenteC;
            iconPictureBoxNVer1.Visible = false;
            iconPictureBoxNVer2.Visible = false;
            iconPictureBoxVer1.Visible = false;
            iconPictureBoxVer2.Visible = false;
        }

        private void Contraseña_Enter(object sender, EventArgs e)
        {
            if (Contraseña.Text == "CONTRASEÑA")
            {
                Contraseña.Text = "";
                Contraseña.PasswordChar = '*';
                Contraseña.ForeColor = Colores.FuenteC;
                iconPictureBoxNVer1.Visible = true;
            }
        }

        private void Contraseña_Leave(object sender, EventArgs e)
        {
            if (Contraseña.Text == "")
            {
                Contraseña.Text = "CONTRASEÑA";
                Contraseña.ForeColor = Color.DimGray;
                Contraseña.PasswordChar = '\0';
                iconPictureBoxNVer1.Visible = false;
            }
        }

        private void ConfirmarPass_Enter(object sender, EventArgs e)
        {
            if (ConfirmarPass.Text == "CONFIRMAR CONTRASEÑA")
            {
                ConfirmarPass.Text = "";
                ConfirmarPass.PasswordChar = '*';
                ConfirmarPass.ForeColor = Colores.FuenteC;
                iconPictureBoxNVer2.Visible = true;
            }
        }

        private void ConfirmarPass_Leave(object sender, EventArgs e)
        {
            if (ConfirmarPass.Text == "")
            {
                ConfirmarPass.Text = "CONFIRMAR CONTRASEÑA";
                ConfirmarPass.ForeColor = Color.DimGray;
                ConfirmarPass.PasswordChar = '\0';
                iconPictureBoxNVer2.Visible = false;
            }
        }

        public void Modificar()
        {
            if (ConfirmarPass.Text == Contraseña.Text)
            {

                try
                {
                    string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;
                    using (MySqlConnection connection = new MySqlConnection(cadena))
                    {
                        connection.Open();
                        /*    UPDATE users SET Password = '4321' WHERE Email = 'guevaravic25@gmail.com';*/
                        string consulta = "UPDATE users SET Password= AES_ENCRYPT('" + ConfirmarPass.Text + "','" + Variables.Code + "') WHERE Email =  '" + Variables.Email + "';";
                        using (MySqlCommand command = new MySqlCommand(consulta, connection))
                        {
                            command.ExecuteNonQuery();
                            connection.Close();
                            MessageBox.Show("Registro Modificado");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else MessageBox.Show("Las contraseñas no coinciden");
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            Modificar();
        }

        private void iconPictureBoxVer1_Click(object sender, EventArgs e)
        {
            iconPictureBoxVer1.Visible = false;
            iconPictureBoxNVer1.Visible = true;
            Contraseña.PasswordChar = '*';
        }

        private void iconPictureBoxNVer1_Click(object sender, EventArgs e)
        {
            iconPictureBoxVer1.Visible = true;
            iconPictureBoxNVer1.Visible = false;
            Contraseña.PasswordChar = '\0';
        }

        private void iconPictureBoxVer2_Click(object sender, EventArgs e)
        {
            iconPictureBoxVer2.Visible = false;
            iconPictureBoxNVer2.Visible = true;
            ConfirmarPass.PasswordChar = '*';
        }

        private void iconPictureBoxNVer2_Click(object sender, EventArgs e)
        {
            iconPictureBoxVer2.Visible = true;
            iconPictureBoxNVer2.Visible = false;
            ConfirmarPass.PasswordChar = '\0';
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            ConfirmarPass.Text = "CONFIRMAR CONTRASEÑA";
            ConfirmarPass.ForeColor = Color.DimGray;
            Contraseña.Text = "CONTRASEÑA";
            Contraseña.ForeColor = Color.DimGray;
            Contraseña.PasswordChar = '\0';
            ConfirmarPass.PasswordChar = '\0';
            iconPictureBoxNVer1.Visible = false;         
            iconPictureBoxNVer2.Visible = false;         
            iconPictureBoxVer1.Visible = false;         
            iconPictureBoxVer2.Visible = false;         
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}