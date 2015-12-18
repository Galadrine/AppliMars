namespace AppliMars {
    partial class WindowResultSearch {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowResultSearch));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonRetourCalendrier = new System.Windows.Forms.Button();
            this.labelRecherche = new System.Windows.Forms.Label();
            this.listBoxNom = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBoxDescription = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxCompteRendu = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonGoTo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Résultats de la recherche :";
            // 
            // buttonRetourCalendrier
            // 
            this.buttonRetourCalendrier.Image = ((System.Drawing.Image)(resources.GetObject("buttonRetourCalendrier.Image")));
            this.buttonRetourCalendrier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRetourCalendrier.Location = new System.Drawing.Point(12, 12);
            this.buttonRetourCalendrier.Name = "buttonRetourCalendrier";
            this.buttonRetourCalendrier.Size = new System.Drawing.Size(162, 34);
            this.buttonRetourCalendrier.TabIndex = 2;
            this.buttonRetourCalendrier.Text = "Revenir au calendrier";
            this.buttonRetourCalendrier.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRetourCalendrier.UseVisualStyleBackColor = true;
            this.buttonRetourCalendrier.Click += new System.EventHandler(this.buttonRetourCalendrier_Click);
            // 
            // labelRecherche
            // 
            this.labelRecherche.AutoSize = true;
            this.labelRecherche.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.labelRecherche.Location = new System.Drawing.Point(290, 68);
            this.labelRecherche.Name = "labelRecherche";
            this.labelRecherche.Size = new System.Drawing.Size(80, 13);
            this.labelRecherche.TabIndex = 3;
            this.labelRecherche.Text = "label recherche";
            this.labelRecherche.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBoxNom
            // 
            this.listBoxNom.FormattingEnabled = true;
            this.listBoxNom.Location = new System.Drawing.Point(90, 136);
            this.listBoxNom.Name = "listBoxNom";
            this.listBoxNom.Size = new System.Drawing.Size(151, 316);
            this.listBoxNom.TabIndex = 4;
            this.listBoxNom.SelectedIndexChanged += new System.EventHandler(this.listBoxNom_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(321, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Résultat dans les descriptions d\'activité";
            // 
            // listBoxDescription
            // 
            this.listBoxDescription.FormattingEnabled = true;
            this.listBoxDescription.Location = new System.Drawing.Point(324, 136);
            this.listBoxDescription.Name = "listBoxDescription";
            this.listBoxDescription.Size = new System.Drawing.Size(151, 316);
            this.listBoxDescription.TabIndex = 4;
            this.listBoxDescription.SelectedIndexChanged += new System.EventHandler(this.listBoxDescription_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(565, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Résultat dans les compte rendu de journée";
            // 
            // listBoxCompteRendu
            // 
            this.listBoxCompteRendu.FormattingEnabled = true;
            this.listBoxCompteRendu.Location = new System.Drawing.Point(568, 136);
            this.listBoxCompteRendu.Name = "listBoxCompteRendu";
            this.listBoxCompteRendu.Size = new System.Drawing.Size(151, 316);
            this.listBoxCompteRendu.TabIndex = 4;
            this.listBoxCompteRendu.SelectedIndexChanged += new System.EventHandler(this.listBoxCompteRendu_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Résultat dans le nom d\'une activité";
            // 
            // buttonGoTo
            // 
            this.buttonGoTo.Enabled = false;
            this.buttonGoTo.Location = new System.Drawing.Point(306, 489);
            this.buttonGoTo.Name = "buttonGoTo";
            this.buttonGoTo.Size = new System.Drawing.Size(188, 43);
            this.buttonGoTo.TabIndex = 6;
            this.buttonGoTo.Text = "Accéder à l\'élément sélectionné";
            this.buttonGoTo.UseVisualStyleBackColor = true;
            this.buttonGoTo.Click += new System.EventHandler(this.buttonGoTo_Click);
            // 
            // WindowResultSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 562);
            this.ControlBox = false;
            this.Controls.Add(this.buttonGoTo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxCompteRendu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBoxDescription);
            this.Controls.Add(this.listBoxNom);
            this.Controls.Add(this.labelRecherche);
            this.Controls.Add(this.buttonRetourCalendrier);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "WindowResultSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Résultats de la recherche";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRetourCalendrier;
        private System.Windows.Forms.Label labelRecherche;
        private System.Windows.Forms.ListBox listBoxNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxCompteRendu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonGoTo;
    }
}