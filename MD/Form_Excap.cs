using System;
using System.Collections;
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
    public partial class Form_Excap : Form
    {
        public Form_Excap()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }
        private void Form_Estudio_Load(object sender, EventArgs e)
        {
            Variables.Panel = "ExaCap";
            panelPrincipal1.BringToFront();
            Exa1();
            Exa2();
            Exa3();
        }

        #region->Colores de los paneles y demás herramientas
        public void Exa1()
        {
            Colores.ElegirColor(color);
            panelPrincipal1.BackColor = Colores.PanelPrincipal;
            panelL.BackColor = Colores.PanelPrincipal;
            label1.BackColor = Colores.PanelPrincipal;
            label1.ForeColor = Colores.FuenteC;
            label2.BackColor = Colores.PanelPrincipal;
            label2.ForeColor = Colores.FuenteC;
            label3.BackColor = Colores.PanelPrincipal;
            label3.ForeColor = Colores.FuenteC;
            label4.BackColor = Colores.PanelPrincipal;
            label4.ForeColor = Colores.FuenteC;
            label5.BackColor = Colores.PanelPrincipal;
            label5.ForeColor = Colores.FuenteC;
            label6.BackColor = Colores.PanelPrincipal;
            label6.ForeColor = Colores.FuenteC;
            label7.BackColor = Colores.PanelPrincipal;
            label7.ForeColor = Colores.FuenteC;
            label8.BackColor = Colores.PanelPrincipal;
            label8.ForeColor = Colores.FuenteC;
            label9.BackColor = Colores.PanelPrincipal;
            label9.ForeColor = Colores.FuenteC;
            label10.BackColor = Colores.PanelPrincipal;
            label10.ForeColor = Colores.FuenteC;
            label11.BackColor = Colores.PanelPrincipal;
            label11.ForeColor = Colores.FuenteC;
            label12.BackColor = Colores.PanelPrincipal;
            label12.ForeColor = Colores.FuenteC;
            label13.BackColor = Colores.PanelPrincipal;
            label13.ForeColor = Colores.FuenteC;
            label14.BackColor = Colores.PanelPrincipal;
            label14.ForeColor = Colores.FuenteC;
            label15.BackColor = Colores.PanelPrincipal;
            label15.ForeColor = Colores.FuenteC;
            textBoxConceptos.BackColor = Colores.PanelPrincipal;
            textBoxTiposArranceles.BackColor = Colores.PanelPrincipal;

            comboBoxTrasladar.BackColor = Colores.PanelPrincipal;
            comboBoxTrasladar.ForeColor = Colores.FuenteC;
            comboBoxTransporte.BackColor = Colores.PanelPrincipal;
            comboBoxTransporte.ForeColor = Colores.FuenteC;
            comboBoxLeyObjetivo.BackColor = Colores.PanelPrincipal;
            comboBoxLeyObjetivo.ForeColor = Colores.FuenteC;

            textBoxConceptos.ForeColor = Colores.FuenteC;
            textBoxTiposArranceles.ForeColor = Colores.FuenteC;
            textBoxClasificar.ForeColor = Colores.FuenteC;
            textBoxClasificar.BackColor = Colores.PanelPrincipal;
            iconButtonIngresar.BackColor = Colores.PanelSuperior;
            iconButtonIngresar.ForeColor = Colores.FuenteC;
            iconButtonIngresar.IconColor = Colores.FuenteC;
            iconButtonIngresarArranceles.BackColor = Colores.PanelSuperior;
            iconButtonIngresarArranceles.ForeColor = Colores.FuenteC;
            iconButtonIngresarArranceles.IconColor = Colores.FuenteC;
            iconButtonIngresarClasi.BackColor = Colores.PanelSuperior;
            iconButtonIngresarClasi.ForeColor = Colores.FuenteC;
            iconButtonIngresarClasi.IconColor = Colores.FuenteC;
            radioButtonBad.BackColor = Colores.PanelPrincipal;
            radioButtonBad2.BackColor = Colores.PanelPrincipal;
            radioButtonBad3.BackColor = Colores.PanelPrincipal;
            radioButtonGood.BackColor = Colores.PanelPrincipal;
            radioButtonBad.ForeColor = Colores.FuenteC;
            radioButtonBad2.ForeColor = Colores.FuenteC;
            radioButtonBad3.ForeColor = Colores.FuenteC;
            radioButtonGood.ForeColor = Colores.FuenteC;
            radioButtonBad4.BackColor = Colores.PanelPrincipal;
            radioButtonBad5.BackColor = Colores.PanelPrincipal;
            radioButtonBad6.BackColor = Colores.PanelPrincipal;
            radioButtonGood2.BackColor = Colores.PanelPrincipal;
            radioButtonBad4.ForeColor = Colores.FuenteC;
            radioButtonBad5.ForeColor = Colores.FuenteC;
            radioButtonBad6.ForeColor = Colores.FuenteC;
            radioButtonGood2.ForeColor = Colores.FuenteC;
            radioButtonBad7.ForeColor = Colores.FuenteC;
            radioButtonBad8.ForeColor = Colores.FuenteC;
            radioButtonBad9.ForeColor = Colores.FuenteC;
            radioButtonBad10.ForeColor = Colores.FuenteC;
            radioButtonBad11.ForeColor = Colores.FuenteC;
            radioButtonBad12.ForeColor = Colores.FuenteC;
            radioButtonBad13.ForeColor = Colores.FuenteC;         
            radioButtonGood3.ForeColor = Colores.FuenteC;
            radioButtonBad14.ForeColor = Colores.FuenteC;
            radioButtonBad15.ForeColor = Colores.FuenteC;
            radioButtonBad16.ForeColor = Colores.FuenteC;
            radioButtonBad17.ForeColor = Colores.FuenteC;
            radioButtonBad18.ForeColor = Colores.FuenteC;
            radioButtonBad19.ForeColor = Colores.FuenteC;
            radioButtonBad20.ForeColor = Colores.FuenteC;
            radioButtonBad21.ForeColor = Colores.FuenteC;
            radioButtonBad22.ForeColor = Colores.FuenteC;
            radioButtonBad23.ForeColor = Colores.FuenteC;
            radioButtonBad24.ForeColor = Colores.FuenteC;
            radioButtonBad25.ForeColor = Colores.FuenteC;
            radioButtonBad26.ForeColor = Colores.FuenteC;
            radioButtonBad27.ForeColor = Colores.FuenteC;
            radioButtonGood4.ForeColor = Colores.FuenteC;
            radioButtonGood5.ForeColor = Colores.FuenteC;
            iconButtonNextExa1.BackColor = Colores.PanelSuperior;
            iconButtonNextExa1.ForeColor = Colores.FuenteC;
            iconButtonNextExa1.IconColor = Colores.FuenteC;            
        }

        public void Exa2()
        {
            Colores.ElegirColor(color);
            panelPrincipal2.BackColor = Colores.PanelPrincipal;
            label16.BackColor = Colores.PanelPrincipal;
            label16.ForeColor = Colores.FuenteC;
            label17.BackColor = Colores.PanelPrincipal;
            label17.ForeColor = Colores.FuenteC;
            label18.BackColor = Colores.PanelPrincipal;
            label18.ForeColor = Colores.FuenteC;
            label19.BackColor = Colores.PanelPrincipal;
            label19.ForeColor = Colores.FuenteC;
            label20.BackColor = Colores.PanelPrincipal;
            label20.ForeColor = Colores.FuenteC;
            label21.BackColor = Colores.PanelPrincipal;
            label21.ForeColor = Colores.FuenteC;
            label22.BackColor = Colores.PanelPrincipal;
            label22.ForeColor = Colores.FuenteC;
            label23.BackColor = Colores.PanelPrincipal;
            label23.ForeColor = Colores.FuenteC;
            label24.BackColor = Colores.PanelPrincipal;
            label24.ForeColor = Colores.FuenteC;
            label25.BackColor = Colores.PanelPrincipal;
            label25.ForeColor = Colores.FuenteC;
            label26.BackColor = Colores.PanelPrincipal;
            label26.ForeColor = Colores.FuenteC;
            label27.BackColor = Colores.PanelPrincipal;
            label27.ForeColor = Colores.FuenteC;
            label28.BackColor = Colores.PanelPrincipal;
            label28.ForeColor = Colores.FuenteC;
            label29.BackColor = Colores.PanelPrincipal;
            label29.ForeColor = Colores.FuenteC;
            label30.BackColor = Colores.PanelPrincipal;
            label30.ForeColor = Colores.FuenteC;
            label31.BackColor = Colores.PanelPrincipal;
            label31.ForeColor = Colores.FuenteC;
            label32.BackColor = Colores.PanelPrincipal;
            label32.ForeColor = Colores.FuenteC;
            label33.BackColor = Colores.PanelPrincipal;
            label33.ForeColor = Colores.FuenteC;
            label34.BackColor = Colores.PanelPrincipal;
            label34.ForeColor = Colores.FuenteC;

            listBox1.BackColor = Colores.PanelPrincipal;
            listBox1.ForeColor = Colores.FuenteC;
            listBox2.BackColor = Colores.PanelPrincipal;
            listBox2.ForeColor = Colores.FuenteC;
            listBox3.BackColor = Colores.PanelPrincipal;
            listBox3.ForeColor = Colores.FuenteC;

            checkBoxGood1.BackColor = Colores.PanelPrincipal;
            checkBoxGood2.BackColor = Colores.PanelPrincipal;
            checkBoxGood3.BackColor = Colores.PanelPrincipal;
            checkBoxGood4.BackColor = Colores.PanelPrincipal;
            checkBoxGood5.BackColor = Colores.PanelPrincipal;
            checkBoxGood6.BackColor = Colores.PanelPrincipal;
            checkBoxGood1.ForeColor = Colores.FuenteC;
            checkBoxGood2.ForeColor = Colores.FuenteC;
            checkBoxGood3.ForeColor = Colores.FuenteC;
            checkBoxGood4.ForeColor = Colores.FuenteC;
            checkBoxGood5.ForeColor = Colores.FuenteC;
            checkBoxGood6.ForeColor = Colores.FuenteC;
            checkBoxBad1.BackColor = Colores.PanelPrincipal;
            checkBoxBad2.BackColor = Colores.PanelPrincipal;
            checkBoxBad3.BackColor = Colores.PanelPrincipal;
            checkBoxBad4.BackColor = Colores.PanelPrincipal;
            checkBoxBad5.BackColor = Colores.PanelPrincipal;
            checkBoxBad6.BackColor = Colores.PanelPrincipal;
            checkBoxBad7.BackColor = Colores.PanelPrincipal;
            checkBoxBad8.BackColor = Colores.PanelPrincipal;
            checkBoxBad9.BackColor = Colores.PanelPrincipal;
            checkBoxBad10.BackColor = Colores.PanelPrincipal;
            checkBoxBad11.BackColor = Colores.PanelPrincipal;
            checkBoxBad12.BackColor = Colores.PanelPrincipal;
            checkBoxBad13.BackColor = Colores.PanelPrincipal;
            checkBoxBad14.BackColor = Colores.PanelPrincipal;
            checkBoxBad15.BackColor = Colores.PanelPrincipal;
            checkBoxBad16.BackColor = Colores.PanelPrincipal;
            checkBoxBad17.BackColor = Colores.PanelPrincipal;
            checkBoxBad18.BackColor = Colores.PanelPrincipal;
            checkBoxBad19.BackColor = Colores.PanelPrincipal;
            checkBoxBad20.BackColor = Colores.PanelPrincipal;
            checkBoxBad21.BackColor = Colores.PanelPrincipal;
            checkBoxBad22.BackColor = Colores.PanelPrincipal;
            checkBoxBad23.BackColor = Colores.PanelPrincipal;
            checkBoxBad24.BackColor = Colores.PanelPrincipal;
            checkBoxBad25.BackColor = Colores.PanelPrincipal;
            checkBoxBad26.BackColor = Colores.PanelPrincipal;
            checkBoxBad27.BackColor = Colores.PanelPrincipal;
            checkBoxBad28.BackColor = Colores.PanelPrincipal;
            checkBoxBad29.BackColor = Colores.PanelPrincipal;
            checkBoxBad30.BackColor = Colores.PanelPrincipal;
            checkBoxBad31.BackColor = Colores.PanelPrincipal;
            checkBoxBad32.BackColor = Colores.PanelPrincipal;
            checkBoxBad33.BackColor = Colores.PanelPrincipal;
            checkBoxBad34.BackColor = Colores.PanelPrincipal;
            checkBoxBad35.BackColor = Colores.PanelPrincipal;
            checkBoxBad36.BackColor = Colores.PanelPrincipal;

            checkBoxBad1.ForeColor = Colores.FuenteC;
            checkBoxBad2.ForeColor = Colores.FuenteC;
            checkBoxBad3.ForeColor = Colores.FuenteC;
            checkBoxBad4.ForeColor = Colores.FuenteC;
            checkBoxBad5.ForeColor = Colores.FuenteC;
            checkBoxBad6.ForeColor = Colores.FuenteC;
            checkBoxBad7.ForeColor = Colores.FuenteC;
            checkBoxBad8.ForeColor = Colores.FuenteC;
            checkBoxBad9.ForeColor = Colores.FuenteC;
            checkBoxBad10.ForeColor = Colores.FuenteC;
            checkBoxBad11.ForeColor = Colores.FuenteC;
            checkBoxBad12.ForeColor = Colores.FuenteC;
            checkBoxBad13.ForeColor = Colores.FuenteC;
            checkBoxBad14.ForeColor = Colores.FuenteC;
            checkBoxBad15.ForeColor = Colores.FuenteC;
            checkBoxBad16.ForeColor = Colores.FuenteC;
            checkBoxBad17.ForeColor = Colores.FuenteC;
            checkBoxBad18.ForeColor = Colores.FuenteC;
            checkBoxBad19.ForeColor = Colores.FuenteC;
            checkBoxBad20.ForeColor = Colores.FuenteC;
            checkBoxBad21.ForeColor = Colores.FuenteC;
            checkBoxBad22.ForeColor = Colores.FuenteC;
            checkBoxBad23.ForeColor = Colores.FuenteC;
            checkBoxBad24.ForeColor = Colores.FuenteC;
            checkBoxBad25.ForeColor = Colores.FuenteC;
            checkBoxBad26.ForeColor = Colores.FuenteC;
            checkBoxBad27.ForeColor = Colores.FuenteC;
            checkBoxBad28.ForeColor = Colores.FuenteC;
            checkBoxBad29.ForeColor = Colores.FuenteC;
            checkBoxBad30.ForeColor = Colores.FuenteC;
            checkBoxBad31.ForeColor = Colores.FuenteC;
            checkBoxBad32.ForeColor = Colores.FuenteC;
            checkBoxBad33.ForeColor = Colores.FuenteC;
            checkBoxBad34.ForeColor = Colores.FuenteC;
            checkBoxBad35.ForeColor = Colores.FuenteC;
            checkBoxBad36.ForeColor = Colores.FuenteC;

            radioButtonGood6.BackColor = Colores.PanelPrincipal;
            radioButtonGood6.ForeColor = Colores.FuenteC;
            radioButtonGood8.BackColor = Colores.PanelPrincipal;
            radioButtonGood8.ForeColor = Colores.FuenteC;
            radioButtonGood7.BackColor = Colores.PanelPrincipal;
            radioButtonGood7.ForeColor = Colores.FuenteC;

            radioButtonBad28.BackColor = Colores.PanelPrincipal;
            radioButtonBad29.BackColor = Colores.PanelPrincipal;
            radioButtonBad30.BackColor = Colores.PanelPrincipal;
            radioButtonBad31.BackColor = Colores.PanelPrincipal;
            radioButtonBad32.BackColor = Colores.PanelPrincipal;
            radioButtonBad33.BackColor = Colores.PanelPrincipal;
            radioButtonBad34.BackColor = Colores.PanelPrincipal;
            radioButtonBad35.BackColor = Colores.PanelPrincipal;
            radioButtonBad36.BackColor = Colores.PanelPrincipal;
            radioButtonBad37.BackColor = Colores.PanelPrincipal;
            radioButtonBad38.BackColor = Colores.PanelPrincipal;

            radioButtonBad28.ForeColor = Colores.FuenteC;
            radioButtonBad29.ForeColor = Colores.FuenteC;
            radioButtonBad30.ForeColor = Colores.FuenteC;
            radioButtonBad31.ForeColor = Colores.FuenteC;
            radioButtonBad32.ForeColor = Colores.FuenteC;
            radioButtonBad33.ForeColor = Colores.FuenteC;
            radioButtonBad34.ForeColor = Colores.FuenteC;
            radioButtonBad35.ForeColor = Colores.FuenteC;
            radioButtonBad36.ForeColor = Colores.FuenteC;
            radioButtonBad37.ForeColor = Colores.FuenteC;
            radioButtonBad38.ForeColor = Colores.FuenteC;

            comboBoxSeguridad.BackColor = Colores.PanelPrincipal;
            comboBoxSeguridad.ForeColor = Colores.FuenteC;
            comboBoxCarnet.BackColor = Colores.PanelPrincipal;
            comboBoxCarnet.ForeColor = Colores.FuenteC;

            textBoxurbano.BackColor = Colores.PanelPrincipal;
            textBoxpistas.BackColor = Colores.PanelPrincipal;
            textBoxcarretera.BackColor = Colores.PanelPrincipal;
            textBoxurbano.ForeColor = Colores.FuenteC;
            textBoxpistas.ForeColor = Colores.FuenteC;
            textBoxcarretera.ForeColor = Colores.FuenteC;
            iconButtonIngresarVelocidad.BackColor = Colores.PanelSuperior;
            iconButtonIngresarVelocidad.ForeColor = Colores.FuenteC;
            iconButtonIngresarVelocidad.IconColor = Colores.FuenteC;
            iconButtoncarnet.BackColor = Colores.PanelSuperior;
            iconButtoncarnet.ForeColor = Colores.FuenteC;
            iconButtoncarnet.IconColor = Colores.FuenteC;

        }

        public void Exa3()
        {
            Colores.ElegirColor(color);
            panelPrincipal3.BackColor = Colores.PanelPrincipal;
            label35.BackColor = Colores.PanelPrincipal;
            label35.ForeColor = Colores.FuenteC;
            label36.BackColor = Colores.PanelPrincipal;
            label36.ForeColor = Colores.FuenteC;
            label37.BackColor = Colores.PanelPrincipal;
            label37.ForeColor = Colores.FuenteC;
            label38.BackColor = Colores.PanelPrincipal;
            label38.ForeColor = Colores.FuenteC;
            label39.BackColor = Colores.PanelPrincipal;
            label39.ForeColor = Colores.FuenteC;
            label40.BackColor = Colores.PanelPrincipal;
            label40.ForeColor = Colores.FuenteC;
            label41.BackColor = Colores.PanelPrincipal;
            label41.ForeColor = Colores.FuenteC;
            label42.BackColor = Colores.PanelPrincipal;
            label42.ForeColor = Colores.FuenteC;
            label43.BackColor = Colores.PanelPrincipal;
            label43.ForeColor = Colores.FuenteC;
            label44.BackColor = Colores.PanelPrincipal;
            label44.ForeColor = Colores.FuenteC;

            checkBoxGood8.BackColor = Colores.PanelPrincipal;
            checkBoxBad37.BackColor = Colores.PanelPrincipal;
            checkBoxBad38.BackColor = Colores.PanelPrincipal;
            checkBoxBad39.BackColor = Colores.PanelPrincipal;

            checkBoxGood8.ForeColor = Colores.FuenteC;
            checkBoxBad37.ForeColor = Colores.FuenteC;
            checkBoxBad38.ForeColor = Colores.FuenteC;
            checkBoxBad39.ForeColor = Colores.FuenteC;

            checkBoxGood9.BackColor = Colores.PanelPrincipal;
            checkBoxGood10.BackColor = Colores.PanelPrincipal;
            checkBoxBad40.BackColor = Colores.PanelPrincipal;
            checkBoxBad41.BackColor = Colores.PanelPrincipal;
            checkBoxBad42.BackColor = Colores.PanelPrincipal;
            checkBoxBad43.BackColor = Colores.PanelPrincipal;
            checkBoxBad44.BackColor = Colores.PanelPrincipal;
            checkBoxBad45.BackColor = Colores.PanelPrincipal;

            checkBoxGood9.ForeColor = Colores.FuenteC;
            checkBoxGood10.ForeColor = Colores.FuenteC;
            checkBoxBad40.ForeColor = Colores.FuenteC;
            checkBoxBad41.ForeColor = Colores.FuenteC;
            checkBoxBad42.ForeColor = Colores.FuenteC;
            checkBoxBad43.ForeColor = Colores.FuenteC;
            checkBoxBad44.ForeColor = Colores.FuenteC;
            checkBoxBad45.ForeColor = Colores.FuenteC;

            comboBoxpeatones.BackColor = Colores.PanelPrincipal;
            comboBoxpeatones.ForeColor = Colores.FuenteC;
            comboBox17.BackColor = Colores.PanelPrincipal;
            comboBox17.ForeColor = Colores.FuenteC;

            textBoxIngrearLast.BackColor = Colores.PanelPrincipal;
            textBoxIngrearLast.ForeColor = Colores.FuenteC;

            iconButtonIngresarPeatones.BackColor = Colores.PanelSuperior;
            iconButtonIngresarPeatones.ForeColor = Colores.FuenteC;
            iconButtonIngresarPeatones.IconColor = Colores.FuenteC;
            iconButtonIngresar17.BackColor = Colores.PanelSuperior;
            iconButtonIngresar17.ForeColor = Colores.FuenteC;
            iconButtonIngresar17.IconColor = Colores.FuenteC;
            iconButtonIngresarLast.BackColor = Colores.PanelSuperior;
            iconButtonIngresarLast.ForeColor = Colores.FuenteC;
            iconButtonIngresarLast.IconColor = Colores.FuenteC;
            iconButtonReview.BackColor = Colores.PanelSuperior;
            iconButtonReview.ForeColor = Colores.FuenteC;
            iconButtonReview.IconColor = Colores.FuenteC;
            iconButtonNextExa3.BackColor = Colores.PanelSuperior;
            iconButtonNextExa3.ForeColor = Colores.FuenteC;
            iconButtonNextExa3.IconColor = Colores.FuenteC;
            iconButtonBeforeExa2.BackColor = Colores.PanelSuperior;
            iconButtonBeforeExa2.ForeColor = Colores.FuenteC;
            iconButtonBeforeExa2.IconColor = Colores.FuenteC;
            iconButtonBeforeExa3.BackColor = Colores.PanelSuperior;
            iconButtonBeforeExa3.ForeColor = Colores.FuenteC;
            iconButtonBeforeExa3.IconColor = Colores.FuenteC;
            iconButtonCerrarExa3.BackColor = Colores.PanelSuperior;
            iconButtonCerrarExa3.ForeColor = Colores.FuenteC;
            iconButtonCerrarExa3.IconColor = Colores.FuenteC;
        }
        #endregion

        #region->Funciones Variables, listas y Métodos ultilizados
        ValidarText validar = new ValidarText();
        int i = 0, j = 0, k = 0, l = 0, m = 0, n = 0;
        int cont = 0;
        string color = Properties.Settings.Default.Tema;


        List<string> listaConceptos = new List<string>();
        List<string> listaArranceles = new List<string>();
        List<string> listaClasificar = new List<string>();
        List<string> listaCarnet = new List<string>();
        List<string> listaDerchos = new List<string>();
        List<string> listaLast = new List<string>();
        public void Comprobar1()
        {
            listaConceptos.Add("accidente de transito");
            listaConceptos.Add("aventajamiento");
            listaConceptos.Add("acera o anden");     
            listaConceptos.Add("agente de transito");
            listaConceptos.Add("arcen");
            listaConceptos.Add("angulo de visibilidad");
            listaConceptos.Add("boleta de infracción");
            listaConceptos.Add("calzada");
            listaConceptos.Add("calcomania");
            listaConceptos.Add("calcomania de revisado");
            listaConceptos.Add("conduccion temeraria:");
            listaConceptos.Add("carretera");
            listaConceptos.Add("caminos");
            listaConceptos.Add("carril");
        }

        public void Comprobar2()
        {
            listaArranceles.Add("derecho de matricula y su calcomania");
            listaArranceles.Add("placas");
            listaArranceles.Add("licencia de circulacion");
            listaArranceles.Add("calcomania de revisado");
        }

        public void Comprobar3()
        {
            listaClasificar.Add("de Mayor Peligrosidad");
            listaClasificar.Add("peligrosas");
            listaClasificar.Add("violaciones a las normas de admision al trafico");
        }

        public void Comprobar4()
        {
            listaCarnet.Add("Número de póliza");
            listaCarnet.Add("Hora, fecha de inicio y finalización de la vigencia del seguro");
            listaCarnet.Add("Nombre del propietario del vehículo automotor");
            listaCarnet.Add("Número de la cédula de identidad del titular");
            listaCarnet.Add("Datos de identificación del vehículo automotor conforme la licencia de circulación emitida por la Autoridad de Aplicación de la Ley");
            listaCarnet.Add("Firma autorizada y sello de la aseguradora");
        }

        public void Comprobar5()
        {
            listaDerchos.Add("Presentar reclamo judicial por los daños materiales a terceros");
            listaDerchos.Add("Demandar de la Policía Nacional de Seguridad de Tránsito la protección a sus vidas al momento de cruzar las vías de circulación");
            listaDerchos.Add("Recibir educación e instrucción vial con carácter obligatorio en los centros de educación primaria y secundaria");
            listaDerchos.Add("Exigir a la Policía Nacional de Seguridad de Tránsito, que con carácter obligatorio se establezca un programa nacional para la instrucción y capacitación en educación vial para los conductores de las diferentes empresas de transporte");
            listaDerchos.Add("Exigir a la Policía Nacional de Seguridad de Tránsito la publicación de manuales de instrucción y comportamiento peatonal y de estudio obligatorio en los centros de educación primaria y secundaria");
            listaDerchos.Add("Exigir la señalización de las calles y carreteras del país a las autoridades de los diferentes gobiernos locales y al Ministerio de Transporte e Infraestructura");
            listaDerchos.Add("Los peatones tienen la obligación de acatar las disposiciones establecidas en la presente Ley");
        }       

        public void Comprobar6()
        {
            listaLast.Add("ordinaria");
            listaLast.Add("profesional");
            listaLast.Add("menor de edad");
            listaLast.Add("menores de edad");
            listaLast.Add("especial");
        }

        public void Score()
        {
            Variables.Process = cont;
            try
            {
                string cadena = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;
                using (MySqlConnection connection = new MySqlConnection(cadena))
                {
                    connection.Open();
                    /*    UPDATE users SET Password = '4321' WHERE Email = 'guevaravic25@gmail.com';*/
                    string consulta = "UPDATE users SET Score= '" + Variables.Process + "' WHERE Name =  '" + Variables.Name + "';";
                    using (MySqlCommand command = new MySqlCommand(consulta, connection))
                    {
                        command.ExecuteNonQuery();
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        #endregion

        #region->Textboxs Todos las funciones y métodos de los textbox
        private void textBoxClasificar_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ValidarLetras(e);
        }

        private void textBoxConceptos_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ValidarLetras(e);
        }

        private void textBoxTiposArranceles_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ValidarLetras(e);
        }

        private void textBoxcarretera_KeyPress(object sender, KeyPressEventArgs e)
        {
            validar.ValidarNumeros(e);
        }
        #endregion

        #region->IcconButtons Todos los métodos y funciones de los Icon Buttons
        //Botones de paneles
        private void iconButtonBeforeExa2_Click(object sender, EventArgs e)
        {
            panelPrincipal1.BringToFront();
        }

        private void iconButtonNextExa3_Click(object sender, EventArgs e)
        {
            panelPrincipal3.BringToFront();
        }

        private void iconButtonReview_Click(object sender, EventArgs e)
        {
            Score();
        }

        private void iconButtonBeforeExa3_Click(object sender, EventArgs e)
        {
            panelPrincipal2.BringToFront();
        }

        private void iconButtonCerrarExa3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void iconButtonNextExa1_Click(object sender, EventArgs e)
        {
            panelPrincipal2.BringToFront();
        }
        //Botones de Ingresar
        private void iconButtonIngresar_Click(object sender, EventArgs e)
        {
            if (i < 3)
            {
                Comprobar1();
                if (listaConceptos.Contains(textBoxConceptos.Text.ToLower())) cont += 2;
                textBoxConceptos.Text = "";
                textBoxConceptos.Focus();
                i++;
            }
            else if (i == 3)
            {
                textBoxConceptos.Enabled = false;
            }
        }

        private void iconButtonIngresarVelocidad_Click(object sender, EventArgs e)
        {
            if (textBoxurbano.Text == "40") { cont += 2; }
            if (textBoxpistas.Text == "60") { cont += 2; }
            if (textBoxcarretera.Text == "100") { cont += 2; }
            iconButtonIngresarVelocidad.Enabled = false;
            textBoxurbano.Enabled = false;
            textBoxpistas.Enabled = false;
            textBoxcarretera.Enabled = false;
        }

        private void iconButtonIngresar17_Click(object sender, EventArgs e)
        {
            if (comboBox17.Text == "Espacio Aéreo, Espacio Terrestre y Espacio Marítimo") { cont += 3; comboBox17.Enabled = false; iconButtonIngresar17.Enabled = false; }
            else { comboBox17.Enabled = false; iconButtonIngresar17.Enabled = false; }
        }


        private void iconButtonIngresarLast_Click(object sender, EventArgs e)
        {
            if (n < 4)
            {
                Comprobar6();
                if (listaLast.Contains(textBoxIngrearLast.Text.ToLower())) cont += 1;
                textBoxIngrearLast.Text = "";
                textBoxIngrearLast.Focus();
                n++;
            }
            if (n == 4)
            {
                iconButtonIngresarLast.Enabled = false; textBoxIngrearLast.Enabled = false; cont += 1;
            }
        }

        private void iconButtonIngresarPeatones_Click(object sender, EventArgs e)
        {
            if (m < 6)
            {
                Comprobar5();
                if (listaDerchos.Contains(comboBoxpeatones.Text)) { cont += 1; }
                comboBoxpeatones.Items.Remove(comboBoxpeatones.SelectedItem);
                comboBoxpeatones.Text = "";
                comboBoxpeatones.Focus();
                m++;
            }
            else if (m == 6) { iconButtonIngresarPeatones.Enabled = false; comboBoxpeatones.Enabled = false; }
        }

        private void iconButtoncarnet_Click(object sender, EventArgs e)
        {
            if (l < 5)
            {
                Comprobar4();
                if (listaCarnet.Contains(comboBoxCarnet.Text)) { cont += 2; }
                comboBoxCarnet.Items.Remove(comboBoxCarnet.SelectedItem);
                comboBoxCarnet.Text = "";
                comboBoxCarnet.Focus();
                l++;
            }
            else if (l == 5) { comboBoxCarnet.Enabled = false; }
        }

        private void iconButtonIngresarClasi_Click(object sender, EventArgs e)
        {
            if (k < 2)
            {
                Comprobar3();
                if (listaClasificar.Contains(textBoxClasificar.Text.ToLower())) cont += 3;
                textBoxClasificar.Text = "";
                textBoxClasificar.Focus();
                k++;
            }
            else if (k == 2)
            {
                iconButtonIngresarClasi.Enabled = false; textBoxClasificar.Enabled = false;
            }
        }

        private void iconButtonIngresarArranceles_Click(object sender, EventArgs e)
        {
            if (j < 3)
            {
                Comprobar2();
                if (listaArranceles.Contains(textBoxTiposArranceles.Text.ToLower())) cont += 2;
                textBoxTiposArranceles.Text = "";
                textBoxTiposArranceles.Focus();
                j++;
            }
            else if (j == 3) { iconButtonIngresarArranceles.Enabled = false; textBoxTiposArranceles.Enabled = false; }
        }
        #endregion

        #region->Comboxs Todas las funciones y métodos de los comboxs
        private void comboBoxSeguridad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxSeguridad.Text == "Eliminar las causas que provocan los accidentes.") { cont += 3; comboBoxSeguridad.Enabled = false; }
            else comboBoxSeguridad.Enabled = false;
        }

        private void comboBoxTrasladar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTrasladar.Text == "Transportar") { cont += 1; comboBoxTrasladar.Enabled = false; }
            else comboBoxTrasladar.Enabled = false;
        }

        private void comboBoxTransporte_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTransporte.Text == "Circular por la vía") { cont += 1; comboBoxTransporte.Enabled = false; }
            else comboBoxTransporte.Enabled = false;
        }

        private void comboBoxLeyObjetivo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxLeyObjetivo.Text == "Hacer cumplir la ley, dar fluidez al tránsito y disminuir la contaminación ambiental por los vehículos automotores") { cont += 2; comboBoxTrasladar.Enabled = false; }
            else comboBoxLeyObjetivo.Enabled = false;

        }
        #endregion

        #region->RadioButtons Todas las funciones y métodos de los radiobuttons
        public void Imbecil()
        {
            radioButtonGood7.Enabled = false;
            radioButtonBad37.Enabled = false;
            radioButtonBad36.Enabled = false;
            radioButtonBad38.Enabled = false;
        }

        private void radioButtonBad36_CheckedChanged(object sender, EventArgs e)
        {
            Imbecil();
        }

        private void radioButtonBad37_CheckedChanged(object sender, EventArgs e)
        {
            Imbecil();
        }

        private void radioButtonBad38_CheckedChanged(object sender, EventArgs e)
        {
            Imbecil();
        }
        private void radioButtonGood_CheckedChanged(object sender, EventArgs e)
        {
            cont += 2;
            radioButtonGood.Enabled = false;
            radioButtonBad.Enabled = false;
            radioButtonBad2.Enabled = false;
            radioButtonBad3.Enabled = false;
        }

        private void radioButtonBad_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonGood.Enabled = false;
            radioButtonBad.Enabled = false;
            radioButtonBad2.Enabled = false;
            radioButtonBad3.Enabled = false;
        }

        private void radioButtonGood6_CheckedChanged(object sender, EventArgs e)
        {
            cont += 2;
            radioButtonGood6.Enabled = false;
            radioButtonBad28.Enabled = false;
            radioButtonBad29.Enabled = false;
            radioButtonBad30.Enabled = false;
            radioButtonBad31.Enabled = false;
        }

        private void radioButtonBad28_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonGood6.Enabled = false;
            radioButtonBad28.Enabled = false;
            radioButtonBad29.Enabled = false;
            radioButtonBad30.Enabled = false;
            radioButtonBad31.Enabled = false;
        }

        private void radioButtonBad32_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonGood8.Enabled = false;
            radioButtonBad32.Enabled = false;
            radioButtonBad33.Enabled = false;
            radioButtonBad34.Enabled = false;
            radioButtonBad35.Enabled = false;
        }

        private void radioButtonGood3_CheckedChanged(object sender, EventArgs e)
        {
            cont += 2;
            radioButtonGood3.Enabled = false;
            radioButtonBad7.Enabled = false;
            radioButtonBad8.Enabled = false;
            radioButtonBad9.Enabled = false;
            radioButtonBad10.Enabled = false;
            radioButtonBad11.Enabled = false;
            radioButtonBad12.Enabled = false;
            radioButtonBad13.Enabled = false;
        }

        private void radioButtonBad13_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonGood3.Enabled = false;
            radioButtonBad7.Enabled = false;
            radioButtonBad8.Enabled = false;
            radioButtonBad9.Enabled = false;
            radioButtonBad10.Enabled = false;
            radioButtonBad11.Enabled = false;
            radioButtonBad12.Enabled = false;
            radioButtonBad13.Enabled = false;
        }

        private void radioButtonGood4_CheckedChanged(object sender, EventArgs e)
        {
            cont += 2;
            radioButtonGood4.Enabled = false;
            radioButtonBad14.Enabled = false;
            radioButtonBad15.Enabled = false;
            radioButtonBad16.Enabled = false;
            radioButtonBad17.Enabled = false;
            radioButtonBad18.Enabled = false;
            radioButtonBad19.Enabled = false;
            radioButtonBad20.Enabled = false;
        }

        private void radioButtonBad14_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonGood4.Enabled = false;
            radioButtonBad14.Enabled = false;
            radioButtonBad15.Enabled = false;
            radioButtonBad16.Enabled = false;
            radioButtonBad17.Enabled = false;
            radioButtonBad18.Enabled = false;
            radioButtonBad19.Enabled = false;
            radioButtonBad20.Enabled = false;
        }

        private void radioButtonGood5_CheckedChanged(object sender, EventArgs e)
        {
            cont += 2;
            radioButtonGood5.Enabled = false;
            radioButtonBad21.Enabled = false;
            radioButtonBad22.Enabled = false;
            radioButtonBad23.Enabled = false;
            radioButtonBad24.Enabled = false;
            radioButtonBad25.Enabled = false;
            radioButtonBad26.Enabled = false;
            radioButtonBad27.Enabled = false;
        }

        private void radioButtonBad21_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonGood5.Enabled = false;
            radioButtonBad21.Enabled = false;
            radioButtonBad22.Enabled = false;
            radioButtonBad23.Enabled = false;
            radioButtonBad24.Enabled = false;
            radioButtonBad25.Enabled = false;
            radioButtonBad26.Enabled = false;
            radioButtonBad27.Enabled = false;
        }

        private void radioButtonGood2_CheckedChanged(object sender, EventArgs e)
        {
            cont += 2;
            radioButtonGood2.Enabled = false;
            radioButtonBad4.Enabled = false;
            radioButtonBad5.Enabled = false;
            radioButtonBad6.Enabled = false;
        }

        private void radioButtonBad6_CheckedChanged(object sender, EventArgs e)
        {
            radioButtonGood2.Enabled = false;
            radioButtonBad4.Enabled = false;
            radioButtonBad5.Enabled = false;
            radioButtonBad6.Enabled = false;
        }

        private void radioButtonGood7_CheckedChanged_1(object sender, EventArgs e)
        {
            cont += 2;
            radioButtonGood7.Enabled = false;
            radioButtonBad37.Enabled = false;
            radioButtonBad36.Enabled = false;
            radioButtonBad38.Enabled = false;
        }

        private void radioButtonGood8_CheckedChanged(object sender, EventArgs e)
        {
            cont += 3;
            radioButtonGood8.Enabled = false;
            radioButtonBad32.Enabled = false;
            radioButtonBad33.Enabled = false;
            radioButtonBad34.Enabled = false;
            radioButtonBad35.Enabled = false;
        }
        #endregion

        #region->Checkboxs Todas las funciones y métodos de los checkboxs
        private void checkBoxGood8_CheckedChanged(object sender, EventArgs e)
        {
            cont += 3;
            checkBoxBad37.Enabled = false;
            checkBoxBad38.Enabled = false;
            checkBoxBad39.Enabled = false;
        }

        private void checkBoxBad37_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxGood8.Enabled = false;
            checkBoxBad37.Enabled = false;
            checkBoxBad38.Enabled = false;
            checkBoxBad39.Enabled = false;
        }

        private void checkBoxGood9_CheckedChanged(object sender, EventArgs e)
        {
            cont += 3;
            checkBoxGood9.Enabled = false;
            checkBoxBad40.Enabled = false;
            checkBoxBad41.Enabled = false;
            checkBoxBad42.Enabled = false;
        }

        private void checkBoxBad40_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxGood9.Enabled = false;
            checkBoxBad40.Enabled = false;
            checkBoxBad41.Enabled = false;
            checkBoxBad42.Enabled = false;
        }

        private void checkBoxGood10_CheckedChanged(object sender, EventArgs e)
        {
            cont += 3;
            checkBoxGood10.Enabled = false;
            checkBoxBad43.Enabled = false;
            checkBoxBad44.Enabled = false;
            checkBoxBad45.Enabled = false;
        }

        private void checkBoxBad43_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxGood10.Enabled = false;
            checkBoxBad43.Enabled = false;
            checkBoxBad44.Enabled = false;
            checkBoxBad45.Enabled = false;
        }

        private void checkBoxGood1_CheckedChanged(object sender, EventArgs e)
        {
            cont += 2;
            checkBoxGood1.Enabled = false;
            checkBoxBad1.Enabled = false;
            checkBoxBad2.Enabled = false;
            checkBoxBad3.Enabled = false;
            checkBoxBad4.Enabled = false;
            checkBoxBad5.Enabled = false;
            checkBoxBad6.Enabled = false;
        }

        private void checkBoxBad1_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxGood1.Enabled = false;
            checkBoxBad1.Enabled = false;
            checkBoxBad2.Enabled = false;
            checkBoxBad3.Enabled = false;
            checkBoxBad4.Enabled = false;
            checkBoxBad5.Enabled = false;
            checkBoxBad6.Enabled = false;
        }

        private void checkBoxGood2_CheckedChanged(object sender, EventArgs e)
        {
            cont += 2;
            checkBoxGood2.Enabled = false;
            checkBoxBad7.Enabled = false;
            checkBoxBad8.Enabled = false;
            checkBoxBad9.Enabled = false;
            checkBoxBad10.Enabled = false;
            checkBoxBad11.Enabled = false;
            checkBoxBad12.Enabled = false;
        }

        private void checkBoxBad7_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxGood2.Enabled = false;
            checkBoxBad7.Enabled = false;
            checkBoxBad8.Enabled = false;
            checkBoxBad9.Enabled = false;
            checkBoxBad10.Enabled = false;
            checkBoxBad11.Enabled = false;
            checkBoxBad12.Enabled = false;
        }

        private void checkBoxGood3_CheckedChanged(object sender, EventArgs e)
        {
            cont += 2;
            checkBoxGood3.Enabled = false;
            checkBoxBad13.Enabled = false;
            checkBoxBad14.Enabled = false;
            checkBoxBad15.Enabled = false;
            checkBoxBad16.Enabled = false;
            checkBoxBad17.Enabled = false;
            checkBoxBad18.Enabled = false;
        }

        private void checkBoxBad13_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxGood3.Enabled = false;
            checkBoxBad13.Enabled = false;
            checkBoxBad14.Enabled = false;
            checkBoxBad15.Enabled = false;
            checkBoxBad16.Enabled = false;
            checkBoxBad17.Enabled = false;
            checkBoxBad18.Enabled = false;
        }

        private void checkBoxGood4_CheckedChanged(object sender, EventArgs e)
        {
            cont += 2;
            checkBoxGood4.Enabled = false;
            checkBoxBad19.Enabled = false;
            checkBoxBad20.Enabled = false;
            checkBoxBad21.Enabled = false;
            checkBoxBad22.Enabled = false;
            checkBoxBad23.Enabled = false;
            checkBoxBad24.Enabled = false;
        }

        private void checkBoxBad19_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxGood4.Enabled = false;
            checkBoxBad19.Enabled = false;
            checkBoxBad20.Enabled = false;
            checkBoxBad21.Enabled = false;
            checkBoxBad22.Enabled = false;
            checkBoxBad23.Enabled = false;
            checkBoxBad24.Enabled = false;
        }

        private void checkBoxGood5_CheckedChanged(object sender, EventArgs e)
        {
            cont += 2;
            checkBoxGood5.Enabled = false;
            checkBoxBad25.Enabled = false;
            checkBoxBad26.Enabled = false;
            checkBoxBad27.Enabled = false;
            checkBoxBad28.Enabled = false;
            checkBoxBad29.Enabled = false;
            checkBoxBad30.Enabled = false;
        }

        private void checkBoxBad25_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxGood5.Enabled = false;
            checkBoxBad25.Enabled = false;
            checkBoxBad26.Enabled = false;
            checkBoxBad27.Enabled = false;
            checkBoxBad28.Enabled = false;
            checkBoxBad29.Enabled = false;
            checkBoxBad30.Enabled = false;
        }

        private void checkBoxGood6_CheckedChanged(object sender, EventArgs e)
        {
            cont += 2;
            checkBoxGood6.Enabled = false;
            checkBoxBad31.Enabled = false;
            checkBoxBad32.Enabled = false;
            checkBoxBad33.Enabled = false;
            checkBoxBad34.Enabled = false;
            checkBoxBad35.Enabled = false;
            checkBoxBad36.Enabled = false;
        }

        private void checkBoxBad31_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxGood6.Enabled = false;
            checkBoxBad31.Enabled = false;
            checkBoxBad32.Enabled = false;
            checkBoxBad33.Enabled = false;
            checkBoxBad34.Enabled = false;
            checkBoxBad35.Enabled = false;
            checkBoxBad36.Enabled = false;
        }
        #endregion
    }
}