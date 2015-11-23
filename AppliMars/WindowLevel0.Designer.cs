namespace AppliMars {
    partial class WindowLevel0 {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowLevel0));
            this.buttonCreer = new System.Windows.Forms.Button();
            this.buttonCharger = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxListMissions = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBoxJour = new System.Windows.Forms.ComboBox();
            this.comboBoxAnnee = new System.Windows.Forms.ComboBox();
            this.comboBoxMois = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBoxListMissions.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCreer
            // 
            this.buttonCreer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreer.Location = new System.Drawing.Point(522, 93);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(162, 34);
            this.buttonCreer.TabIndex = 3;
            this.buttonCreer.Text = "Créer une mission";
            this.buttonCreer.UseVisualStyleBackColor = true;
            this.buttonCreer.Click += new System.EventHandler(this.buttonCreer_Click);
            // 
            // buttonCharger
            // 
            this.buttonCharger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCharger.Location = new System.Drawing.Point(522, 133);
            this.buttonCharger.Name = "buttonCharger";
            this.buttonCharger.Size = new System.Drawing.Size(162, 34);
            this.buttonCharger.TabIndex = 3;
            this.buttonCharger.Text = "Charger une mission";
            this.buttonCharger.UseVisualStyleBackColor = true;
            this.buttonCharger.Click += new System.EventHandler(this.buttonCharger_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonModifier.Location = new System.Drawing.Point(522, 173);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(162, 34);
            this.buttonModifier.TabIndex = 3;
            this.buttonModifier.Text = "Modifier une mission";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxMois);
            this.groupBox1.Controls.Add(this.comboBoxAnnee);
            this.groupBox1.Controls.Add(this.comboBoxJour);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(81, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 171);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creation d\'une mission";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(191, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nom de mission";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Durée";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(140, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Debut";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre d\'astronautes";
            // 
            // groupBoxListMissions
            // 
            this.groupBoxListMissions.Controls.Add(this.button2);
            this.groupBoxListMissions.Controls.Add(this.button1);
            this.groupBoxListMissions.Location = new System.Drawing.Point(780, 74);
            this.groupBoxListMissions.Name = "groupBoxListMissions";
            this.groupBoxListMissions.Size = new System.Drawing.Size(242, 344);
            this.groupBoxListMissions.TabIndex = 5;
            this.groupBoxListMissions.TabStop = false;
            this.groupBoxListMissions.Text = "Liste des missions";
            // 
            // button1
            // 
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(38, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mission 00";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.buttonCharger_Click);
            // 
            // button2
            // 
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(38, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(162, 34);
            this.button2.TabIndex = 3;
            this.button2.Text = "Mission 00";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.buttonCharger_Click);
            // 
            // comboBoxJour
            // 
            this.comboBoxJour.FormattingEnabled = true;
            this.comboBoxJour.Location = new System.Drawing.Point(191, 96);
            this.comboBoxJour.Name = "comboBoxJour";
            this.comboBoxJour.Size = new System.Drawing.Size(45, 21);
            this.comboBoxJour.TabIndex = 10;
            // 
            // comboBoxAnnee
            // 
            this.comboBoxAnnee.FormattingEnabled = true;
            this.comboBoxAnnee.Location = new System.Drawing.Point(299, 96);
            this.comboBoxAnnee.Name = "comboBoxAnnee";
            this.comboBoxAnnee.Size = new System.Drawing.Size(49, 21);
            this.comboBoxAnnee.TabIndex = 12;
            // 
            // comboBoxMois
            // 
            this.comboBoxMois.FormattingEnabled = true;
            this.comboBoxMois.Location = new System.Drawing.Point(246, 96);
            this.comboBoxMois.Name = "comboBoxMois";
            this.comboBoxMois.Size = new System.Drawing.Size(45, 21);
            this.comboBoxMois.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(191, 138);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 8;
            // 
            // WindowLevel0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 791);
            this.Controls.Add(this.groupBoxListMissions);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonCharger);
            this.Controls.Add(this.buttonCreer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WindowLevel0";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spaceship Organisator";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxListMissions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.Button buttonCharger;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBoxListMissions;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBoxMois;
        private System.Windows.Forms.ComboBox comboBoxAnnee;
        private System.Windows.Forms.ComboBox comboBoxJour;
        private System.Windows.Forms.TextBox textBox3;
    }
}