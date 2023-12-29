using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SplitVideo
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string directoryToAdd = @"C:\Program Files\Encodal\SplitVideo\ffmpeg"; // Replace with your directory path

            // Get the current PATH environment variable
            string currentPath = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Machine);

            // Split the PATH variable into individual paths
            string[] pathDirectories = currentPath.Split(';');

            if (Directory.Exists(directoryToAdd))
            {
                if (!pathDirectories.Contains(directoryToAdd))
                {
                    string newPath = string.IsNullOrEmpty(currentPath)
                        ? directoryToAdd
                        : $"{currentPath};{directoryToAdd}";

                    Environment.SetEnvironmentVariable("PATH", newPath, EnvironmentVariableTarget.Machine);
                }
            }

                Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //Application.Run(new Enter_Video());





        }
    }
}
