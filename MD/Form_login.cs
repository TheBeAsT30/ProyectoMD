using MySql.Data.MySqlClient;
using System.Configuration;

namespace MD
{
    public partial class Form_login : Form
    {

        public Form_login()
        {
            InitializeComponent();
        }
        string color = Properties.Settings.Default.Tema;

        int posY = 0;
        int posX = 0;
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

        public void Datos()
        {
            try
            {
                string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;
                MySqlConnection connection = new MySqlConnection(cadena);
                connection.Open();     
                
                MySqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT Name, Last_name, Score FROM users WHERE NUser= @user";
                command.CommandType = System.Data.CommandType.Text;                                
                command.Parameters.Add(new MySqlParameter("@user", Usuario.Text));
                
                MySqlDataReader dataReader = command.ExecuteReader();
                    
                while(dataReader.Read())
                {                                
                    Variables.Name = (string)dataReader["Name"];                
                    Variables.Last_name = (string)dataReader["Last_name"];
                    Variables.Process = (int)dataReader["Score"];
                }
                dataReader.Close();
                command.Dispose();
                connection.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
        }
        public void Login()
        {
            Variables.NUser = Usuario.Text;
            Variables.Email = Usuario.Text;
            Variables.Password = Contraseña.Text;
            try
            {
                string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;
                using (MySqlConnection connection = new MySqlConnection(cadena))
                {
                    connection.Open();
                    string consulta = "SELECT NUser, AES_DECRYPT(Password, '" + Variables.Code + "') FROM users WHERE BINARY NUser='" + Variables.NUser + "' AND AES_DECRYPT(Password, '" + Variables.Code + "')='" + Variables.Password + "'OR BINARY Email='" + Variables.Email + "'AND AES_DECRYPT(Password, '" + Variables.Code + "')='" + Variables.Password + "'";

                    using (MySqlCommand command = new MySqlCommand(consulta, connection))
                    {
                        MySqlDataReader dataReader;
                        dataReader = command.ExecuteReader();
                        if (dataReader.Read())
                        {
                            GUI_Moderno.FormPresentacion pre = new GUI_Moderno.FormPresentacion();
                            pre.ShowDialog();
                            this.Hide();
                            Form_principal frm = new Form_principal();
                            frm.Show();
                            this.Hide();                                                        
                        }
                        else
                        {
                            MensajeError("Usuario o Contraseña incorrecto.\n Porfavor intente denuevo");
                          
                        }

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
                Console.Write(ex);
            }
        }
        private void MensajeError(string mensaje)
        {
            Label5.Text = " " + mensaje;
            Label5.Visible = true;
            Contraseña.Text = "CONTRASEÑA";
            Usuario.Text = "USUARIO O CORREO";
            Contraseña.PasswordChar = '\0';
            Usuario.ForeColor = Color.DimGray;
            Contraseña.ForeColor = Color.DimGray;

        }

        private void Usuario_Enter(object sender, EventArgs e)
        {
            if (Usuario.Text == "USUARIO O CORREO")
            {
                Usuario.Text = "";
                Usuario.ForeColor = Colores.FuenteC;
            }
        }

        private void Usuario_Leave(object sender, EventArgs e)
        {
            if (Usuario.Text == "")
            {
                Usuario.Text = "USUARIO O CORREO";
                Usuario.ForeColor = Color.DimGray;
            }
        }

        private void Contraseña_Enter(object sender, EventArgs e)
        {
            if (Contraseña.Text == "CONTRASEÑA")
            {
                Contraseña.Text = "";
                Contraseña.ForeColor = Colores.FuenteC;
                //Contraseña.UseSystemPasswordChar = true;
                Contraseña.PasswordChar = '*';
                iconPictureBox4.Visible = true;
            }
        }

        private void Contraseña_Leave(object sender, EventArgs e)
        {
            if (Contraseña.Text == "")
            {
                Contraseña.Text = "CONTRASEÑA";
                Contraseña.ForeColor = Color.DimGray;
                //Contraseña.UseSystemPasswordChar = false;
                Contraseña.PasswordChar = '\0';
                iconPictureBox4.Visible = false;
            }
        }

        private void PanelP_DoubleClick(object sender, EventArgs e)
        {
            Usuario.Text = "USUARIO O CORREO";
            Usuario.ForeColor = Color.DimGray;
            Contraseña.Text = "CONTRASEÑA";
            Contraseña.ForeColor = Color.DimGray;
            Contraseña.PasswordChar = '\0';
            //iconPictureBox3.Visible = false;
            //iconPictureBox4.Visible = false;
            iconPictureBox4.Visible = false;

        }
        private void CerrarCesion(object sender, FormClosedEventArgs e)
        {
            Usuario.Text = "USUARIO O CORREO";
            //Contraseña.UseSystemPasswordChar = false;         
            Contraseña.Text = "CONTRASEÑA";
            this.Show();
            Usuario.Focus();
        }

        private void iconPictureBox3_Click(object sender, EventArgs e)
        {
            iconPictureBox3.Visible = false;
            iconPictureBox4.Visible = true;
            Contraseña.PasswordChar = '*';
        }

        private void iconPictureBox4_Click(object sender, EventArgs e)
        {
            iconPictureBox3.Visible = true;
            iconPictureBox4.Visible = false;
            Contraseña.PasswordChar = '\0';
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Abrirformulario<Form_Register>();
        }
        private void Abrirformulario<MiForm>() where MiForm : Form, new()
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

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Cerrar<Form_Register>();
            Cerrar<Form_Recuperar>();
        }
        private void Cerrar<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = PanelP.Controls.OfType<MiForm>().FirstOrDefault();
            if (formulario != null)
            {
                formulario.Close();
            }
        }

        private void iconPictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void iconPictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            Datos();
            Login();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Abrirformulario<Form_Recuperar>();

        }

        private void Form_login_Load(object sender, EventArgs e)
        {
            #region ->Color
            Colores.ElegirColor(color);
            PanelP.BackColor = Colores.PanelPrincipal;
            Usuario.BackColor = Colores.PanelLateral;
            Contraseña.BackColor = Colores.PanelLateral;
            iconPictureBox1.BackColor = Colores.PanelLateral;
            iconPictureBox1.ForeColor = Colores.FuenteC;
            iconPictureBox2.BackColor = Colores.PanelLateral;
            iconPictureBox2.ForeColor = Colores.FuenteC;
            iconPictureBox3.BackColor = Colores.PanelLateral;
            iconPictureBox4.BackColor = Colores.PanelLateral;
            panelLogin.BackColor = Colores.PanelPrincipal;
            Label5.ForeColor = Colores.FuenteC;
            linkLabel1.LinkColor = Colores.FuenteC;
            Acceder.ForeColor = Colores.FuenteC;
            Acceder.IconColor = Colores.FuenteC;
            Acceder.BackColor = Colores.PanelLateral;
            iconButton1.BackColor = Colores.BotonesS;
            iconButton2.BackColor = Colores.BotonesS;
            iconButton1.ForeColor = Colores.FuenteC;
            iconButton2.ForeColor = Colores.FuenteC;
            iconButton1.IconColor = Colores.FuenteC;
            iconButton2.IconColor = Colores.FuenteC;
            iconPictureBox4.IconColor = Colores.FuenteC;
            iconPictureBox3.IconColor = Colores.FuenteC;
            PanelB.BackColor = Colores.PanelPrincipal;
            #endregion
            iconPictureBox3.Visible = false;
            iconPictureBox4.Visible = false;
            Contraseña.PasswordChar = '\0';
        }

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
    
    }
}