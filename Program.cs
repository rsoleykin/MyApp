using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Squirrel;

namespace MyApp
{
    using System.Net;

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            new TaskFactory().StartNew(async () =>
                    {
                        using (var mgr = new UpdateManager("D:\\Download\\MyApp\\Releases", "D:\\Download\\SomeTest", "Renat App"))
                        {
                            await mgr.UpdateApp();
                        }
                    });

            //new TaskFactory().StartNew(async () =>
            //        {
            //            using (var mgr = UpdateManager.GitHubUpdateManager("https://github.com/rsoleykin/MyApp/releases/latest", rootDirectory: "C:\\Program Files (x86)\\TestingFolder"))
            //            {
            //                await mgr.Result.UpdateApp();
            //            }
            //        });

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
