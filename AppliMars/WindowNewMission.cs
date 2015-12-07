using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliMars
{
    public partial class WindowNewMission : Form {

        #region variables

        private List<string> _listeAstronautes = new List<string>();
        private WindowLevel0 _win0;

        #endregion


        #region accesseurs

        public List<string> maListeAstronautes {
            get { return _listeAstronautes; }
            set { _listeAstronautes = value; }
        }

        public WindowLevel0 maFenetrePrec {
            get { return _win0; }
            set { _win0 = value; }
        }
        

        #endregion


        #region constructeurs

        public WindowNewMission(WindowLevel0 win) {
            InitializeComponent();
            maFenetrePrec = win;

            lB_ListeAstroNvMission.DataSource = maListeAstronautes;
        }

        #endregion


        #region méthodes


        #endregion


        #region évènements

        private void b_NewAstro_Click(object sender, EventArgs e)
        {
            string nvAstro = tB_nvAstro.Text;
            if (!String.IsNullOrWhiteSpace(nvAstro))
                maListeAstronautes.Add(tB_nvAstro.Text);
            lB_ListeAstroNvMission.DataSource = null;
            lB_ListeAstroNvMission.DataSource = maListeAstronautes;
            tB_nvAstro.Clear();
        }

        private void b_DelAstro_Click(object sender, EventArgs e)
        {
            int selectedIndex = lB_ListeAstroNvMission.SelectedIndex;
            try
            {
                maListeAstronautes.RemoveAt(selectedIndex);
            }
            catch { }
            lB_ListeAstroNvMission.DataSource = null;
            lB_ListeAstroNvMission.DataSource = maListeAstronautes;
        }

        private void b_creerNvMission_Click(object sender, EventArgs e)
        {
            // Récupération du fichier cible pour sauver les XML de la mission
            string cheminPourFichiersXML = "..//..//Missions//";

            // Récupération des données
            string nomMission = tB_nomNvMission.Text;
            DateTime dateDebut = dT_DateDebNvMission.Value.Date;
            int dureeMission = int.Parse(tB_dureeNvMission.Text);
            List<string> astronautes = maListeAstronautes;
            Mission _mission = new Mission(nomMission, dateDebut, dureeMission, astronautes, cheminPourFichiersXML);
            WindowLevel1 win1 = new WindowLevel1(_mission, maFenetrePrec);

            maFenetrePrec.refreshListBox();
            this.Close();
            win1.Show();
        }

        private void tB_dureeNvMission_TextChanged(object sender, EventArgs e)
        {
            int dureeNvMission;
            bool test = int.TryParse(tB_dureeNvMission.Text, out dureeNvMission);
            if (test == false)
            {
                b_creerNvMission.Visible = false;
                tB_dureeNvMission.ForeColor = Color.Red;
            }
            else
            {
                b_creerNvMission.Visible = true;
                tB_dureeNvMission.ForeColor = Color.Black;
            }
        }

        private void buttonRetourChoixMission_Click(object sender, EventArgs e) {
            this.Close();
            maFenetrePrec.Show();
        }

        #endregion


    }
}
