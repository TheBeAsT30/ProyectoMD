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
        private void Form_Test_Load(object sender, EventArgs e)
        {
            #region->Capitulo 1
            /*Colores.ElegirColor(color);
            panelCap1.BackColor = Colores.PanelPrincipal;
            label1.ForeColor = Colores.FuenteC;
            listBoxart1.ForeColor = Colores.FuenteC;
            listBoxart2.ForeColor = Colores.FuenteC;
            listBoxart3.ForeColor = Colores.FuenteC;
            listBoxart1.BackColor = Colores.PanelPrincipal;
            listBoxart2.BackColor = Colores.PanelPrincipal;
            listBoxart3.BackColor = Colores.PanelPrincipal;*/
            #endregion
        }

        private void datosmoto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
