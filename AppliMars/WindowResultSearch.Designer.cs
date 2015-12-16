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
            this.label1.Location = new System.Drawing.Point(146, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Résultats de la recherche :";
            // 
            // buttonRetourCalendrier
            // 
            this.buttonRetourCalendrier.Image = ((System.Drawing.Image)(resources.GetObject("buttonRetourCalendrier.Image")));
            this.buttonRetourCalendrier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRetourCalendrier.Location = new System.Drawing.Point(18, 18);
            this.buttonRetourCalendrier.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonRetourCalendrier.Name = "buttonRetourCalendrier";
            this.buttonRetourCalendrier.Size = new System.Drawing.Size(243, 52);
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
            this.labelRecherche.Location = new System.Drawing.Point(452, 168);
            this.labelRecherche.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecherche.Name = "labelRecherche";
            this.labelRecherche.Size = new System.Drawing.Size(117, 20);
            this.labelRecherche.TabIndex = 3;
            this.labelRecherche.Text = "label recherche";
            this.labelRecherche.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelRecherche.TextChanged += new System.EventHandler(this.labelRecherche_TextChanged);
            // 
            // listBoxNom
            // 
            this.listBoxNom.FormattingEnabled = true;
            this.listBoxNom.ItemHeight = 20;
            this.listBoxNom.Location = new System.Drawing.Point(148, 311);
            this.listBoxNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxNom.Name = "listBoxNom";
            this.listBoxNom.Size = new System.Drawing.Size(224, 484);
            this.listBoxNom.TabIndex = 4;
            this.listBoxNom.SelectedIndexChanged += new System.EventHandler(this.listBoxNom_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(286, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Résultat dans les descriptions d\'activité";
            // 
            // listBoxDescription
            // 
            this.listBoxDescription.FormattingEnabled = true;
            this.listBoxDescription.ItemHeight = 20;
            this.listBoxDescription.Location = new System.Drawing.Point(500, 311);
            this.listBoxDescription.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxDescription.Name = "listBoxDescription";
            this.listBoxDescription.Size = new System.Drawing.Size(224, 484);
            this.listBoxDescription.TabIndex = 4;
            this.listBoxDescription.SelectedIndexChanged += new System.EventHandler(this.listBoxDescription_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(861, 269);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(313, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Résultat dans les compte rendu de journée";
            // 
            // listBoxCompteRendu
            // 
            this.listBoxCompteRendu.FormattingEnabled = true;
            this.listBoxCompteRendu.ItemHeight = 20;
            this.listBoxCompteRendu.Location = new System.Drawing.Point(866, 311);
            this.listBoxCompteRendu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBoxCompteRendu.Name = "listBoxCompteRendu";
            this.listBoxCompteRendu.Size = new System.Drawing.Size(224, 484);
            this.listBoxCompteRendu.TabIndex = 4;
            this.listBoxCompteRendu.SelectedIndexChanged += new System.EventHandler(this.listBoxCompteRendu_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 269);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(255, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Résultat dans le nom d\'une activité";
            // 
            // buttonGoTo
            // 
            this.buttonGoTo.Enabled = false;
            this.buttonGoTo.Location = new System.Drawing.Point(470, 885);
            this.buttonGoTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.buttonGoTo.Name = "buttonGoTo";
            this.buttonGoTo.Size = new System.Drawing.Size(282, 48);
            this.buttonGoTo.TabIndex = 6;
            this.buttonGoTo.Text = "Accéder au jour sélectionné";
            this.buttonGoTo.UseVisualStyleBackColor = true;
            this.buttonGoTo.Click += new System.EventHandler(this.buttonGoTo_Click);
            // 
            // WindowResultSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 1038);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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