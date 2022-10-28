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
    public partial class Form_Test : Form
    {
        public Form_Test()
        {
            InitializeComponent();
        }
        string color = Properties.Settings.Default.Tema;
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form_temas_Load(object sender, EventArgs e)
        {
            #region ->Color        
            if (Variables.Opcion == "Amarillo")
            {
                /*Properties.Settings.Default["Tema"] = "Amarillo";
                Properties.Settings.Default.Save();
                color = Properties.Settings.Default.Tema;*/                    
                Colores.ElegirColor(color);
                PanelT.BackColor = Colores.PanelTemas;
            }
            #endregion
        }
    }
}
