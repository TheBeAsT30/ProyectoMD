using GUI_Moderno;
using MD;
namespace MD
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();            
            Application.Run(new Form_principal());
            //Application.Run(new Form_login());
            //Application.Run(new Form_Register());
            //Application.Run(new Form_Recuperar());
            //Application.Run(new Form_NuevoPass());   
            //Application.Run(new Form_cap());
            //Application.Run(new Form_Estudio());         
            //Application.Run(new FormPresentacion());
            //Application.Run(new Form_Leyes());
            //Application.Run(new Form_Senales());


        }
    }
}