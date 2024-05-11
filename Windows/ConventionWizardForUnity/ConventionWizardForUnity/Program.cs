namespace ConventionWizardForUnity
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            ApplicationConfiguration.Initialize();
            (new InitializingForm()).Show();
            Application.Run();
        }
    }
}