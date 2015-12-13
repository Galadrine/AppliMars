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
        public TreeNode previousSelectedNode = null;

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

        // Fenetre Niveau 3 pour activité existante
        public WindowLevel3(Activite activite, Journee jour, WindowLevel2 win2) 
            : this()
        {
            maFenetrePrec = win2;
            monActivite = activite;
            maJournee = jour;
            this.Text = maFenetrePrec.maFenetrePrec.maMission.monNomMission + " - Activité du jour " + maJournee.monNumero.ToString("D3");
            labelNumeroJour.Text = maJournee.monNumero.ToString("D3");
            //////////////////Charger le type d'activité
            affichage_treeView();
            //cB_typeAct.Text = monActivite.monNom;
            tB_descrAct.Text = monActivite.maDescription;
            tB_HDebAct.Text = monActivite.monHeureDebut.ToString();
            tB_MDebAct.Text = monActivite.mesMinutesDebut.ToString();
            tB_HFinAct.Text = monActivite.monHeureFin.ToString();
            tB_MFinAct.Text = monActivite.mesMinutesFin.ToString();
            textBoxNomLieu.Text = monActivite.monLieu.monNom.ToString();
            numUpDown_xAct.Text = monActivite.monLieu.maPosX.ToString();
            numUpDown_yAct.Text = monActivite.monLieu.maPosY.ToString();
            cB_localisation.Checked = monActivite.enExterieur;
            pictureBoxMap.Controls.Add(pb_maps);
            pb_maps.Location = new Point(0, 0);
            pb_maps.BackColor = Color.Transparent;
            foreach (Astronaute a in monActivite.mesAstronautes) {
                int indexLB = 0;
                lB_listePart.Items.Add(a.monNom);
                foreach (Astronaute ast in maFenetrePrec.maFenetrePrec.maMission.mesAstronautes) {
                    if (ast.monNom == a.monNom) {
                        lB_listePart.SetSelected(indexLB, true);
                    }
                    indexLB++;
                }
            }

        }

        #endregion


        #region methodes

        public System.Drawing.Point convertionCoordonneesImageVersXML(Point coordinates) 
        {
            return new System.Drawing.Point((coordinates.X * 3) - 700, (coordinates.Y * 3) - 1000);
        }
        
        public void affichage_treeView(){
            int i = 0;
            foreach (Categorie SC in maFenetrePrec.maFenetrePrec.maMission.maListeCategories) {
                treeViewCategories.Nodes.Add(SC.monNom);
                int j = 0;
                foreach (Categorie A in SC.maSousCategorie) {
                    if (A.maSousCategorie.Count == 0) {
                        
                    }
                    treeViewCategories.Nodes[i].Nodes.Add(A.monNom);
                    if (A.monNom == monActivite.monNom) {
                        treeViewCategories.SelectedNode = treeViewCategories.Nodes[i].Nodes[j];
                    }
                    int k = 0;
                    foreach (Categorie a3 in A.maSousCategorie) {
                        if (a3.maSousCategorie.Count == 0) {

                        }
                        treeViewCategories.Nodes[i].Nodes[j].Nodes.Add(a3.monNom);
                        if (a3.monNom == monActivite.monNom) {
                            previousSelectedNode = treeViewCategories.Nodes[i].Nodes[j].Nodes[k];
                            treeViewCategories.SelectedNode = treeViewCategories.Nodes[i].Nodes[j].Nodes[k];
                        }
                        k++;
                    }
                    j++;
                }
                i++;
            }
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

            numUpDown_xAct.Text = (coordinates.X * 3).ToString();
            numUpDown_yAct.Text = (coordinates.Y * 3).ToString();

            Image maps = (Image)(new Bitmap(Image.FromFile("..//..//Images//maps.png")));
            Point p = new Point(me.Location.X-10, me.Location.Y-34);
            graphics.DrawImage(maps, p);


            DialogResult dlgRes = DialogResult.No;
            //dlgRes = MessageBox.Show(numUpDown_xAct.Value.ToString() + " - " + numUpDown_yAct.Value.ToString(), "numUpDown_xAct.Value.ToString() - numUpDown_yAct.Value.ToString()", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            dlgRes = MessageBox.Show(p.X.ToString() + " - " + p.Y.ToString(), "p.X.ToString() + p.Y.ToString()", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
                textBoxNomLieu.Enabled = true;
                numUpDown_xAct.Enabled = true;
                numUpDown_yAct.Enabled = true;

            } else {
                textBoxNomLieu.Enabled = false;
                numUpDown_xAct.Enabled = false;
                numUpDown_yAct.Enabled = false;
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

        private void WindowLevel3_Shown(object sender, EventArgs e) {
            // Affichage de la position sur la map
            if (monActivite.enExterieur == true) {
                pictureBoxMap.Enabled = true;
                textBoxNomLieu.Enabled = true;
                numUpDown_xAct.Enabled = true;
                numUpDown_yAct.Enabled = true;
                Graphics graphics = this.pictureBoxMap.CreateGraphics();
                Point p = new Point(monActivite.monLieu.maPosX / 3, monActivite.monLieu.maPosY / 3);
                Image maps = (Image)(new Bitmap(Image.FromFile("..//..//Images//maps.png")));
                graphics.DrawImage(maps, p);
            } else {
                pictureBoxMap.Enabled = true;
                Graphics graphics = this.pictureBoxMap.CreateGraphics();
                Point p = new Point(463-20+700 / 3, 21-34+1000 / 3);
                Image maps = (Image)(new Bitmap(Image.FromFile("..//..//Images//maps.png")));
                graphics.DrawImage(maps, p);

                pb_maps.Location = p;

                DialogResult dlgRes = DialogResult.No;
                //dlgRes = MessageBox.Show(p.X.ToString() + " - " + p.Y.ToString(), "p.X.ToString() + p.Y.ToString()", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            }

        }

        private void treeViewCategories_BeforeSelect(object sender, TreeViewCancelEventArgs e) {
            // On vérifie si le noeud du treeView a des enfants, si c'est le cas, c'est un super-catégorie, donc on ne peut pas la sélectionner
            if (e.Node.Nodes.Count != 0) {
                e.Cancel = true;
            }
        }

        private void treeViewCategories_AfterSelect(object sender, TreeViewEventArgs e) {
            if (previousSelectedNode != null) {
                previousSelectedNode.BackColor = treeViewCategories.BackColor;
                previousSelectedNode.ForeColor = treeViewCategories.ForeColor;
            }
        }

        private void treeViewCategories_Validating(object sender, CancelEventArgs e) {
            treeViewCategories.SelectedNode.BackColor = SystemColors.Highlight;
            treeViewCategories.SelectedNode.ForeColor = Color.White;
            previousSelectedNode = treeViewCategories.SelectedNode;
        }

        #endregion


    }
}
