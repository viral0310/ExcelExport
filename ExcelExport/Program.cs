namespace ExcelExport
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
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NCaF5cWWFCdkx3RHxbf1x0ZFBMYF5bRXZPMyBoS35RckVkWHledXZQQ2FaUUN/");
            Application.EnableVisualStyles();
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}