namespace AppliMars
{
    partial class WindowNewAct
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
            this.cB_localisation = new System.Windows.Forms.CheckBox();
            this.tB_descrAct = new System.Windows.Forms.TextBox();
            this.l_hFin = new System.Windows.Forms.Label();
            this.l_mFin = new System.Windows.Forms.Label();
            this.l_mDebut = new System.Windows.Forms.Label();
            this.l_hDeb = new System.Windows.Forms.Label();
            this.l_descr = new System.Windows.Forms.Label();
            this.l_debut = new System.Windows.Forms.Label();
            this.l_fin = new System.Windows.Forms.Label();
            this.l_coord = new System.Windows.Forms.Label();
            this.l_loc = new System.Windows.Forms.Label();
            this.tB_xAct = new System.Windows.Forms.TextBox();
            this.l_y = new System.Windows.Forms.Label();
            this.l_x = new System.Windows.Forms.Label();
            this.tB_yAct = new System.Windows.Forms.TextBox();
            this.l_typeAct = new System.Windows.Forms.Label();
            this.l_cate = new System.Windows.Forms.Label();
            this.cB_cate = new System.Windows.Forms.ComboBox();
            this.cB_typeAct = new System.Windows.Forms.ComboBox();
            this.tB_MFinAct = new System.Windows.Forms.TextBox();
            this.tB_HFinAct = new System.Windows.Forms.TextBox();
            this.tB_MDebAct = new System.Windows.Forms.TextBox();
            this.tB_HDebAct = new System.Windows.Forms.TextBox();
            this.lB_listePart = new System.Windows.Forms.ListBox();
            this.l_participants = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.l_numJour = new System.Windows.Forms.Label();
            this.b_creerNvAct = new System.Windows.Forms.Button();
            this.l_erreurConvert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cB_localisation
            // 
            this.cB_localisation.AutoSize = true;
            this.cB_localisation.Location = new System.Drawing.Point(128, 425);
            this.cB_localisation.Name = "cB_localisation";
            this.cB_localisation.Size = new System.Drawing.Size(119, 17);
            this.cB_localisation.TabIndex = 46;
            this.cB_localisation.Text = "Activité en extérieur";
            this.cB_localisation.UseVisualStyleBackColor = true;
            this.cB_localisation.CheckedChanged += new System.EventHandler(this.cB_localisation_CheckedChanged);
            // 
            // tB_descrAct
            // 
            this.tB_descrAct.Location = new System.Drawing.Point(129, 173);
            this.tB_descrAct.Margin = new System.Windows.Forms.Padding(2);
            this.tB_descrAct.Multiline = true;
            this.tB_descrAct.Name = "tB_descrAct";
            this.tB_descrAct.Size = new System.Drawing.Size(247, 146);
            this.tB_descrAct.TabIndex = 31;
            this.tB_descrAct.TextChanged += new System.EventHandler(this.tB_descrAct_TextChanged);
            // 
            // l_hFin
            // 
            this.l_hFin.AutoSize = true;
            this.l_hFin.Location = new System.Drawing.Point(164, 145);
            this.l_hFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_hFin.Name = "l_hFin";
            this.l_hFin.Size = new System.Drawing.Size(13, 13);
            this.l_hFin.TabIndex = 32;
            this.l_hFin.Text = "h";
            // 
            // l_mFin
            // 
            this.l_mFin.AutoSize = true;
            this.l_mFin.Location = new System.Drawing.Point(214, 145);
            this.l_mFin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_mFin.Name = "l_mFin";
            this.l_mFin.Size = new System.Drawing.Size(23, 13);
            this.l_mFin.TabIndex = 33;
            this.l_mFin.Text = "min";
            // 
            // l_mDebut
            // 
            this.l_mDebut.AutoSize = true;
            this.l_mDebut.Location = new System.Drawing.Point(214, 114);
            this.l_mDebut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_mDebut.Name = "l_mDebut";
            this.l_mDebut.Size = new System.Drawing.Size(23, 13);
            this.l_mDebut.TabIndex = 34;
            this.l_mDebut.Text = "min";
            // 
            // l_hDeb
            // 
            this.l_hDeb.AutoSize = true;
            this.l_hDeb.Location = new System.Drawing.Point(162, 114);
            this.l_hDeb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_hDeb.Name = "l_hDeb";
            this.l_hDeb.Size = new System.Drawing.Size(13, 13);
            this.l_hDeb.TabIndex = 35;
            this.l_hDeb.Text = "h";
            // 
            // l_descr
            // 
            this.l_descr.AutoSize = true;
            this.l_descr.Location = new System.Drawing.Point(44, 173);
            this.l_descr.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_descr.Name = "l_descr";
            this.l_descr.Size = new System.Drawing.Size(60, 13);
            this.l_descr.TabIndex = 36;
            this.l_descr.Text = "Description";
            // 
            // l_debut
            // 
            this.l_debut.AutoSize = true;
            this.l_debut.Location = new System.Drawing.Point(68, 114);
            this.l_debut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_debut.Name = "l_debut";
            this.l_debut.Size = new System.Drawing.Size(36, 13);
            this.l_debut.TabIndex = 37;
            this.l_debut.Text = "Debut";
            // 
            // l_fin
            // 
            this.l_fin.AutoSize = true;
            this.l_fin.Location = new System.Drawing.Point(83, 145);
            this.l_fin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_fin.Name = "l_fin";
            this.l_fin.Size = new System.Drawing.Size(21, 13);
            this.l_fin.TabIndex = 38;
            this.l_fin.Text = "Fin";
            // 
            // l_coord
            // 
            this.l_coord.AutoSize = true;
            this.l_coord.Location = new System.Drawing.Point(4, 460);
            this.l_coord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_coord.Name = "l_coord";
            this.l_coord.Size = new System.Drawing.Size(99, 13);
            this.l_coord.TabIndex = 39;
            this.l_coord.Text = "Coordonnee du lieu";
            this.l_coord.Visible = false;
            // 
            // l_loc
            // 
            this.l_loc.AutoSize = true;
            this.l_loc.Location = new System.Drawing.Point(40, 427);
            this.l_loc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_loc.Name = "l_loc";
            this.l_loc.Size = new System.Drawing.Size(63, 13);
            this.l_loc.TabIndex = 40;
            this.l_loc.Text = "Localisation";
            // 
            // tB_xAct
            // 
            this.tB_xAct.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tB_xAct.Location = new System.Drawing.Point(191, 457);
            this.tB_xAct.Margin = new System.Windows.Forms.Padding(2);
            this.tB_xAct.Name = "tB_xAct";
            this.tB_xAct.Size = new System.Drawing.Size(35, 20);
            this.tB_xAct.TabIndex = 41;
            this.tB_xAct.Visible = false;
            // 
            // l_y
            // 
            this.l_y.AutoSize = true;
            this.l_y.Location = new System.Drawing.Point(232, 462);
            this.l_y.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_y.Name = "l_y";
            this.l_y.Size = new System.Drawing.Size(41, 13);
            this.l_y.TabIndex = 42;
            this.l_y.Text = "latitude";
            this.l_y.Visible = false;
            // 
            // l_x
            // 
            this.l_x.AutoSize = true;
            this.l_x.Location = new System.Drawing.Point(126, 462);
            this.l_x.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_x.Name = "l_x";
            this.l_x.Size = new System.Drawing.Size(50, 13);
            this.l_x.TabIndex = 43;
            this.l_x.Text = "longitude";
            this.l_x.Visible = false;
            // 
            // tB_yAct
            // 
            this.tB_yAct.Location = new System.Drawing.Point(281, 459);
            this.tB_yAct.Margin = new System.Windows.Forms.Padding(2);
            this.tB_yAct.Name = "tB_yAct";
            this.tB_yAct.Size = new System.Drawing.Size(35, 20);
            this.tB_yAct.TabIndex = 44;
            this.tB_yAct.Visible = false;
            // 
            // l_typeAct
            // 
            this.l_typeAct.AutoSize = true;
            this.l_typeAct.Location = new System.Drawing.Point(28, 79);
            this.l_typeAct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_typeAct.Name = "l_typeAct";
            this.l_typeAct.Size = new System.Drawing.Size(76, 13);
            this.l_typeAct.TabIndex = 45;
            this.l_typeAct.Text = "Type d\'activité";
            // 
            // l_cate
            // 
            this.l_cate.AutoSize = true;
            this.l_cate.Location = new System.Drawing.Point(52, 48);
            this.l_cate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_cate.Name = "l_cate";
            this.l_cate.Size = new System.Drawing.Size(52, 13);
            this.l_cate.TabIndex = 47;
            this.l_cate.Text = "Catégorie";
            // 
            // cB_cate
            // 
            this.cB_cate.FormattingEnabled = true;
            this.cB_cate.Location = new System.Drawing.Point(130, 45);
            this.cB_cate.Name = "cB_cate";
            this.cB_cate.Size = new System.Drawing.Size(121, 21);
            this.cB_cate.TabIndex = 48;
            this.cB_cate.SelectedIndexChanged += new System.EventHandler(this.cB_cate_SelectedIndexChanged);
            // 
            // cB_typeAct
            // 
            this.cB_typeAct.FormattingEnabled = true;
            this.cB_typeAct.Location = new System.Drawing.Point(130, 76);
            this.cB_typeAct.Name = "cB_typeAct";
            this.cB_typeAct.Size = new System.Drawing.Size(121, 21);
            this.cB_typeAct.TabIndex = 49;
            // 
            // tB_MFinAct
            // 
            this.tB_MFinAct.Location = new System.Drawing.Point(179, 142);
            this.tB_MFinAct.Name = "tB_MFinAct";
            this.tB_MFinAct.Size = new System.Drawing.Size(27, 20);
            this.tB_MFinAct.TabIndex = 53;
            // 
            // tB_HFinAct
            // 
            this.tB_HFinAct.Location = new System.Drawing.Point(128, 142);
            this.tB_HFinAct.Name = "tB_HFinAct";
            this.tB_HFinAct.Size = new System.Drawing.Size(27, 20);
            this.tB_HFinAct.TabIndex = 52;
            // 
            // tB_MDebAct
            // 
            this.tB_MDebAct.Location = new System.Drawing.Point(179, 111);
            this.tB_MDebAct.Name = "tB_MDebAct";
            this.tB_MDebAct.Size = new System.Drawing.Size(27, 20);
            this.tB_MDebAct.TabIndex = 51;
            // 
            // tB_HDebAct
            // 
            this.tB_HDebAct.Location = new System.Drawing.Point(129, 111);
            this.tB_HDebAct.Name = "tB_HDebAct";
            this.tB_HDebAct.Size = new System.Drawing.Size(27, 20);
            this.tB_HDebAct.TabIndex = 50;
            // 
            // lB_listePart
            // 
            this.lB_listePart.FormattingEnabled = true;
            this.lB_listePart.Location = new System.Drawing.Point(130, 324);
            this.lB_listePart.Name = "lB_listePart";
            this.lB_listePart.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lB_listePart.Size = new System.Drawing.Size(246, 95);
            this.lB_listePart.TabIndex = 55;
            // 
            // l_participants
            // 
            this.l_participants.AutoSize = true;
            this.l_participants.Location = new System.Drawing.Point(44, 324);
            this.l_participants.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_participants.Name = "l_participants";
            this.l_participants.Size = new System.Drawing.Size(62, 13);
            this.l_participants.TabIndex = 54;
            this.l_participants.Text = "Participants";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(81, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 25);
            this.label7.TabIndex = 56;
            this.label7.Text = "Activité du jour";
            // 
            // l_numJour
            // 
            this.l_numJour.AutoSize = true;
            this.l_numJour.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_numJour.Location = new System.Drawing.Point(220, 8);
            this.l_numJour.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_numJour.Name = "l_numJour";
            this.l_numJour.Size = new System.Drawing.Size(0, 25);
            this.l_numJour.TabIndex = 57;
            // 
            // b_creerNvAct
            // 
            this.b_creerNvAct.Location = new System.Drawing.Point(128, 495);
            this.b_creerNvAct.Name = "b_creerNvAct";
            this.b_creerNvAct.Size = new System.Drawing.Size(172, 34);
            this.b_creerNvAct.TabIndex = 58;
            this.b_creerNvAct.Text = "CREER";
            this.b_creerNvAct.UseVisualStyleBackColor = true;
            this.b_creerNvAct.Click += new System.EventHandler(this.b_creerNvAct_Click);
            // 
            // l_erreurConvert
            // 
            this.l_erreurConvert.AutoSize = true;
            this.l_erreurConvert.ForeColor = System.Drawing.Color.Red;
            this.l_erreurConvert.Location = new System.Drawing.Point(259, 127);
            this.l_erreurConvert.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l_erreurConvert.Name = "l_erreurConvert";
            this.l_erreurConvert.Size = new System.Drawing.Size(117, 13);
            this.l_erreurConvert.TabIndex = 59;
            this.l_erreurConvert.Text = "Conversion impossible !";
            this.l_erreurConvert.Visible = false;
            // 
            // WindowNewAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 541);
            this.Controls.Add(this.l_erreurConvert);
            this.Controls.Add(this.b_creerNvAct);
            this.Controls.Add(this.l_numJour);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lB_listePart);
            this.Controls.Add(this.l_participants);
            this.Controls.Add(this.tB_MFinAct);
            this.Controls.Add(this.tB_HFinAct);
            this.Controls.Add(this.tB_MDebAct);
            this.Controls.Add(this.tB_HDebAct);
            this.Controls.Add(this.cB_typeAct);
            this.Controls.Add(this.cB_cate);
            this.Controls.Add(this.l_cate);
            this.Controls.Add(this.cB_localisation);
            this.Controls.Add(this.tB_descrAct);
            this.Controls.Add(this.l_hFin);
            this.Controls.Add(this.l_mFin);
            this.Controls.Add(this.l_mDebut);
            this.Controls.Add(this.l_hDeb);
            this.Controls.Add(this.l_descr);
            this.Controls.Add(this.l_debut);
            this.Controls.Add(this.l_fin);
            this.Controls.Add(this.l_coord);
            this.Controls.Add(this.l_loc);
            this.Controls.Add(this.tB_xAct);
            this.Controls.Add(this.l_y);
            this.Controls.Add(this.l_x);
            this.Controls.Add(this.tB_yAct);
            this.Controls.Add(this.l_typeAct);
            this.Name = "WindowNewAct";
            this.Text = "WindowNewAct";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cB_localisation;
        private System.Windows.Forms.TextBox tB_descrAct;
        private System.Windows.Forms.Label l_hFin;
        private System.Windows.Forms.Label l_mFin;
        private System.Windows.Forms.Label l_mDebut;
        private System.Windows.Forms.Label l_hDeb;
        private System.Windows.Forms.Label l_descr;
        private System.Windows.Forms.Label l_debut;
        private System.Windows.Forms.Label l_fin;
        private System.Windows.Forms.Label l_coord;
        private System.Windows.Forms.Label l_loc;
        private System.Windows.Forms.TextBox tB_xAct;
        private System.Windows.Forms.Label l_y;
        private System.Windows.Forms.Label l_x;
        private System.Windows.Forms.TextBox tB_yAct;
        private System.Windows.Forms.Label l_typeAct;
        private System.Windows.Forms.Label l_cate;
        private System.Windows.Forms.ComboBox cB_cate;
        private System.Windows.Forms.ComboBox cB_typeAct;
        private System.Windows.Forms.TextBox tB_MFinAct;
        private System.Windows.Forms.TextBox tB_HFinAct;
        private System.Windows.Forms.TextBox tB_MDebAct;
        private System.Windows.Forms.TextBox tB_HDebAct;
        private System.Windows.Forms.ListBox lB_listePart;
        private System.Windows.Forms.Label l_participants;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label l_numJour;
        private System.Windows.Forms.Button b_creerNvAct;
        private System.Windows.Forms.Label l_erreurConvert;
    }
}