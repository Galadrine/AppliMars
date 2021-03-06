﻿using System;
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
    public partial class WindowRecord : Form {

        #region variables

        AppliMars.WindowLevel2 _win2;
        AppliMars.WindowResultSearch _winS;
        Journee _jour;
        private bool _passee;

        #endregion 


        #region accesseurs

        public Journee maJournee {
            get { return _jour; }
            set { _jour = value; }
        }

        public WindowLevel2 maFenetrePrec {
            get { return _win2; }
            set { _win2 = value; }
        }

        public bool journeePasse {
            get { return _passee; }
            set { _passee = value; }
        }

        #endregion


        #region constructeurs

        public WindowRecord(Journee jour, AppliMars.WindowLevel2 w2)
            : this() {
            _win2 = w2;
            _jour = jour;
            tB_CR.Clear();
            this.Text = "Compte-rendu du jour "+(jour.monNumero).ToString();
            labelCompteRendu.Text = "Compte-rendu du jour " + (jour.monNumero).ToString();
            tB_CR.Text = _jour.monCompteRendu;
            // Vérifier si le jour est passé ou pas
            if (_jour.monNumero < _jour.maMission.monJourJ)
            {
                journeePasse = true;
                tB_CR.ReadOnly = true;
                string s1 = "Le compte rendu contient ";
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
            
        }

        // Depuis la recherche
        public WindowRecord(Journee jour, AppliMars.WindowResultSearch w2)
            : this()
        {
            _winS = w2;
            _jour = jour;
            this.Text = "Compte-rendu du jour " + (jour.monNumero).ToString();
            labelCompteRendu.Text = "Compte-rendu du jour " + (jour.monNumero).ToString();
            tB_CR.Text = _jour.monCompteRendu;
            tB_CR.ReadOnly = true;
            b_retourSearch.Visible = true;
            buttonRetourJournee.Visible = false;
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
            _jour.monCompteRendu = tB_CR.Text;
            string fileName = maFenetrePrec.maFenetrePrec.maMission.monCheminPlanningXML;
            var doc = XDocument.Load(fileName);
            XElement target = doc
                .Element("Planning")
                .Elements("Jour")
                .Where(elem => (string)elem.Attribute("id") == maJournee.monNumero.ToString())
                .First();
            target.Element("CRJour").Value = tB_CR.Text;
            doc.Save(fileName);

            maFenetrePrec.maFenetrePrec.maMission.monPlanning.monTableauJournees[maJournee.monNumero - 1].monCompteRendu = tB_CR.Text; 
            this.Close();
            _win2.Show();
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

        private void b_retourSearch_Click(object sender, EventArgs e)
        {
            this.Close();
            _winS.Show();
        }

        #endregion

    }
}
