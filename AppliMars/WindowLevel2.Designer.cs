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
            this.buttonDeleteAct = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAjoutActivite = new System.Windows.Forms.Button();
            this.buttonCompteRendu = new System.Windows.Forms.Button();
            this.labelNomEmploiDuTemps = new System.Windows.Forms.Label();
            this.buttonRetourCalendrier = new System.Windows.Forms.Button();
            this.pictureBoxJourSuivant = new System.Windows.Forms.PictureBox();
            this.pictureBoxJourPrecedent = new System.Windows.Forms.PictureBox();
            this.listBoxActivites = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxRightArrow = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeftArrow = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJourSuivant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJourPrecedent)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftArrow)).BeginInit();
            this.SuspendLayout();
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(68, 20);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(85, 39);
            this.label26.TabIndex = 2;
            this.label26.Text = "Jour";
            // 
            // labelJour
            // 
            this.labelJour.AutoSize = true;
            this.labelJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJour.Location = new System.Drawing.Point(148, 20);
            this.labelJour.Name = "labelJour";
            this.labelJour.Size = new System.Drawing.Size(74, 39);
            this.labelJour.TabIndex = 3;
            this.labelJour.Text = "000";
            this.labelJour.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonDeleteAct
            // 
            this.buttonDeleteAct.Location = new System.Drawing.Point(634, 271);
            this.buttonDeleteAct.Name = "buttonDeleteAct";
            this.buttonDeleteAct.Size = new System.Drawing.Size(162, 34);
            this.buttonDeleteAct.TabIndex = 8;
            this.buttonDeleteAct.Text = "Supprimer l\'activité sélectionnée";
            this.buttonDeleteAct.UseVisualStyleBackColor = true;
            this.buttonDeleteAct.Visible = false;
            this.buttonDeleteAct.Click += new System.EventHandler(this.buttonDeleteAct_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonAjoutActivite);
            this.groupBox2.Controls.Add(this.buttonCompteRendu);
            this.groupBox2.Location = new System.Drawing.Point(22, 271);
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
            this.labelNomEmploiDuTemps.Location = new System.Drawing.Point(460, 208);
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
            this.pictureBoxJourSuivant.Location = new System.Drawing.Point(538, 208);
            this.pictureBoxJourSuivant.Name = "pictureBoxJourSuivant";
            this.pictureBoxJourSuivant.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxJourSuivant.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxJourSuivant.TabIndex = 4;
            this.pictureBoxJourSuivant.TabStop = false;
            this.pictureBoxJourSuivant.Click += new System.EventHandler(this.pictureBoxEDTSuiv_Click);
            // 
            // pictureBoxJourPrecedent
            // 
            this.pictureBoxJourPrecedent.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxJourPrecedent.Image")));
            this.pictureBoxJourPrecedent.Location = new System.Drawing.Point(262, 208);
            this.pictureBoxJourPrecedent.Name = "pictureBoxJourPrecedent";
            this.pictureBoxJourPrecedent.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxJourPrecedent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxJourPrecedent.TabIndex = 5;
            this.pictureBoxJourPrecedent.TabStop = false;
            this.pictureBoxJourPrecedent.Click += new System.EventHandler(this.pictureBoxEDTPrec_Click);
            // 
            // listBoxActivites
            // 
            this.listBoxActivites.FormattingEnabled = true;
            this.listBoxActivites.Location = new System.Drawing.Point(284, 271);
            this.listBoxActivites.Name = "listBoxActivites";
            this.listBoxActivites.Size = new System.Drawing.Size(247, 368);
            this.listBoxActivites.TabIndex = 15;
            this.listBoxActivites.SelectedIndexChanged += new System.EventHandler(this.listBoxActivites_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Emploi du temps de";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBoxRightArrow);
            this.panel2.Controls.Add(this.label26);
            this.panel2.Controls.Add(this.labelJour);
            this.panel2.Controls.Add(this.pictureBoxLeftArrow);
            this.panel2.Location = new System.Drawing.Point(262, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 80);
            this.panel2.TabIndex = 17;
            // 
            // pictureBoxRightArrow
            // 
            this.pictureBoxRightArrow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRightArrow.Image")));
            this.pictureBoxRightArrow.Location = new System.Drawing.Point(228, 14);
            this.pictureBoxRightArrow.Name = "pictureBoxRightArrow";
            this.pictureBoxRightArrow.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxRightArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRightArrow.TabIndex = 18;
            this.pictureBoxRightArrow.TabStop = false;
            this.pictureBoxRightArrow.Click += new System.EventHandler(this.pictureBoxJourSuivant_Click);
            // 
            // pictureBoxLeftArrow
            // 
            this.pictureBoxLeftArrow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLeftArrow.Image")));
            this.pictureBoxLeftArrow.Location = new System.Drawing.Point(8, 14);
            this.pictureBoxLeftArrow.Name = "pictureBoxLeftArrow";
            this.pictureBoxLeftArrow.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLeftArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLeftArrow.TabIndex = 19;
            this.pictureBoxLeftArrow.TabStop = false;
            this.pictureBoxLeftArrow.Click += new System.EventHandler(this.pictureBoxJourPrecedent_Click);
            // 
            // WindowLevel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 731);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxJourPrecedent);
            this.Controls.Add(this.pictureBoxJourSuivant);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.buttonDeleteAct);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listBoxActivites);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelNomEmploiDuTemps);
            this.Controls.Add(this.buttonRetourCalendrier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WindowLevel2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mars Explorer 2017 - Mode journée";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJourSuivant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJourPrecedent)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftArrow)).EndInit();
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
        private System.Windows.Forms.Button buttonDeleteAct;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelNomEmploiDuTemps;
        private System.Windows.Forms.ListBox listBoxActivites;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBoxRightArrow;
        private System.Windows.Forms.PictureBox pictureBoxLeftArrow;
    }
}