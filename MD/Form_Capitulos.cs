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
    public partial class Form_Capitulos : Form
    {
        public Form_Capitulos()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
        }

        private void Form_temas_Load(object sender, EventArgs e)
        {
            //panelCap1_1();
            Variables.Panel = "Cap1";
            Cap1();
            Cap1_1();
            Cap1_2();
            Cap2_3();
            Cap3();
            Cap3_2();
            Cap3_3();
            Cap4_5();
            Cap5_6();
            Cap6_7();
            Cap7_8();
            Cap8_9();
            Cap10();
            Cap11_12();
            if (Variables.Config == "Cap1") panelPrincipal.BringToFront();
            if (Variables.Config == "Cap2") panelPrincipal4.BringToFront();
            if (Variables.Config == "Cap4") panelPrincipal8.BringToFront();
            if (Variables.Config == "Cap6") panelPrincipal9.BringToFront();
            if (Variables.Config == "Cap7") panelPrincipal10.BringToFront();
            if (Variables.Config == "Cap8") panelPrincipal11.BringToFront();
            if (Variables.Config == "Cap10") panelPrincipal13.BringToFront();
            if (Variables.Config == "Cap11") panelPrincipal14.BringToFront();

        }

        #region->Colores de paneles y demás Herramientas 
        string color = Properties.Settings.Default.Tema;

        public void Cap1()
        {
            Colores.ElegirColor(color);
            panelPrincipal.BackColor = Colores.PanelPrincipal;
            panelL.BackColor = Colores.PanelPrincipal;
            label1.BackColor = Colores.PanelPrincipal;
            listBoxart1.BackColor = Colores.PanelPrincipal;
            listBoxart2.BackColor = Colores.PanelPrincipal;
            listBoxart3.BackColor = Colores.PanelPrincipal;
            label1.ForeColor = Colores.FuenteC;
            listBoxart1.ForeColor = Colores.FuenteC;
            listBoxart2.ForeColor = Colores.FuenteC;
            listBoxart3.ForeColor = Colores.FuenteC;
            iconButtonNextCap1.BackColor = Colores.PanelSuperior;
            iconButtonNextCap1.ForeColor = Colores.FuenteC;
            iconButtonNextCap1.IconColor = Colores.FuenteC;
        }

        public void Cap1_1()
        {
            Colores.ElegirColor(color);
            panelPrincipal2.BackColor = Colores.PanelPrincipal;
            panelL.BackColor = Colores.PanelPrincipal;
            label2.BackColor = Colores.PanelPrincipal;
            label3.BackColor = Colores.PanelPrincipal;
            label2.ForeColor = Colores.FuenteC;
            label3.ForeColor = Colores.FuenteC;
            listBoxart4.BackColor = Colores.PanelPrincipal;
            label1.ForeColor = Colores.FuenteC;
            listBoxart4.ForeColor = Colores.FuenteC;
            //iconButtonBeforeCap1_1.Visible = false;
            iconButtonBeforeCap1_1.BackColor = Colores.PanelSuperior;
            iconButtonBeforeCap1_1.ForeColor = Colores.FuenteC;
            iconButtonBeforeCap1_1.IconColor = Colores.FuenteC;
            //iconButtonNextCap1_1.Visible = false;
            iconButtonNextCap1_1.BackColor = Colores.PanelSuperior;
            iconButtonNextCap1_1.ForeColor = Colores.FuenteC;
            iconButtonNextCap1_1.IconColor = Colores.FuenteC;
            data4ruedas.ColumnHeadersDefaultCellStyle.BackColor = Colores.PanelSuperior;
            data4ruedas.ColumnHeadersDefaultCellStyle.ForeColor = Colores.FuenteC;
            data4ruedas.RowHeadersDefaultCellStyle.BackColor = Colores.PanelSuperior;
            data4ruedas.RowHeadersDefaultCellStyle.ForeColor = Colores.FuenteC;
            data4ruedas.DefaultCellStyle.BackColor = Colores.PanelPrincipal;       
            data4ruedas.ForeColor = Colores.FuenteC;
            data4ruedas.DefaultCellStyle.SelectionBackColor = Colores.PanelSuperior;
            data4ruedas.DefaultCellStyle.SelectionForeColor = Colores.FuenteC;                   
            data4ruedas.Rows.Add("1", "Derecho de matrícula y su calcomania", "C$ 200.00");
            data4ruedas.Rows.Add("2", "Placas", "C$ 200.00");
            data4ruedas.Rows.Add("3", "Licencia de circulación", "C$ 100.00");
            data4ruedas.Rows.Add("4", "Calcomania de revisado", "C$ 50.00");
        }

        public void Cap1_2()
        {
            Colores.ElegirColor(color);
            panelPrincipal3.BackColor = Colores.PanelPrincipal;
            label4.BackColor = Colores.PanelPrincipal;
            label4.ForeColor = Colores.FuenteC;
            label5.BackColor = Colores.PanelPrincipal;
            label5.ForeColor = Colores.FuenteC;
            label6.ForeColor = Colores.FuenteC;
            label6.ForeColor = Colores.PanelPrincipal;
            iconButtonBeforeCap1_2.BackColor = Colores.PanelSuperior;
            iconButtonBeforeCap1_2.ForeColor = Colores.FuenteC;
            iconButtonBeforeCap1_2.IconColor = Colores.FuenteC;
            iconButtonNextCap1_2.BackColor = Colores.PanelSuperior;
            iconButtonNextCap1_2.ForeColor = Colores.FuenteC;
            iconButtonNextCap1_2.IconColor = Colores.FuenteC;
            datosmoto.ColumnHeadersDefaultCellStyle.BackColor = Colores.PanelSuperior;
            datosmoto.ColumnHeadersDefaultCellStyle.ForeColor = Colores.FuenteC;
            datosmoto.RowHeadersDefaultCellStyle.BackColor = Colores.PanelSuperior;
            datosmoto.RowHeadersDefaultCellStyle.ForeColor = Colores.FuenteC;
            datosmoto.DefaultCellStyle.BackColor = Colores.PanelPrincipal;
            datosmoto.ForeColor = Colores.FuenteC;
            datosmoto.DefaultCellStyle.SelectionBackColor = Colores.PanelSuperior;
            datosmoto.DefaultCellStyle.SelectionForeColor = Colores.FuenteC;
            datosmoto.Rows.Add("1", "Derecho de matrícula", "C$ 150.00");
            datosmoto.Rows.Add("2", "Placas", "C$ 175.00");
            datosmoto.Rows.Add("3", "Licencia de circulación", "C$ 100.00");
            datosmoto.Rows.Add("4", "Calcomania de revisado", "C$ 50.00");

            datosclass.ColumnHeadersDefaultCellStyle.BackColor = Colores.PanelSuperior;
            datosclass.ColumnHeadersDefaultCellStyle.ForeColor = Colores.FuenteC;
            datosclass.RowHeadersDefaultCellStyle.BackColor = Colores.PanelSuperior;
            datosclass.RowHeadersDefaultCellStyle.ForeColor = Colores.FuenteC;
            datosclass.DefaultCellStyle.BackColor = Colores.PanelPrincipal;
            datosclass.ForeColor = Colores.FuenteC;
            datosclass.DefaultCellStyle.SelectionBackColor = Colores.PanelSuperior;
            datosclass.DefaultCellStyle.SelectionForeColor = Colores.FuenteC;
            datosclass.Rows.Add("1", "Motocicletas de uso partícular y estatal", "C$ 50.00");
            datosclass.Rows.Add("2", "Tractores y maquinaria agrícola. Se exceptúan implementos agrícolas", "C$ 75.00");
            datosclass.Rows.Add("3", "Automóviles, camionetas y jeeps de uso particular y estatal", "C$ 105.00");
            datosclass.Rows.Add("4", "Taxis y Camionetas de uso comercial", "C$ 125.00");
            datosclass.Rows.Add("5", "Microbuses de uso comercial", "C$ 150.00");
            datosclass.Rows.Add("6", "Remolques de más de dos ejes", "C$ 250.00");
            datosclass.Rows.Add("7", "Buses de uso comercial", "C$ 300.00");
            datosclass.Rows.Add("8", "Camiones de menores de 7 toneladas de capacidad", "C$ 400.00");
            datosclass.Rows.Add("9", "Montacargas", "C$ 500.00");
            datosclass.Rows.Add("10", "Camiones desde 7 hasta 12 toneladas", "C$ 600.00");
            datosclass.Rows.Add("11", "Cabezales", "C$ 600.00");
            datosclass.Rows.Add("12", "Grúas tractores, cisternas, mezcladoras compactadoras y demás equipos pesados", "C$ 800.00");
            datosclass.Rows.Add("13", "Camiones de más de 12 toneladas", "C$ 1,000.00");
        
        }

        public void Cap2_3()
        {
            Colores.ElegirColor(color);
            panelPrincipal4.BackColor = Colores.PanelPrincipal;
            listBoxart5.BackColor = Colores.PanelPrincipal;
            listBoxartCap3_6.BackColor = Colores.PanelPrincipal;
            label7.BackColor = Colores.PanelPrincipal;
            label8.BackColor = Colores.PanelPrincipal;
            label7.ForeColor = Colores.FuenteC;
            label8.ForeColor = Colores.FuenteC;
            listBoxart5.ForeColor = Colores.FuenteC;
            listBoxartCap3_6.ForeColor = Colores.FuenteC;
            //iconButtonNextCap2_3.Visible = false;           
            iconButtonNextCap2_3.BackColor = Colores.PanelSuperior;
            iconButtonNextCap2_3.ForeColor = Colores.FuenteC;
            iconButtonNextCap2_3.IconColor = Colores.FuenteC;
            //iconButtonBeforeCap2_3.Visible = false;
            iconButtonBeforeCap2_3.BackColor = Colores.PanelSuperior;
            iconButtonBeforeCap2_3.ForeColor = Colores.FuenteC;
            iconButtonBeforeCap2_3.IconColor = Colores.FuenteC;
        }

        public void Cap3()
        {
            panelPrincipal5.BackColor = Colores.PanelPrincipal;
            label10.BackColor = Colores.PanelPrincipal;
            label9.BackColor = Colores.PanelPrincipal;
            label10.ForeColor = Colores.FuenteC;
            label9.ForeColor = Colores.FuenteC;
            listBoxart3_1.BackColor = Colores.PanelPrincipal;
            listBoxart3_1.ForeColor = Colores.FuenteC;
            iconButtonNextCap3_1.BackColor = Colores.PanelSuperior; ;
            iconButtonBeforeCap3_1.ForeColor = Colores.FuenteC;
            iconButtonNextCap3_1.ForeColor = Colores.FuenteC;
            iconButtonBeforeCap3_1.BackColor = Colores.PanelSuperior;

            datosMayorP.ColumnHeadersDefaultCellStyle.BackColor = Colores.PanelSuperior;
            datosMayorP.ColumnHeadersDefaultCellStyle.ForeColor = Colores.FuenteC;
            datosMayorP.RowHeadersDefaultCellStyle.BackColor = Colores.PanelSuperior;
            datosMayorP.RowHeadersDefaultCellStyle.ForeColor = Colores.FuenteC;
            datosMayorP.DefaultCellStyle.BackColor = Colores.PanelPrincipal;
            datosMayorP.ForeColor = Colores.FuenteC;
            datosMayorP.DefaultCellStyle.SelectionBackColor = Colores.PanelSuperior;
            datosMayorP.DefaultCellStyle.SelectionForeColor = Colores.FuenteC;
            datosMayorP.Rows.Add("1", "Conducir en estado de embriaguez extrema: Concentración superior a 2 gramos de alcohol por litro de sangre", "C$ 5000.00");
            datosMayorP.Rows.Add("2", "Conducir en estado de embriaguez: Concentración de más de 1 gramos hasta 2 gramos de alcohol por litro de sangre", "C$ 4000.00");
            datosMayorP.Rows.Add("3", "Conducir bajo los efectos de estupefacientes, psicotrópicos, estimulantes y sustancias controladas", "C$ 4000.00");
            datosMayorP.Rows.Add("4", "Conducir de forma temeraria", "C$ 3000.00");
            datosMayorP.Rows.Add("5", "Provocar accidente y darse a la fuga", "C$ 2500.00");
            datosMayorP.Rows.Add("6", "Conducir a velocidad mayor que la que se exprese en la señalización de tránsito o al estándar establecido", "C$ 2500.00");
            datosMayorP.Rows.Add("7", "Estacionar en carretera, trailers, rastras y contenedores sin triángulos reflectivos u otras señales lumínicas adecuadas para la prevención de accidentes", "C$ 1000.00");
            datosMayorP.Rows.Add("8", "Giros indebidos en U y Zigzag", "C$ 1000.00");
            datosMayorP.Rows.Add("9", "Usar placas y/o circulación de otro vehículo", "C$ 1000.0");
            datosMayorP.Rows.Add("10", "Invasión de carril", "C$ 800.0");
            datosMayorP.Rows.Add("11", "Trasladar mercadería o carga a granel sin la protección total de cargas o lonas", "C$ 500.0");
            datosMayorP.Rows.Add("12", "Participar en competencias ilegales de automotores", "C$ 1000.0");
            datosMayorP.Rows.Add("13", "Conducir sin tener licencia de conducir", "C$ 500.0");
            datosMayorP.Rows.Add("14", "No respetar la preferencia peatonal en las intersecciones o los cruces de colegios", "C$ 650.0");
            datosMayorP.Rows.Add("15", "Exceso de pasajeros o de carga", "C$ 500.0");
            datosMayorP.Rows.Add("16", "Aventajar en pendientes, curvas o puentes", "C$ 500.0");
            datosMayorP.Rows.Add("17", "Conducir con las luces apagadas después de la hora indicada o durante el día cuando haya condiciones ambientales de lluvia, neblina o tolvanera", "C$ 500.0");
            datosMayorP.Rows.Add("18", "Adelantar en linea continua amarilla", "C$ 500.0");
            datosMayorP.Rows.Add("19", "Condicir contra la villa", "C$ 500.0");
            datosMayorP.Rows.Add("20", "Obstrucción de la libre circulación vehicular", "C$ 500.0");
            datosMayorP.Rows.Add("21", "El conductor de motocicleta y acompañante que circulen sin portar debidamente el casco", "C$ 500.0");
            datosMayorP.Rows.Add("22", "El conductor y acompañante de un vehículo automotor que no utilice el cinturón de seguridad", "C$ 350.0");
            datosMayorP.Rows.Add("23", "Desatender señales de emergencia, lumínicas sonoras de ambulancia, policía o bomberos", "C$ 350.0");
            datosMayorP.Rows.Add("24", "Conducir utilizando manualmente teléfonos móviles, o cualquier otro aparato de distracción en el manejo", "C$ 250.0");

        }

        public void Cap3_2()
        {
            panelPrincipal6.BackColor = Colores.PanelPrincipal;
            label11.BackColor = Colores.PanelPrincipal;
            label12.BackColor = Colores.PanelPrincipal;
            label13.BackColor = Colores.PanelPrincipal;
            label11.ForeColor = Colores.FuenteC;
            label12.ForeColor = Colores.FuenteC;
            label13.ForeColor = Colores.FuenteC;
            iconButtonNextCap3_2.BackColor = Colores.PanelSuperior; ;
            iconButtonBeforeCap3_2.ForeColor = Colores.FuenteC;
            iconButtonNextCap3_2.ForeColor = Colores.FuenteC;
            iconButtonBeforeCap3_2.BackColor = Colores.PanelSuperior;
            datosmayores2.ColumnHeadersDefaultCellStyle.BackColor = Colores.PanelSuperior;
            datosmayores2.ColumnHeadersDefaultCellStyle.ForeColor = Colores.FuenteC;
            datosmayores2.RowHeadersDefaultCellStyle.BackColor = Colores.PanelSuperior;
            datosmayores2.RowHeadersDefaultCellStyle.ForeColor = Colores.FuenteC;
            datosmayores2.DefaultCellStyle.BackColor = Colores.PanelPrincipal;
            datosmayores2.ForeColor = Colores.FuenteC;
            datosmayores2.DefaultCellStyle.SelectionBackColor = Colores.PanelSuperior;
            datosmayores2.DefaultCellStyle.SelectionForeColor = Colores.FuenteC;
            datosmayores2.Rows.Add("25", "No reportar los cambios de las características físicas del vehículo", "C$ 500.0");
            datosmayores2.Rows.Add("26", "Conducir con las puertas abiertas, transporte colectivo y de carga", "C$ 650.0");
            datosmayores2.Rows.Add("27", "Conducir carga sib la sebida señalización visible o reflectiva apropiada", "C$ 350.0");
            datosmayores2.Rows.Add("28", "Estacionarse en la via publica, en caso de emergencia, sin triangulos reflectivos u otras señales lumíncas adecuadas para la prevencción de accidentes", "C$ 350.0");
            datosmayores2.Rows.Add("29", "Transportar niños menores que siete años en el asiento delantero o en asientos posteriores", "C$ 350.0");
            datosmayores2.Rows.Add("30", "Desatender señales de transito, verticales u horizontales, siempre que estén visibles", "C$ 350.0");
            datosmayores2.Rows.Add("31", "Conducir motocicletas con niños menores de 8 añosf", "C$ 200.0");

            datospeligrosos.ColumnHeadersDefaultCellStyle.BackColor = Colores.PanelSuperior;
            datospeligrosos.ColumnHeadersDefaultCellStyle.ForeColor = Colores.FuenteC;
            datospeligrosos.RowHeadersDefaultCellStyle.BackColor = Colores.PanelSuperior;
            datospeligrosos.DefaultCellStyle.BackColor = Colores.PanelPrincipal;
            datospeligrosos.ForeColor = Colores.FuenteC;
            datospeligrosos.DefaultCellStyle.SelectionBackColor = Colores.PanelSuperior;
            datospeligrosos.DefaultCellStyle.SelectionForeColor = Colores.FuenteC;
            datospeligrosos.Rows.Add("1", "Conducir cuadraciclos en ciudades y áreas no autorizadas por la policia nacional", "C$ 700.0");
            datospeligrosos.Rows.Add("2", "Conducir vehículos que provocan exceso de humo", "C$ 500.0");
            datospeligrosos.Rows.Add("3", "Conducir en estado de embriaguez ligera: Concentración de 0.5 gramos hasta 1 gramo de alcohol por litro de sangre", "C$  1000.0");
            datospeligrosos.Rows.Add("4", "Conducir cuadraciclos o triciclos sin utilizar debidamente el casco adecuado", "C$  1000.0");
            datospeligrosos.Rows.Add("5", "Conducir cuadraciclos o triciclos sin utilizar debidamente el casco adecuado", "C$  250.0");
            datospeligrosos.Rows.Add("6", "Aventajar por la derecha en vias de un solo carril", "C$  250.0");
            datospeligrosos.Rows.Add("7", "Bajar o subir pasajeros por el lado izquierdo en la via pública", "C$  250.0");
            datospeligrosos.Rows.Add("8", "Realizar señaeles equivocadas sobre sus maniobras al conducir", "C$  250.0");
            datospeligrosos.Rows.Add("9", "Conducir vehículo en mal estado", "C$  250.0");
            datospeligrosos.Rows.Add("10", "Provocar ruidos y escandalos perturbadores del medio ambiente", "C$  450.0");
            datospeligrosos.Rows.Add("11", "Circular con los vehículos sobre bulevares", "C$  250.0");
            datospeligrosos.Rows.Add("12", "Conducir sin seguro de responsabilidad civil por daños a terceros, según la categoría siguiente:", "");
            datospeligrosos.Rows.Add("12", "a) Motocicletas", "C$ 500.00");
            datospeligrosos.Rows.Add("12", "b) Vehículos automotores livianos", "C$ 1,500.00");
            datospeligrosos.Rows.Add("12", "c) Vehículos automotores pesados", "C$ 3,000.00");
            datospeligrosos.Rows.Add("13", "No portar triángulos fluorecentes", "C$ 250.00");
            datospeligrosos.Rows.Add("14", "No guardar distancia entre uno y otro carro", "C$ 160.00");
            datospeligrosos.Rows.Add("15", "Estacionarse", "");
            datospeligrosos.Rows.Add("15", "a) Sobre aceras y andenes", "C$ 160.00");
            datospeligrosos.Rows.Add("15", "b) Frente a hidrantes", "C$ 160.00");
            datospeligrosos.Rows.Add("15", "c) Frente a granjes", "C$ 160.00");
            datospeligrosos.Rows.Add("15", "d) En las entradas de hospitales y clínicas", "C$ 160.00");
            datospeligrosos.Rows.Add("15", "e) En los estacionmientos habilitados para personas con discapacidad", "C$ 160.00");
            datospeligrosos.Rows.Add("15", "f) En paradas de buses, particulares o transporte selectivo", "C$ 160.00");
        }

        public void Cap3_3()
        {
            panelPrincipal7.BackColor = Colores.PanelPrincipal;
            label14.BackColor = Colores.PanelPrincipal;
            label14.ForeColor = Colores.FuenteC;
            label15.ForeColor = Colores.FuenteC;
            label15.BackColor = Colores.PanelPrincipal;
            iconButtonNextCap3_3.BackColor = Colores.PanelSuperior;
            iconButtonBeforeCap3_3.ForeColor = Colores.FuenteC;
            iconButtonBeforeCap3_3.IconColor = Colores.FuenteC;
            iconButtonNextCap3_3.IconColor = Colores.FuenteC;
            iconButtonNextCap3_3.ForeColor = Colores.FuenteC;
            iconButtonBeforeCap3_3.BackColor = Colores.PanelSuperior;
            datospeligrosos2.ColumnHeadersDefaultCellStyle.BackColor = Colores.PanelSuperior;
            datospeligrosos2.ColumnHeadersDefaultCellStyle.ForeColor = Colores.FuenteC;
            datospeligrosos2.RowHeadersDefaultCellStyle.BackColor = Colores.PanelSuperior;
            datospeligrosos2.DefaultCellStyle.BackColor = Colores.PanelPrincipal;
            datospeligrosos2.ForeColor = Colores.FuenteC;
            datospeligrosos2.DefaultCellStyle.SelectionBackColor = Colores.PanelSuperior;
            datospeligrosos2.DefaultCellStyle.SelectionForeColor = Colores.FuenteC;
            datospeligrosos2.Rows.Add("15", "f) En rotondas", "C$ 160.00");

            listBoxart3_3.BackColor = Colores.PanelPrincipal;
            listBoxart3_3.ForeColor = Colores.FuenteC;
            datosadmision.ColumnHeadersDefaultCellStyle.BackColor = Colores.PanelSuperior;
            datosadmision.ColumnHeadersDefaultCellStyle.ForeColor = Colores.FuenteC;
            datosadmision.RowHeadersDefaultCellStyle.BackColor = Colores.PanelSuperior;
            datosadmision.DefaultCellStyle.BackColor = Colores.PanelPrincipal;
            datosadmision.ForeColor = Colores.FuenteC;
            datosadmision.DefaultCellStyle.SelectionBackColor = Colores.PanelSuperior;
            datosadmision.DefaultCellStyle.SelectionForeColor = Colores.FuenteC;
            datosadmision.Rows.Add("1", "Tirar basura o desechos en las vías públicas desde vehículos automotores de uso público o privado", "C$ 320.00");
            datosadmision.Rows.Add("2", "Conducir sin portar placas o licencia de circulación", "C$ 320.00");
            datosadmision.Rows.Add("3", "Conducir con licencia o categorías diferentes a la autorizada", "C$ 320.00");
            datosadmision.Rows.Add("4", "Transporte urbano, no detenerse a subir o bajar pasajeros en las paradas definidas por la autoridad correspondiente", "C$ 320.00");
            datosadmision.Rows.Add("5", "Cicular con placas no visibles, en mal estado o no autorizadas", "C$ 320.00");
            datosadmision.Rows.Add("6", "Prestar servicio de transporte público sin la debida autorización", "C$ 320.00");
            datosadmision.Rows.Add("7", "Conducir automotores con el certificado o calcomania de emisión de gases o el certificado de inspección mecánica sin vigencia", "C$ 320.00");
            datosadmision.Rows.Add("8", "Conducir con la licencia vencida", "C$ 250.00");
            datosadmision.Rows.Add("9", "Conducir sin portar licencia", "C$ 160.00");
            datosadmision.Rows.Add("10", "Conducir sin loderas en las llantas traseras de vehículos de carga o pasajeros", "C$ 160.00");
            datosadmision.Rows.Add("11", "Circular sin espejos retrovisores internoso laterales", "C$ 160.00");
            datosadmision.Rows.Add("12", "Obstruir la visibilidad en los vidrios del vehículo utilizando polarizo no autorizado", "C$ 200.00");
            datosadmision.Rows.Add("13", "Circular en bicicletas o medios de transporte de tracción animal sin señales lumínicas visibles", "C$ 100.00");
            datosadmision.Rows.Add("14", "Circular sin la calcomania del pago de impuesto de rodamiento", "C$ 100.00");
        }
        
        public void Cap4_5()
        {
            panelPrincipal8.BackColor = Colores.PanelPrincipal;
            panelPrincipal8.ForeColor = Colores.FuenteC;
            label16.ForeColor = Colores.FuenteC;
            label16.BackColor = Colores.PanelPrincipal;
            label18.BackColor = Colores.PanelPrincipal;
            label18.ForeColor = Colores.FuenteC;
            iconButtonBeforeCap4.BackColor = Colores.PanelSuperior;
            iconButtonBeforeCap4.ForeColor = Colores.FuenteC;
            iconButtonBeforeCap4.IconColor = Colores.FuenteC;
            iconButtonNextCap4.BackColor = Colores.PanelSuperior;
            iconButtonNextCap4.ForeColor = Colores.FuenteC;
            iconButtonNextCap4.IconColor = Colores.FuenteC;
            listBoxartCap4.BackColor = Colores.PanelPrincipal;
            listBoxartCap4.ForeColor = Colores.FuenteC;
            listBoxCap5.BackColor = Colores.PanelPrincipal;
            listBoxCap5.ForeColor = Colores.FuenteC;
        }

        public void Cap5_6()
        {
            panelPrincipal9.BackColor = Colores.PanelPrincipal;
            label17.ForeColor = Colores.FuenteC;
            label17.BackColor = Colores.PanelPrincipal;
            label19.BackColor = Colores.PanelPrincipal;
            label19.ForeColor = Colores.FuenteC;
            listBoxCap5_1.ForeColor = Colores.FuenteC;
            listBoxCap5_1.BackColor = Colores.PanelPrincipal;
            listBoxCap6.BackColor = Colores.PanelPrincipal;
            listBoxCap6.ForeColor = Colores.FuenteC;
            iconButtonBeforeCap5_6.BackColor = Colores.PanelSuperior;
            iconButtonBeforeCap5_6.ForeColor = Colores.FuenteC;
            iconButtonBeforeCap5_6.IconColor = Colores.FuenteC;
            iconButtonNextCap5_6.BackColor = Colores.PanelSuperior;
            iconButtonNextCap5_6.ForeColor = Colores.FuenteC;
            iconButtonNextCap5_6.IconColor = Colores.FuenteC;
        }

        public void Cap6_7()
        {
            panelPrincipal10.BackColor = Colores.PanelPrincipal;
            label20.ForeColor = Colores.FuenteC;
            label20.BackColor = Colores.PanelPrincipal;
            label21.BackColor = Colores.PanelPrincipal;
            label21.ForeColor = Colores.FuenteC;
            listBoxCap6_1.ForeColor = Colores.FuenteC;
            listBoxCap6_1.BackColor = Colores.PanelPrincipal;
            listBoxCap7.BackColor = Colores.PanelPrincipal;
            listBoxCap7.ForeColor = Colores.FuenteC;
            iconButtonBeforeCap6_7.BackColor = Colores.PanelSuperior;
            iconButtonBeforeCap6_7.ForeColor = Colores.FuenteC;
            iconButtonBeforeCap6_7.IconColor = Colores.FuenteC;
            iconButtonNextCap6_7.BackColor = Colores.PanelSuperior;
            iconButtonNextCap6_7.ForeColor = Colores.FuenteC;
            iconButtonNextCap6_7.IconColor = Colores.FuenteC;
        }

        public void Cap7_8()
        {
            panelPrincipal11.BackColor = Colores.PanelPrincipal;
            label22.ForeColor = Colores.FuenteC;
            label22.BackColor = Colores.PanelPrincipal;
            label23.BackColor = Colores.PanelPrincipal;
            label23.ForeColor = Colores.FuenteC;
            listBoxCap7_1.ForeColor = Colores.FuenteC;
            listBoxCap7_1.BackColor = Colores.PanelPrincipal;
            listBoxCap8.BackColor = Colores.PanelPrincipal;
            listBoxCap8.ForeColor = Colores.FuenteC;
            iconButtonBeforeCap7_8.BackColor = Colores.PanelSuperior;
            iconButtonBeforeCap7_8.ForeColor = Colores.FuenteC;
            iconButtonBeforeCap7_8.IconColor = Colores.FuenteC;
            iconButtonNextCap7_8.BackColor = Colores.PanelSuperior;
            iconButtonNextCap7_8.ForeColor = Colores.FuenteC;
            iconButtonNextCap7_8.IconColor = Colores.FuenteC;
        }

        public void Cap8_9()
        {
            panelPrincipal12.BackColor = Colores.PanelPrincipal;
            label24.ForeColor = Colores.FuenteC;
            label24.BackColor = Colores.PanelPrincipal;
            label25.BackColor = Colores.PanelPrincipal;
            label25.ForeColor = Colores.FuenteC;
            listBoxCap8_1.ForeColor = Colores.FuenteC;
            listBoxCap8_1.BackColor = Colores.PanelPrincipal;
            listBoxCap9.BackColor = Colores.PanelPrincipal;
            listBoxCap9.ForeColor = Colores.FuenteC;
            iconButtonBeforeCap8_9.BackColor = Colores.PanelSuperior;
            iconButtonBeforeCap8_9.ForeColor = Colores.FuenteC;
            iconButtonBeforeCap8_9.IconColor = Colores.FuenteC;
            iconButtonNextCap8_9.BackColor = Colores.PanelSuperior;
            iconButtonNextCap8_9.ForeColor = Colores.FuenteC;
            iconButtonNextCap8_9.IconColor = Colores.FuenteC;
        }

        public void Cap10()
        {
            panelPrincipal13.BackColor = Colores.PanelPrincipal;
            label26.ForeColor = Colores.FuenteC;
            label26.BackColor = Colores.PanelPrincipal;
            label27.BackColor = Colores.PanelPrincipal;
            label27.ForeColor = Colores.FuenteC;
            listBoxCap10.ForeColor = Colores.FuenteC;
            listBoxCap10.BackColor = Colores.PanelPrincipal;
            iconButtonBeforeCap10.BackColor = Colores.PanelSuperior;
            iconButtonBeforeCap10.ForeColor = Colores.FuenteC;
            iconButtonBeforeCap10.IconColor = Colores.FuenteC;
            iconButtonNextCap10.BackColor = Colores.PanelSuperior;
            iconButtonNextCap10.ForeColor = Colores.FuenteC;
            iconButtonNextCap10.IconColor = Colores.FuenteC;
            datosEstacionamiento.ColumnHeadersDefaultCellStyle.BackColor = Colores.PanelSuperior;
            datosEstacionamiento.ColumnHeadersDefaultCellStyle.ForeColor = Colores.FuenteC;
            datosEstacionamiento.RowHeadersDefaultCellStyle.BackColor = Colores.PanelSuperior;
            datosEstacionamiento.RowHeadersDefaultCellStyle.ForeColor = Colores.FuenteC;
            datosEstacionamiento.DefaultCellStyle.BackColor = Colores.PanelPrincipal;
            datosEstacionamiento.ForeColor = Colores.FuenteC;
            datosEstacionamiento.DefaultCellStyle.SelectionBackColor = Colores.PanelSuperior;
            datosEstacionamiento.DefaultCellStyle.SelectionForeColor = Colores.FuenteC;
            datosEstacionamiento.Rows.Add("1", "Exámen de vista", "C$ 125.00");
            datosEstacionamiento.Rows.Add("2", "Exámen de sangre", "C$ 125.00");
            datosEstacionamiento.Rows.Add("3", "Exámen psicológico", "C$ 200.00");
        }

        public void Cap11_12()
        {
            panelPrincipal14.BackColor = Colores.PanelPrincipal;
            label28.ForeColor = Colores.FuenteC;
            label28.BackColor = Colores.PanelPrincipal;
            label29.BackColor = Colores.PanelPrincipal;
            label29.ForeColor = Colores.FuenteC;
            listBoxCap11_12.ForeColor = Colores.FuenteC;
            listBoxCap11_12.BackColor = Colores.PanelPrincipal;
            listBoxCap12.BackColor = Colores.PanelPrincipal;
            listBoxCap12.ForeColor = Colores.FuenteC;
            iconButtonBeforeCap11_12.BackColor = Colores.PanelSuperior;
            iconButtonBeforeCap11_12.ForeColor = Colores.FuenteC;
            iconButtonBeforeCap11_12.IconColor = Colores.FuenteC;
        }
        #endregion

        #region->Botones de los paneles
        private void iconButtonBeforeCap1_1_Click(object sender, EventArgs e)
        {
            panelPrincipal.BringToFront();
        }

        private void iconButtonNextCap1_1_Click(object sender, EventArgs e)
        {
            panelPrincipal3.BringToFront();
        }

        private void iconButtonNextCap1_Click(object sender, EventArgs e)
        {
            panelPrincipal2.BringToFront();
        }

        private void iconButtonBeforeCap1_2_Click(object sender, EventArgs e)
        {
            panelPrincipal2.BringToFront();
        }

        private void iconButtonNextCap1_2_Click(object sender, EventArgs e)
        {
            panelPrincipal4.BringToFront();
        }

        private void iconButtonBeforeCap2_3_Click(object sender, EventArgs e)
        {
            panelPrincipal3.BringToFront();
        }

        private void iconButtonNextCap3_1_Click(object sender, EventArgs e)
        {
            panelPrincipal6.BringToFront();
        }

        private void iconButtonNextCap2_3_Click(object sender, EventArgs e)
        {
            panelPrincipal5.BringToFront();
        }

        private void iconButtonBeforeCap3_1_Click(object sender, EventArgs e)
        {
            panelPrincipal4.BringToFront();
        }

        private void iconButtonbeforeCap3_2_Click(object sender, EventArgs e)
        {
            panelPrincipal5.BringToFront();
        }

        private void iconButtonBeforeCap3_3_Click(object sender, EventArgs e)
        {
            panelPrincipal6.BringToFront();
        }

        private void iconButtonNextCap3_2_Click(object sender, EventArgs e)
        {
            panelPrincipal7.BringToFront();
        }

        private void iconButtonBeforeCap4_Click(object sender, EventArgs e)
        {
            panelPrincipal7.BringToFront();
        }

        private void iconButtonNextCap4_Click(object sender, EventArgs e)
        {
            panelPrincipal9.BringToFront();
        }

        private void iconButtonNextCap3_3_Click(object sender, EventArgs e)
        {
            panelPrincipal8.BringToFront();
        }

        private void iconButtonBeforeCap5_6_Click(object sender, EventArgs e)
        {
            panelPrincipal8.BringToFront();
        }

        private void iconButtonNextCap5_6_Click(object sender, EventArgs e)
        {
            panelPrincipal10.BringToFront();
        }

        private void iconButtonBeforeCap6_7_Click(object sender, EventArgs e)
        {
            panelPrincipal9.BringToFront();
        }

        private void iconButtonNextCap6_7_Click(object sender, EventArgs e)
        {
            panelPrincipal11.BringToFront();
        }

        private void iconButtonBeforeCap7_8_Click(object sender, EventArgs e)
        {
            panelPrincipal10.BringToFront();
        }

        private void iconButtonNextCap7_8_Click(object sender, EventArgs e)
        {
            panelPrincipal12.BringToFront();
        }

        private void iconButtonbeforeCap8_9_Click(object sender, EventArgs e)
        {
            panelPrincipal11.BringToFront();
        }

        private void iconButtonNextCap8_9_Click(object sender, EventArgs e)
        {
            panelPrincipal13.BringToFront();
        }

        private void iconButtonBeforeCap10_Click(object sender, EventArgs e)
        {
            panelPrincipal12.BringToFront();
        }

        private void iconButtonBeforeCap11_12_Click(object sender, EventArgs e)
        {
            panelPrincipal13.BringToFront();
        }

        private void iconButtonNextCap10_Click(object sender, EventArgs e)
        {
            panelPrincipal14.BringToFront();
        }
        #endregion
    }

}