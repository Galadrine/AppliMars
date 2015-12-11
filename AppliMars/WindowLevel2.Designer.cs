namespace AppliMars {
    partial class WindowLevel2 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowLevel2));
            this.label26 = new System.Windows.Forms.Label();
            this.labelJour = new System.Windows.Forms.Label();
            this.buttonGoToLevel3 = new System.Windows.Forms.Button();
            this.buttonEDTSuiv = new System.Windows.Forms.Button();
            this.buttonEDTPrec = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAjoutActivite = new System.Windows.Forms.Button();
            this.buttonCompteRendu = new System.Windows.Forms.Button();
            this.labelNomEmploiDuTemps = new System.Windows.Forms.Label();
            this.buttonRetourCalendrier = new System.Windows.Forms.Button();
            this.pictureBoxJourSuivant = new System.Windows.Forms.PictureBox();
            this.pictureBoxJourPrecedent = new System.Windows.Forms.PictureBox();
            this.listBoxActivites = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJourSuivant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJourPrecedent)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(37, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(51, 25);
            this.label26.TabIndex = 2;
            this.label26.Text = "Jour";
            // 
            // labelJour
            // 
            this.labelJour.AutoSize = true;
            this.labelJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJour.Location = new System.Drawing.Point(87, 0);
            this.labelJour.Name = "labelJour";
            this.labelJour.Size = new System.Drawing.Size(23, 25);
            this.labelJour.TabIndex = 3;
            this.labelJour.Text = "0";
            // 
            // buttonGoToLevel3
            // 
            this.buttonGoToLevel3.Location = new System.Drawing.Point(33, 127);
            this.buttonGoToLevel3.Name = "buttonGoToLevel3";
            this.buttonGoToLevel3.Size = new System.Drawing.Size(162, 30);
            this.buttonGoToLevel3.TabIndex = 8;
            this.buttonGoToLevel3.Text = "Modifier l\'activité sélectionnée";
            this.buttonGoToLevel3.UseVisualStyleBackColor = true;
            this.buttonGoToLevel3.Visible = false;
            this.buttonGoToLevel3.Click += new System.EventHandler(this.detailActivite);
            // 
            // buttonEDTSuiv
            // 
            this.buttonEDTSuiv.Location = new System.Drawing.Point(6, 56);
            this.buttonEDTSuiv.Name = "buttonEDTSuiv";
            this.buttonEDTSuiv.Size = new System.Drawing.Size(162, 34);
            this.buttonEDTSuiv.TabIndex = 10;
            this.buttonEDTSuiv.Text = "Emploi du temps suivant";
            this.buttonEDTSuiv.UseVisualStyleBackColor = true;
            this.buttonEDTSuiv.Click += new System.EventHandler(this.buttonEDTSuiv_Click);
            // 
            // buttonEDTPrec
            // 
            this.buttonEDTPrec.Location = new System.Drawing.Point(6, 19);
            this.buttonEDTPrec.Name = "buttonEDTPrec";
            this.buttonEDTPrec.Size = new System.Drawing.Size(162, 34);
            this.buttonEDTPrec.TabIndex = 11;
            this.buttonEDTPrec.Text = "Emploi du temps précédent";
            this.buttonEDTPrec.UseVisualStyleBackColor = true;
            this.buttonEDTPrec.Click += new System.EventHandler(this.buttonEDTPrec_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonEDTPrec);
            this.groupBox1.Controls.Add(this.buttonEDTSuiv);
            this.groupBox1.Location = new System.Drawing.Point(58, 228);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 100);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choix de l\'emploi du temps";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAjoutActivite);
            this.groupBox2.Controls.Add(this.buttonCompteRendu);
            this.groupBox2.Location = new System.Drawing.Point(27, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(176, 100);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Actions sur la journée";
            // 
            // buttonAjoutActivite
            // 
            this.buttonAjoutActivite.Image = global::AppliMars.Properties.Resources.add;
            this.buttonAjoutActivite.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAjoutActivite.Location = new System.Drawing.Point(6, 19);
            this.buttonAjoutActivite.Name = "buttonAjoutActivite";
            this.buttonAjoutActivite.Size = new System.Drawing.Size(162, 34);
            this.buttonAjoutActivite.TabIndex = 1;
            this.buttonAjoutActivite.Text = "    Ajouter une activité";
            this.buttonAjoutActivite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAjoutActivite.UseVisualStyleBackColor = true;
            this.buttonAjoutActivite.Click += new System.EventHandler(this.buttonAjoutActivite_Click);
            // 
            // buttonCompteRendu
            // 
            this.buttonCompteRendu.Image = ((System.Drawing.Image)(resources.GetObject("buttonCompteRendu.Image")));
            this.buttonCompteRendu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCompteRendu.Location = new System.Drawing.Point(6, 56);
            this.buttonCompteRendu.Name = "buttonCompteRendu";
            this.buttonCompteRendu.Size = new System.Drawing.Size(162, 34);
            this.buttonCompteRendu.TabIndex = 7;
            this.buttonCompteRendu.Text = "         Compte rendu";
            this.buttonCompteRendu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCompteRendu.UseVisualStyleBackColor = true;
            this.buttonCompteRendu.Click += new System.EventHandler(this.buttonCompteRendu_Click);
            // 
            // labelNomEmploiDuTemps
            // 
            this.labelNomEmploiDuTemps.AutoSize = true;
            this.labelNomEmploiDuTemps.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNomEmploiDuTemps.Location = new System.Drawing.Point(468, 188);
            this.labelNomEmploiDuTemps.Name = "labelNomEmploiDuTemps";
            this.labelNomEmploiDuTemps.Size = new System.Drawing.Size(44, 20);
            this.labelNomEmploiDuTemps.TabIndex = 14;
            this.labelNomEmploiDuTemps.Text = "John";
            this.labelNomEmploiDuTemps.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonRetourCalendrier
            // 
            this.buttonRetourCalendrier.Image = ((System.Drawing.Image)(resources.GetObject("buttonRetourCalendrier.Image")));
            this.buttonRetourCalendrier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRetourCalendrier.Location = new System.Drawing.Point(22, 12);
            this.buttonRetourCalendrier.Name = "buttonRetourCalendrier";
            this.buttonRetourCalendrier.Size = new System.Drawing.Size(162, 34);
            this.buttonRetourCalendrier.TabIndex = 1;
            this.buttonRetourCalendrier.Text = "Revenir au calendrier";
            this.buttonRetourCalendrier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRetourCalendrier.UseVisualStyleBackColor = true;
            this.buttonRetourCalendrier.Click += new System.EventHandler(this.buttonRetourCalendrier_Click);
            // 
            // pictureBoxJourSuivant
            // 
            this.pictureBoxJourSuivant.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxJourSuivant.Image")));
            this.pictureBoxJourSuivant.Location = new System.Drawing.Point(124, 2);
            this.pictureBoxJourSuivant.Name = "pictureBoxJourSuivant";
            this.pictureBoxJourSuivant.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxJourSuivant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxJourSuivant.TabIndex = 4;
            this.pictureBoxJourSuivant.TabStop = false;
            this.pictureBoxJourSuivant.Click += new System.EventHandler(this.pictureBoxJourSuivant_Click);
            // 
            // pictureBoxJourPrecedent
            // 
            this.pictureBoxJourPrecedent.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxJourPrecedent.Image")));
            this.pictureBoxJourPrecedent.Location = new System.Drawing.Point(3, 2);
            this.pictureBoxJourPrecedent.Name = "pictureBoxJourPrecedent";
            this.pictureBoxJourPrecedent.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxJourPrecedent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxJourPrecedent.TabIndex = 5;
            this.pictureBoxJourPrecedent.TabStop = false;
            this.pictureBoxJourPrecedent.Click += new System.EventHandler(this.pictureBoxJourPrecedent_Click);
            // 
            // listBoxActivites
            // 
            this.listBoxActivites.FormattingEnabled = true;
            this.listBoxActivites.Location = new System.Drawing.Point(293, 228);
            this.listBoxActivites.Name = "listBoxActivites";
            this.listBoxActivites.Size = new System.Drawing.Size(247, 368);
            this.listBoxActivites.TabIndex = 15;
            this.listBoxActivites.SelectedIndexChanged += new System.EventHandler(this.listBoxActivites_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Emploi du temps de";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.buttonGoToLevel3);
            this.panel1.Location = new System.Drawing.Point(570, 207);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 194);
            this.panel1.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.pictureBoxJourPrecedent);
            this.panel2.Controls.Add(this.pictureBoxJourSuivant);
            this.panel2.Controls.Add(this.labelJour);
            this.panel2.Location = new System.Drawing.Point(338, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 28);
            this.panel2.TabIndex = 17;
            // 
            // WindowLevel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 731);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxActivites);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNomEmploiDuTemps);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonRetourCalendrier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WindowLevel2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mars Explorer 2017 - Mode journée";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJourSuivant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJourPrecedent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAjoutActivite;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label labelJour;
        private System.Windows.Forms.PictureBox pictureBoxJourSuivant;
        private System.Windows.Forms.PictureBox pictureBoxJourPrecedent;
        private System.Windows.Forms.Button buttonRetourCalendrier;
        private System.Windows.Forms.Button buttonCompteRendu;
        private System.Windows.Forms.Button buttonGoToLevel3;
        private System.Windows.Forms.Button buttonEDTSuiv;
        private System.Windows.Forms.Button buttonEDTPrec;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelNomEmploiDuTemps;
        private System.Windows.Forms.ListBox listBoxActivites;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}