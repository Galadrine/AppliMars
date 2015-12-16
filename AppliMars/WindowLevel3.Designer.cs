namespace AppliMars {
    partial class WindowLevel3 {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowLevel3));
            this.l_numJour = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.b_supprimer = new System.Windows.Forms.Button();
            this.labelNumeroJour = new System.Windows.Forms.Label();
            this.b_valider = new System.Windows.Forms.Button();
            this.labelLongitude = new System.Windows.Forms.Label();
            this.labelLatitude = new System.Windows.Forms.Label();
            this.tB_nomLieu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCoordonnees = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label_heure_fin = new System.Windows.Forms.Label();
            this.label_heure_debut = new System.Windows.Forms.Label();
            this.label_description_activite = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tB_descrAct = new System.Windows.Forms.TextBox();
            this.cB_localisation = new System.Windows.Forms.CheckBox();
            this.l_participants = new System.Windows.Forms.Label();
            this.lB_listePart = new System.Windows.Forms.ListBox();
            this.l_cate = new System.Windows.Forms.Label();
            this.l_erreurConvert = new System.Windows.Forms.Label();
            this.numUpDown_xAct = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_yAct = new System.Windows.Forms.NumericUpDown();
            this.treeViewCategories = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_MFinAct = new System.Windows.Forms.ComboBox();
            this.cb_HFinAct = new System.Windows.Forms.ComboBox();
            this.cb_HDebAct = new System.Windows.Forms.ComboBox();
            this.cb_MDebAct = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pb_maps = new System.Windows.Forms.PictureBox();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.buttonRetourJournee = new System.Windows.Forms.Button();
            this.b_modifier = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_xAct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_yAct)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_maps)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.SuspendLayout();
            // 
            // l_numJour
            // 
            this.l_numJour.AutoSize = true;
            this.l_numJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_numJour.Location = new System.Drawing.Point(278, 44);
            this.l_numJour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_numJour.Name = "l_numJour";
            this.l_numJour.Size = new System.Drawing.Size(0, 25);
            this.l_numJour.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(173, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Activité du jour";
            // 
            // b_supprimer
            // 
            this.b_supprimer.Location = new System.Drawing.Point(408, 582);
            this.b_supprimer.Name = "b_supprimer";
            this.b_supprimer.Size = new System.Drawing.Size(126, 48);
            this.b_supprimer.TabIndex = 33;
            this.b_supprimer.Text = "SUPPRIMER";
            this.b_supprimer.UseVisualStyleBackColor = true;
            this.b_supprimer.Click += new System.EventHandler(this.b_supprimer_Click);
            // 
            // labelNumeroJour
            // 
            this.labelNumeroJour.AutoSize = true;
            this.labelNumeroJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroJour.Location = new System.Drawing.Point(307, 21);
            this.labelNumeroJour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumeroJour.Name = "labelNumeroJour";
            this.labelNumeroJour.Size = new System.Drawing.Size(45, 25);
            this.labelNumeroJour.TabIndex = 4;
            this.labelNumeroJour.Text = "000";
            this.labelNumeroJour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // b_valider
            // 
            this.b_valider.Location = new System.Drawing.Point(268, 582);
            this.b_valider.Name = "b_valider";
            this.b_valider.Size = new System.Drawing.Size(126, 48);
            this.b_valider.TabIndex = 33;
            this.b_valider.Text = "VALIDER";
            this.b_valider.UseVisualStyleBackColor = true;
            this.b_valider.Click += new System.EventHandler(this.b_valider_Click);
            // 
            // labelLongitude
            // 
            this.labelLongitude.AutoSize = true;
            this.labelLongitude.Location = new System.Drawing.Point(336, 453);
            this.labelLongitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLongitude.Name = "labelLongitude";
            this.labelLongitude.Size = new System.Drawing.Size(50, 13);
            this.labelLongitude.TabIndex = 13;
            this.labelLongitude.Text = "longitude";
            // 
            // labelLatitude
            // 
            this.labelLatitude.AutoSize = true;
            this.labelLatitude.Location = new System.Drawing.Point(449, 453);
            this.labelLatitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLatitude.Name = "labelLatitude";
            this.labelLatitude.Size = new System.Drawing.Size(41, 13);
            this.labelLatitude.TabIndex = 12;
            this.labelLatitude.Text = "latitude";
            // 
            // tB_nomLieu
            // 
            this.tB_nomLieu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tB_nomLieu.Enabled = false;
            this.tB_nomLieu.Location = new System.Drawing.Point(339, 415);
            this.tB_nomLieu.Margin = new System.Windows.Forms.Padding(2);
            this.tB_nomLieu.Name = "tB_nomLieu";
            this.tB_nomLieu.Size = new System.Drawing.Size(188, 20);
            this.tB_nomLieu.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 385);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Localisation";
            // 
            // labelCoordonnees
            // 
            this.labelCoordonnees.AutoSize = true;
            this.labelCoordonnees.Location = new System.Drawing.Point(211, 450);
            this.labelCoordonnees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCoordonnees.Name = "labelCoordonnees";
            this.labelCoordonnees.Size = new System.Drawing.Size(99, 13);
            this.labelCoordonnees.TabIndex = 10;
            this.labelCoordonnees.Text = "Coordonnee du lieu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(242, 418);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Nom du lieu";
            // 
            // label_heure_fin
            // 
            this.label_heure_fin.AutoSize = true;
            this.label_heure_fin.Location = new System.Drawing.Point(289, 101);
            this.label_heure_fin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_heure_fin.Name = "label_heure_fin";
            this.label_heure_fin.Size = new System.Drawing.Size(21, 13);
            this.label_heure_fin.TabIndex = 8;
            this.label_heure_fin.Text = "Fin";
            // 
            // label_heure_debut
            // 
            this.label_heure_debut.AutoSize = true;
            this.label_heure_debut.Location = new System.Drawing.Point(274, 70);
            this.label_heure_debut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_heure_debut.Name = "label_heure_debut";
            this.label_heure_debut.Size = new System.Drawing.Size(36, 13);
            this.label_heure_debut.TabIndex = 6;
            this.label_heure_debut.Text = "Debut";
            // 
            // label_description_activite
            // 
            this.label_description_activite.AutoSize = true;
            this.label_description_activite.Location = new System.Drawing.Point(250, 129);
            this.label_description_activite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_description_activite.Name = "label_description_activite";
            this.label_description_activite.Size = new System.Drawing.Size(60, 13);
            this.label_description_activite.TabIndex = 3;
            this.label_description_activite.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "h";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 70);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "min";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "min";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "h";
            // 
            // tB_descrAct
            // 
            this.tB_descrAct.Location = new System.Drawing.Point(336, 129);
            this.tB_descrAct.Margin = new System.Windows.Forms.Padding(2);
            this.tB_descrAct.MaxLength = 400;
            this.tB_descrAct.Multiline = true;
            this.tB_descrAct.Name = "tB_descrAct";
            this.tB_descrAct.Size = new System.Drawing.Size(245, 145);
            this.tB_descrAct.TabIndex = 2;
            // 
            // cB_localisation
            // 
            this.cB_localisation.AutoSize = true;
            this.cB_localisation.Location = new System.Drawing.Point(336, 385);
            this.cB_localisation.Name = "cB_localisation";
            this.cB_localisation.Size = new System.Drawing.Size(119, 17);
            this.cB_localisation.TabIndex = 30;
            this.cB_localisation.Text = "Activité en extérieur";
            this.cB_localisation.UseVisualStyleBackColor = true;
            this.cB_localisation.CheckedChanged += new System.EventHandler(this.checkBoxLocalisation_CheckedChanged);
            // 
            // l_participants
            // 
            this.l_participants.AutoSize = true;
            this.l_participants.Location = new System.Drawing.Point(248, 280);
            this.l_participants.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_participants.Name = "l_participants";
            this.l_participants.Size = new System.Drawing.Size(62, 13);
            this.l_participants.TabIndex = 36;
            this.l_participants.Text = "Participants";
            // 
            // lB_listePart
            // 
            this.lB_listePart.FormattingEnabled = true;
            this.lB_listePart.Location = new System.Drawing.Point(336, 280);
            this.lB_listePart.MultiColumn = true;
            this.lB_listePart.Name = "lB_listePart";
            this.lB_listePart.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lB_listePart.Size = new System.Drawing.Size(246, 95);
            this.lB_listePart.TabIndex = 37;
            // 
            // l_cate
            // 
            this.l_cate.AutoSize = true;
            this.l_cate.Location = new System.Drawing.Point(18, 32);
            this.l_cate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_cate.Name = "l_cate";
            this.l_cate.Size = new System.Drawing.Size(52, 13);
            this.l_cate.TabIndex = 51;
            this.l_cate.Text = "Catégorie";
            // 
            // l_erreurConvert
            // 
            this.l_erreurConvert.AutoSize = true;
            this.l_erreurConvert.ForeColor = System.Drawing.Color.Red;
            this.l_erreurConvert.Location = new System.Drawing.Point(490, 80);
            this.l_erreurConvert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_erreurConvert.Name = "l_erreurConvert";
            this.l_erreurConvert.Size = new System.Drawing.Size(117, 13);
            this.l_erreurConvert.TabIndex = 60;
            this.l_erreurConvert.Text = "Conversion impossible !";
            this.l_erreurConvert.Visible = false;
            // 
            // numUpDown_xAct
            // 
            this.numUpDown_xAct.Enabled = false;
            this.numUpDown_xAct.Location = new System.Drawing.Point(391, 451);
            this.numUpDown_xAct.Maximum = new decimal(new int[] {
            395,
            0,
            0,
            0});
            this.numUpDown_xAct.Minimum = new decimal(new int[] {
            700,
            0,
            0,
            -2147483648});
            this.numUpDown_xAct.Name = "numUpDown_xAct";
            this.numUpDown_xAct.Size = new System.Drawing.Size(51, 20);
            this.numUpDown_xAct.TabIndex = 61;
            this.numUpDown_xAct.ValueChanged += new System.EventHandler(this.numUpDown_ValueChanged);
            // 
            // numUpDown_yAct
            // 
            this.numUpDown_yAct.Enabled = false;
            this.numUpDown_yAct.Location = new System.Drawing.Point(493, 451);
            this.numUpDown_yAct.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numUpDown_yAct.Minimum = new decimal(new int[] {
            1053,
            0,
            0,
            -2147483648});
            this.numUpDown_yAct.Name = "numUpDown_yAct";
            this.numUpDown_yAct.Size = new System.Drawing.Size(51, 20);
            this.numUpDown_yAct.TabIndex = 61;
            this.numUpDown_yAct.ValueChanged += new System.EventHandler(this.numUpDown_ValueChanged);
            // 
            // treeViewCategories
            // 
            this.treeViewCategories.HideSelection = false;
            this.treeViewCategories.Location = new System.Drawing.Point(21, 62);
            this.treeViewCategories.Name = "treeViewCategories";
            this.treeViewCategories.Size = new System.Drawing.Size(175, 356);
            this.treeViewCategories.TabIndex = 1;
            this.treeViewCategories.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewCategories_BeforeSelect);
            this.treeViewCategories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCategories_AfterSelect);
            this.treeViewCategories.Validating += new System.ComponentModel.CancelEventHandler(this.treeViewCategories_Validating);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_MFinAct);
            this.groupBox1.Controls.Add(this.treeViewCategories);
            this.groupBox1.Controls.Add(this.cb_HFinAct);
            this.groupBox1.Controls.Add(this.numUpDown_yAct);
            this.groupBox1.Controls.Add(this.cb_HDebAct);
            this.groupBox1.Controls.Add(this.cb_MDebAct);
            this.groupBox1.Controls.Add(this.numUpDown_xAct);
            this.groupBox1.Controls.Add(this.l_erreurConvert);
            this.groupBox1.Controls.Add(this.l_cate);
            this.groupBox1.Controls.Add(this.lB_listePart);
            this.groupBox1.Controls.Add(this.l_participants);
            this.groupBox1.Controls.Add(this.cB_localisation);
            this.groupBox1.Controls.Add(this.tB_descrAct);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label_description_activite);
            this.groupBox1.Controls.Add(this.label_heure_debut);
            this.groupBox1.Controls.Add(this.label_heure_fin);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.labelCoordonnees);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tB_nomLieu);
            this.groupBox1.Controls.Add(this.labelLatitude);
            this.groupBox1.Controls.Add(this.labelLongitude);
            this.groupBox1.Location = new System.Drawing.Point(42, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 488);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // cb_MFinAct
            // 
            this.cb_MFinAct.FormattingEnabled = true;
            this.cb_MFinAct.Items.AddRange(new object[] {
            "00",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.cb_MFinAct.Location = new System.Drawing.Point(404, 101);
            this.cb_MFinAct.Name = "cb_MFinAct";
            this.cb_MFinAct.Size = new System.Drawing.Size(51, 21);
            this.cb_MFinAct.TabIndex = 63;
            this.cb_MFinAct.Text = "00";
            // 
            // cb_HFinAct
            // 
            this.cb_HFinAct.AutoCompleteCustomSource.AddRange(new string[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cb_HFinAct.FormattingEnabled = true;
            this.cb_HFinAct.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cb_HFinAct.Location = new System.Drawing.Point(335, 101);
            this.cb_HFinAct.Name = "cb_HFinAct";
            this.cb_HFinAct.Size = new System.Drawing.Size(51, 21);
            this.cb_HFinAct.TabIndex = 64;
            this.cb_HFinAct.Text = "10";
            // 
            // cb_HDebAct
            // 
            this.cb_HDebAct.FormattingEnabled = true;
            this.cb_HDebAct.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24"});
            this.cb_HDebAct.Location = new System.Drawing.Point(335, 67);
            this.cb_HDebAct.Name = "cb_HDebAct";
            this.cb_HDebAct.Size = new System.Drawing.Size(51, 21);
            this.cb_HDebAct.TabIndex = 65;
            this.cb_HDebAct.Text = "00";
            // 
            // cb_MDebAct
            // 
            this.cb_MDebAct.FormattingEnabled = true;
            this.cb_MDebAct.Items.AddRange(new object[] {
            "00",
            "10",
            "20",
            "30",
            "40",
            "50"});
            this.cb_MDebAct.Location = new System.Drawing.Point(404, 67);
            this.cb_MDebAct.Name = "cb_MDebAct";
            this.cb_MDebAct.Size = new System.Drawing.Size(51, 21);
            this.cb_MDebAct.TabIndex = 66;
            this.cb_MDebAct.Text = "00";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(336, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 11;
            // 
            // pb_maps
            // 
            this.pb_maps.BackColor = System.Drawing.Color.Transparent;
            this.pb_maps.Image = global::AppliMars.Properties.Resources.maps;
            this.pb_maps.Location = new System.Drawing.Point(904, 174);
            this.pb_maps.Name = "pb_maps";
            this.pb_maps.Size = new System.Drawing.Size(20, 34);
            this.pb_maps.TabIndex = 34;
            this.pb_maps.TabStop = false;
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMap.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMap.Image")));
            this.pictureBoxMap.Location = new System.Drawing.Point(699, 21);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(365, 684);
            this.pictureBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMap.TabIndex = 29;
            this.pictureBoxMap.TabStop = false;
            this.pictureBoxMap.Click += new System.EventHandler(this.pictureBoxMap_Click);
            // 
            // buttonRetourJournee
            // 
            this.buttonRetourJournee.Image = ((System.Drawing.Image)(resources.GetObject("buttonRetourJournee.Image")));
            this.buttonRetourJournee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRetourJournee.Location = new System.Drawing.Point(12, 12);
            this.buttonRetourJournee.Name = "buttonRetourJournee";
            this.buttonRetourJournee.Size = new System.Drawing.Size(141, 34);
            this.buttonRetourJournee.TabIndex = 50;
            this.buttonRetourJournee.Text = "Revenir à la journée";
            this.buttonRetourJournee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRetourJournee.UseVisualStyleBackColor = true;
            this.buttonRetourJournee.Click += new System.EventHandler(this.buttonRetourJournee_Click);
            // 
            // b_modifier
            // 
            this.b_modifier.Location = new System.Drawing.Point(89, 582);
            this.b_modifier.Name = "b_modifier";
            this.b_modifier.Size = new System.Drawing.Size(126, 48);
            this.b_modifier.TabIndex = 51;
            this.b_modifier.Text = "MODIFIER";
            this.b_modifier.UseVisualStyleBackColor = true;
            this.b_modifier.Click += new System.EventHandler(this.b_modifier_Click);
            // 
            // WindowLevel3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 731);
            this.ControlBox = false;
            this.Controls.Add(this.b_modifier);
            this.Controls.Add(this.pb_maps);
            this.Controls.Add(this.b_valider);
            this.Controls.Add(this.b_supprimer);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxMap);
            this.Controls.Add(this.buttonRetourJournee);
            this.Controls.Add(this.labelNumeroJour);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.l_numJour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "WindowLevel3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modification d\'une mission";
            this.Load += new System.EventHandler(this.WindowLevel3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_xAct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_yAct)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_maps)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_numJour;
        private System.Windows.Forms.Button buttonRetourJournee;
        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button b_supprimer;
        private System.Windows.Forms.Label labelNumeroJour;
        private System.Windows.Forms.Button b_valider;
        private System.Windows.Forms.PictureBox pb_maps;
        private System.Windows.Forms.Label labelLongitude;
        private System.Windows.Forms.Label labelLatitude;
        private System.Windows.Forms.TextBox tB_nomLieu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCoordonnees;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_heure_fin;
        private System.Windows.Forms.Label label_heure_debut;
        private System.Windows.Forms.Label label_description_activite;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tB_descrAct;
        private System.Windows.Forms.CheckBox cB_localisation;
        private System.Windows.Forms.Label l_participants;
        private System.Windows.Forms.ListBox lB_listePart;
        private System.Windows.Forms.Label l_cate;
        private System.Windows.Forms.Label l_erreurConvert;
        private System.Windows.Forms.NumericUpDown numUpDown_xAct;
        private System.Windows.Forms.NumericUpDown numUpDown_yAct;
        private System.Windows.Forms.TreeView treeViewCategories;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_MFinAct;
        private System.Windows.Forms.ComboBox cb_HFinAct;
        private System.Windows.Forms.ComboBox cb_HDebAct;
        private System.Windows.Forms.ComboBox cb_MDebAct;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button b_modifier;
    }
}

