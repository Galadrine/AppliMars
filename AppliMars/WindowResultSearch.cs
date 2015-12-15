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
    public partial class WindowResultSearch : Form {

        #region variables

        private WindowLevel1 win1;
        private List<Journee> _listRechercheJour_CompteRendu = new List<Journee>();
        private List<Journee> _listRechercheJour_Nom = new List<Journee>();
        private List<Activite> _listRechercheActivite_Nom;
        private List<Journee> _listRechercheJour_Description = new List<Journee>();
        private List<Activite> _listRechercheActivite_Description;
        private Journee _maJourneeSelectionnee = null;
        private Activite _monActiviteSelectionnee = null;

        #endregion


        #region accesseurs

        public WindowLevel1 maFenetrePrec {
            get { return win1; }
            set { win1 = value; }
        }

        public List<Journee> maListeRechercheJour_Nom {
            get { return _listRechercheJour_Nom; }
            set { _listRechercheJour_Nom = value; }
        }

        public List<Journee> maListeRechercheJour_Description {
            get { return _listRechercheJour_Description; }
            set { _listRechercheJour_Description = value; }
        }

        public List<Journee> maListeRechercheJour_CompteRendu {
            get { return _listRechercheJour_CompteRendu; }
            set { _listRechercheJour_CompteRendu = value; }
        }

        public Journee maJourneeSel {
            get { return _maJourneeSelectionnee; }
            set { _maJourneeSelectionnee = value; }
        }

        public Activite monActiviteSel {
            get { return _monActiviteSelectionnee; }
            set { _monActiviteSelectionnee = value; }
        }

        public List<Activite> maListeRechercheActivit_Description {
            get { return _listRechercheActivite_Description; }
            set { _listRechercheActivite_Description = value; }
        }

        public List<Activite> maListeRechercheActivit_Nom {
            get { return _listRechercheActivite_Nom; }
            set { _listRechercheActivite_Nom = value; }
        }

        #endregion


        #region constructeurs

        public WindowResultSearch() {
            InitializeComponent();
        }

        public WindowResultSearch(AppliMars.WindowLevel1 w1, string aRechercher, string debutRecherche, string finRecherche) : this() {
            maFenetrePrec = w1;
            labelRecherche.Text = aRechercher;
            listBoxNom.Items.Clear();
            listBoxCompteRendu.Items.Clear();
            listBoxDescription.Items.Clear();

            int indexOccNom, indexOccDescription, indexOccCompteRendu;


            /////////////// Ajouter les dates de début et de fin

            foreach (Journee jour in maFenetrePrec.maMission.monPlanning.monTableauJournees) {

                indexOccCompteRendu = jour.monCompteRendu.IndexOf(aRechercher);

                if (indexOccCompteRendu != -1) {
                    string stringActivite = "Jour " + jour.monNumero;
                    listBoxCompteRendu.Items.Add(stringActivite);
                    _listRechercheJour_CompteRendu.Add(jour);
                }

                foreach (Activite act in jour.maListeActivites) {
                    indexOccNom = act.monNom.IndexOf(aRechercher);
                    indexOccDescription = act.maDescription.IndexOf(aRechercher);
                    if (indexOccNom != -1 ) {
                        string stringActivite = "Jour " + jour.monNumero;
                        listBoxNom.Items.Add(stringActivite);
                        maListeRechercheActivit_Nom.Add(act);
                        maListeRechercheJour_Nom.Add(jour);
                    }
                    if (indexOccDescription != -1) {
                        string stringActivite = "Jour " + jour.monNumero;
                        listBoxDescription.Items.Add(stringActivite);
                        maListeRechercheActivit_Nom.Add(act);
                        maListeRechercheJour_Description.Add(jour);
                    }
                }
            }

        }

        #endregion


        #region evenements

        private void buttonRetourCalendrier_Click(object sender, EventArgs e) {
            this.Close();
            win1.Show();
        }

        private void listBoxNom_SelectedIndexChanged(object sender, EventArgs e) {
            int sel = Int32.Parse(listBoxNom.GetItemText(listBoxNom.SelectedIndex));
            if (sel >= 0) {
                buttonGoTo.Enabled = true;
                maJourneeSel = maListeRechercheJour_Nom[sel];
                monActiviteSel = maListeRechercheActivit_Nom[sel];
                listBoxDescription.ClearSelected();
                listBoxCompteRendu.ClearSelected();
            }
        }

        private void listBoxDescription_SelectedIndexChanged(object sender, EventArgs e) {
            int sel = Int32.Parse(listBoxDescription.GetItemText(listBoxDescription.SelectedIndex));
            if (sel >= 0) {
                buttonGoTo.Enabled = true;
                maJourneeSel = maListeRechercheJour_CompteRendu[sel];
                monActiviteSel = maListeRechercheActivit_Description[sel];
                listBoxNom.ClearSelected();
                listBoxCompteRendu.ClearSelected();
            }
        }

        private void listBoxCompteRendu_SelectedIndexChanged(object sender, EventArgs e) {
            int sel = Int32.Parse(listBoxCompteRendu.GetItemText(listBoxCompteRendu.SelectedIndex));
            if (sel >= 0) {
                buttonGoTo.Enabled = true;
                maJourneeSel = maListeRechercheJour_Description[sel];
                monActiviteSel = null;
                listBoxNom.ClearSelected();
                listBoxDescription.ClearSelected();
            }
        }

        private void buttonGoTo_Click(object sender, EventArgs e) {
            if (maJourneeSel != null) {
                ///////////////////////// Ajouter des constructeurs à WindowLevel2 et WindowLevel3 pour avoir comme fenetrePrec la fenetre de recherche
                if (monActiviteSel != null) {
                    //WindowLevel1 win1 = new WindowLevel3(maJourneeSel, this);
                    //win1.Show();
                    //this.Hide();
                } else {
                    //WindowLevel1 win1 = new WindowLevel3(maJourneeSel, this);
                    //win1.Show();
                    //this.Hide();
                }
            }
        }

        #endregion

    }
}
