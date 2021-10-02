using System.Diagnostics;
using System.Windows;
using System.Windows.Threading;

namespace RDM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Save an unhandled exception.
        /// </summary>
        private void Application_DispatcherUnhandledException(object sender,
            DispatcherUnhandledExceptionEventArgs e)
        {
            //e.Exception.Save();
            e.Handled = true;
        }
        /// <summary>
        /// Method to run when the application closes.
        /// </summary>
        private void Application_Exit(object sender, ExitEventArgs e)
        {
            (Process.GetCurrentProcess()).Kill();
        }
    }
}
