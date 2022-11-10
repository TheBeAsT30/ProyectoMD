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
        public static Color FuenteC;
        public static Color FuenteO;
        public static Color PanelLateral;
        public static Color BackImagen;
        //Cafe
        private static readonly Color PanelSC = Color.FromArgb(58, 42, 5);
        private static readonly Color PanelPC = Color.FromArgb(131, 104, 27);
        private static readonly Color PanelTC = Color.FromArgb(131, 104, 27);
        private static readonly Color PanelLC = Color.FromArgb(176, 152, 61);
        private static readonly Color BackImagenC = Color.FromArgb(58, 42, 5);   
        private static readonly Color BotonesSC = Color.FromArgb(209, 178, 91);
        private static readonly Color FuenteNC = Color.FromArgb(0, 0, 0);
        private static readonly Color FuenteAC = Color.FromArgb(210, 11, 3);
        //Oscuro
        private static readonly Color PanelSN = Color.FromArgb(0, 0, 0);
        private static readonly Color PanelPN = Color.FromArgb(35, 30, 29);
        private static readonly Color PanelLN = Color.FromArgb(72, 67, 66);
        private static readonly Color BackImagenN = Color.FromArgb(0, 0, 0);
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
        private static readonly Color BotonesSA = Color.FromArgb(12, 47, 67);
        private static readonly Color FuenteAzul = Color.FromArgb(255, 255, 255);
        private static readonly Color FuenteAA = Color.FromArgb(210, 11, 3);
        //Morado
        private static readonly Color PanelSM = Color.FromArgb(101, 7, 100);
        private static readonly Color PanelPM = Color.FromArgb(25, 0, 25);
        private static readonly Color PanelLM = Color.FromArgb(82, 0, 81);
        private static readonly Color BotonesSM = Color.FromArgb(44, 0, 44);
        private static readonly Color FuenteM = Color.FromArgb(255, 255, 255);
        private static readonly Color FuenteAM = Color.FromArgb(210, 11, 3);
        private static readonly Color BackImagenM = Color.FromArgb(101, 7, 100);
        //Verde
        private static readonly Color PanelSV = Color.FromArgb(36, 115, 71);
        private static readonly Color PanelPV = Color.FromArgb(18, 52, 45);
        private static readonly Color PanelLV = Color.FromArgb(18, 75, 55);
        private static readonly Color BotonesSV = Color.FromArgb(36, 115, 71);
        private static readonly Color BackImagenV = Color.FromArgb(36, 115, 71);
        private static readonly Color FuenteV = Color.FromArgb(255, 255, 255);
        private static readonly Color FuenteV2 = Color.FromArgb(0, 0, 0);
        //Rosa
        private static readonly Color PanelSRS = Color.FromArgb(98, 41, 90);
        private static readonly Color PanelPRS = Color.FromArgb(100, 22, 65);
        private static readonly Color PanelLRS = Color.FromArgb(143, 50, 102);
        private static readonly Color BotonesSRS = Color.FromArgb(98, 41, 90);
        private static readonly Color BackImagenRS = Color.FromArgb(98, 41, 90);
        private static readonly Color FuenteRo = Color.FromArgb(255, 255, 255);
        private static readonly Color FuenteRo2 = Color.FromArgb(0, 0, 0);
        //Celeste
        private static readonly Color PanelSCE = Color.FromArgb(10, 102, 155);
        private static readonly Color PanelPCE = Color.FromArgb(12, 72, 123);
        private static readonly Color PanelLCE = Color.FromArgb(8, 152, 202);
        private static readonly Color BotonesSCE = Color.FromArgb(10, 102, 155);
        private static readonly Color BackImagenCE = Color.FromArgb(10, 102, 155);
        private static readonly Color FuenteCE = Color.FromArgb(255, 255, 255);
        private static readonly Color FuenteCE2 = Color.FromArgb(0, 0, 0);
        //Claro
        private static readonly Color PanelSBL = Color.FromArgb(229, 229, 229);
        private static readonly Color PanelPBL = Color.FromArgb(248, 248, 248);
        private static readonly Color PanelLBL = Color.FromArgb(219, 221, 212);
        private static readonly Color BotonesBL = Color.FromArgb(248, 248, 248);
        private static readonly Color BackImagenVL = Color.FromArgb(229, 229, 229);
        private static readonly Color FuenteCA = Color.FromArgb(255, 255, 255);
        private static readonly Color FuenteCA2 = Color.FromArgb(0, 0, 0);

        #region ->Metodo
        public static void ElegirColor(string tema)
        {
            if (tema == "Cafe")
            {
                PanelPrincipal = PanelPC;
                PanelSuperior = PanelSC;
                PanelTemas = PanelTC;               
                BotonesS = BotonesSC;
                FuenteC = FuenteNC;
                FuenteO = FuenteAC;
                PanelLateral = PanelLC;
                BackImagen = BackImagenC;
            }
            else if (tema == "Oscuro")
            {
                PanelPrincipal = PanelPN;
                PanelSuperior = PanelSN;
                //BotonesP = BotonesPN;
                BotonesS = BotonesSN;
                FuenteC = FuenteN;
                FuenteO = FuenteAN;
                PanelLateral = PanelLN;
                BackImagen = BackImagenN;
            }
            else if (tema == "Morado")
            {
                PanelPrincipal = PanelPM;
                PanelSuperior = PanelSM;
                BotonesS = BotonesSM;
                FuenteC = FuenteM;
                FuenteO = FuenteAM;
                PanelLateral = PanelLM;
                BackImagen = BackImagenM;
            }
            else if (tema == "Rojo")
            {
                PanelPrincipal = PanelPR;
                PanelSuperior = PanelSR;
                //BotonesP = BotonesPR;
                BotonesS = BotonesSR;
                FuenteC = FuenteR;
                FuenteO = FuenteAR;
                PanelLateral = PanelLR;
                BackImagen = BackImagenR;
            }
            else if (tema == "Azul")
            {
                PanelPrincipal = PanelPA;
                PanelSuperior = PanelSA;
                //BotonesP = BotonesPA;
                BotonesS = BotonesSA;
                FuenteC = FuenteAzul;
                FuenteO = FuenteAA;
                PanelLateral = PanelLA;
                BackImagen = BackImagenA;
            }
            else if (tema == "Verde")
            {
                PanelPrincipal = PanelPV;
                PanelSuperior = PanelSV;
                BotonesS = BotonesSV;
                PanelLateral = PanelLV;
                BackImagen = BackImagenV;
                FuenteC = FuenteV;
                FuenteO = FuenteV2;
            }
            else if (tema == "Rosa")
            {
                PanelPrincipal = PanelPRS;
                PanelSuperior = PanelSRS;
                BotonesS = BotonesSRS;
                PanelLateral = PanelLRS;
                BackImagen = BackImagenRS;
                FuenteC = FuenteRo;
                FuenteO = FuenteRo2;
            }
            else if (tema == "Celeste")
            {
                PanelPrincipal = PanelPCE;
                PanelSuperior = PanelSCE;
                BotonesS = BotonesSCE;
                PanelLateral = PanelLCE;
                BackImagen = BackImagenCE;
                FuenteC = FuenteCE;
                FuenteO = FuenteCE2;
            }
            else if (tema == "Claro")
            {
                PanelPrincipal = PanelPBL;
                PanelSuperior = PanelSBL;
                BotonesS = BotonesBL;
                FuenteC = FuenteCA;
                FuenteO = FuenteCA2;
                PanelLateral = PanelLBL;
                BackImagen = BackImagenVL;
            }
        }
        #endregion
    }

}