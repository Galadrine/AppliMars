namespace AppliMars
{
    partial class WindowNewMission
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
            this.tB_nomNvMission = new System.Windows.Forms.TextBox();
            this.b_DelAstro = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.dT_DateDebNvMission = new System.Windows.Forms.DateTimePicker();
            this.tB_nvAstro = new System.Windows.Forms.TextBox();
            this.b_NewAstro = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lB_ListeAstroNvMission = new System.Windows.Forms.ListBox();
            this.l_dureeNvMission = new System.Windows.Forms.Label();
            this.l_dateDebNvMission = new System.Windows.Forms.Label();
            this.l_nomNvMission = new System.Windows.Forms.Label();
            this.b_creerNvMission = new System.Windows.Forms.Button();
            this.tB_dureeNvMission = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tB_nomNvMission
            // 
            this.tB_nomNvMission.Location = new System.Drawing.Point(105, 66);
            this.tB_nomNvMission.Name = "tB_nomNvMission";
            this.tB_nomNvMission.Size = new System.Drawing.Size(100, 20);
            this.tB_nomNvMission.TabIndex = 24;
            // 
            // b_DelAstro
            // 
            this.b_DelAstro.Location = new System.Drawing.Point(230, 212);
            this.b_DelAstro.Name = "b_DelAstro";
            this.b_DelAstro.Size = new System.Drawing.Size(75, 23);
            this.b_DelAstro.TabIndex = 23;
            this.b_DelAstro.Text = "Supprimer";
            this.b_DelAstro.UseVisualStyleBackColor = true;
            this.b_DelAstro.Click += new System.EventHandler(this.b_DelAstro_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(240, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Durée";
            // 
            // dT_DateDebNvMission
            // 
            this.dT_DateDebNvMission.CustomFormat = "DD:MM:YYYY";
            this.dT_DateDebNvMission.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dT_DateDebNvMission.Location = new System.Drawing.Point(105, 102);
            this.dT_DateDebNvMission.Name = "dT_DateDebNvMission";
            this.dT_DateDebNvMission.Size = new System.Drawing.Size(200, 20);
            this.dT_DateDebNvMission.TabIndex = 20;
            // 
            // tB_nvAstro
            // 
            this.tB_nvAstro.Location = new System.Drawing.Point(311, 176);
            this.tB_nvAstro.Name = "tB_nvAstro";
            this.tB_nvAstro.Size = new System.Drawing.Size(100, 20);
            this.tB_nvAstro.TabIndex = 19;
            // 
            // b_NewAstro
            // 
            this.b_NewAstro.Location = new System.Drawing.Point(230, 174);
            this.b_NewAstro.Name = "b_NewAstro";
            this.b_NewAstro.Size = new System.Drawing.Size(75, 23);
            this.b_NewAstro.TabIndex = 18;
            this.b_NewAstro.Text = "Ajouter";
            this.b_NewAstro.UseVisualStyleBackColor = true;
            this.b_NewAstro.Click += new System.EventHandler(this.b_NewAstro_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Astronautes";
            // 
            // lB_ListeAstroNvMission
            // 
            this.lB_ListeAstroNvMission.FormattingEnabled = true;
            this.lB_ListeAstroNvMission.Location = new System.Drawing.Point(105, 174);
            this.lB_ListeAstroNvMission.Name = "lB_ListeAstroNvMission";
            this.lB_ListeAstroNvMission.Size = new System.Drawing.Size(120, 95);
            this.lB_ListeAstroNvMission.TabIndex = 16;
            // 
            // l_dureeNvMission
            // 
            this.l_dureeNvMission.AutoSize = true;
            this.l_dureeNvMission.Location = new System.Drawing.Point(12, 136);
            this.l_dureeNvMission.Name = "l_dureeNvMission";
            this.l_dureeNvMission.Size = new System.Drawing.Size(36, 13);
            this.l_dureeNvMission.TabIndex = 15;
            this.l_dureeNvMission.Text = "Durée";
            // 
            // l_dateDebNvMission
            // 
            this.l_dateDebNvMission.AutoSize = true;
            this.l_dateDebNvMission.Location = new System.Drawing.Point(12, 102);
            this.l_dateDebNvMission.Name = "l_dateDebNvMission";
            this.l_dateDebNvMission.Size = new System.Drawing.Size(75, 13);
            this.l_dateDebNvMission.TabIndex = 14;
            this.l_dateDebNvMission.Text = "Date de début";
            // 
            // l_nomNvMission
            // 
            this.l_nomNvMission.AutoSize = true;
            this.l_nomNvMission.Location = new System.Drawing.Point(12, 69);
            this.l_nomNvMission.Name = "l_nomNvMission";
            this.l_nomNvMission.Size = new System.Drawing.Size(66, 13);
            this.l_nomNvMission.TabIndex = 13;
            this.l_nomNvMission.Text = "Nom mission";
            // 
            // b_creerNvMission
            // 
            this.b_creerNvMission.Location = new System.Drawing.Point(129, 290);
            this.b_creerNvMission.Name = "b_creerNvMission";
            this.b_creerNvMission.Size = new System.Drawing.Size(176, 43);
            this.b_creerNvMission.TabIndex = 25;
            this.b_creerNvMission.Text = "CREER MISSION";
            this.b_creerNvMission.UseVisualStyleBackColor = true;
            this.b_creerNvMission.Click += new System.EventHandler(this.b_creerNvMission_Click);
            // 
            // tB_dureeNvMission
            // 
            this.tB_dureeNvMission.Location = new System.Drawing.Point(105, 135);
            this.tB_dureeNvMission.Name = "tB_dureeNvMission";
            this.tB_dureeNvMission.Size = new System.Drawing.Size(100, 20);
            this.tB_dureeNvMission.TabIndex = 26;
            this.tB_dureeNvMission.TextChanged += new System.EventHandler(this.tB_dureeNvMission_TextChanged);
            // 
            // WindowNewMission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 358);
            this.Controls.Add(this.tB_dureeNvMission);
            this.Controls.Add(this.b_creerNvMission);
            this.Controls.Add(this.tB_nomNvMission);
            this.Controls.Add(this.b_DelAstro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dT_DateDebNvMission);
            this.Controls.Add(this.tB_nvAstro);
            this.Controls.Add(this.b_NewAstro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lB_ListeAstroNvMission);
            this.Controls.Add(this.l_dureeNvMission);
            this.Controls.Add(this.l_dateDebNvMission);
            this.Controls.Add(this.l_nomNvMission);
            this.Name = "WindowNewMission";
            this.Text = "WindowNewMission";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tB_nomNvMission;
        private System.Windows.Forms.Button b_DelAstro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dT_DateDebNvMission;
        private System.Windows.Forms.TextBox tB_nvAstro;
        private System.Windows.Forms.Button b_NewAstro;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lB_ListeAstroNvMission;
        private System.Windows.Forms.Label l_dureeNvMission;
        private System.Windows.Forms.Label l_dateDebNvMission;
        private System.Windows.Forms.Label l_nomNvMission;
        private System.Windows.Forms.Button b_creerNvMission;
        private System.Windows.Forms.TextBox tB_dureeNvMission;
    }
}