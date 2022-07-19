using Entra21.BancoDeDados01.Ado.Net.Views;
using Entra21.BancoDeDados01.Ado.Net.Views.Personagens;
using Entra21.BancoDeDados01.Ado.Net.Views.TiposPersonagens;

namespace Entra21.BancoDeDados01.Ado.Net
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
            Application.Run(new MenuPrincipalForm());
        }
    }
}