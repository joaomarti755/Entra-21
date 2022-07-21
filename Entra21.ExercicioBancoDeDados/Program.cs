using Entra21.ExercicioBancoDeDados.Views.UnidadeFederativa;

namespace Entra21.BancoDados01.Ado.Net
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new UnidadeFederativaCadastroEdicaoForm());
        }
    }
}
