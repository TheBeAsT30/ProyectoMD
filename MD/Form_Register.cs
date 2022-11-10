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
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace MD
{
    public partial class Form_Register : Form
    {
        public Form_Register()
        {
            InitializeComponent();
        }


        private void iconPictureBoxVer1_Click(object sender, EventArgs e)
        {
            iconPictureBoxVer1.Visible = false;
            iconPictureBoxNVer1.Visible = true;
            Contraseña.PasswordChar = '*';
        }

        private void iconPictureBoxVer2_Click(object sender, EventArgs e)
        {
            iconPictureBoxVer2.Visible = false;
            iconPictureBoxNVer2.Visible = true;
            textConfirmar.PasswordChar = '*';
        }

        private void iconPictureBoxNVer1_Click(object sender, EventArgs e)
        {
            iconPictureBoxVer1.Visible = true;
            iconPictureBoxNVer1.Visible = false;
            Contraseña.PasswordChar = '\0';
        }

        private void iconPictureBoxNVer2_Click(object sender, EventArgs e)
        {
            iconPictureBoxVer2.Visible = true;
            iconPictureBoxNVer2.Visible = false;
            textConfirmar.PasswordChar = '\0';
        }
        string color = Properties.Settings.Default.Tema;

        private void Form_Register_Load(object sender, EventArgs e)
        {
            Contraseña.PasswordChar = '\0';
            textcorreo.PasswordChar = '\0';
            Colores.ElegirColor(color);
            PanelP.BackColor = Colores.PanelPrincipal;
            Registrar.BackColor = Colores.PanelLateral;
            Registrar.IconColor = Colores.FuenteC;
            Registrar.ForeColor = Colores.FuenteC;
            textname.BackColor = Colores.PanelLateral;
            textlastname.BackColor = Colores.PanelLateral;
            textuser.BackColor = Colores.PanelLateral;
            textConfirmar.BackColor = Colores.PanelLateral;
            Contraseña.BackColor = Colores.PanelLateral;
            textcorreo.BackColor = Colores.PanelLateral;
            iconPictureBox1.BackColor = Colores.PanelLateral;
            iconPictureBox1.IconColor = Colores.FuenteC;
            iconPictureBox2.BackColor = Colores.PanelLateral;
            iconPictureBox2.IconColor = Colores.FuenteC;
            iconPictureBox3.BackColor = Colores.PanelLateral;
            iconPictureBox3.IconColor = Colores.FuenteC;
            iconPictureBoxNVer1.Visible = false;
            iconPictureBoxNVer1.BackColor = Colores.PanelLateral;
            iconPictureBoxNVer1.IconColor = Colores.FuenteC;
            iconPictureBoxNVer2.Visible = false;
            iconPictureBoxNVer2.BackColor = Colores.PanelLateral;
            iconPictureBoxNVer2.IconColor = Colores.FuenteC;
            iconPictureBoxVer1.Visible = false;
            iconPictureBoxVer1.BackColor = Colores.PanelLateral;
            iconPictureBoxVer1.IconColor = Colores.FuenteC;
            iconPictureBoxVer2.Visible = false;
            iconPictureBoxVer2.BackColor = Colores.PanelLateral;
            iconPictureBoxVer2.IconColor = Colores.FuenteC;

        }

        public static bool checkEmail(string sendmail)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(sendmail, sFormato))
            {
                if (Regex.Replace(sendmail, sFormato, String.Empty).Length == 0) return true;
                else return false;
            }
            else return false;
        }



        public void Register()
        {
            Variables.Name = textname.Text;
            Variables.Last_name = textlastname.Text;
            Variables.NUser = textuser.Text;
            Variables.Email = textcorreo.Text;
            Variables.Password = Contraseña.Text;
            if (Contraseña.Text == textConfirmar.Text)
            {
                if (checkEmail(textcorreo.Text) == false) MessageBox.Show("El correo " + Variables.Email + "es inválido!", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    try
                    {
                        string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;
                        using (SqlConnection connection = new SqlConnection(cadena))
                        {
                            connection.Open();
                            string consulta = "IF NOT EXISTS(SELECT NUser FROM users WHERE NUser= '" + Variables.NUser + "') " + "INSERT INTO users VALUES('" + Variables.Name + "','" + Variables.Last_name + "','" + Variables.NUser + "','" + Variables.Email + "','" + Variables.Password + "')";
                            using (SqlCommand command = new SqlCommand(consulta, connection))
                            {
                                command.ExecuteNonQuery();
                                if (command.ExecuteNonQuery() != 1) MessageBox.Show("El Usuario " + Variables.NUser + " ya existe!", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                else
                                {
                                    connection.Close();
                                    MessageBox.Show("Registro creado");
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                
            }
            else MessageBox.Show("Las contraseñas no coinciden");
        }

        private void Registrar_Click(object sender, EventArgs e)
        {
            Register();
        }

        private void textname_Enter(object sender, EventArgs e)
        {
            if (textname.Text == "NOMBRE")
            {
                textname.Text = "";
                textname.ForeColor = Colores.FuenteC;
            }
        }

        private void textname_Leave(object sender, EventArgs e)
        {
            if (textname.Text == "")
            {
                textname.Text = "NOMBRE";
                textname.ForeColor = Color.DimGray;
            }
        }

        private void textlastname_Enter(object sender, EventArgs e)
        {
            if (textlastname.Text == "APELLIDO")
            {
                textlastname.Text = "";
                textlastname.ForeColor = Colores.FuenteC;
            }
        }

        private void textlastname_Leave(object sender, EventArgs e)
        {
            if (textlastname.Text == "")
            {
                textlastname.Text = "APELLIDO";
                textlastname.ForeColor = Color.DimGray;
            }
        }

        private void textuser_Enter(object sender, EventArgs e)
        {
            if (textuser.Text == "USUARIO")
            {
                textuser.Text = "";
                textuser.ForeColor = Colores.FuenteC;
            }
        }

        private void textuser_Leave(object sender, EventArgs e)
        {
            if (textuser.Text == "")
            {
                textuser.Text = "USUARIO";
                textuser.ForeColor = Color.DimGray;
            }
        }

        private void email_Enter(object sender, EventArgs e)
        {
            if (textConfirmar.Text == "CONFIRMAR CONTRASEÑA")
            {
                textConfirmar.Text = "";
                textConfirmar.ForeColor = Colores.FuenteC;
                textConfirmar.PasswordChar = '*';
                iconPictureBoxNVer2.Visible = true;
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (textConfirmar.Text == "")
            {
                textConfirmar.Text = "CONFIRMAR CONTRASEÑA";
                textConfirmar.ForeColor = Color.DimGray;
                textConfirmar.PasswordChar = '\0';
                iconPictureBoxNVer2.Visible = false;
            }
        }

        private void Contraseña_Enter(object sender, EventArgs e)
        {
            if (Contraseña.Text == "CONTRASEÑA")
            {
                Contraseña.Text = "";
                Contraseña.ForeColor = Colores.FuenteC;
                Contraseña.PasswordChar = '*';
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
        private void Correo_Enter(object sender, EventArgs e)
        {
            if (textcorreo.Text == "CORREO")
            {
                textcorreo.Text = "";
                textcorreo.ForeColor = Colores.FuenteC;
            }
        }
        private void Correo_Leave(object sender, EventArgs e)
        {
            if (textcorreo.Text == "")
            {
                textcorreo.Text = "CORREO";
                textcorreo.ForeColor = Color.DimGray;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {   if (textname.Text == "NOMBRE")
                MessageBox.Show("El campo NOMBRE está vacío");
            if (textlastname.Text == "APELLIDO")
                MessageBox.Show("El campo APELLIDO está vacío");
            if (textuser.Text == "USUARIO")
                MessageBox.Show("El campo USUARIO está vacío");
            if (textcorreo.Text == "CORREO")
                MessageBox.Show("El campo CORREO está vacío");
            if (Contraseña.Text == "CONTRASEÑA")
                MessageBox.Show("El campo CONTRASEÑA está vacío");
            if (textConfirmar.Text == "CONFIRMAR CONTRASEÑA")
                MessageBox.Show("El campo CONFIRMAR CONTRASEÑA está vació");
            else
                Register();
        }

        private void PanelP_Click(object sender, EventArgs e)
        {
            textname.Text = "NOMBRE";
            textname.ForeColor = Color.DimGray;
            textlastname.Text = "APELLIDO";
            textlastname.ForeColor = Color.DimGray;
            textuser.Text = "USUARIO";
            textuser.ForeColor = Color.DimGray;
            textcorreo.Text = "CORREO";
            textcorreo.ForeColor = Color.DimGray;
            Contraseña.Text = "CONTRASEÑA";
            Contraseña.ForeColor = Color.DimGray;
            Contraseña.PasswordChar = '\0';
            textConfirmar.Text = "CONFIRMAR CONTRASEÑA";
            textConfirmar.ForeColor = Color.DimGray;
            textConfirmar.PasswordChar = '\0';
            iconPictureBoxVer2.Visible = false;
            iconPictureBoxNVer1.Visible = false;
            iconPictureBoxVer1.Visible = false;
            iconPictureBoxNVer2.Visible = false;
        }
    }
}
