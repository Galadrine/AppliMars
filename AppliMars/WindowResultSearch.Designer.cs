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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 156);
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
            this.labelRecherche.Location = new System.Drawing.Point(299, 161);
            this.labelRecherche.Name = "labelRecherche";
            this.labelRecherche.Size = new System.Drawing.Size(273, 13);
            this.labelRecherche.TabIndex = 3;
            this.labelRecherche.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX";
            this.labelRecherche.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(97, 254);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(151, 316);
            this.listBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Résultat dans les descriptions d\'activité";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(331, 254);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(151, 316);
            this.listBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Résultat dans les compte rendu";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(575, 254);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(151, 316);
            this.listBox3.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(572, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Résultat dans XX";
            // 
            // WindowResultSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 731);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
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
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label label4;
    }
}