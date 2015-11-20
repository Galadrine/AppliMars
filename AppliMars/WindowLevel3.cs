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
    public partial class WindowLevel3 : Form {

        #region variables

        AppliMars.WindowLevel2 win2;
        Activite act;


        #endregion

        #region constructeurs

        public WindowLevel3() {
            InitializeComponent();
            

        }

        public WindowLevel3(string numeroJour, AppliMars.WindowLevel2 w2)
            : this() {
                win2 = w2;
                labelNumeroJour.Text = (win2.maJournee.monNumero).ToString();
                
        }


        #endregion


        #region methodes

        public void SupprimerActivite() {

        }

            
        #endregion


        #region evenements


        private void buttonRetourJournee_Click(object sender, EventArgs e) {
            this.Close();
            win2.Show();
        }

        private void pictureBoxMap_Click(object sender, EventArgs e) {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = me.Location;


            TextBoxAbscisse.Text = (coordinates.X * 3).ToString();
            TextBoxOrdonnee.Text = (coordinates.Y * 3).ToString();

        }

        private void TextBoxAbscisse_KeyPress(object sender, KeyPressEventArgs e) {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void TextBoxOrdonnee_KeyPress(object sender, KeyPressEventArgs e) {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void checkBoxLocalisation_CheckedChanged(object sender, EventArgs e) {
            if (checkBoxLocalisation.Checked) {
                labelCoordonnees.Visible = true;
                labelLongitude.Visible = true;
                labelLatitude.Visible = true;
                TextBoxAbscisse.Visible = true;
                TextBoxOrdonnee.Visible = true;
            } else {
                labelCoordonnees.Visible = false;
                labelLongitude.Visible = false;
                labelLatitude.Visible = false;
                TextBoxAbscisse.Visible = false;
                TextBoxOrdonnee.Visible = false;

            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e) {
            DialogResult dlgRes = DialogResult.No;
            dlgRes = MessageBox.Show(
            "Voulez-vous vraiement supprimer cette activité ?",
            "Confirmation suppression activité",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (dlgRes == DialogResult.Yes) {
                SupprimerActivite();
            }

        }

        #endregion

    }
}
