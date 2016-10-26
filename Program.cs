using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Squirrel;

namespace MyApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //using (var mgr = UpdateManager.GitHubUpdateManager("https://github.com/rsoleykin/MyApp"))
            //{
            //    mgr.Result.UpdateApp();
            //}

            //new TaskFactory().StartNew(async () =>
            //        {
            //            using (var mgr = new UpdateManager("D:\\Download\\MyApp\\Releases"))
            //            {
            //                await mgr.UpdateApp();
            //            }
            //        });


            new TaskFactory().StartNew(async () =>
                    {
                        using (var mgr = UpdateManager.GitHubUpdateManager("https://github.com/rsoleykin/MyApp"))
                        {
                            await mgr.Result.UpdateApp();
                        }
                    });

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
