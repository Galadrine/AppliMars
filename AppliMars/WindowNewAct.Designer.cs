namespace AppliMars
{
    partial class WindowNewAct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowNewAct));
            this.cB_localisation = new System.Windows.Forms.CheckBox();
            this.tB_descrAct = new System.Windows.Forms.TextBox();
            this.l_hFin = new System.Windows.Forms.Label();
            this.l_mFin = new System.Windows.Forms.Label();
            this.l_mDebut = new System.Windows.Forms.Label();
            this.l_hDeb = new System.Windows.Forms.Label();
            this.l_descr = new System.Windows.Forms.Label();
            this.l_debut = new System.Windows.Forms.Label();
            this.l_fin = new System.Windows.Forms.Label();
            this.l_coord = new System.Windows.Forms.Label();
            this.l_loc = new System.Windows.Forms.Label();
            this.l_y = new System.Windows.Forms.Label();
            this.l_x = new System.Windows.Forms.Label();
            this.lB_listePart = new System.Windows.Forms.ListBox();
            this.l_participants = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.l_numJour = new System.Windows.Forms.Label();
            this.b_creerNvAct = new System.Windows.Forms.Button();
            this.l_erreurHoraires = new System.Windows.Forms.Label();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNomLieu = new System.Windows.Forms.TextBox();
            this.buttonRetourJournee = new System.Windows.Forms.Button();
            this.labelNumeroJour = new System.Windows.Forms.Label();
            this.cb_MDebAct = new System.Windows.Forms.ComboBox();
            this.cb_MFinAct = new System.Windows.Forms.ComboBox();
            this.cb_HDebAct = new System.Windows.Forms.ComboBox();
            this.cb_HFinAct = new System.Windows.Forms.ComboBox();
            this.treeViewCategories = new System.Windows.Forms.TreeView();
            this.l_cate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numUpDown_yAct = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_xAct = new System.Windows.Forms.NumericUpDown();
            this.pb_maps = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_yAct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_xAct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_maps)).BeginInit();
            this.SuspendLayout();
            // 
            // cB_localisation
            // 
            this.cB_localisation.AutoSize = true;
            this.cB_localisation.Location = new System.Drawing.Point(332, 376);
            this.cB_localisation.Name = "cB_localisation";
            this.cB_localisation.Size = new System.Drawing.Size(119, 17);
            this.cB_localisation.TabIndex = 46;
            this.cB_localisation.Text = "Activité en extérieur";
            this.cB_localisation.UseVisualStyleBackColor = true;
            this.cB_localisation.CheckedChanged += new System.EventHandler(this.cB_localisation_CheckedChanged);
            // 
            // tB_descrAct
            // 
            this.tB_descrAct.Location = new System.Drawing.Point(333, 124);
            this.tB_descrAct.Margin = new System.Windows.Forms.Padding(2);
            this.tB_descrAct.MaxLength = 400;
            this.tB_descrAct.Multiline = true;
            this.tB_descrAct.Name = "tB_descrAct";
            this.tB_descrAct.Size = new System.Drawing.Size(245, 145);
            this.tB_descrAct.TabIndex = 31;
            // 
            // l_hFin
            // 
            this.l_hFin.AutoSize = true;
            this.l_hFin.Location = new System.Drawing.Point(387, 99);
            this.l_hFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_hFin.Name = "l_hFin";
            this.l_hFin.Size = new System.Drawing.Size(13, 13);
            this.l_hFin.TabIndex = 32;
            this.l_hFin.Text = "h";
            // 
            // l_mFin
            // 
            this.l_mFin.AutoSize = true;
            this.l_mFin.Location = new System.Drawing.Point(460, 96);
            this.l_mFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_mFin.Name = "l_mFin";
            this.l_mFin.Size = new System.Drawing.Size(23, 13);
            this.l_mFin.TabIndex = 33;
            this.l_mFin.Text = "min";
            // 
            // l_mDebut
            // 
            this.l_mDebut.AutoSize = true;
            this.l_mDebut.Location = new System.Drawing.Point(460, 65);
            this.l_mDebut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_mDebut.Name = "l_mDebut";
            this.l_mDebut.Size = new System.Drawing.Size(23, 13);
            this.l_mDebut.TabIndex = 34;
            this.l_mDebut.Text = "min";
            // 
            // l_hDeb
            // 
            this.l_hDeb.AutoSize = true;
            this.l_hDeb.Location = new System.Drawing.Point(387, 65);
            this.l_hDeb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_hDeb.Name = "l_hDeb";
            this.l_hDeb.Size = new System.Drawing.Size(13, 13);
            this.l_hDeb.TabIndex = 35;
            this.l_hDeb.Text = "h";
            // 
            // l_descr
            // 
            this.l_descr.AutoSize = true;
            this.l_descr.Location = new System.Drawing.Point(248, 124);
            this.l_descr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_descr.Name = "l_descr";
            this.l_descr.Size = new System.Drawing.Size(60, 13);
            this.l_descr.TabIndex = 36;
            this.l_descr.Text = "Description";
            // 
            // l_debut
            // 
            this.l_debut.AutoSize = true;
            this.l_debut.Location = new System.Drawing.Point(272, 65);
            this.l_debut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_debut.Name = "l_debut";
            this.l_debut.Size = new System.Drawing.Size(36, 13);
            this.l_debut.TabIndex = 37;
            this.l_debut.Text = "Debut";
            // 
            // l_fin
            // 
            this.l_fin.AutoSize = true;
            this.l_fin.Location = new System.Drawing.Point(287, 96);
            this.l_fin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_fin.Name = "l_fin";
            this.l_fin.Size = new System.Drawing.Size(21, 13);
            this.l_fin.TabIndex = 38;
            this.l_fin.Text = "Fin";
            // 
            // l_coord
            // 
            this.l_coord.AutoSize = true;
            this.l_coord.Location = new System.Drawing.Point(209, 453);
            this.l_coord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_coord.Name = "l_coord";
            this.l_coord.Size = new System.Drawing.Size(99, 13);
            this.l_coord.TabIndex = 39;
            this.l_coord.Text = "Coordonnee du lieu";
            this.l_coord.Visible = false;
            // 
            // l_loc
            // 
            this.l_loc.AutoSize = true;
            this.l_loc.Location = new System.Drawing.Point(244, 378);
            this.l_loc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_loc.Name = "l_loc";
            this.l_loc.Size = new System.Drawing.Size(63, 13);
            this.l_loc.TabIndex = 40;
            this.l_loc.Text = "Localisation";
            // 
            // l_y
            // 
            this.l_y.AutoSize = true;
            this.l_y.Location = new System.Drawing.Point(442, 455);
            this.l_y.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_y.Name = "l_y";
            this.l_y.Size = new System.Drawing.Size(41, 13);
            this.l_y.TabIndex = 42;
            this.l_y.Text = "latitude";
            this.l_y.Visible = false;
            // 
            // l_x
            // 
            this.l_x.AutoSize = true;
            this.l_x.Location = new System.Drawing.Point(331, 455);
            this.l_x.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_x.Name = "l_x";
            this.l_x.Size = new System.Drawing.Size(50, 13);
            this.l_x.TabIndex = 43;
            this.l_x.Text = "longitude";
            this.l_x.Visible = false;
            // 
            // lB_listePart
            // 
            this.lB_listePart.FormattingEnabled = true;
            this.lB_listePart.Location = new System.Drawing.Point(334, 275);
            this.lB_listePart.Name = "lB_listePart";
            this.lB_listePart.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lB_listePart.Size = new System.Drawing.Size(246, 95);
            this.lB_listePart.TabIndex = 55;
            // 
            // l_participants
            // 
            this.l_participants.AutoSize = true;
            this.l_participants.Location = new System.Drawing.Point(248, 275);
            this.l_participants.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_participants.Name = "l_participants";
            this.l_participants.Size = new System.Drawing.Size(62, 13);
            this.l_participants.TabIndex = 54;
            this.l_participants.Text = "Participants";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(173, 21);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 25);
            this.label7.TabIndex = 56;
            this.label7.Text = "Activité du jour";
            // 
            // l_numJour
            // 
            this.l_numJour.AutoSize = true;
            this.l_numJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_numJour.Location = new System.Drawing.Point(220, 90);
            this.l_numJour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_numJour.Name = "l_numJour";
            this.l_numJour.Size = new System.Drawing.Size(0, 25);
            this.l_numJour.TabIndex = 57;
            // 
            // b_creerNvAct
            // 
            this.b_creerNvAct.Location = new System.Drawing.Point(171, 615);
            this.b_creerNvAct.Name = "b_creerNvAct";
            this.b_creerNvAct.Size = new System.Drawing.Size(126, 48);
            this.b_creerNvAct.TabIndex = 58;
            this.b_creerNvAct.Text = "CRÉER";
            this.b_creerNvAct.UseVisualStyleBackColor = true;
            this.b_creerNvAct.Click += new System.EventHandler(this.b_creerNvAct_Click);
            // 
            // l_erreurHoraires
            // 
            this.l_erreurHoraires.AutoSize = true;
            this.l_erreurHoraires.ForeColor = System.Drawing.Color.Red;
            this.l_erreurHoraires.Location = new System.Drawing.Point(496, 83);
            this.l_erreurHoraires.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_erreurHoraires.Name = "l_erreurHoraires";
            this.l_erreurHoraires.Size = new System.Drawing.Size(96, 13);
            this.l_erreurHoraires.TabIndex = 59;
            this.l_erreurHoraires.Text = "Horaires invalides !";
            this.l_erreurHoraires.Visible = false;
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMap.Image")));
            this.pictureBoxMap.Location = new System.Drawing.Point(699, 21);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(365, 684);
            this.pictureBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMap.TabIndex = 60;
            this.pictureBoxMap.TabStop = false;
            this.pictureBoxMap.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numUpDown_yAct);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numUpDown_xAct);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.treeViewCategories);
            this.groupBox1.Controls.Add(this.l_cate);
            this.groupBox1.Controls.Add(this.cb_MFinAct);
            this.groupBox1.Controls.Add(this.cb_HFinAct);
            this.groupBox1.Controls.Add(this.cb_HDebAct);
            this.groupBox1.Controls.Add(this.cb_MDebAct);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxNomLieu);
            this.groupBox1.Controls.Add(this.l_erreurHoraires);
            this.groupBox1.Controls.Add(this.l_x);
            this.groupBox1.Controls.Add(this.l_y);
            this.groupBox1.Controls.Add(this.lB_listePart);
            this.groupBox1.Controls.Add(this.l_loc);
            this.groupBox1.Controls.Add(this.l_participants);
            this.groupBox1.Controls.Add(this.l_coord);
            this.groupBox1.Controls.Add(this.l_fin);
            this.groupBox1.Controls.Add(this.l_debut);
            this.groupBox1.Controls.Add(this.l_descr);
            this.groupBox1.Controls.Add(this.l_hDeb);
            this.groupBox1.Controls.Add(this.l_mDebut);
            this.groupBox1.Controls.Add(this.l_mFin);
            this.groupBox1.Controls.Add(this.l_hFin);
            this.groupBox1.Controls.Add(this.cB_localisation);
            this.groupBox1.Controls.Add(this.tB_descrAct);
            this.groupBox1.Location = new System.Drawing.Point(42, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(618, 538);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(244, 417);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 13);
            this.label8.TabIndex = 60;
            this.label8.Text = "Nom du lieu";
            // 
            // textBoxNomLieu
            // 
            this.textBoxNomLieu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxNomLieu.Enabled = false;
            this.textBoxNomLieu.Location = new System.Drawing.Point(338, 417);
            this.textBoxNomLieu.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxNomLieu.Name = "textBoxNomLieu";
            this.textBoxNomLieu.Size = new System.Drawing.Size(188, 20);
            this.textBoxNomLieu.TabIndex = 61;
            // 
            // buttonRetourJournee
            // 
            this.buttonRetourJournee.Image = ((System.Drawing.Image)(resources.GetObject("buttonRetourJournee.Image")));
            this.buttonRetourJournee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRetourJournee.Location = new System.Drawing.Point(12, 12);
            this.buttonRetourJournee.Name = "buttonRetourJournee";
            this.buttonRetourJournee.Size = new System.Drawing.Size(141, 34);
            this.buttonRetourJournee.TabIndex = 62;
            this.buttonRetourJournee.Text = "Revenir à la journée";
            this.buttonRetourJournee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRetourJournee.UseVisualStyleBackColor = true;
            this.buttonRetourJournee.Click += new System.EventHandler(this.buttonRetourJournee_Click);
            // 
            // labelNumeroJour
            // 
            this.labelNumeroJour.AutoSize = true;
            this.labelNumeroJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroJour.Location = new System.Drawing.Point(307, 21);
            this.labelNumeroJour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumeroJour.Name = "labelNumeroJour";
            this.labelNumeroJour.Size = new System.Drawing.Size(45, 25);
            this.labelNumeroJour.TabIndex = 63;
            this.labelNumeroJour.Text = "000";
            this.labelNumeroJour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cb_MDebAct.Location = new System.Drawing.Point(409, 62);
            this.cb_MDebAct.Name = "cb_MDebAct";
            this.cb_MDebAct.Size = new System.Drawing.Size(51, 21);
            this.cb_MDebAct.TabIndex = 62;
            this.cb_MDebAct.Text = "00";
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
            this.cb_MFinAct.Location = new System.Drawing.Point(409, 96);
            this.cb_MFinAct.Name = "cb_MFinAct";
            this.cb_MFinAct.Size = new System.Drawing.Size(51, 21);
            this.cb_MFinAct.TabIndex = 62;
            this.cb_MFinAct.Text = "00";
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
            this.cb_HDebAct.Location = new System.Drawing.Point(333, 62);
            this.cb_HDebAct.Name = "cb_HDebAct";
            this.cb_HDebAct.Size = new System.Drawing.Size(51, 21);
            this.cb_HDebAct.TabIndex = 62;
            this.cb_HDebAct.Text = "00";
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
            this.cb_HFinAct.Location = new System.Drawing.Point(333, 96);
            this.cb_HFinAct.Name = "cb_HFinAct";
            this.cb_HFinAct.Size = new System.Drawing.Size(51, 21);
            this.cb_HFinAct.TabIndex = 62;
            this.cb_HFinAct.Text = "10";
            // 
            // treeViewCategories
            // 
            this.treeViewCategories.HideSelection = false;
            this.treeViewCategories.Location = new System.Drawing.Point(21, 62);
            this.treeViewCategories.Name = "treeViewCategories";
            this.treeViewCategories.Size = new System.Drawing.Size(175, 356);
            this.treeViewCategories.TabIndex = 63;
            this.treeViewCategories.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.treeViewCategories_BeforeSelect);
            this.treeViewCategories.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewCategories_AfterSelect);
            this.treeViewCategories.Validating += new System.ComponentModel.CancelEventHandler(this.treeViewCategories_Validating);
            // 
            // l_cate
            // 
            this.l_cate.AutoSize = true;
            this.l_cate.Location = new System.Drawing.Point(18, 32);
            this.l_cate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_cate.Name = "l_cate";
            this.l_cate.Size = new System.Drawing.Size(52, 13);
            this.l_cate.TabIndex = 64;
            this.l_cate.Text = "Catégorie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Nom de l\'activité";
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(334, 32);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(188, 20);
            this.textBox1.TabIndex = 66;
            // 
            // numUpDown_yAct
            // 
            this.numUpDown_yAct.Enabled = false;
            this.numUpDown_yAct.Location = new System.Drawing.Point(483, 453);
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
            this.numUpDown_yAct.TabIndex = 64;
            // 
            // numUpDown_xAct
            // 
            this.numUpDown_xAct.Enabled = false;
            this.numUpDown_xAct.Location = new System.Drawing.Point(381, 453);
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
            this.numUpDown_xAct.TabIndex = 65;
            // 
            // pb_maps
            // 
            this.pb_maps.BackColor = System.Drawing.Color.Transparent;
            this.pb_maps.Image = global::AppliMars.Properties.Resources.maps;
            this.pb_maps.Location = new System.Drawing.Point(866, 207);
            this.pb_maps.Name = "pb_maps";
            this.pb_maps.Size = new System.Drawing.Size(20, 34);
            this.pb_maps.TabIndex = 67;
            this.pb_maps.TabStop = false;
            // 
            // WindowNewAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 731);
            this.ControlBox = false;
            this.Controls.Add(this.pb_maps);
            this.Controls.Add(this.labelNumeroJour);
            this.Controls.Add(this.buttonRetourJournee);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxMap);
            this.Controls.Add(this.b_creerNvAct);
            this.Controls.Add(this.l_numJour);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WindowNewAct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Création d\'une nouvelle mission";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_yAct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_xAct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_maps)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cB_localisation;
        private System.Windows.Forms.TextBox tB_descrAct;
        private System.Windows.Forms.Label l_hFin;
        private System.Windows.Forms.Label l_mFin;
        private System.Windows.Forms.Label l_mDebut;
        private System.Windows.Forms.Label l_hDeb;
        private System.Windows.Forms.Label l_descr;
        private System.Windows.Forms.Label l_debut;
        private System.Windows.Forms.Label l_fin;
        private System.Windows.Forms.Label l_coord;
        private System.Windows.Forms.Label l_loc;
        private System.Windows.Forms.Label l_y;
        private System.Windows.Forms.Label l_x;
        private System.Windows.Forms.ListBox lB_listePart;
        private System.Windows.Forms.Label l_participants;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l_numJour;
        private System.Windows.Forms.Button b_creerNvAct;
        private System.Windows.Forms.Label l_erreurHoraires;
        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRetourJournee;
        private System.Windows.Forms.Label labelNumeroJour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNomLieu;
        private System.Windows.Forms.ComboBox cb_MFinAct;
        private System.Windows.Forms.ComboBox cb_MDebAct;
        private System.Windows.Forms.ComboBox cb_HFinAct;
        private System.Windows.Forms.ComboBox cb_HDebAct;
        private System.Windows.Forms.TreeView treeViewCategories;
        private System.Windows.Forms.Label l_cate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numUpDown_yAct;
        private System.Windows.Forms.NumericUpDown numUpDown_xAct;
        private System.Windows.Forms.PictureBox pb_maps;
    }
}