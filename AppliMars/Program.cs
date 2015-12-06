using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliMars {
    static class Program {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (File.Exists(@"..//..//XML//General.xml")) {

            } else {

            }

            if (File.Exists(@"..//..//XML//Planning.xml")) {

            } else {

            }


            /*
            // Création d'une mission à la main
            datetime deb = new datetime(2015, 12, 01, 00, 01, 00);
            list<string> list = new list<string>();
            list.add("bob");
            list.add("charlie");
            list.add("popeye");
            mission _mission = new mission("mars attack", deb, 500, list, @"..//..//mission1/");

            Application.Run(new WindowLevel1(_mission));
            */


            Application.Run(new WindowLevel0());
        }
    }
}
