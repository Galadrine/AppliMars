using System;
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

        // Fenetre Niveau 3 pour création d'activite
        public WindowLevel3(Journee jour, WindowLevel2 win2)
            : this() {
                maJournee = jour;
                maFenetrePrec = win2;
        }

        // Fenetre Niveau 3 pour activité existante
        public WindowLevel3(Activite activite, Journee jour, WindowLevel2 win2) 
            : this()
        {

            maFenetrePrec = win2;
            monActivite = activite;
            maJournee = jour;
            this.Text = maFenetrePrec.maFenetrePrec.maMission.monNomMission + " - Activité du jour " + maJournee.monNumero.ToString("D3");
            labelNumeroJour.Text = maJournee.monNumero.ToString("D3");

            cB_typeAct.Enabled = false;
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
            cB_typeAct.Text = monActivite.monNom;
            tB_descrAct.Text = monActivite.maDescription;
            tB_HDebAct.Text = monActivite.monHeureDebut.ToString();
            tB_MDebAct.Text = monActivite.mesMinutesDebut.ToString();
            tB_HFinAct.Text = monActivite.monHeureFin.ToString();
            tB_MFinAct.Text = monActivite.mesMinutesFin.ToString();
            tB_xAct.Text = monActivite.maPosX.ToString();
            tB_yAct.Text = monActivite.maPosY.ToString();
            cB_localisation.Checked = monActivite.enExterieur;

            
            foreach (Astronaute a in monActivite.mesAstronautes) {
                lB_listePart.Items.Add(a.monNom);
            }

            Image imageSource = (Image)(new Bitmap(Image.FromFile("..//..//Images//nanediValles3.jpg")));
            Graphics graphics = this.pictureBoxMap.CreateGraphics();
            Point p0 = new Point(0, 0);
            graphics.DrawImage(imageSource, p0);

            // Affichage de la position sur la map
            Image maps = (Image)(new Bitmap(Image.FromFile("..//..//Images//maps.png")));
            Point p;
            if (monActivite.enExterieur == true) {
                p = new Point(monActivite.maPosX / 3, monActivite.maPosY / 3);
                tB_xAct.Enabled = true;
                tB_yAct.Enabled = true;
                pictureBoxMap.Enabled = true;
            } else {
                p = new Point(70/3, 1000/3);
                pictureBoxMap.Enabled = true;

            }
            graphics.DrawImage(maps, p);

            DialogResult dlgRes = DialogResult.No;
            dlgRes = MessageBox.Show(
            p.X.ToString() + " - " + p.Y.ToString(),
            "p.X.ToString() + p.Y.ToString()",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
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
            maFenetrePrec.Show();
        }

        private void pictureBoxMap_Click(object sender, EventArgs e) {
            Image imageSource = (Image)(new Bitmap(Image.FromFile("..//..//Images//nanediValles3.jpg")));
            Graphics graphics = this.pictureBoxMap.CreateGraphics();
            Point p0 = new Point(0, 0);
            graphics.DrawImage(imageSource, p0);

            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = convertionCoordonneesImageVersXML(me.Location);

            tB_xAct.Text = (coordinates.X * 3).ToString();
            tB_yAct.Text = (coordinates.Y * 3).ToString();

            Image maps = (Image)(new Bitmap(Image.FromFile("..//..//Images//maps.png")));
            Point p = new Point(me.Location.X-10, me.Location.Y-34);
            graphics.DrawImage(maps, p);


            DialogResult dlgRes = DialogResult.No;
            dlgRes = MessageBox.Show(
            p.X.ToString() + " - " + p.Y.ToString(),
            "p.X.ToString() + p.Y.ToString()",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

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

        private void b_supprimer_Click(object sender, EventArgs e) { // Laisse ça ici, c'est pour savoir comment faire pour plus tard (on sait jamais)
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

        private void b_annuler_Click(object sender, EventArgs e) {
            this.Close();
            maFenetrePrec.Show();
        }

        private void b_valider_Click(object sender, EventArgs e) {
            string fileName = maFenetrePrec.maFenetrePrec.maMission.monCheminPlanningXML;
            XDocument _generalXML = XDocument.Load(fileName);
            var edt = (from jour in _generalXML.Descendants("Jour") where (string)jour.Attribute("id") == maJournee.monNumero.ToString() select jour.Element("Activites")).FirstOrDefault();
            var doc = XDocument.Load(fileName);
            XElement target = doc
                .Element("Planning")
                .Elements("Jour")
                .Where(elem => (string)elem.Attribute("id") == maJournee.monNumero.ToString())
                .First();
            //target.Element("CRJour").Value = tB_CR.Text;
            doc.Save(fileName);

            this.Close();
            maFenetrePrec.Show();
        }

        #endregion

    }
}
