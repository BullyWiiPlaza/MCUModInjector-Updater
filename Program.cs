using System;
using System.Windows.Forms;

namespace Minecraft_Wii_U_Mod_Injector_Updater
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] arguments)
        {
            var repositoryBaseUrl = "https://github.com/BullyWiiPlaza/Minecraft-Wii-U-Mod-Injector";
            if (arguments.Length == 0)
            {
                MainForm.DownloadUrl = repositoryBaseUrl + "/releases/latest/download/Minecraft.Wii.U.Mod.Injector.exe";
            }
            else
            {
                MainForm.DownloadUrl = repositoryBaseUrl + "/releases/" + arguments[0] + "/download/Minecraft.Wii.U.Mod.Injector.exe";
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}