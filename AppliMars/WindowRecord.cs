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

<<<<<<< HEAD
            // érifier si le jour est passé ou pas
            if (_jour.monNumero < _jour.maMission.monJourJ)
=======
            // vérifier si le jour est passé ou pas
            if (_jour.monNumero < _jour.m.monJourJ)
>>>>>>> origin/master
            {
                journeePasse = true;
                tB_CR.ReadOnly = true;
            }
            else
            {
                journeePasse = false;
                tB_CR.ReadOnly = false;
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

        }

        private void textBoxCompteRendu_TextChanged(object sender, EventArgs e) {
            _jour.monCompteRendu = tB_CR.Text;
        }


        #endregion




    }
}
