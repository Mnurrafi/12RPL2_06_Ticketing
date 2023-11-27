using _12RPL2_06_Ticketing.masterform;

namespace _12RPL2_06_Ticketing
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
            //FormLogin formLogin = new FormLogin();
            //formLogin.Show();
            FormMasterBandara bandara = new FormMasterBandara();
            bandara.Show();

            //FormMasterMaskapai maskapai = new FormMasterMaskapai();
            //maskapai.Show();

            //FormMasterKodePromo kodePromo = new FormMasterKodePromo();
            //kodePromo.Show();

            Application.Run();
        }
    }
}