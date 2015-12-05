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
    public partial class WindowNewMission : Form
    {
        List<string> _listeAstronautes = new List<string>();

        public WindowNewMission()
        {
            InitializeComponent();
            lB_ListeAstroNvMission.DataSource = _listeAstronautes;
        }

        private void b_NewAstro_Click(object sender, EventArgs e)
        {
            string nvAstro = tB_nvAstro.Text;
            if (!String.IsNullOrWhiteSpace(nvAstro))
                _listeAstronautes.Add(tB_nvAstro.Text);
            lB_ListeAstroNvMission.DataSource = null;
            lB_ListeAstroNvMission.DataSource = _listeAstronautes;
            tB_nvAstro.Clear();
        }

        private void b_DelAstro_Click(object sender, EventArgs e)
        {
            int selectedIndex = lB_ListeAstroNvMission.SelectedIndex;
            try
            {
                _listeAstronautes.RemoveAt(selectedIndex);
            }
            catch { }
            lB_ListeAstroNvMission.DataSource = null;
            lB_ListeAstroNvMission.DataSource = _listeAstronautes;
        }

        private void b_creerNvMission_Click(object sender, EventArgs e)
        {
            // Récupération du fichier cible pour sauver les XML de la mission
            string cheminPourFichiersXML = "";
            FolderBrowserDialog dossier = new FolderBrowserDialog();

            //dossier.ShowDialog();
            if ( dossier.ShowDialog() == DialogResult.OK)
            {
                cheminPourFichiersXML = dossier.SelectedPath;
            }
            // Récupération des données
            string nomMission = tB_nomNvMission.Text;
            DateTime dateDebut = dT_DateDebNvMission.Value.Date;
            int dureeMission = int.Parse(tB_dureeNvMission.Text);
            List<string> astronautes = _listeAstronautes;
            Mission _mission = new Mission(nomMission, dateDebut, dureeMission, astronautes, cheminPourFichiersXML);
            WindowLevel1 win1 = new WindowLevel1(_mission);
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
    }
}
