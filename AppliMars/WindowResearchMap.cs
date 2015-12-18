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
    public partial class WindowResearchMap : Form {

        #region variables

        private WindowLevel1 _win1;
        private List<Button> _listBut;
        private List<Activite> _listAct;
        private List<int> _litJour;
        private int _nbActExtTrouve;
        private Activite _actSelectionnee;
        public TreeNode previousSelectedNode = null;
        private TreeNode _previousSelectedNode = null;
        
        #endregion


        #region accesseurs

        public WindowLevel1 maFenetrePrec {
            get { return _win1; }
            set { _win1 = value; }
        }

        public List<Button> maListeBouttons {
            get { return _listBut; }
            set { _listBut = value; }
        }

        public List<Activite> maListeActivite {
            get { return _listAct; }
            set { _listAct = value; }
        }

        public int monNbActExtTrouve {
            get { return _nbActExtTrouve; }
            set { _nbActExtTrouve = value; }
        }

        public Activite monActSel {
            get { return _actSelectionnee; }
            set { _actSelectionnee = value; }
        }

        public TreeNode myPreviousNode {
            get { return _previousSelectedNode; }
            set { _previousSelectedNode = value; }
        }

        public List<int> maListeJours {
            get { return _litJour; }
            set { _litJour = value; }
        }
        
        #endregion


        #region constructeurs

        public WindowResearchMap() {
            InitializeComponent();
        }

        public WindowResearchMap(WindowLevel1 w1)
            : this() {
            maFenetrePrec = w1;
            _listBut = new List<Button>();
            maListeActivite = new List<Activite>();
            maListeActivite = new List<Activite>();
            maListeJours = new List<int>();
            monNbActExtTrouve = 0;
            for (int i = 0; i < maFenetrePrec.maMission.maDureeMission + 1; i++) {
                cB_JourDebut.Items.Add(i);
                cB_JourFin.Items.Add(i);
            }

            cB_JourDebut.SelectedIndex = 1;
            cB_JourFin.SelectedIndex = maFenetrePrec.maMission.maDureeMission - 1;

        }

        #endregion


        #region méthodes

        public void updateImagesMap(int debut, int fin) { // affiche toutes les images dans la période passée en paramètre

            foreach (Button but in maListeBouttons) {
                this.Controls.Remove(but);
            }

            for (int i = debut; i < fin; i++) {
                
                Journee jour = maFenetrePrec.maMission.monPlanning.monTableauJournees[i-1];

                foreach (Activite act in jour.maListeActivites) {
                    if (act.enExterieur == true) {
                        Button btnImg = new Button();
                        btnImg.Text = "";
                        btnImg.Width = 22;
                        btnImg.Height = 22;
                        btnImg.Visible = true;
                        btnImg.Enabled = true;
                        btnImg.Location = new System.Drawing.Point(686 + -8 + 700/3 + act.monLieu.maPosX / 3, 25 - 8 + 1000/3 + act.monLieu.maPosY / 3);
                        //btnImg.Location = new System.Drawing.Point(480,25);
                        btnImg.Click += new System.EventHandler(img_click);
                        Bitmap image = (Bitmap)Image.FromFile(@"..//..//Images//vehiculePasse.png", true);
                        btnImg.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
                        if (jour.monNumero < maFenetrePrec.maMission.monJourJ) { // activités passées
                            if (act.monNom == "Vehicle") {
                                image = (Bitmap)Image.FromFile(@"..//..//Images//vehiculePasse.png", true);
                            } else if (act.monNom == "Space suit") {
                                image = (Bitmap)Image.FromFile(@"..//..//Images//astroPasse.png", true);
                            } else if (act.monNom == "Outside experiment") {
                                image = (Bitmap)Image.FromFile(@"..//..//Images//expePasse.png", true);
                            }
                        } else {
                            if (act.monNom == "Vehicle") {
                                image = (Bitmap)Image.FromFile(@"..//..//Images//vehiculeFutur.png", true);
                            } else if (act.monNom == "Space suit") {
                                image = (Bitmap)Image.FromFile(@"..//..//Images//astroFutur.png", true);
                            } else if (act.monNom == "Outside experiment") {
                                image = (Bitmap)Image.FromFile(@"..//..//Images//expeFutur.png", true);
                            }
                        }
                        btnImg.Image = image;
                        btnImg.BringToFront();
                        btnImg.Name = monNbActExtTrouve.ToString();
                        maListeBouttons.Add(btnImg);
                        maListeActivite.Add(act);
                        maListeJours.Add(jour.monNumero);
                        monNbActExtTrouve++;
                        this.Controls.Add(btnImg);
                    }
                }
            }
            foreach (Button but in maListeBouttons) {
                but.Visible = true;
                but.Enabled = true;
                but.BringToFront();
            }
        }

        public void affichage_treeView() {

            treeViewCategories.Nodes.Clear();

            int i = 0;
            foreach (Categorie SC in maFenetrePrec.maMission.maListeCategories) {
                treeViewCategories.Nodes.Add(SC.monNom);
                int j = 0;
                foreach (Categorie A in SC.maSousCategorie) {
                    treeViewCategories.Nodes[i].Nodes.Add(A.monNom);
                    if (A.monNom == monActSel.monNom) {
                        treeViewCategories.SelectedNode = treeViewCategories.Nodes[i].Nodes[j];
                    }
                    int k = 0;
                    foreach (Categorie a3 in A.maSousCategorie) {
                        treeViewCategories.Nodes[i].Nodes[j].Nodes.Add(a3.monNom);
                        if (a3.monNom == monActSel.monNom) {
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


        #region évènements

        private void buttonRetourCalendrier_Click(object sender, EventArgs e) {
            this.Close();
            maFenetrePrec.Show();
        }

        private void buttonResearch_Click(object sender, EventArgs e) {
            updateImagesMap(int.Parse(cB_JourDebut.Text), int.Parse(cB_JourFin.Text));
        }

        private void img_click(object sender, EventArgs e) {
            var button = (Button)sender;
            int numAct = int.Parse(button.Name);
            tB_descrAct.Clear();
            monActSel = maListeActivite[numAct];

            affichage_treeView();
            tB_descrAct.Text = monActSel.maDescription;
            cb_HDebAct.Text = monActSel.monHeureDebut.ToString();
            cb_MDebAct.Text = monActSel.mesMinutesDebut.ToString();
            cb_HFinAct.Text = monActSel.monHeureFin.ToString();
            cb_MFinAct.Text = monActSel.mesMinutesFin.ToString();
            tB_nomLieu.Text = monActSel.monLieu.monNom.ToString();
            labelNumJour.Text = maListeJours[numAct].ToString();
            numUpDown_xAct.Text = monActSel.monLieu.maPosX.ToString();
            numUpDown_yAct.Text = monActSel.monLieu.maPosY.ToString();
            cB_localisation.Checked = monActSel.enExterieur;

            foreach (Astronaute a in maFenetrePrec.maMission.mesAstronautes) {
                int indexLB = 0;
                lB_listePart.Items.Add(a.monNom);
                foreach (Astronaute ast in monActSel.mesAstronautes) {
                    if (ast.monNom == a.monNom) {
                        lB_listePart.SetSelected(indexLB, true);
                    }
                    indexLB++;
                }
            }
        }

        private void WindowResearchMap_Load(object sender, EventArgs e) {
            updateImagesMap(1, 500);
        }

        #endregion

    }
}
