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
        Activite _act;
        Journee _jour;


        #endregion

        #region constructeurs

        public WindowLevel3() {
            InitializeComponent();
        }

        // Fenetre Niveau 3 pour activité existante
        public WindowLevel3(Activite activite, Journee jour)
        {
            InitializeComponent();
            _act = activite;
            _jour = jour;
            tB_TypeAct.ReadOnly = true;
            tB_descrAct.ReadOnly = true;
            tB_HDebAct.ReadOnly = true;
            tB_MDebAct.ReadOnly = true;
            tB_HFinAct.ReadOnly = true;
            tB_MFinAct.ReadOnly = true;
            tB_xAct.ReadOnly = true;
            tB_yAct.ReadOnly = true;
            cB_localisation.Enabled = false;
            b_annuler.Visible = false;
            b_valider.Visible = false;

            l_numJour.Text = _jour.monNumero.ToString();
            tB_TypeAct.Text = _act.monNom;
            tB_descrAct.Text = _act.maDescription;
            tB_HDebAct.Text = _act.monHeureDebut.ToString();
            tB_MDebAct.Text = _act.mesMinutesDebut.ToString();
            tB_HFinAct.Text = _act.monHeuresFin.ToString();
            tB_MFinAct.Text = _act.mesMinutesFin.ToString();
            tB_xAct.Text = _act.maPosX.ToString();
            tB_yAct.Text = _act.maPosY.ToString();
            cB_localisation.Checked = _act.interieurOuExterieur;

            // A FAIRE : GESTION DE LA MAP!!
        }

        //public WindowLevel3(Journee jour)
        //{
        //    InitializeComponent();
        //    _jour = jour;

        //}


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

        

        #endregion

    }
}
