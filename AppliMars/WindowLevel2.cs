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


        #endregion

        #region constructeurs

        public WindowLevel2() {
            InitializeComponent();

        }

       // public windowlevel2(string numerojour, applimars.windowlevel1 w1)
       //     : this() 
       // {
       //     labeljour.text = numerojour;

       //     majournee = new journee(int32.parse(numerojour));
       //     mafenetreprec = w1;


       //     verifdifferentsedt();

       //}

        public WindowLevel2(Journee jour, AppliMars.WindowLevel1 w1)
        {
            _win1 = w1;
            _jour = jour;
            labelJour.Text = _jour.monNumero.ToString();
        }

        #endregion

        #region methodes

        private void majActivites() {

        }

        private void verifDifferentsEDT() {

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
            WindowLevel3 win2 = new WindowLevel3(but.Text, this);
            win2.Show();
            this.Hide();
        }

        private void buttonRetourCalendrier_Click(object sender, EventArgs e) {
            this.Close();
            _win1.Show();
        }


        private void detailActivite(object sender, EventArgs e) {
            Button but = sender as Button;
            WindowLevel3 win3 = new WindowLevel3(but.Text, this, 0);
            win3.Show();
            this.Hide();
        }

        private void buttonCompteRendu_Click(object sender, EventArgs e) {
            Button but = sender as Button;
            WindowRecord winrec = new WindowRecord(maJournee, this);
            winrec.Show();
            this.Hide();
        }

        #endregion







    }
}
