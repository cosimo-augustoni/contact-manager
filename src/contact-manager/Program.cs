using contact_manager.Views;

namespace contact_manager
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            try
            {
                var formFactory = new DefaultFormFactory();
                var loginForm = formFactory.CreateLoginDialog();
                Application.Run(loginForm);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"Unerwarteter Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
