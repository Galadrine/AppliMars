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
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label_description_activite = new System.Windows.Forms.Label();
            this.l_numJour = new System.Windows.Forms.Label();
            this.label_heure_debut = new System.Windows.Forms.Label();
            this.label_heure_fin = new System.Windows.Forms.Label();
            this.labelCoordonnees = new System.Windows.Forms.Label();
            this.labelLatitude = new System.Windows.Forms.Label();
            this.labelLongitude = new System.Windows.Forms.Label();
            this.TextBoxOrdonnee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxHeuresDebut = new System.Windows.Forms.ComboBox();
            this.comboBoxMinutesDebut = new System.Windows.Forms.ComboBox();
            this.comboBoxHeuresFin = new System.Windows.Forms.ComboBox();
            this.comboBoxMinutesFin = new System.Windows.Forms.ComboBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonRetourJournee = new System.Windows.Forms.Button();
            this.comboBoxTypeActivite = new System.Windows.Forms.ComboBox();
            this.pictureBoxMap = new System.Windows.Forms.PictureBox();
            this.checkBoxLocalisation = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxAbscisse = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(135, 146);
            this.textBoxDescription.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(247, 173);
            this.textBoxDescription.TabIndex = 2;
            // 
            // label_description_activite
            // 
            this.label_description_activite.AutoSize = true;
            this.label_description_activite.Location = new System.Drawing.Point(50, 146);
            this.label_description_activite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_description_activite.Name = "label_description_activite";
            this.label_description_activite.Size = new System.Drawing.Size(60, 13);
            this.label_description_activite.TabIndex = 3;
            this.label_description_activite.Text = "Description";
            // 
            // l_numJour
            // 
            this.l_numJour.AutoSize = true;
            this.l_numJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_numJour.Location = new System.Drawing.Point(395, 58);
            this.l_numJour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_numJour.Name = "l_numJour";
            this.l_numJour.Size = new System.Drawing.Size(34, 25);
            this.l_numJour.TabIndex = 4;
            this.l_numJour.Text = "00";
            // 
            // label_heure_debut
            // 
            this.label_heure_debut.AutoSize = true;
            this.label_heure_debut.Location = new System.Drawing.Point(74, 70);
            this.label_heure_debut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_heure_debut.Name = "label_heure_debut";
            this.label_heure_debut.Size = new System.Drawing.Size(36, 13);
            this.label_heure_debut.TabIndex = 6;
            this.label_heure_debut.Text = "Debut";
            // 
            // label_heure_fin
            // 
            this.label_heure_fin.AutoSize = true;
            this.label_heure_fin.Location = new System.Drawing.Point(89, 101);
            this.label_heure_fin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_heure_fin.Name = "label_heure_fin";
            this.label_heure_fin.Size = new System.Drawing.Size(21, 13);
            this.label_heure_fin.TabIndex = 8;
            this.label_heure_fin.Text = "Fin";
            // 
            // labelCoordonnees
            // 
            this.labelCoordonnees.AutoSize = true;
            this.labelCoordonnees.Location = new System.Drawing.Point(11, 369);
            this.labelCoordonnees.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCoordonnees.Name = "labelCoordonnees";
            this.labelCoordonnees.Size = new System.Drawing.Size(99, 13);
            this.labelCoordonnees.TabIndex = 10;
            this.labelCoordonnees.Text = "Coordonnee du lieu";
            this.labelCoordonnees.Visible = false;
            // 
            // labelLatitude
            // 
            this.labelLatitude.AutoSize = true;
            this.labelLatitude.Location = new System.Drawing.Point(239, 371);
            this.labelLatitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLatitude.Name = "labelLatitude";
            this.labelLatitude.Size = new System.Drawing.Size(41, 13);
            this.labelLatitude.TabIndex = 12;
            this.labelLatitude.Text = "latitude";
            this.labelLatitude.Visible = false;
            // 
            // labelLongitude
            // 
            this.labelLongitude.AutoSize = true;
            this.labelLongitude.Location = new System.Drawing.Point(133, 371);
            this.labelLongitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLongitude.Name = "labelLongitude";
            this.labelLongitude.Size = new System.Drawing.Size(50, 13);
            this.labelLongitude.TabIndex = 13;
            this.labelLongitude.Text = "longitude";
            this.labelLongitude.Visible = false;
            // 
            // TextBoxOrdonnee
            // 
            this.TextBoxOrdonnee.Location = new System.Drawing.Point(288, 368);
            this.TextBoxOrdonnee.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxOrdonnee.Name = "TextBoxOrdonnee";
            this.TextBoxOrdonnee.Size = new System.Drawing.Size(35, 20);
            this.TextBoxOrdonnee.TabIndex = 14;
            this.TextBoxOrdonnee.Visible = false;
            this.TextBoxOrdonnee.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxOrdonnee_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Type d\'activité";
            // 
            // comboBoxHeuresDebut
            // 
            this.comboBoxHeuresDebut.FormattingEnabled = true;
            this.comboBoxHeuresDebut.Location = new System.Drawing.Point(135, 70);
            this.comboBoxHeuresDebut.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxHeuresDebut.Name = "comboBoxHeuresDebut";
            this.comboBoxHeuresDebut.Size = new System.Drawing.Size(31, 21);
            this.comboBoxHeuresDebut.TabIndex = 21;
            // 
            // comboBoxMinutesDebut
            // 
            this.comboBoxMinutesDebut.FormattingEnabled = true;
            this.comboBoxMinutesDebut.Location = new System.Drawing.Point(185, 70);
            this.comboBoxMinutesDebut.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMinutesDebut.Name = "comboBoxMinutesDebut";
            this.comboBoxMinutesDebut.Size = new System.Drawing.Size(31, 21);
            this.comboBoxMinutesDebut.TabIndex = 22;
            // 
            // comboBoxHeuresFin
            // 
            this.comboBoxHeuresFin.FormattingEnabled = true;
            this.comboBoxHeuresFin.Location = new System.Drawing.Point(135, 101);
            this.comboBoxHeuresFin.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxHeuresFin.Name = "comboBoxHeuresFin";
            this.comboBoxHeuresFin.Size = new System.Drawing.Size(31, 21);
            this.comboBoxHeuresFin.TabIndex = 23;
            // 
            // comboBoxMinutesFin
            // 
            this.comboBoxMinutesFin.FormattingEnabled = true;
            this.comboBoxMinutesFin.Location = new System.Drawing.Point(185, 101);
            this.comboBoxMinutesFin.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMinutesFin.Name = "comboBoxMinutesFin";
            this.comboBoxMinutesFin.Size = new System.Drawing.Size(31, 21);
            this.comboBoxMinutesFin.TabIndex = 24;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.Location = new System.Drawing.Point(135, 404);
            this.buttonAjouter.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(98, 32);
            this.buttonAjouter.TabIndex = 26;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = true;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.Location = new System.Drawing.Point(237, 404);
            this.buttonSupprimer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(98, 32);
            this.buttonSupprimer.TabIndex = 27;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = true;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonRetourJournee
            // 
            this.buttonRetourJournee.Image = ((System.Drawing.Image)(resources.GetObject("buttonRetourJournee.Image")));
            this.buttonRetourJournee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRetourJournee.Location = new System.Drawing.Point(12, 12);
            this.buttonRetourJournee.Name = "buttonRetourJournee";
            this.buttonRetourJournee.Size = new System.Drawing.Size(141, 34);
            this.buttonRetourJournee.TabIndex = 1;
            this.buttonRetourJournee.Text = "Revenir à la journée";
            this.buttonRetourJournee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRetourJournee.UseVisualStyleBackColor = true;
            this.buttonRetourJournee.Click += new System.EventHandler(this.buttonRetourJournee_Click);
            // 
            // comboBoxTypeActivite
            // 
            this.comboBoxTypeActivite.FormattingEnabled = true;
            this.comboBoxTypeActivite.Location = new System.Drawing.Point(135, 27);
            this.comboBoxTypeActivite.Name = "comboBoxTypeActivite";
            this.comboBoxTypeActivite.Size = new System.Drawing.Size(145, 21);
            this.comboBoxTypeActivite.TabIndex = 28;
            // 
            // pictureBoxMap
            // 
            this.pictureBoxMap.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMap.Image")));
            this.pictureBoxMap.Location = new System.Drawing.Point(580, 35);
            this.pictureBoxMap.Name = "pictureBoxMap";
            this.pictureBoxMap.Size = new System.Drawing.Size(365, 684);
            this.pictureBoxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMap.TabIndex = 29;
            this.pictureBoxMap.TabStop = false;
            this.pictureBoxMap.Visible = false;
            this.pictureBoxMap.Click += new System.EventHandler(this.pictureBoxMap_Click);
            // 
            // checkBoxLocalisation
            // 
            this.checkBoxLocalisation.AutoSize = true;
            this.checkBoxLocalisation.Location = new System.Drawing.Point(135, 334);
            this.checkBoxLocalisation.Name = "checkBoxLocalisation";
            this.checkBoxLocalisation.Size = new System.Drawing.Size(119, 17);
            this.checkBoxLocalisation.TabIndex = 30;
            this.checkBoxLocalisation.Text = "Activité en extérieur";
            this.checkBoxLocalisation.UseVisualStyleBackColor = true;
            this.checkBoxLocalisation.CheckedChanged += new System.EventHandler(this.checkBoxLocalisation_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 336);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Localisation";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.comboBoxTypeActivite);
            this.groupBox1.Controls.Add(this.checkBoxLocalisation);
            this.groupBox1.Controls.Add(this.textBoxDescription);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label_description_activite);
            this.groupBox1.Controls.Add(this.label_heure_debut);
            this.groupBox1.Controls.Add(this.label_heure_fin);
            this.groupBox1.Controls.Add(this.buttonSupprimer);
            this.groupBox1.Controls.Add(this.labelCoordonnees);
            this.groupBox1.Controls.Add(this.buttonAjouter);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxMinutesFin);
            this.groupBox1.Controls.Add(this.TextBoxAbscisse);
            this.groupBox1.Controls.Add(this.comboBoxHeuresFin);
            this.groupBox1.Controls.Add(this.labelLatitude);
            this.groupBox1.Controls.Add(this.comboBoxMinutesDebut);
            this.groupBox1.Controls.Add(this.labelLongitude);
            this.groupBox1.Controls.Add(this.comboBoxHeuresDebut);
            this.groupBox1.Controls.Add(this.TextBoxOrdonnee);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(158, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(408, 456);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(280, 336);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            395,
            0,
            0,
            -2147483648});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(43, 20);
            this.numericUpDown1.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "h";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 104);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(220, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 73);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "h";
            // 
            // TextBoxAbscisse
            // 
            this.TextBoxAbscisse.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.TextBoxAbscisse.Location = new System.Drawing.Point(198, 366);
            this.TextBoxAbscisse.Margin = new System.Windows.Forms.Padding(2);
            this.TextBoxAbscisse.Name = "TextBoxAbscisse";
            this.TextBoxAbscisse.Size = new System.Drawing.Size(35, 20);
            this.TextBoxAbscisse.TabIndex = 11;
            this.TextBoxAbscisse.Visible = false;
            this.TextBoxAbscisse.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxAbscisse_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(258, 58);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Activité du jour";
            // 
            // WindowLevel3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 750);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBoxMap);
            this.Controls.Add(this.buttonRetourJournee);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.l_numJour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "WindowLevel3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mars Explorer 2017";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label_description_activite;
        private System.Windows.Forms.Label l_numJour;
        private System.Windows.Forms.Label label_heure_debut;
        private System.Windows.Forms.Label label_heure_fin;
        private System.Windows.Forms.Label labelCoordonnees;
        private System.Windows.Forms.Label labelLatitude;
        private System.Windows.Forms.Label labelLongitude;
        private System.Windows.Forms.TextBox TextBoxOrdonnee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxHeuresDebut;
        private System.Windows.Forms.ComboBox comboBoxMinutesDebut;
        private System.Windows.Forms.ComboBox comboBoxHeuresFin;
        private System.Windows.Forms.ComboBox comboBoxMinutesFin;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonRetourJournee;
        private System.Windows.Forms.ComboBox comboBoxTypeActivite;
        private System.Windows.Forms.PictureBox pictureBoxMap;
        private System.Windows.Forms.CheckBox checkBoxLocalisation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox TextBoxAbscisse;
    }
}

