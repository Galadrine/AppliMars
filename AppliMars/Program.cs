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



            DateTime deb = new DateTime(2015, 12, 01, 00, 01, 00);
            List<string> list = new List<string>();
            list.Add("Bob");
            list.Add("Charlie");
            list.Add("Popeye");
            Mission _mission = new Mission("Mars Attack", deb, 500, list,@"..//..//Mission1/");



            Application.Run(new WindowLevel1(_mission));
        }
    }
}
