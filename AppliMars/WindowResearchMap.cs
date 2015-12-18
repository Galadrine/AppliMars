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
        private int _nbActExtTrouve;
        private Activite _actSelectionnee;

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
            monNbActExtTrouve = 0;
            for (int i = 0; i < maFenetrePrec.maMission.maDureeMission + 1; i++) {
                cB_JourDebut.Items.Add(i);
                cB_JourFin.Items.Add(i);
            }

            cB_JourDebut.SelectedIndex = 1;
            cB_JourFin.SelectedIndex = maFenetrePrec.maMission.maDureeMission - 1;

            updateImagesMap(1, 500);

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
                        btnImg.Width = 16;
                        btnImg.Visible = true;
                        btnImg.Enabled = true;
                        btnImg.Height = 16;
                        btnImg.Location = new Point(692 + -8 + act.monLieu.maPosX / 3, 25 - 8 + act.monLieu.maPosY / 3);
                        btnImg.Click += new System.EventHandler(img_click);
                        btnImg.BackColor = System.Drawing.Color.PaleGreen;
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
                        monNbActExtTrouve++;
                    }
                }
            }
        }

        public void affichage_treeView() {
            /////////////Finir
            /*
            int i = 0;
            foreach (Categorie SC in maFenetrePrec.maMission.maListeCategories) {
                treeViewCategories.Nodes.Add(SC.monNom);
                int j = 0;
                foreach (Categorie A in SC.maSousCategorie) {
                    treeViewCategories.Nodes[i].Nodes.Add(A.monNom);
                    if (A.monNom == monActivite.monNom) {
                        treeViewCategories.SelectedNode = treeViewCategories.Nodes[i].Nodes[j];
                    }
                    int k = 0;
                    foreach (Categorie a3 in A.maSousCategorie) {
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
            }*/

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
            ////////////Finir cet évènement
            ////////////Ajouter l'affichage du treeView
            /*
            var button = (Button)sender;

            string name = button.Name;
            
            monActivite = activite;
            maJournee = jour;


            affichage_treeView();
            //cB_typeAct.Text = monActivite.monNom;
            tB_descrAct.Text = monActivite.maDescription;
            cb_HDebAct.Text = monActivite.monHeureDebut.ToString();
            cb_MDebAct.Text = monActivite.mesMinutesDebut.ToString();
            cb_HFinAct.Text = monActivite.monHeureFin.ToString();
            cb_MFinAct.Text = monActivite.mesMinutesFin.ToString();
            tB_nomLieu.Text = monActivite.monLieu.monNom.ToString();
            numUpDown_xAct.Text = monActivite.monLieu.maPosX.ToString();
            numUpDown_yAct.Text = monActivite.monLieu.maPosY.ToString();
            cB_localisation.Checked = monActivite.enExterieur;

            foreach (Astronaute a in maFenetrePrec.maMission.mesAstronautes) {
                int indexLB = 0;
                lB_listePart.Items.Add(a.monNom);
                foreach (Astronaute ast in monActivite.mesAstronautes) {
                    if (ast.monNom == a.monNom) {
                        lB_listePart.SetSelected(indexLB, true);
                    }
                    indexLB++;
                }
            }
            */
        }

        #endregion

    }
}
