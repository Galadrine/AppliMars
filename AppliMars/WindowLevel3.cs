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

        private WindowLevel2 win2;
        private Activite act;
        private Journee jour;

        #endregion


        #region accesseurs

        public Activite monActivite {
            get { return act; }
            set { act = value; }
        }

        public WindowLevel2 maFenetrePrec {
            get { return win2; }
            set { win2 = value; }
        }

        public Journee maJournee {
            get { return jour; }
            set { jour = value; }
        }

        #endregion


        #region constructeurs

        public WindowLevel3() {
            InitializeComponent();
        }

        // Fenetre Niveau 3 pour créaétion d'activite
        public WindowLevel3(Journee jour, WindowLevel2 win2)
            : this() {
                maJournee = jour;
        }

        // Fenetre Niveau 3 pour activité existante
        public WindowLevel3(Activite activite, Journee jour, WindowLevel2 win2) 
            : this()
        {

            maFenetrePrec = win2;
            monActivite = activite;
            maJournee = jour;
            this.Text = maFenetrePrec.maFenetrePrec.maMission.monNomMission + " - Activité du jour " + maJournee.monNumero;

            tB_TypeAct.ReadOnly = true;
            tB_descrAct.ReadOnly = true;
            tB_HDebAct.ReadOnly = true;
            tB_MDebAct.ReadOnly = true;
            tB_HFinAct.ReadOnly = true;
            tB_MFinAct.ReadOnly = true;
            tB_xAct.ReadOnly = true;
            tB_yAct.ReadOnly = true;

            cB_localisation.Enabled = false;
            lB_listePart.Enabled = false;
            //b_annuler.Visible = false;
            //b_valider.Visible = false;
            l_numJour.Text = maJournee.monNumero.ToString();
            tB_TypeAct.Text = monActivite.monNom;
            tB_descrAct.Text = monActivite.maDescription;
            tB_HDebAct.Text = monActivite.monHeureDebut.ToString();
            tB_MDebAct.Text = monActivite.mesMinutesDebut.ToString();
            tB_HFinAct.Text = monActivite.monHeureFin.ToString();
            tB_MFinAct.Text = monActivite.mesMinutesFin.ToString();
            tB_xAct.Text = monActivite.maPosX.ToString();
            tB_yAct.Text = monActivite.maPosY.ToString();
            cB_localisation.Checked = monActivite.interieurOuExterieur;

            lB_listePart.DataSource = monActivite.mesAstronautes;


            // A FAIRE : GESTION DE LA MAP!!
        }


        #endregion


        #region methodes

        public System.Drawing.Point convertionCoordonneesImageVersXML(Point coordinates) 
        {
            return new System.Drawing.Point((coordinates.X * 3) - 700, (coordinates.Y * 3) - 1000);
        }
            
        #endregion


        #region evenements

        private void buttonRetourJournee_Click(object sender, EventArgs e) {
            this.Close();
            win2.Show();
        }

        private void pictureBoxMap_Click(object sender, EventArgs e) {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = convertionCoordonneesImageVersXML(me.Location);

            tB_xAct.Text = (coordinates.X * 3).ToString();
            tB_yAct.Text = (coordinates.Y * 3).ToString();
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
            if (cB_localisation.Checked) {
                labelCoordonnees.Visible = true;
                labelLongitude.Visible = true;
                labelLatitude.Visible = true;
                tB_xAct.Visible = true;
                tB_yAct.Visible = true;
                pictureBoxMap.Visible = true;

            } else {
                labelCoordonnees.Visible = false;
                labelLongitude.Visible = false;
                labelLatitude.Visible = false;
                tB_xAct.Visible = false;
                tB_yAct.Visible = false;
                pictureBoxMap.Visible = false;
            }
        }

        // Laisse ça ici, c'est pour savoir comment faire pour plus tard (on sait jamais)
        private void buttonSupprimer_Click(object sender, EventArgs e) {
            DialogResult dlgRes = DialogResult.No;
            dlgRes = MessageBox.Show(
            "Voulez-vous vraiement supprimer cette activité ?",
            "Confirmation suppression activité",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (dlgRes == DialogResult.Yes) {
                // SupprimerActivite();
            }

        }

        #endregion

    }
}
