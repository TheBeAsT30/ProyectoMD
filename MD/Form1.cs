namespace MD
{
    public partial class Panel : Form
    {
        public Panel()
        {
            InitializeComponent();
        }
        string color = Properties.Settings.Default.Tema;
        string contrase�aa = "Hola";
        string usuarioo = "Sergio";
        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PanelP_Load(object sender, EventArgs e)
        {
            #region ->Color
            Colores.ElegirColor(color);
            PanelP.BackColor = Colores.PanelPrincipal;
            PanelS.BackColor = Colores.PanelSuperior;
            PanelL.BackColor = Colores.PanelLateral;
            Ingresar.BackColor = Colores.BotonesP;
            Usuario.BackColor = Colores.PanelLateral;
            Contrase�a.BackColor = Colores.PanelLateral;
            Label1.ForeColor = Colores.Fuente;
            Label2.ForeColor = Colores.Fuente;
            Label4.ForeColor = Colores.Fuente;
            Label5.ForeColor = Colores.FuenteA;
            Label3.ForeColor = Colores.FuenteA;
            Minimizar.BackColor = Colores.BackImagen;
            Cerrar.BackColor = Colores.BackImagen;
            Usuario.ForeColor = Colores.Fuente;
            Contrase�a.ForeColor = Colores.Fuente;
            Ingresar.ForeColor = Colores.Fuente;
            #endregion
        }
        private void ojoM_Click(object sender, EventArgs e)
        {
            ojoM.Visible = false;
            ojoO.Visible = true;
            Contrase�a.PasswordChar = '\0';      
        }

        private void ojoO_Click(object sender, EventArgs e)
        {
            ojoM.Visible = true;
            ojoO.Visible = false;
            Contrase�a.PasswordChar = '*';
        }

        private void PanelP_MouseLeave(object sender, EventArgs e)
        {

        }
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

        private void Ingresar_Click(object sender, EventArgs e)
        {
            if (Contrase�a.Text == contrase�aa && Usuario.Text == usuarioo)
            {
                Principal frm = new Principal();
                frm.Show();
                this.Hide();
            }
            else
            {
                Label5.Visible = true;
            }
        }

        private void Usuario_TextChanged(object sender, EventArgs e)
        {
            Label5.Visible = false;
        }

        private void Contrase�a_TextAlignChanged(object sender, EventArgs e)
        {

        }

        private void Contrase�a_TextChanged(object sender, EventArgs e)
        {
            Label5.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}