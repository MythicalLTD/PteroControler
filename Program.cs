using PteroController.Forms;
using PteroController.Managers;

namespace PteroController
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static string AppVersion = "1.0.0";
        public static LoggerManager logger = new LoggerManager();
        public static string mcascii = @" 
  _____  _                  _____            _             _ _           
 |  __ \| |                / ____|          | |           | | |          
 | |__) | |_ ___ _ __ ___ | |     ___  _ __ | |_ _ __ ___ | | | ___ _ __ 
 |  ___/| __/ _ \ '__/ _ \| |    / _ \| '_ \| __| '__/ _ \| | |/ _ \ '__|
 | |    | ||  __/ | | (_) | |___| (_) | | | | |_| | | (_) | | |  __/ |   
 |_|     \__\___|_|  \___/ \_____\___/|_| |_|\__|_|  \___/|_|_|\___|_|   
                                                                                 
    ";
        [STAThread]
        public static void Main()
        {
            ApplicationConfiguration.Initialize();
            if (!OperatingSystem.IsWindows())
            {
                logger.Log(LogType.Error, "We are sorry, but we blocked this app from running on any other OS than Windows!");
                Application.Exit();
            }
            if (!File.Exists(Application.StartupPath + @"\PteroConsole.exe"))
            {
                Application.Run(new FrmInstallTools());
            }
            else
            {
                Application.Run(new FrmLoading());
            }

        }
        public static void Alert(string msg, FrmAlert.enmType type)
        {
            FrmAlert frm = new FrmAlert();
            frm.showAlert(msg, type);
        }
    }
}