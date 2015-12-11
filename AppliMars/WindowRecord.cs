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

        AppliMars.WindowLevel2 _win2;
        Journee _jour;
        bool journeePasse;

        #endregion 


        #region constructeurs 

        public WindowRecord(Journee jour, AppliMars.WindowLevel2 w2)
            : this() {
            _win2 = w2;
            _jour = jour;
            this.Text = "Compte-rendu du jour "+(jour.monNumero).ToString();
            labelCompteRendu.Text = "Compte-rendu du jour " + (jour.monNumero).ToString();

            // Vérifier si le jour est passé ou pas
            if (_jour.monNumero < _jour.maMission.monJourJ)
            {
                journeePasse = true;
                tB_CR.ReadOnly = true;
                string s1 = "Le compte rendu fait ";
                string s2 = " caractères.";
                int i0 = tB_CR.TextLength;
                labelCarRest.Text = s1 + i0.ToString() + s2;
            }
            else
            {
                journeePasse = false;
                tB_CR.ReadOnly = false;
                string s1 = "Vous pouvez taper encore ";
                string s2 = " caractères.";
                int i0 = tB_CR.TextLength;
                int i1 = 1000 - i0;
                labelCarRest.Text = s1 + i1.ToString() + s2;
            }
            tB_CR.Text = _jour.monCompteRendu;
            
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
            _win2.Show();
        }

        private void buttonModifier_Click(object sender, EventArgs e) 
        {
            tB_CR.Text.Substring(0,1000);
        }

        private void textBoxCompteRendu_KeyPress(object sender, KeyPressEventArgs e) {
            if (tB_CR.TextLength<=1000) {
                string s1 = "Vous pouvez taper encore ";
                string s2 = " caractères.";
                int i0 = tB_CR.TextLength;
                int i1 = 1000 - i0;
                labelCarRest.Text = s1 + i1.ToString() + s2;
            }

        }

        private void textBoxCompteRendu_TextChanged(object sender, EventArgs e) {
            _jour.monCompteRendu = tB_CR.Text;

        }



        #endregion




    }
}
