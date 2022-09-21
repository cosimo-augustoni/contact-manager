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

            //TODO Unklarheiten Dokumentieren und Kommentieren in Search-Domäne (Päddy)

            //TODO Code Cleanup (Cosimo)
            //TODO Ausführliches Testing mit Fixes (Cosimo)
            //TODO Klassendiagram (Cosimo)
            //TODO Stundenprotokoll vervollstädigen
            //TODO Text-Datei mit Applikationsbeschreib (Vorschlag: Cosimo, Review/Ergänzungen: Päddy/Luca)

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
