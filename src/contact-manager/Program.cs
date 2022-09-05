using System.Diagnostics;
using contact_manager.Models.Domain.Authentication;
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
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            // todo: noch anpassen

            var formFactory = new DefaultFormFactory();

            if (Debugger.IsAttached)
            {
                // todo: direct login nur für die Entwicklungsphase
                var overviewView = formFactory.CreateOverview(Users.AdminUser);
                Application.Run(overviewView);
            }
            else
            {
                var loginForm = formFactory.CreateLoginDialog();
                Application.Run(loginForm);
            }
        }
    }
}
