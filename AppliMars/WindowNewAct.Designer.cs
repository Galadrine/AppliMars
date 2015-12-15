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
            this.tB_xAct = new System.Windows.Forms.TextBox();
            this.l_y = new System.Windows.Forms.Label();
            this.l_x = new System.Windows.Forms.Label();
            this.tB_yAct = new System.Windows.Forms.TextBox();
            this.l_typeAct = new System.Windows.Forms.Label();
            this.l_cate = new System.Windows.Forms.Label();
            this.cB_cate = new System.Windows.Forms.ComboBox();
            this.cB_typeAct = new System.Windows.Forms.ComboBox();
            this.tB_MFinAct = new System.Windows.Forms.TextBox();
            this.tB_HFinAct = new System.Windows.Forms.TextBox();
            this.tB_MDebAct = new System.Windows.Forms.TextBox();
            this.tB_HDebAct = new System.Windows.Forms.TextBox();
            this.lB_listePart = new System.Windows.Forms.ListBox();
            this.l_participants = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.l_numJour = new System.Windows.Forms.Label();
            this.b_creerNvAct = new System.Windows.Forms.Button();
            this.l_erreurConvert = new System.Windows.Forms.Label();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxNomLieu = new System.Windows.Forms.TextBox();
            this.buttonRetourJournee = new System.Windows.Forms.Button();
            this.labelNumeroJour = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cB_localisation
            // 
            this.cB_localisation.AutoSize = true;
            this.cB_localisation.Location = new System.Drawing.Point(136, 407);
            this.cB_localisation.Name = "cB_localisation";
            this.cB_localisation.Size = new System.Drawing.Size(119, 17);
            this.cB_localisation.TabIndex = 46;
            this.cB_localisation.Text = "Activité en extérieur";
            this.cB_localisation.UseVisualStyleBackColor = true;
            this.cB_localisation.CheckedChanged += new System.EventHandler(this.cB_localisation_CheckedChanged);
            // 
            // tB_descrAct
            // 
            this.tB_descrAct.Location = new System.Drawing.Point(137, 155);
            this.tB_descrAct.Margin = new System.Windows.Forms.Padding(2);
            this.tB_descrAct.MaxLength = 400;
            this.tB_descrAct.Multiline = true;
            this.tB_descrAct.Name = "tB_descrAct";
            this.tB_descrAct.Size = new System.Drawing.Size(245, 145);
            this.tB_descrAct.TabIndex = 31;
            this.tB_descrAct.TextChanged += new System.EventHandler(this.tB_descrAct_TextChanged);
            // 
            // l_hFin
            // 
            this.l_hFin.AutoSize = true;
            this.l_hFin.Location = new System.Drawing.Point(169, 127);
            this.l_hFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_hFin.Name = "l_hFin";
            this.l_hFin.Size = new System.Drawing.Size(13, 13);
            this.l_hFin.TabIndex = 32;
            this.l_hFin.Text = "h";
            // 
            // l_mFin
            // 
            this.l_mFin.AutoSize = true;
            this.l_mFin.Location = new System.Drawing.Point(222, 127);
            this.l_mFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_mFin.Name = "l_mFin";
            this.l_mFin.Size = new System.Drawing.Size(23, 13);
            this.l_mFin.TabIndex = 33;
            this.l_mFin.Text = "min";
            // 
            // l_mDebut
            // 
            this.l_mDebut.AutoSize = true;
            this.l_mDebut.Location = new System.Drawing.Point(222, 96);
            this.l_mDebut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_mDebut.Name = "l_mDebut";
            this.l_mDebut.Size = new System.Drawing.Size(23, 13);
            this.l_mDebut.TabIndex = 34;
            this.l_mDebut.Text = "min";
            // 
            // l_hDeb
            // 
            this.l_hDeb.AutoSize = true;
            this.l_hDeb.Location = new System.Drawing.Point(170, 96);
            this.l_hDeb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_hDeb.Name = "l_hDeb";
            this.l_hDeb.Size = new System.Drawing.Size(13, 13);
            this.l_hDeb.TabIndex = 35;
            this.l_hDeb.Text = "h";
            // 
            // l_descr
            // 
            this.l_descr.AutoSize = true;
            this.l_descr.Location = new System.Drawing.Point(52, 155);
            this.l_descr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_descr.Name = "l_descr";
            this.l_descr.Size = new System.Drawing.Size(60, 13);
            this.l_descr.TabIndex = 36;
            this.l_descr.Text = "Description";
            // 
            // l_debut
            // 
            this.l_debut.AutoSize = true;
            this.l_debut.Location = new System.Drawing.Point(76, 96);
            this.l_debut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_debut.Name = "l_debut";
            this.l_debut.Size = new System.Drawing.Size(36, 13);
            this.l_debut.TabIndex = 37;
            this.l_debut.Text = "Debut";
            // 
            // l_fin
            // 
            this.l_fin.AutoSize = true;
            this.l_fin.Location = new System.Drawing.Point(91, 127);
            this.l_fin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_fin.Name = "l_fin";
            this.l_fin.Size = new System.Drawing.Size(21, 13);
            this.l_fin.TabIndex = 38;
            this.l_fin.Text = "Fin";
            // 
            // l_coord
            // 
            this.l_coord.AutoSize = true;
            this.l_coord.Location = new System.Drawing.Point(13, 484);
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
            this.l_loc.Location = new System.Drawing.Point(48, 409);
            this.l_loc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_loc.Name = "l_loc";
            this.l_loc.Size = new System.Drawing.Size(63, 13);
            this.l_loc.TabIndex = 40;
            this.l_loc.Text = "Localisation";
            // 
            // tB_xAct
            // 
            this.tB_xAct.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tB_xAct.Location = new System.Drawing.Point(200, 481);
            this.tB_xAct.Margin = new System.Windows.Forms.Padding(2);
            this.tB_xAct.Name = "tB_xAct";
            this.tB_xAct.Size = new System.Drawing.Size(35, 20);
            this.tB_xAct.TabIndex = 41;
            this.tB_xAct.Visible = false;
            // 
            // l_y
            // 
            this.l_y.AutoSize = true;
            this.l_y.Location = new System.Drawing.Point(241, 486);
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
            this.l_x.Location = new System.Drawing.Point(135, 486);
            this.l_x.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_x.Name = "l_x";
            this.l_x.Size = new System.Drawing.Size(50, 13);
            this.l_x.TabIndex = 43;
            this.l_x.Text = "longitude";
            this.l_x.Visible = false;
            // 
            // tB_yAct
            // 
            this.tB_yAct.Location = new System.Drawing.Point(290, 483);
            this.tB_yAct.Margin = new System.Windows.Forms.Padding(2);
            this.tB_yAct.Name = "tB_yAct";
            this.tB_yAct.Size = new System.Drawing.Size(35, 20);
            this.tB_yAct.TabIndex = 44;
            this.tB_yAct.Visible = false;
            // 
            // l_typeAct
            // 
            this.l_typeAct.AutoSize = true;
            this.l_typeAct.Location = new System.Drawing.Point(36, 61);
            this.l_typeAct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_typeAct.Name = "l_typeAct";
            this.l_typeAct.Size = new System.Drawing.Size(76, 13);
            this.l_typeAct.TabIndex = 45;
            this.l_typeAct.Text = "Type d\'activité";
            // 
            // l_cate
            // 
            this.l_cate.AutoSize = true;
            this.l_cate.Location = new System.Drawing.Point(60, 30);
            this.l_cate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_cate.Name = "l_cate";
            this.l_cate.Size = new System.Drawing.Size(52, 13);
            this.l_cate.TabIndex = 47;
            this.l_cate.Text = "Catégorie";
            // 
            // cB_cate
            // 
            this.cB_cate.FormattingEnabled = true;
            this.cB_cate.Location = new System.Drawing.Point(138, 27);
            this.cB_cate.Name = "cB_cate";
            this.cB_cate.Size = new System.Drawing.Size(121, 21);
            this.cB_cate.TabIndex = 48;
            this.cB_cate.SelectedIndexChanged += new System.EventHandler(this.cB_cate_SelectedIndexChanged);
            // 
            // cB_typeAct
            // 
            this.cB_typeAct.FormattingEnabled = true;
            this.cB_typeAct.Location = new System.Drawing.Point(138, 58);
            this.cB_typeAct.Name = "cB_typeAct";
            this.cB_typeAct.Size = new System.Drawing.Size(121, 21);
            this.cB_typeAct.TabIndex = 49;
            // 
            // tB_MFinAct
            // 
            this.tB_MFinAct.Location = new System.Drawing.Point(187, 124);
            this.tB_MFinAct.Name = "tB_MFinAct";
            this.tB_MFinAct.Size = new System.Drawing.Size(27, 20);
            this.tB_MFinAct.TabIndex = 53;
            // 
            // tB_HFinAct
            // 
            this.tB_HFinAct.Location = new System.Drawing.Point(136, 124);
            this.tB_HFinAct.Name = "tB_HFinAct";
            this.tB_HFinAct.Size = new System.Drawing.Size(27, 20);
            this.tB_HFinAct.TabIndex = 52;
            // 
            // tB_MDebAct
            // 
            this.tB_MDebAct.Location = new System.Drawing.Point(187, 93);
            this.tB_MDebAct.Name = "tB_MDebAct";
            this.tB_MDebAct.Size = new System.Drawing.Size(27, 20);
            this.tB_MDebAct.TabIndex = 51;
            // 
            // tB_HDebAct
            // 
            this.tB_HDebAct.Location = new System.Drawing.Point(137, 93);
            this.tB_HDebAct.Name = "tB_HDebAct";
            this.tB_HDebAct.Size = new System.Drawing.Size(27, 20);
            this.tB_HDebAct.TabIndex = 50;
            // 
            // lB_listePart
            // 
            this.lB_listePart.FormattingEnabled = true;
            this.lB_listePart.Location = new System.Drawing.Point(138, 306);
            this.lB_listePart.Name = "lB_listePart";
            this.lB_listePart.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lB_listePart.Size = new System.Drawing.Size(246, 95);
            this.lB_listePart.TabIndex = 55;
            // 
            // l_participants
            // 
            this.l_participants.AutoSize = true;
            this.l_participants.Location = new System.Drawing.Point(52, 306);
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
            // l_erreurConvert
            // 
            this.l_erreurConvert.AutoSize = true;
            this.l_erreurConvert.ForeColor = System.Drawing.Color.Red;
            this.l_erreurConvert.Location = new System.Drawing.Point(267, 109);
            this.l_erreurConvert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_erreurConvert.Name = "l_erreurConvert";
            this.l_erreurConvert.Size = new System.Drawing.Size(117, 13);
            this.l_erreurConvert.TabIndex = 59;
            this.l_erreurConvert.Text = "Conversion impossible !";
            this.l_erreurConvert.Visible = false;
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMap.Image")));
            this.pictureBoxMap.Location = new System.Drawing.Point(463, 21);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(365, 684);
            this.pictureBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMap.TabIndex = 60;
            this.pictureBoxMap.TabStop = false;
            this.pictureBoxMap.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textBoxNomLieu);
            this.groupBox1.Controls.Add(this.l_cate);
            this.groupBox1.Controls.Add(this.l_typeAct);
            this.groupBox1.Controls.Add(this.l_erreurConvert);
            this.groupBox1.Controls.Add(this.tB_yAct);
            this.groupBox1.Controls.Add(this.l_x);
            this.groupBox1.Controls.Add(this.l_y);
            this.groupBox1.Controls.Add(this.tB_xAct);
            this.groupBox1.Controls.Add(this.lB_listePart);
            this.groupBox1.Controls.Add(this.l_loc);
            this.groupBox1.Controls.Add(this.l_participants);
            this.groupBox1.Controls.Add(this.l_coord);
            this.groupBox1.Controls.Add(this.tB_MFinAct);
            this.groupBox1.Controls.Add(this.l_fin);
            this.groupBox1.Controls.Add(this.tB_HFinAct);
            this.groupBox1.Controls.Add(this.l_debut);
            this.groupBox1.Controls.Add(this.tB_MDebAct);
            this.groupBox1.Controls.Add(this.l_descr);
            this.groupBox1.Controls.Add(this.tB_HDebAct);
            this.groupBox1.Controls.Add(this.l_hDeb);
            this.groupBox1.Controls.Add(this.cB_typeAct);
            this.groupBox1.Controls.Add(this.l_mDebut);
            this.groupBox1.Controls.Add(this.cB_cate);
            this.groupBox1.Controls.Add(this.l_mFin);
            this.groupBox1.Controls.Add(this.l_hFin);
            this.groupBox1.Controls.Add(this.cB_localisation);
            this.groupBox1.Controls.Add(this.tB_descrAct);
            this.groupBox1.Location = new System.Drawing.Point(42, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 538);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Enabled = false;
            this.label8.Location = new System.Drawing.Point(48, 448);
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
            this.textBoxNomLieu.Location = new System.Drawing.Point(142, 448);
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
            // WindowNewAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 731);
            this.ControlBox = false;
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
        private System.Windows.Forms.TextBox tB_xAct;
        private System.Windows.Forms.Label l_y;
        private System.Windows.Forms.Label l_x;
        private System.Windows.Forms.TextBox tB_yAct;
        private System.Windows.Forms.Label l_typeAct;
        private System.Windows.Forms.Label l_cate;
        private System.Windows.Forms.ComboBox cB_cate;
        private System.Windows.Forms.ComboBox cB_typeAct;
        private System.Windows.Forms.TextBox tB_MFinAct;
        private System.Windows.Forms.TextBox tB_HFinAct;
        private System.Windows.Forms.TextBox tB_MDebAct;
        private System.Windows.Forms.TextBox tB_HDebAct;
        private System.Windows.Forms.ListBox lB_listePart;
        private System.Windows.Forms.Label l_participants;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l_numJour;
        private System.Windows.Forms.Button b_creerNvAct;
        private System.Windows.Forms.Label l_erreurConvert;
        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonRetourJournee;
        private System.Windows.Forms.Label labelNumeroJour;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxNomLieu;
    }
}