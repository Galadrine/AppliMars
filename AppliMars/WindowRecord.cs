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
    public partial class WindowRecord : Form {

        #region variables

        AppliMars.WindowLevel2 win2;
        bool journeePasse = false;

        #endregion 



        #region constructeurs 

        public WindowRecord(string numeroJour, AppliMars.WindowLevel2 w2)
            : this() {
            win2 = w2;

            this.Text = "Compte-rendu du jour "+(win2.maJournee.monNumero).ToString();
            labelCompteRendu.Text = "Compte-rendu du jour " + (win2.maJournee.monNumero).ToString();


            // Insérer ici le code pour vérifier si le jour est passé ou pas
            if (false) {




                journeePasse = true;

            }


        }


        public WindowRecord() {
            InitializeComponent();
        }


        #endregion


        #region methodes 



        #endregion


        #region evenements 

        private void buttonRetourJournee_Click(object sender, EventArgs e) {
            this.Close();
            win2.Show();
        }

        private void buttonModifier_Click(object sender, EventArgs e) {
            textBoxCompteRendu.Text.Substring(0,1000);
        }

        #endregion

        private void textBoxCompteRendu_KeyPress(object sender, KeyPressEventArgs e) {

        }

        private void textBoxCompteRendu_TextChanged(object sender, EventArgs e) {
            if (textBoxCompteRendu.Text.Length > 1000) {
                labelDanger.Visible = true;
            }
        }




    }
}
