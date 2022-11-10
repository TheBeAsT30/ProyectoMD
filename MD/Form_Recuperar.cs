using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Text.RegularExpressions;

namespace MD
{
    public partial class Form_Recuperar : Form
    {
        const string USER = "soportelibreriapnt@gmail.com";
        const string PASSWORD = "kgojkwerbvjrcgxo";
        public Form_Recuperar()
        {
            InitializeComponent();
        }
        string color = Properties.Settings.Default.Tema;

        private void Form_Recuperar_Load(object sender, EventArgs e)
        {            
            Colores.ElegirColor(color);
            Enviar.BackColor = Colores.PanelLateral;
            panel1.BackColor = Colores.PanelPrincipal;
            Enviar.ForeColor = Colores.FuenteC;
            Enviar.IconColor = Colores.FuenteC;
            Validar.ForeColor = Colores.FuenteC;
            Validar.IconColor = Colores.FuenteC;
            Validar.BackColor = Colores.PanelLateral;
            label1.ForeColor = Colores.FuenteC;
            label2.ForeColor = Colores.FuenteC;
            label4.ForeColor = Colores.FuenteC;
            labelMensaje.ForeColor = Colores.FuenteC;
            textmessage.BackColor = Colores.PanelLateral;
            textCode.BackColor = Colores.PanelLateral;
            iconPictureBox1.IconColor = Colores.FuenteC;
            iconPictureBox2.IconColor = Colores.FuenteC;
        }

        public static void EnviarCorreo(StringBuilder message, DateTime dateTime, string of, string by, string affair, out string Error)
        {
            Error = "";
            try
            {
                message.Append(Environment.NewLine);
                message.Append(string.Format("\nEste correo ha sido enviado el día {0:dd/MM/yyyy} a las {0:HH:mm:ss} Hrs: \n\n", dateTime));
                message.Append(Environment.NewLine);
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(of);
                mail.To.Add(by);
                mail.Subject = affair;
                mail.Body = message.ToString();
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new System.Net.NetworkCredential(USER, PASSWORD);
                smtp.EnableSsl = true;
                smtp.Send(mail);
                Error = "Envío exitoso";
                MessageBox.Show(Error);
            }
            catch (Exception ex)
            {
                Error = "Erro: " + ex.Message;
                MessageBox.Show(Error);
                throw;
            }
        }

        private int GeneararCodigo(int code)
        {
            for (int i = 0; i < 1; i++)
            {
                var guid = Guid.NewGuid();
                var justNumbers = new String(guid.ToString().Where(Char.IsDigit).ToArray());
                code = int.Parse(justNumbers.Substring(0, 4));
            }
            return code;
        }
        public static bool checkEmail(string seMailAComprobar)
        {
            String sFormato;
            sFormato = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(seMailAComprobar, sFormato))
            {
                if (Regex.Replace(seMailAComprobar, sFormato, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        int c = 0;
        private void Enviar_Click(object sender, EventArgs e)
        {
            if (checkEmail(textmessage.Text) == false) MessageBox.Show("El correo " + Variables.Email + "es inválido!", "Error:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                int code = 0;
                c = GeneararCodigo(code);
                Variables.Email = textmessage.Text;
                string Error = "";
                string body = "\nHemos recibido tu solicitud de recuperación de contraseña para tu cuenta\n" +
        "Tu codigo es " + c;
                string message = "Hola, " + textmessage.Text + body;
                string of = USER;
                string by = textmessage.Text;
                string affair = "Recuperación de Contraseña";
                StringBuilder stringBuilder = new StringBuilder();
                stringBuilder.Append(message);
                EnviarCorreo(stringBuilder, DateTime.Now, of.Trim(), by.Trim(), affair.Trim(), out Error);
            }                
        }

        private void textCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;            
            if (textCode.TextLength > 3) e.Handled = true;
            if (e.KeyChar == (char)Keys.Back) e.Handled = false;

        }

        private void textCode_Enter(object sender, EventArgs e)
        {
            if (textCode.Text == "CODIGO")
            {
                textCode.Text = "";
                textCode.ForeColor = Colores.FuenteC;
            }
        }

        private void textCode_Leave(object sender, EventArgs e)
        {
            if (textCode.Text == "")
            {
                textCode.Text = "CODIGO";
                textCode.ForeColor = Color.DimGray;
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {          
            if (textCode.Text == Convert.ToString(c))
            {
                Form_NuevoPass nuevoPass = new Form_NuevoPass();
                nuevoPass.ShowDialog();
                this.Hide();
            }
            else respuesta.Text = "Código incorrecto\nIntente de nuevo";
        }

        private void textmessage_Enter(object sender, EventArgs e)
        {
            if(textmessage.Text == "CORREO")
            {
                textmessage.Text = "";
                textmessage.ForeColor = Colores.FuenteC;
            }
        }

        private void textmessage_Leave(object sender, EventArgs e)
        {
            if (textmessage.Text == "")
            {
                textmessage.Text = "CORREO";
                textmessage.ForeColor = Color.DimGray;
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            textmessage.Text = "CORREO";
            textmessage.ForeColor = Color.DimGray;
            textCode.Text = "CODIGO";
            textCode.ForeColor = Color.DimGray;
        }
    }
}