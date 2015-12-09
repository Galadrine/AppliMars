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
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonAjoutActivite = new System.Windows.Forms.Button();
            this.buttonCompteRendu = new System.Windows.Forms.Button();
            this.labelNomEmploiDuTemps = new System.Windows.Forms.Label();
            this.buttonRetourCalendrier = new System.Windows.Forms.Button();
            this.pictureBoxJourSuivant = new System.Windows.Forms.PictureBox();
            this.pictureBoxJourPrecedent = new System.Windows.Forms.PictureBox();
            this.listBoxActivites = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJourSuivant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJourPrecedent)).BeginInit();
            this.SuspendLayout();
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(308, 75);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(51, 25);
            this.label26.TabIndex = 2;
            this.label26.Text = "Jour";
            // 
            // labelJour
            // 
            this.labelJour.AutoSize = true;
            this.labelJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJour.Location = new System.Drawing.Point(358, 75);
            this.labelJour.Name = "labelJour";
            this.labelJour.Size = new System.Drawing.Size(23, 25);
            this.labelJour.TabIndex = 3;
            this.labelJour.Text = "0";
            // 
            // buttonGoToLevel3
            // 
            this.buttonGoToLevel3.Location = new System.Drawing.Point(769, 77);
            this.buttonGoToLevel3.Name = "buttonGoToLevel3";
            this.buttonGoToLevel3.Size = new System.Drawing.Size(162, 30);
            this.buttonGoToLevel3.TabIndex = 8;
            this.buttonGoToLevel3.Text = "Modifier l\'activité sélectionnée";
            this.buttonGoToLevel3.UseVisualStyleBackColor = true;
            this.buttonGoToLevel3.Visible = false;
            this.buttonGoToLevel3.Click += new System.EventHandler(this.detailActivite);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 34);
            this.button3.TabIndex = 10;
            this.button3.Text = "Emploi du temps suivant";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 34);
            this.button4.TabIndex = 11;
            this.button4.Text = "Emploi du temps précédent";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Location = new System.Drawing.Point(763, 131);
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
            this.groupBox2.Location = new System.Drawing.Point(259, 131);
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
            this.labelNomEmploiDuTemps.Location = new System.Drawing.Point(513, 40);
            this.labelNomEmploiDuTemps.Name = "labelNomEmploiDuTemps";
            this.labelNomEmploiDuTemps.Size = new System.Drawing.Size(188, 20);
            this.labelNomEmploiDuTemps.TabIndex = 14;
            this.labelNomEmploiDuTemps.Text = "Emploi du temps de John";
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
            this.pictureBoxJourSuivant.Location = new System.Drawing.Point(395, 77);
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
            this.pictureBoxJourPrecedent.Location = new System.Drawing.Point(274, 77);
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
            this.listBoxActivites.Location = new System.Drawing.Point(481, 77);
            this.listBoxActivites.Name = "listBoxActivites";
            this.listBoxActivites.Size = new System.Drawing.Size(247, 368);
            this.listBoxActivites.TabIndex = 15;
            this.listBoxActivites.SelectedIndexChanged += new System.EventHandler(this.listBoxActivites_SelectedIndexChanged);
            // 
            // WindowLevel2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 791);
            this.ControlBox = false;
            this.Controls.Add(this.listBoxActivites);
            this.Controls.Add(this.labelNomEmploiDuTemps);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonGoToLevel3);
            this.Controls.Add(this.buttonRetourCalendrier);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.labelJour);
            this.Controls.Add(this.pictureBoxJourSuivant);
            this.Controls.Add(this.pictureBoxJourPrecedent);
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelNomEmploiDuTemps;
        private System.Windows.Forms.ListBox listBoxActivites;
    }
}