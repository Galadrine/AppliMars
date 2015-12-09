using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppliMars {
    public partial class WindowLevel2 : Form {

        #region variables

        private WindowLevel1 _win1;
        private Journee _jour;
        private Activite _monactivite;
        
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


        #endregion


        #region constructeurs

        public WindowLevel2() {
            InitializeComponent();
        }

        /*
        public windowlevel2(string numerojour, applimars.windowlevel1 w1)
            : this() 
        {
            labeljour.text = numerojour;

            majournee = new journee(int32.parse(numerojour));
            mafenetreprec = w1;


            verifdifferentsedt();

        }
        */

        public WindowLevel2(Journee jour, AppliMars.WindowLevel1 w1)
            : this() {
            maFenetrePrec = w1;
            maJournee = jour;
            labelJour.Text = maJournee.monNumero.ToString();
            this.Text = maFenetrePrec.maMission.monNomMission + " - Jour " + maJournee.monNumero;
            insertionActivitesListBox();
        }

        #endregion


        #region methodes

        private void majActivites() {

        }

        private void verifDifferentsEDT() {

        }

        public void insertionActivitesListBox() {
            string stringActivite;
            foreach (Activite A in maJournee.maListeActivites) {
                stringActivite = A.getDetailsActivites();
                listBoxActivites.Items.Add(stringActivite);

            }
        }

        #endregion


        #region evenements

        private void pictureBoxJourPrecedent_Click(object sender, EventArgs e) {
            if (_jour.monNumero != 1) {
                labelJour.Text = (Int32.Parse(labelJour.Text)-1).ToString();
                majActivites();
            }
        }

        private void pictureBoxJourSuivant_Click(object sender, EventArgs e) {
            if (_jour.monNumero != 500) {
                labelJour.Text = (Int32.Parse(labelJour.Text) + 1).ToString();
                majActivites();
            }
        }

        private void buttonAjoutActivite_Click(object sender, EventArgs e) {
            Button but = sender as Button;
            WindowLevel3 win3 = new WindowLevel3(maJournee, this);
            win3.Show();
            this.Hide();
        }

        private void buttonRetourCalendrier_Click(object sender, EventArgs e) {
            this.Close();
            maFenetrePrec.Show();
        }


        private void detailActivite(object sender, EventArgs e) {
            Button but = sender as Button;
            WindowLevel3 win3 = new WindowLevel3(monactiviteSelectionnee, maJournee, this);
            win3.Show();
            this.Hide();
        }

        private void buttonCompteRendu_Click(object sender, EventArgs e) {
            Button but = sender as Button;
            WindowRecord winrec = new WindowRecord(maJournee, this);
            winrec.Show();
            this.Hide();
        }


        private void listBoxActivites_SelectedIndexChanged(object sender, EventArgs e) {
            buttonGoToLevel3.Visible = true;
            monactiviteSelectionnee = maJournee.maListeActivites[listBoxActivites.SelectedIndex];
        }
        #endregion

    }
}
