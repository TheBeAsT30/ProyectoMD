using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD;

namespace MD
{
    public static class Colores
    {
        public static Color PanelPrincipal;
        public static Color PanelSuperior;
        public static Color PanelTemas;
        public static Color BotonesP;
        public static Color BotonesS;
        public static Color Fuente;
        public static Color FuenteA;
        public static Color PanelLateral;
        public static Color BackImagen;
        //Cafe
        private static readonly Color PanelSC = Color.FromArgb(58, 42, 5);
        private static readonly Color PanelPC = Color.FromArgb(131, 104, 27);
        private static readonly Color PanelTC = Color.FromArgb(131, 104, 27);
        private static readonly Color PanelLC = Color.FromArgb(176, 152, 61);
        private static readonly Color BackImagenC = Color.FromArgb(58, 42, 5);   
        private static readonly Color BotonesSC = Color.FromArgb(209, 178, 91);
        private static readonly Color FuenteC = Color.FromArgb(0, 0, 0);
        private static readonly Color FuenteAC = Color.FromArgb(210, 11, 3);
        //Oscuro
        private static readonly Color PanelSN = Color.FromArgb(0, 0, 0);
        private static readonly Color PanelPN = Color.FromArgb(35, 30, 29);
        private static readonly Color PanelLN = Color.FromArgb(72, 67, 66);
        private static readonly Color BackImagenN = Color.FromArgb(0, 0, 0);
        //private static readonly Color BotonesPN = Color.FromArgb(51, 34, 193);
        private static readonly Color BotonesSN = Color.FromArgb(128, 118, 117);
        private static readonly Color FuenteN = Color.FromArgb(255, 255, 255);
        private static readonly Color FuenteAN = Color.FromArgb(210, 11, 3);
        //Rojo
        private static readonly Color PanelSR = Color.FromArgb(208, 52, 24);
        private static readonly Color PanelPR = Color.FromArgb(79, 0, 0);
        private static readonly Color PanelLR = Color.FromArgb(176, 34, 13);
        private static readonly Color BackImagenR = Color.FromArgb(208, 52, 24);
        private static readonly Color BotonesPR = Color.FromArgb(143, 16, 2);
        private static readonly Color BotonesSR = Color.FromArgb(111, 0, 0);
        private static readonly Color FuenteR = Color.FromArgb(255, 255, 255);
        private static readonly Color FuenteAR = Color.FromArgb(255, 0, 0);
        //Azul
        private static readonly Color PanelSA = Color.FromArgb(12, 47, 67);
        private static readonly Color PanelPA = Color.FromArgb(45, 49, 85);    
        private static readonly Color PanelLA = Color.FromArgb(18, 60, 110);
        private static readonly Color BackImagenA = Color.FromArgb(12, 47, 67);
        private static readonly Color BotonesPA = Color.FromArgb(5, 0, 155);
        private static readonly Color BotonesSA = Color.FromArgb(0, 0, 126);
        private static readonly Color FuenteAzul = Color.FromArgb(255, 255, 255);
        private static readonly Color FuenteAA = Color.FromArgb(210, 11, 3);
        //Morado
        private static readonly Color PanelSM = Color.FromArgb(101, 7, 100);
        private static readonly Color PanelPM = Color.FromArgb(25, 0, 25);
        private static readonly Color PanelLM = Color.FromArgb(82, 0, 81);
        private static readonly Color BotonesPM = Color.FromArgb(63, 0, 62);
        private static readonly Color BotonesSM = Color.FromArgb(44, 0, 44);
        private static readonly Color FuenteM = Color.FromArgb(255, 255, 255);
        private static readonly Color FuenteAM = Color.FromArgb(210, 11, 3);
        private static readonly Color BackImagenM = Color.FromArgb(101, 7, 100);
        //Claro
        private static readonly Color PanelSBL = Color.FromArgb(229, 229, 229);
        private static readonly Color PanelPBL = Color.FromArgb(248, 248, 248);
        private static readonly Color PanelLBL = Color.FromArgb(219, 221, 212);
        private static readonly Color BotonesBL = Color.FromArgb(248, 248, 248);
        private static readonly Color FuenteBL = Color.FromArgb(255, 255, 255);
        //private static readonly Color FuenteABL = Color.FromArgb(210, 11, 3);
        private static readonly Color BackImagenVL = Color.FromArgb(229, 229, 229);

        #region ->Metodo
        public static void ElegirColor(string tema)
        {
            if (tema == "Cafe")
            {
                PanelPrincipal = PanelPC;
                PanelSuperior = PanelSC;
                PanelTemas = PanelTC;               
                BotonesS = BotonesSC;
                Fuente = FuenteC;
                FuenteA = FuenteAC;
                PanelLateral = PanelLC;
                BackImagen = BackImagenC;
            }
            else if (tema == "Oscuro")
            {
                PanelPrincipal = PanelPN;
                PanelSuperior = PanelSN;
                //BotonesP = BotonesPN;
                BotonesS = BotonesSN;
                Fuente = FuenteN;
                FuenteA = FuenteAN;
                PanelLateral = PanelLN;
                BackImagen = BackImagenN;
            }
            else if (tema == "Morado")
            {
                PanelPrincipal = PanelPM;
                PanelSuperior = PanelSM;
                BotonesP = BotonesPM;
                BotonesS = BotonesSM;
                Fuente = FuenteM;
                FuenteA = FuenteAM;
                PanelLateral = PanelLM;
                BackImagen = BackImagenM;
            }
            else if (tema == "Rojo")
            {
                PanelPrincipal = PanelPR;
                PanelSuperior = PanelSR;
                BotonesP = BotonesPR;
                BotonesS = BotonesSR;
                Fuente = FuenteR;
                FuenteA = FuenteAR;
                PanelLateral = PanelLR;
                BackImagen = BackImagenR;
            }
            else if (tema == "Azul")
            {
                PanelPrincipal = PanelPA;
                PanelSuperior = PanelSA;
                BotonesP = BotonesPA;
                BotonesS = BotonesSA;
                Fuente = FuenteAzul;
                FuenteA = FuenteAA;
                PanelLateral = PanelLA;
                BackImagen = BackImagenA;
            }
            else if (tema == "Claro")
            {
                PanelPrincipal = PanelPBL;
                PanelSuperior = PanelSBL;
                //BotonesP = BotonesBL;
                BotonesS = BotonesBL;
                //Fuente = FuenteAzul;
                //FuenteA = FuenteAA;
                PanelLateral = PanelLBL;
                BackImagen = BackImagenVL;
            }
        }
        #endregion
    }

}