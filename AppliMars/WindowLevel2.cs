﻿using System;
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

        AppliMars.WindowLevel1 win1;
        Journee jour;

        #endregion

        #region constructeurs

        public WindowLevel2() {
            InitializeComponent();

        }

        public WindowLevel2(string numeroJour, AppliMars.WindowLevel1 w1)
            : this() {
            labelJour.Text = numeroJour;

            jour = new Journee( Int32.Parse(numeroJour));
            win1 = w1;
        }

        #endregion


        #region methodes

        private void majActivites() {

        }

        #endregion

        #region evenements

        private void pictureBoxJourPrecedent_Click(object sender, EventArgs e) {
            if (jour._numero != 1) {
                labelJour.Text = (Int32.Parse(labelJour.Text)-1).ToString();
                majActivites();
            }
        }

        private void pictureBoxJourSuivant_Click(object sender, EventArgs e) {
            if (jour._numero != 500) {
                labelJour.Text = (Int32.Parse(labelJour.Text) + 1).ToString();
                majActivites();
            }
        }

        private void buttonAjoutActivite_Click(object sender, EventArgs e) {

        }

        private void buttonRetourCalendrier_Click(object sender, EventArgs e) {
            this.Close();
            win1.Show();
        }


        private void detailActivite(object sender, EventArgs e) {
            Button but = sender as Button;
            WindowLevel3 win2 = new WindowLevel3(but.Text, this);
            win2.Show();
            this.Hide();
        }

        #endregion





    }
}
