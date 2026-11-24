using ProjetoVenda.controle;
using ProjetoVenda.formulario;
using QuestPDF.Infrastructure;
namespace ProjetoVenda
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            QuestPDF.Settings.License = LicenseType.Community;
            
            ApplicationConfiguration.Initialize();
            //Application.Run(new frmLogin());
            //Relatorio relatorio = new Relatorio();
            //relatorio.salvarPdf();

            while (true) 
            {

                using (frmLogin login = new frmLogin())
                {
                    if (login.ShowDialog() != DialogResult.OK)
                    {
                        break;
                
                    }
                }
                using (frmPrincipal principal = new frmPrincipal())
                {
                    Application.Run(principal);
                    if (principal.DialogResult != DialogResult.Retry)
                    {
                        break;
                    }
                }
                    
            }
        }
    }
}