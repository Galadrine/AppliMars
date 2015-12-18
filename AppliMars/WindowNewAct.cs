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

namespace AppliMars
{
    public partial class WindowNewAct : Form
    {

        #region Variables

        private Journee _jour;
        private WindowLevel2 _win2;
        public TreeNode previousSelectedNode = null;

        #endregion


        #region accesseurs

        public WindowLevel2 maFenetrePrec {
            get { return _win2; }
            set { _win2 = value; }
        }

        public Journee maJournee {
            get { return _jour; }
            set { _jour = value; }
        }

        #endregion


        #region constructeurs

        public WindowNewAct() {
            InitializeComponent();
        }

        public WindowNewAct(Journee jour, WindowLevel2 win) :this(){
            maJournee = jour;
            maFenetrePrec = win;
            this.Text = maFenetrePrec.maFenetrePrec.maMission.monNomMission + " - Création d'une activité pour le jour " + maJournee.monNumero;
            labelNumeroJour.Text = maJournee.monNumero.ToString();
            l_numJour.Text = _jour.monNumero.ToString("D3");
            // cB_typeAct dépendant de cB_cate
            foreach (Astronaute ast in _jour.maMission.mesAstronautes) {
                lB_listePart.Items.Add(ast.monNom);
            }
            affichage_treeView();

        }

        #endregion


        #region methodes

        public void affichage_treeView() {
            int i = 0;
            foreach (Categorie SC in maFenetrePrec.maFenetrePrec.maMission.maListeCategories) {
                treeViewCategories.Nodes.Add(SC.monNom);
                int j = 0;
                foreach (Categorie A in SC.maSousCategorie) {
                    treeViewCategories.Nodes[i].Nodes.Add(A.monNom);
                    int k = 0;
                    foreach (Categorie a3 in A.maSousCategorie) {
                        treeViewCategories.Nodes[i].Nodes[j].Nodes.Add(a3.monNom);
                        k++;
                    }
                    j++;
                }
                i++;
            }
        }
        

        #endregion


        #region évènements

        private void cB_localisation_CheckedChanged(object sender, EventArgs e) {
            if (cB_localisation.Checked) {
                textBoxNomLieu.Enabled = true;
                numUpDown_xAct.Enabled = true;
                numUpDown_yAct.Enabled = true;
                pictureBoxMap.Enabled = true;

            } else {
                textBoxNomLieu.Enabled = false;
                numUpDown_xAct.Enabled = false;
                numUpDown_yAct.Enabled = false;
                pictureBoxMap.Enabled = false;
            }
        }

        private void b_creerNvAct_Click(object sender, EventArgs e) {

            string filePlanningName = maFenetrePrec.maFenetrePrec.maMission.monCheminPlanningXML;
            string fileGeneralName = maFenetrePrec.maFenetrePrec.maMission.monCheminGeneralXML;
            XDocument _planningXML = XDocument.Load(filePlanningName);
            XDocument _generalXML = XDocument.Load(fileGeneralName);
            var jourSel = (from jour in _planningXML.Descendants("Jour") where (string)jour.Attribute("id") == maJournee.monNumero.ToString() select jour).FirstOrDefault();
            var act = (from activites in _planningXML.Descendants("Activites") where (string)activites.Parent.Attribute("id") == maJournee.monNumero.ToString() select activites).FirstOrDefault();
            Journee journeeAModif = maFenetrePrec.maFenetrePrec.maMission.monPlanning.monTableauJournees[maJournee.monNumero - 1];


            int hDebNvAct = int.Parse(cb_HDebAct.Text);
            int mDebNvAct = int.Parse(cb_MDebAct.Text);
            int hFinNvAct = int.Parse(cb_HFinAct.Text);
            int mFinNvAct = int.Parse(cb_MFinAct.Text);

            string checkChevauchement = journeeAModif.checkChevauchement(hDebNvAct, mDebNvAct, hFinNvAct, mFinNvAct);

            if (checkChevauchement == "") {
                Activite activit;

                // Récupération de toutes les informations
                int xNvAct, yNvAct;
                string nomLieuNvAct;
                if (cB_localisation.Checked == true) {
                    xNvAct = int.Parse(numUpDown_xAct.Text);
                    yNvAct = int.Parse(numUpDown_xAct.Text);
                    nomLieuNvAct = textBoxNomLieu.Text;
                }else{
                    xNvAct = 0;
                    yNvAct = 0;
                    nomLieuNvAct = "Habitat";
                }
                bool extNvAct = cB_localisation.Checked;
                string descrNvAct = tB_descrAct.Text;
                if (descrNvAct.Length > 400) {
                    tB_descrAct.ForeColor = Color.Red;
                }

                // Echange si les horaires de début et de fin sont inversés
                if (hDebNvAct > hFinNvAct) {
                    int tmp = hFinNvAct;
                    hFinNvAct = hDebNvAct;
                    hDebNvAct = tmp;
                    tmp = mFinNvAct;
                    mFinNvAct = mDebNvAct;
                    mDebNvAct = tmp;
                }

                XElement parts = new XElement("Participants");
                List<Astronaute> partNvAct = new List<Astronaute>();
                foreach (string astro in lB_listePart.SelectedItems) {
                    partNvAct.Add(new Astronaute(astro));
                    parts.Add(new XElement("NomAct", astro));

                }


                string nomNvAct = treeViewCategories.SelectedNode.Text;

                // Si tout est ok flag == true, on peut créer la nouvelle activité 
                activit = new Activite(nomNvAct, extNvAct, descrNvAct, hDebNvAct, mDebNvAct, hFinNvAct, mFinNvAct, partNvAct, nomLieuNvAct, xNvAct, yNvAct);

                 _jour.maListeActivites.Add(activit);


                 act.Add(new XElement("Activite",
                    new XAttribute("idAct", activit.monID.ToString()),
                    new XElement("NomAct", activit.monNom.ToString()),
                    new XElement("HDebutAct", activit.monHeureDebut.ToString()),
                    new XElement("MDebutAct", activit.mesMinutesDebut.ToString()),
                    new XElement("HFinAct", activit.monHeureFin.ToString()),
                    new XElement("MFinAct", activit.mesMinutesFin.ToString()),
                    new XElement("BoolExt", activit.enExterieur.ToString()),
                    new XElement("Lieu",
                        new XElement("nomLieu", activit.monLieu.monNom.ToString()),
                        new XElement("posX", activit.monLieu.maPosX.ToString()),
                        new XElement("posY", activit.monLieu.maPosY.ToString())),
                    new XElement("DescriptionAct", activit.maDescription.ToString()),
                    parts));


                _planningXML.Save(filePlanningName);

                this.Close();
                maFenetrePrec.Show();
                maFenetrePrec.insertionActivitesListBox();

            } else { // Il y a des chevauchements entre les activités
                MessageBox.Show(checkChevauchement,
                    "Insertion impossible");
            }
        }

        private void buttonRetourJournee_Click(object sender, EventArgs e) {
            this.Close();
            maFenetrePrec.Show();
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
            int sel = Int32.Parse(lB_listePart.GetItemText(lB_listePart.SelectedIndex));
            if (sel >= 0 && treeViewCategories.SelectedNode != null) {
                b_creerNvAct.Enabled = true;
            }
        }

        private void treeViewCategories_Validating(object sender, CancelEventArgs e) {
            treeViewCategories.SelectedNode.BackColor = SystemColors.Highlight;
            treeViewCategories.SelectedNode.ForeColor = Color.White;
            previousSelectedNode = treeViewCategories.SelectedNode;
        }
        
        private void cb_HDebAct_SelectedIndexChanged(object sender, EventArgs e) {
            if (cb_HDebAct.Text == "24" && cb_MDebAct.Text == "50") {
                b_creerNvAct.Enabled = false;
                l_erreurHoraires.Visible = true;
            } else {
                if (int.Parse(cb_HDebAct.Text) < int.Parse(cb_HFinAct.Text)) {
                    b_creerNvAct.Enabled = true;
                    l_erreurHoraires.Visible = false;
                } else {
                    b_creerNvAct.Enabled = false;
                    l_erreurHoraires.Visible = true;
                }
            }
        }

        private void cb_MDebAct_SelectedIndexChanged(object sender, EventArgs e) {
            if (cb_HDebAct.Text == "24" && cb_MDebAct.Text == "50") {
                b_creerNvAct.Enabled = false;
                l_erreurHoraires.Visible = true;
            } else {
                if (cb_HDebAct.Text == cb_HFinAct.Text) {
                    if (int.Parse(cb_MDebAct.Text) < int.Parse(cb_MFinAct.Text)) {
                        b_creerNvAct.Enabled = true;
                        l_erreurHoraires.Visible = false;
                    } else {
                        b_creerNvAct.Enabled = false;
                        l_erreurHoraires.Visible = true;
                    }
                }
            }
        }

        private void cb_HFinAct_SelectedIndexChanged(object sender, EventArgs e) {
            if (cb_HFinAct.Text == "24" && cb_MFinAct.Text == "50") {
                    b_creerNvAct.Enabled = false;
                    l_erreurHoraires.Visible = true;
            } else {
                if (int.Parse(cb_HDebAct.Text) < int.Parse(cb_HFinAct.Text)) {
                    b_creerNvAct.Enabled = true;
                    l_erreurHoraires.Visible = false;
                } else {
                    b_creerNvAct.Enabled = false;
                    l_erreurHoraires.Visible = true;
                }
            }
        }

        private void cb_MFinAct_SelectedIndexChanged(object sender, EventArgs e) {
            if (cb_HFinAct.Text == "24" && cb_MFinAct.Text == "50") {
                    b_creerNvAct.Enabled = false;
                    l_erreurHoraires.Visible = true;
            } else {
                if (cb_HDebAct.Text == cb_HFinAct.Text) {
                    if (int.Parse(cb_MDebAct.Text) < int.Parse(cb_MFinAct.Text)) {
                        b_creerNvAct.Enabled = true;
                        l_erreurHoraires.Visible = false;
                    } else {
                        b_creerNvAct.Enabled = false;
                        l_erreurHoraires.Visible = true;
                    }
                }
            }
        }

        private void lB_listePart_SelectedIndexChanged(object sender, EventArgs e) {
            int sel = Int32.Parse(lB_listePart.GetItemText(lB_listePart.SelectedIndex));
            if (sel >= 0 && treeViewCategories.SelectedNode!=null) {
                b_creerNvAct.Enabled = true;
            }
        }

        private void pictureBoxMap_Click(object sender, EventArgs e) {
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = new System.Drawing.Point((me.Location.X * 3) - 700, (me.Location.Y * 3) - 1000);
            numUpDown_xAct.Text = (coordinates.X * 3).ToString();
            numUpDown_yAct.Text = (coordinates.Y * 3).ToString();
            pb_maps.Location = new Point(689 + me.Location.X, 21 - 34 + me.Location.Y);
        }

        #endregion


    }
}
