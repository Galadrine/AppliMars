using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AppliMars {
    public partial class WindowLevel2 : Form {

        #region variables

        private WindowLevel1 _win1;
        private Journee _jour;
        private Activite _monactivite;
        private int _idAstronauteEnCours;
        private Astronaute _astronaute;

        #endregion


        #region accesseurs

        public WindowLevel1 maFenetrePrec {
            get { return _win1; }
            set { _win1 = value; }
        }

        public Journee maJournee {
            get { return _jour; }
            set { _jour = value; }
        }

        public Activite monactiviteSelectionnee {
            get { return _monactivite; }
            set { _monactivite = value; }
        }

        public int monIdAstronaute {
            get { return _idAstronauteEnCours; }
            set { _idAstronauteEnCours = value; }
        }

        public Astronaute monAstronaute {
            get { return _astronaute; }
            set { _astronaute = value; }
        }

        #endregion


        #region constructeurs

        public WindowLevel2() {
            InitializeComponent();
        }

        public WindowLevel2(Journee jour, AppliMars.WindowLevel1 w1)
            : this() {
            maFenetrePrec = w1;
            maJournee = jour;
            refreshPage();
            monIdAstronaute = 0;
        }

        #endregion


        #region methodes

        public void insertionActivitesListBox() {
            listBoxActivites.Items.Clear();

            List<string> activitesAstronauteEnCours = new List<string>();

            foreach (Activite A in maJournee.maListeActivites) {
                foreach (Astronaute Astro in A.mesAstronautes) {
                    if (Astro.monNom == monAstronaute.monNom) {
                        activitesAstronauteEnCours.Add(A.getDetailsActivites());
                    }
                }
            }

            activitesAstronauteEnCours = activitesAstronauteEnCours.OrderBy(q => q).ToList();

            foreach (string item in activitesAstronauteEnCours) {
                listBoxActivites.Items.Add(item);
            }

        }

        public void refreshPage() {
            monAstronaute = maJournee.maMission.mesAstronautes[monIdAstronaute];
            labelJour.Text = maJournee.monNumero.ToString("D3");
            this.Text = maFenetrePrec.maMission.monNomMission + " - Jour " + maJournee.monNumero.ToString("D3");
            insertionActivitesListBox();
            labelNomEmploiDuTemps.Text = maJournee.maMission.mesAstronautes[monIdAstronaute].monNom;
        }

        #endregion


        #region evenements

        private void pictureBoxJourPrecedent_Click(object sender, EventArgs e) {
            if (maJournee.monNumero != 1) {
                maJournee = maFenetrePrec.maMission.monPlanning.monTableauJournees[maJournee.monNumero - 2];
                refreshPage();
            }
        }

        private void pictureBoxJourSuivant_Click(object sender, EventArgs e) {
            if (maJournee.monNumero != maFenetrePrec.maMission.monPlanning.monTableauJournees.Count) {
                maJournee = maFenetrePrec.maMission.monPlanning.monTableauJournees[maJournee.monNumero];
                refreshPage();
            }
        }

        private void buttonAjoutActivite_Click(object sender, EventArgs e) {
            Button but = sender as Button;
            WindowNewAct winNA = new WindowNewAct(maJournee, this);
            winNA.Show();
            this.Hide();
        }

        private void buttonRetourCalendrier_Click(object sender, EventArgs e) {
            this.Close();
            maFenetrePrec.updateImageButtons();
            maFenetrePrec.Show();
        }

        private void buttonCompteRendu_Click(object sender, EventArgs e) {
            Button but = sender as Button;
            WindowRecord winrec = new WindowRecord(maJournee, this);
            winrec.Show();
            this.Hide();
        }

        private void listBoxActivites_SelectedIndexChanged(object sender, EventArgs e) {
            if (listBoxActivites.SelectedIndex >= 0) {
                buttonModifAct.Visible = true;
                buttonDelete.Visible = true;
                groupBox1.Visible = true;
                monactiviteSelectionnee = maJournee.maListeActivites[listBoxActivites.SelectedIndex];
            }
        }

        private void pictureBoxEDTSuiv_Click(object sender, EventArgs e) {
            monIdAstronaute++;
            if (monIdAstronaute >= maJournee.maMission.mesAstronautes.Count) {
                monIdAstronaute=0;
            }
            refreshPage();
        }

        private void pictureBoxEDTPrec_Click(object sender, EventArgs e) {
            monIdAstronaute--;
            if (monIdAstronaute < 0) {
                monIdAstronaute = maJournee.maMission.mesAstronautes.Count-1;
            }
            refreshPage();
        }

        private void buttonDeleteAct_Click(object sender, EventArgs e) {
            DialogResult dlgRes = DialogResult.No;
            dlgRes = MessageBox.Show(
            "Voulez-vous vraiment supprimer cette activité ?",
            "Confirmation suppression activité",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (dlgRes == DialogResult.Yes) {
                // SupprimerActivite();
                string fileName = maFenetrePrec.maMission.monCheminPlanningXML;
                XDocument doc = XDocument.Load(fileName);
                var act = (from activite in doc.Descendants("Activite") where (string)activite.Attribute("idAct") == monactiviteSelectionnee.monID.ToString() select activite).ToList();
                Console.WriteLine();
                foreach (var node in act)
                    node.Remove();
                doc.Save(fileName);

                Journee journeeAModif = maFenetrePrec.maMission.monPlanning.monTableauJournees[maJournee.monNumero - 1];
                int indexActAModif = journeeAModif.getPosActiviteByIdAct(monactiviteSelectionnee.monID);
                Activite actAModif = journeeAModif.maListeActivites[indexActAModif];
                journeeAModif.maListeActivites.Remove(actAModif);

                this.insertionActivitesListBox();
            }
        }

        private void buttonModifAct_Click(object sender, EventArgs e) {
            WindowLevel3 win3 = new WindowLevel3(monactiviteSelectionnee, maJournee, this);
            win3.Show();
            this.Hide();

        }

        #endregion

    }
}
