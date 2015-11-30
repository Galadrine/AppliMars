namespace AppliMars {
    partial class WindowLevel1 {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowLevel1));
            this.groupBoxCalendrier = new System.Windows.Forms.GroupBox();
            this.pictureBoxRightArrow = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeftArrow = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelJour = new System.Windows.Forms.Label();
            this.labelHeures = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxJourFin = new System.Windows.Forms.ComboBox();
            this.comboBoxJourDebut = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.timerMinutes = new System.Windows.Forms.Timer(this.components);
            this.groupBoxCalendrier.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftArrow)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxCalendrier
            // 
            this.groupBoxCalendrier.Controls.Add(this.pictureBoxRightArrow);
            this.groupBoxCalendrier.Controls.Add(this.pictureBoxLeftArrow);
            this.groupBoxCalendrier.Location = new System.Drawing.Point(200, 236);
            this.groupBoxCalendrier.Name = "groupBoxCalendrier";
            this.groupBoxCalendrier.Size = new System.Drawing.Size(747, 366);
            this.groupBoxCalendrier.TabIndex = 0;
            this.groupBoxCalendrier.TabStop = false;
            this.groupBoxCalendrier.Text = "Calendrier";
            // 
            // pictureBoxRightArrow
            // 
            this.pictureBoxRightArrow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRightArrow.Image")));
            this.pictureBoxRightArrow.Location = new System.Drawing.Point(655, 140);
            this.pictureBoxRightArrow.Name = "pictureBoxRightArrow";
            this.pictureBoxRightArrow.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxRightArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRightArrow.TabIndex = 1;
            this.pictureBoxRightArrow.TabStop = false;
            this.pictureBoxRightArrow.Click += new System.EventHandler(this.pictureBoxRightArrow_Click);
            // 
            // pictureBoxLeftArrow
            // 
            this.pictureBoxLeftArrow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxLeftArrow.Image")));
            this.pictureBoxLeftArrow.Location = new System.Drawing.Point(42, 140);
            this.pictureBoxLeftArrow.Name = "pictureBoxLeftArrow";
            this.pictureBoxLeftArrow.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLeftArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLeftArrow.TabIndex = 1;
            this.pictureBoxLeftArrow.TabStop = false;
            this.pictureBoxLeftArrow.Click += new System.EventHandler(this.pictureBoxLeftArrow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Jour";
            // 
            // labelJour
            // 
            this.labelJour.AutoSize = true;
            this.labelJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJour.Location = new System.Drawing.Point(81, 33);
            this.labelJour.Name = "labelJour";
            this.labelJour.Size = new System.Drawing.Size(23, 25);
            this.labelJour.TabIndex = 1;
            this.labelJour.Text = "0";
            // 
            // labelHeures
            // 
            this.labelHeures.AutoSize = true;
            this.labelHeures.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeures.Location = new System.Drawing.Point(144, 33);
            this.labelHeures.Name = "labelHeures";
            this.labelHeures.Size = new System.Drawing.Size(34, 25);
            this.labelHeures.TabIndex = 1;
            this.labelHeures.Text = "00";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelHeures);
            this.groupBox1.Controls.Add(this.labelMinutes);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.labelJour);
            this.groupBox1.Location = new System.Drawing.Point(200, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 83);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinutes.Location = new System.Drawing.Point(189, 33);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(34, 25);
            this.labelMinutes.TabIndex = 1;
            this.labelMinutes.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(172, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "h";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(218, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "min";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxJourFin);
            this.groupBox2.Controls.Add(this.comboBoxJourDebut);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxSearch);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Location = new System.Drawing.Point(590, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(357, 83);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recherche";
            // 
            // comboBoxJourFin
            // 
            this.comboBoxJourFin.FormattingEnabled = true;
            this.comboBoxJourFin.Location = new System.Drawing.Point(185, 45);
            this.comboBoxJourFin.Name = "comboBoxJourFin";
            this.comboBoxJourFin.Size = new System.Drawing.Size(49, 21);
            this.comboBoxJourFin.TabIndex = 3;
            // 
            // comboBoxJourDebut
            // 
            this.comboBoxJourDebut.FormattingEnabled = true;
            this.comboBoxJourDebut.Location = new System.Drawing.Point(107, 45);
            this.comboBoxJourDebut.Name = "comboBoxJourDebut";
            this.comboBoxJourDebut.Size = new System.Drawing.Size(49, 21);
            this.comboBoxJourDebut.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "et";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Entre le jour";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(41, 19);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(193, 20);
            this.textBoxSearch.TabIndex = 1;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(240, 43);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.Text = "Rechercher";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // timerMinutes
            // 
            this.timerMinutes.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // WindowLevel1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 791);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCalendrier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WindowLevel1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.groupBoxCalendrier.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftArrow)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxCalendrier;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxRightArrow;
        private System.Windows.Forms.PictureBox pictureBoxLeftArrow;
        private System.Windows.Forms.Label labelJour;
        private System.Windows.Forms.Label labelHeures;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ComboBox comboBoxJourFin;
        private System.Windows.Forms.ComboBox comboBoxJourDebut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerMinutes;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

