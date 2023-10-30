using CamundaForm.CamundaForms;

namespace CamundaForm
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.ThreadException += new ThreadExceptionEventHandler(Application_ThreadException);
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

  
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMain());
        }

 
        private static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show($"{e.Exception.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            Exception exception = e.ExceptionObject as Exception;
            MessageBox.Show($"{exception?.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}