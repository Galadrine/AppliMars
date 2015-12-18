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
        private  WindowResultSearch win2bis;
        private Activite act;
        private Journee jour;
        public TreeNode previousSelectedNode = null;
        private bool _enModification = false;

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
        
        public WindowResultSearch maFenetrePrec2
        {
            get { return win2bis; }
            set { win2bis = value; }
        }

        public Journee maJournee {
            get { return jour; }
            set { jour = value; }
        }

        public bool modifiable {
            get { return _enModification; }
            set { _enModification = value; }
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
            if (maJournee.monNumero < maFenetrePrec.maFenetrePrec.maMission.monJourJ) {
                DisableControls(this);
                EnableControls(buttonRetourJournee);
            }
            this.Text = maFenetrePrec.maFenetrePrec.maMission.monNomMission + " - Activité du jour " + maJournee.monNumero.ToString("D3");
            labelNumeroJour.Text = maJournee.monNumero.ToString("D3");
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
            
            // Verrouillage des cases pour éviter les modfis

            //treeViewCategories.Enabled = false;
            cb_HDebAct.Enabled = false;
            cb_MDebAct.Enabled = false;
            cb_HFinAct.Enabled = false;
            cb_MFinAct.Enabled = false;
            tB_descrAct.ReadOnly = true;
            lB_listePart.Enabled = false;
            cB_localisation.Enabled = false;
            tB_nomLieu.ReadOnly = true;
            pictureBoxMap.Enabled = false;
            b_valider.Visible = false;
            b_supprimer.Visible = false;


            //this.Controls.Add(this.pictureBoxMap);
            //pictureBoxMap.Controls.AddRange(new Control[]{this.pb_maps});
            //pictureBoxMap.Controls.Add(pb_maps);
            //pb_maps.Parent = pictureBoxMap;
            /*
            ((Bitmap)this.pb_maps.Image).MakeTransparent(((Bitmap)this.pb_maps.Image).GetPixel(1, 1));
            this.pb_maps.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pb_maps.BackColor = System.Drawing.Color.Transparent;
            */
            //((Bitmap)pb_maps.Image).MakeTransparent(((Bitmap)pb_maps.Image).GetPixel(0, pb_maps.Image.Size.Height - 1));

            foreach (Astronaute a in maFenetrePrec.maFenetrePrec.maMission.mesAstronautes) {
                int indexLB = 0;
                lB_listePart.Items.Add(a.monNom);
                foreach (Astronaute ast in monActivite.mesAstronautes) {
                    if (ast.monNom == a.monNom) {
                        lB_listePart.SetSelected(indexLB, true);
                    }
                    indexLB++;
                }
            }

            if (maJournee.monNumero < maFenetrePrec.maFenetrePrec.maMission.monJourJ) {
                DisableControls(this);
                EnableControls(buttonRetourJournee);
                EnableControls(treeViewCategories);
            }

        }
        
        // Depuis la recherche
        public WindowLevel3(Activite activite, Journee jour, WindowResultSearch win2)
            : this()
        {
            // Changement du bouton "Revenir à la journée" 
            buttonRetourJournee.Visible = false;
            b_retourSearch.Visible = true;


            maFenetrePrec2 = win2;
            monActivite = activite;
            maJournee = jour;
            if (maJournee.monNumero < maFenetrePrec2.maFenetrePrec.maMission.monJourJ) {
                DisableControls(this);
                EnableControls(buttonRetourJournee);
            }
            this.Text = maFenetrePrec2.maFenetrePrec.maMission.monNomMission + " - Activité du jour " + maJournee.monNumero.ToString("D3");
            labelNumeroJour.Text = maJournee.monNumero.ToString("D3");
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

            // Verrouillage des cases pour éviter les modfis
            //treeViewCategories.Enabled = false;
            cb_HDebAct.Enabled = true;
            cb_MDebAct.Enabled = true;
            cb_HFinAct.Enabled = true;
            cb_MFinAct.Enabled = true;
            tB_descrAct.ReadOnly = true;
            lB_listePart.Enabled = false;
            cB_localisation.Enabled = false;
            tB_nomLieu.ReadOnly = true;
            pictureBoxMap.Enabled = false;
            b_valider.Visible = false;
            b_supprimer.Visible = false;


            
            foreach (Astronaute a in maFenetrePrec2.maFenetrePrec.maMission.mesAstronautes)
            {
                int indexLB = 0;
                lB_listePart.Items.Add(a.monNom);
                foreach (Astronaute ast in monActivite.mesAstronautes)
                {
                    if (ast.monNom == a.monNom)
                    {
                        lB_listePart.SetSelected(indexLB, true);
                    }
                    indexLB++;
                }
            }


        }

        #endregion


        #region methodes

        public System.Drawing.Point convertCoordImgToXML(Point coordinates) {
            return new System.Drawing.Point((coordinates.X * 3) - 700, (coordinates.Y * 3) - 1000);
        }

        public System.Drawing.Point convertCoordUpDownToImage(Point coordinates) {
            return new System.Drawing.Point(699 + (coordinates.X + 700 / 3), 21 + (coordinates.Y +1000 / 3) );
        }

        public void affichage_treeView() {

            int i = 0;
            try
            {
                foreach (Categorie SC in maFenetrePrec.maFenetrePrec.maMission.maListeCategories)
                {
                    treeViewCategories.Nodes.Add(SC.monNom);
                    int j = 0;
                    foreach (Categorie A in SC.maSousCategorie)
                    {
                        treeViewCategories.Nodes[i].Nodes.Add(A.monNom);
                        if (A.monNom == monActivite.monNom)
                        {
                            treeViewCategories.SelectedNode = treeViewCategories.Nodes[i].Nodes[j];
                        }
                        int k = 0;
                        foreach (Categorie a3 in A.maSousCategorie)
                        {
                            treeViewCategories.Nodes[i].Nodes[j].Nodes.Add(a3.monNom);
                            if (a3.monNom == monActivite.monNom)
                            {
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
            catch
            {
                foreach (Categorie SC in maFenetrePrec2.maFenetrePrec.maMission.maListeCategories)
                {
                    treeViewCategories.Nodes.Add(SC.monNom);
                    int j = 0;
                    foreach (Categorie A in SC.maSousCategorie)
                    {
                        treeViewCategories.Nodes[i].Nodes.Add(A.monNom);
                        if (A.monNom == monActivite.monNom)
                        {
                            treeViewCategories.SelectedNode = treeViewCategories.Nodes[i].Nodes[j];
                        }
                        int k = 0;
                        foreach (Categorie a3 in A.maSousCategorie)
                        {
                            treeViewCategories.Nodes[i].Nodes[j].Nodes.Add(a3.monNom);
                            if (a3.monNom == monActivite.monNom)
                            {
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
        }
        
        private void DisableControls(Control con) {
            foreach (Control c in con.Controls) {
                DisableControls(c);
            }
            con.Enabled = false;
        }

        private void EnableControls(Control con) {
            if (con != null) {
                con.Enabled = true;
                EnableControls(con.Parent);
            }
        }
        
        #endregion


        #region evenements

        private void buttonRetourJournee_Click(object sender, EventArgs e) {
            this.Close();
            maFenetrePrec.Show();
        }

        private void pictureBoxMap_Click(object sender, EventArgs e) {
            
            MouseEventArgs me = (MouseEventArgs)e;
            Point coordinates = convertCoordImgToXML(me.Location);
            numUpDown_xAct.Text = (coordinates.X * 3).ToString();
            numUpDown_yAct.Text = (coordinates.Y * 3).ToString();
            pb_maps.Location = new Point(689 + me.Location.X, 21 - 34 + me.Location.Y);
            
            /*
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

            */
            /*
            DialogResult dlgRes = DialogResult.No;
            //dlgRes = MessageBox.Show(numUpDown_xAct.Value.ToString() + " - " + numUpDown_yAct.Value.ToString(), "numUpDown_xAct.Value.ToString() - numUpDown_yAct.Value.ToString()", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            dlgRes = MessageBox.Show(p.X.ToString() + " - " + p.Y.ToString(), "p.X.ToString() + p.Y.ToString()", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            */
        }

        private void checkBoxLocalisation_CheckedChanged(object sender, EventArgs e) {
            if (cB_localisation.Checked) {
                tB_nomLieu.Enabled = true;
                numUpDown_xAct.Enabled = true;
                numUpDown_yAct.Enabled = true;

            } else {
                tB_nomLieu.Enabled = false;
                numUpDown_xAct.Enabled = false;
                numUpDown_yAct.Enabled = false;
            }
        }

        private void b_supprimer_Click(object sender, EventArgs e) { // Laisse ça ici, c'est pour savoir comment faire pour plus tard (on sait jamais)
            DialogResult dlgRes = DialogResult.No;
            dlgRes = MessageBox.Show(
            "Voulez-vous vraiment supprimer cette activité ?",
            "Confirmation suppression activité",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (dlgRes == DialogResult.Yes) {
                // SupprimerActivite();
                string fileName = maFenetrePrec.maFenetrePrec.maMission.monCheminPlanningXML;
                XDocument doc = XDocument.Load(fileName);
                var act = (from activite in doc.Descendants("Activite") where (string)activite.Attribute("idAct") == monActivite.monID.ToString() select activite).ToList();
                Console.WriteLine();
                foreach (var node in act)
                    node.Remove();
                doc.Save(fileName);

                Journee journeeAModif = maFenetrePrec.maFenetrePrec.maMission.monPlanning.monTableauJournees[maJournee.monNumero - 1];
                int indexActAModif = journeeAModif.getPosActiviteByIdAct(monActivite.monID);
                Activite actAModif = journeeAModif.maListeActivites[indexActAModif];
                journeeAModif.maListeActivites.Remove(actAModif);

                this.Close();
                maFenetrePrec.Show();
                maFenetrePrec.insertionActivitesListBox();
            }

        }

        private void b_valider_Click(object sender, EventArgs e) {
            string fileName = maFenetrePrec.maFenetrePrec.maMission.monCheminPlanningXML;
            XDocument _generalXML = XDocument.Load(fileName);
            var act = (from activite in _generalXML.Descendants("Activite") where (string)activite.Attribute("idAct") == monActivite.monID.ToString() select activite).FirstOrDefault();
            var ParticipantsAct = act.Descendants("Participants").First();
            var lieuAct = act.Descendants("Lieu").First();
            Journee journeeAModif = maFenetrePrec.maFenetrePrec.maMission.monPlanning.monTableauJournees[maJournee.monNumero - 1];
            Activite actAModif = journeeAModif.maListeActivites[journeeAModif.getPosActiviteByIdAct(monActivite.monID)];

            act.Element("NomAct").Value = treeViewCategories.SelectedNode.Text;
            actAModif.monNom = treeViewCategories.SelectedNode.Text;
            act.Element("HDebutAct").Value = cb_HDebAct.Text;
            actAModif.monHeureDebut = int.Parse(cb_HDebAct.Text);
            act.Element("MDebutAct").Value = cb_MDebAct.Text;
            actAModif.mesMinutesDebut = int.Parse(cb_MDebAct.Text);
            act.Element("HFinAct").Value = cb_HFinAct.Text;
            actAModif.monHeureFin = int.Parse(cb_HFinAct.Text);
            act.Element("MFinAct").Value = cb_MFinAct.Text;
            actAModif.mesMinutesFin = int.Parse(cb_MFinAct.Text);
            act.Element("BoolExt").Value = cB_localisation.Checked.ToString();
            actAModif.enExterieur = cB_localisation.Checked;
            act.Element("DescriptionAct").Value = tB_descrAct.Text;
            actAModif.maDescription = tB_descrAct.Text;

            lieuAct.Element("nomLieu").Value = tB_nomLieu.Text;
            actAModif.monLieu.monNom = tB_nomLieu.Text;
            lieuAct.Element("posX").Value = numUpDown_xAct.Text;
            actAModif.monLieu.maPosX = int.Parse(numUpDown_xAct.Text);
            lieuAct.Element("posY").Value = numUpDown_yAct.Text;
            actAModif.monLieu.maPosY = int.Parse(numUpDown_yAct.Text);

            ParticipantsAct.RemoveAll();

            actAModif.mesAstronautes = new List<Astronaute>();
            foreach (var astro in lB_listePart.SelectedItems) {
                string astroNom = astro.ToString();
                ParticipantsAct.Add(new XElement("Astronaute", astroNom));
                actAModif.mesAstronautes.Add(new Astronaute(astroNom));
            }

            _generalXML.Save(fileName);

            this.Close();
            maFenetrePrec.Show();
            maFenetrePrec.insertionActivitesListBox();
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

        private void WindowLevel3_Load(object sender, EventArgs e) {
            /*
            Point p = new Point(899,40);
            
            Image imageSource = (Image)(new Bitmap(Image.FromFile("..//..//Images//nanediValles3.jpg")));
            Graphics graphics = this.pictureBoxMap.CreateGraphics();
            Point p0 = new Point(0, 0);
            graphics.DrawImage(imageSource, p0);

            Image maps = (Image)(new Bitmap(Image.FromFile("..//..//Images//maps.png")));
            graphics.DrawImage(maps, p);
            this.Invalidate();
            this.pictureBoxMap.Invalidate();
            this.pictureBoxMap.Refresh();
            */
            
            // Affichage de la position sur la map
            if (monActivite.enExterieur == true) {
                pictureBoxMap.Enabled = true;
                tB_nomLieu.Enabled = true;
                numUpDown_xAct.Enabled = true;
                numUpDown_yAct.Enabled = true;
                Graphics graphics = this.pictureBoxMap.CreateGraphics();
                Point p = new Point(monActivite.monLieu.maPosX / 3, monActivite.monLieu.maPosY / 3);
                Image maps = (Image)(new Bitmap(Image.FromFile("..//..//Images//maps.png")));
                graphics.DrawImage(maps, p);

                this.Invalidate();
                this.pictureBoxMap.Invalidate();
                this.pictureBoxMap.Refresh();

                pb_maps.Location = new Point(699 + monActivite.monLieu.maPosX / 3, 21 + monActivite.monLieu.maPosY / 3);

            } else {
                pictureBoxMap.Enabled = true;
                Graphics graphics = this.pictureBoxMap.CreateGraphics();
                Point p = new Point(463 - 20 + 700 / 3, 21 - 34 + 1000 / 3);
                Image maps = (Image)(new Bitmap(Image.FromFile("..//..//Images//maps.png")));
                graphics.DrawImage(maps, p);
                pb_maps.Location = p;
                /*
                DialogResult dlgRes = DialogResult.No;
                dlgRes = MessageBox.Show(p.X.ToString() + " - " + p.Y.ToString(), "p.X.ToString() + p.Y.ToString()", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                */

                this.Invalidate();
                this.pictureBoxMap.Invalidate();
                this.pictureBoxMap.Refresh();

                pb_maps.Location = new Point(689 + 700 / 3, 21 -34 + 1000 / 3);
            }
            
        }

        private void b_modifier_Click(object sender, EventArgs e)
        {
            modifiable = true;
            // Déverrouillage des cases pour éviter les modfis
            cb_HDebAct.Enabled = true;
            cb_MDebAct.Enabled = true;
            cb_HFinAct.Enabled = true;
            cb_MFinAct.Enabled = true;
            tB_descrAct.Enabled = true;
            lB_listePart.Enabled = true;
            cB_localisation.Enabled = true;
            tB_nomLieu.Enabled = true;
            b_valider.Visible = true;
            b_supprimer.Visible = true;
            if (monActivite.enExterieur == true) {
                pictureBoxMap.Enabled = true;
                numUpDown_xAct.Enabled = true;
                numUpDown_yAct.Enabled = true;
            }
        }

        private void numUpDown_ValueChanged(object sender, EventArgs e) {
            Point p0 = convertCoordUpDownToImage(new Point(int.Parse(numUpDown_xAct.Value.ToString()), int.Parse(numUpDown_yAct.Value.ToString())));
            pb_maps.Location = new Point(p0.X, p0.Y);
        }

        private void b_retourSearch_Click(object sender, EventArgs e)
        {
            this.Close();
            maFenetrePrec2.Show();
        }

        private void cb_HDebAct_SelectedIndexChanged(object sender, EventArgs e) {
            if (int.Parse(cb_HDebAct.Text) < int.Parse(cb_HFinAct.Text)) {
                b_valider.Enabled = true;
                l_erreurHoraires.Visible = false;
            } else {
                b_valider.Enabled = false;
                l_erreurHoraires.Visible = true;
            }
            if (cb_HDebAct.Text == "24" && cb_MDebAct.Text == "50") {
                b_valider.Enabled = false;
                l_erreurHoraires.Visible = true;
            } else {
                b_valider.Enabled = true;
                l_erreurHoraires.Visible = false;
            }
        }

        private void cb_MDebAct_SelectedIndexChanged(object sender, EventArgs e) {
            if (cb_HDebAct.Text == cb_HFinAct.Text) {
                if (int.Parse(cb_MDebAct.Text) < int.Parse(cb_MFinAct.Text)) {
                    b_valider.Enabled = true;
                    l_erreurHoraires.Visible = false;
                } else {
                    b_valider.Enabled = false;
                    l_erreurHoraires.Visible = true;
                }
            }
            if (cb_HDebAct.Text == "24" && cb_MDebAct.Text == "50") {
                b_valider.Enabled = false;
                l_erreurHoraires.Visible = true;
            } else {
                b_valider.Enabled = true;
                l_erreurHoraires.Visible = false;
            }
        }

        private void cb_HFinAct_SelectedIndexChanged(object sender, EventArgs e) {
            if (int.Parse(cb_HDebAct.Text) < int.Parse(cb_HFinAct.Text)) {
                b_valider.Enabled = true;
                l_erreurHoraires.Visible = false;
            } else {
                b_valider.Enabled = false;
                l_erreurHoraires.Visible = true;
            }
            if (cb_HFinAct.Text == "24" && cb_MFinAct.Text == "50") {
                b_valider.Enabled = false;
                l_erreurHoraires.Visible = true;
            } else {
                b_valider.Enabled = true;
                l_erreurHoraires.Visible = false;
            }
        }

        private void cb_MFinAct_SelectedIndexChanged(object sender, EventArgs e) {
            if (cb_HDebAct.Text == cb_HFinAct.Text) {
                if (int.Parse(cb_MDebAct.Text) < int.Parse(cb_MFinAct.Text)) {
                    b_valider.Enabled = true;
                    l_erreurHoraires.Visible = false;
                } else {
                    b_valider.Enabled = false;
                    l_erreurHoraires.Visible = true;
                }
            }
            if (cb_HFinAct.Text == "24" && cb_MFinAct.Text == "50") {
                b_valider.Enabled = false;
                l_erreurHoraires.Visible = true;
            } else {
                b_valider.Enabled = true;
                l_erreurHoraires.Visible = false;
            }
        }

        #endregion
         
    }
}
