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
            this.label_carte = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.description = new System.Windows.Forms.TextBox();
            this.label_description_activite = new System.Windows.Forms.Label();
            this.label_numero_mission = new System.Windows.Forms.Label();
            this.Numero_mission = new System.Windows.Forms.TextBox();
            this.label_heure_debut = new System.Windows.Forms.Label();
            this.label_heure_fin = new System.Windows.Forms.Label();
            this.label_coordonnee = new System.Windows.Forms.Label();
            this.Abscisse = new System.Windows.Forms.TextBox();
            this.label_latitude = new System.Windows.Forms.Label();
            this.label_longitude = new System.Windows.Forms.Label();
            this.Ordonnee = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.list_activite = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.Heure_debut = new System.Windows.Forms.ComboBox();
            this.Minutes_debut = new System.Windows.Forms.ComboBox();
            this.Heure_fin = new System.Windows.Forms.ComboBox();
            this.Minutes_fin = new System.Windows.Forms.ComboBox();
            this.Bouton_Modifier = new System.Windows.Forms.Button();
            this.Bouton_Ajouter = new System.Windows.Forms.Button();
            this.Bouton_Supprimer = new System.Windows.Forms.Button();
            this.buttonRetourJournee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_carte
            // 
            this.label_carte.AutoSize = true;
            this.label_carte.Location = new System.Drawing.Point(780, 125);
            this.label_carte.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_carte.Name = "label_carte";
            this.label_carte.Size = new System.Drawing.Size(30, 13);
            this.label_carte.TabIndex = 1;
            this.label_carte.Text = "MAP";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(323, 365);
            this.description.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(247, 173);
            this.description.TabIndex = 2;
            this.description.Text = "Ceci est une description des activités";
            // 
            // label_description_activite
            // 
            this.label_description_activite.AutoSize = true;
            this.label_description_activite.Location = new System.Drawing.Point(193, 367);
            this.label_description_activite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_description_activite.Name = "label_description_activite";
            this.label_description_activite.Size = new System.Drawing.Size(116, 13);
            this.label_description_activite.TabIndex = 3;
            this.label_description_activite.Text = "Description de l\'activite";
            // 
            // label_numero_mission
            // 
            this.label_numero_mission.AutoSize = true;
            this.label_numero_mission.Location = new System.Drawing.Point(164, 252);
            this.label_numero_mission.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_numero_mission.Name = "label_numero_mission";
            this.label_numero_mission.Size = new System.Drawing.Size(142, 13);
            this.label_numero_mission.TabIndex = 4;
            this.label_numero_mission.Text = "Numero du jour de la mission";
            // 
            // Numero_mission
            // 
            this.Numero_mission.Location = new System.Drawing.Point(323, 252);
            this.Numero_mission.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Numero_mission.Name = "Numero_mission";
            this.Numero_mission.Size = new System.Drawing.Size(145, 20);
            this.Numero_mission.TabIndex = 5;
            // 
            // label_heure_debut
            // 
            this.label_heure_debut.AutoSize = true;
            this.label_heure_debut.Location = new System.Drawing.Point(228, 289);
            this.label_heure_debut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_heure_debut.Name = "label_heure_debut";
            this.label_heure_debut.Size = new System.Drawing.Size(36, 13);
            this.label_heure_debut.TabIndex = 6;
            this.label_heure_debut.Text = "Debut";
            // 
            // label_heure_fin
            // 
            this.label_heure_fin.AutoSize = true;
            this.label_heure_fin.Location = new System.Drawing.Point(242, 320);
            this.label_heure_fin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_heure_fin.Name = "label_heure_fin";
            this.label_heure_fin.Size = new System.Drawing.Size(21, 13);
            this.label_heure_fin.TabIndex = 8;
            this.label_heure_fin.Text = "Fin";
            // 
            // label_coordonnee
            // 
            this.label_coordonnee.AutoSize = true;
            this.label_coordonnee.Location = new System.Drawing.Point(153, 579);
            this.label_coordonnee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_coordonnee.Name = "label_coordonnee";
            this.label_coordonnee.Size = new System.Drawing.Size(154, 13);
            this.label_coordonnee.TabIndex = 10;
            this.label_coordonnee.Text = "Coordonnee du lieu d\'operation";
            // 
            // Abscisse
            // 
            this.Abscisse.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Abscisse.Location = new System.Drawing.Point(333, 579);
            this.Abscisse.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Abscisse.Name = "Abscisse";
            this.Abscisse.Size = new System.Drawing.Size(35, 20);
            this.Abscisse.TabIndex = 11;
            // 
            // label_latitude
            // 
            this.label_latitude.AutoSize = true;
            this.label_latitude.Location = new System.Drawing.Point(401, 553);
            this.label_latitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_latitude.Name = "label_latitude";
            this.label_latitude.Size = new System.Drawing.Size(41, 13);
            this.label_latitude.TabIndex = 12;
            this.label_latitude.Text = "latitude";
            // 
            // label_longitude
            // 
            this.label_longitude.AutoSize = true;
            this.label_longitude.Location = new System.Drawing.Point(320, 553);
            this.label_longitude.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_longitude.Name = "label_longitude";
            this.label_longitude.Size = new System.Drawing.Size(50, 13);
            this.label_longitude.TabIndex = 13;
            this.label_longitude.Text = "longitude";
            // 
            // Ordonnee
            // 
            this.Ordonnee.Location = new System.Drawing.Point(403, 579);
            this.Ordonnee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Ordonnee.Name = "Ordonnee";
            this.Ordonnee.Size = new System.Drawing.Size(35, 20);
            this.Ordonnee.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(623, 90);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Niveau 3";
            // 
            // list_activite
            // 
            this.list_activite.FormattingEnabled = true;
            this.list_activite.Location = new System.Drawing.Point(323, 102);
            this.list_activite.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.list_activite.Name = "list_activite";
            this.list_activite.ScrollAlwaysVisible = true;
            this.list_activite.Size = new System.Drawing.Size(247, 134);
            this.list_activite.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "liste des activites";
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(586, 153);
            this.panel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(424, 484);
            this.panel.TabIndex = 18;
            // 
            // Heure_debut
            // 
            this.Heure_debut.FormattingEnabled = true;
            this.Heure_debut.Location = new System.Drawing.Point(323, 289);
            this.Heure_debut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Heure_debut.Name = "Heure_debut";
            this.Heure_debut.Size = new System.Drawing.Size(31, 21);
            this.Heure_debut.TabIndex = 21;
            // 
            // Minutes_debut
            // 
            this.Minutes_debut.FormattingEnabled = true;
            this.Minutes_debut.Location = new System.Drawing.Point(373, 289);
            this.Minutes_debut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Minutes_debut.Name = "Minutes_debut";
            this.Minutes_debut.Size = new System.Drawing.Size(31, 21);
            this.Minutes_debut.TabIndex = 22;
            // 
            // Heure_fin
            // 
            this.Heure_fin.FormattingEnabled = true;
            this.Heure_fin.Location = new System.Drawing.Point(323, 320);
            this.Heure_fin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Heure_fin.Name = "Heure_fin";
            this.Heure_fin.Size = new System.Drawing.Size(31, 21);
            this.Heure_fin.TabIndex = 23;
            // 
            // Minutes_fin
            // 
            this.Minutes_fin.FormattingEnabled = true;
            this.Minutes_fin.Location = new System.Drawing.Point(373, 320);
            this.Minutes_fin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Minutes_fin.Name = "Minutes_fin";
            this.Minutes_fin.Size = new System.Drawing.Size(31, 21);
            this.Minutes_fin.TabIndex = 24;
            // 
            // Bouton_Modifier
            // 
            this.Bouton_Modifier.Location = new System.Drawing.Point(212, 605);
            this.Bouton_Modifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bouton_Modifier.Name = "Bouton_Modifier";
            this.Bouton_Modifier.Size = new System.Drawing.Size(108, 32);
            this.Bouton_Modifier.TabIndex = 25;
            this.Bouton_Modifier.Text = "Modifier";
            this.Bouton_Modifier.UseVisualStyleBackColor = true;
            // 
            // Bouton_Ajouter
            // 
            this.Bouton_Ajouter.Location = new System.Drawing.Point(333, 605);
            this.Bouton_Ajouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bouton_Ajouter.Name = "Bouton_Ajouter";
            this.Bouton_Ajouter.Size = new System.Drawing.Size(108, 32);
            this.Bouton_Ajouter.TabIndex = 26;
            this.Bouton_Ajouter.Text = "Ajouter";
            this.Bouton_Ajouter.UseVisualStyleBackColor = true;
            // 
            // Bouton_Supprimer
            // 
            this.Bouton_Supprimer.Location = new System.Drawing.Point(461, 605);
            this.Bouton_Supprimer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Bouton_Supprimer.Name = "Bouton_Supprimer";
            this.Bouton_Supprimer.Size = new System.Drawing.Size(108, 32);
            this.Bouton_Supprimer.TabIndex = 27;
            this.Bouton_Supprimer.Text = "Supprimer";
            this.Bouton_Supprimer.UseVisualStyleBackColor = true;
            // 
            // buttonRetourJournee
            // 
            this.buttonRetourJournee.Location = new System.Drawing.Point(32, 36);
            this.buttonRetourJournee.Name = "buttonRetourJournee";
            this.buttonRetourJournee.Size = new System.Drawing.Size(141, 34);
            this.buttonRetourJournee.TabIndex = 1;
            this.buttonRetourJournee.Text = "Revenir à la journée";
            this.buttonRetourJournee.UseVisualStyleBackColor = true;
            this.buttonRetourJournee.Click += new System.EventHandler(this.buttonRetourJournee_Click);
            // 
            // WindowLevel3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 861);
            this.ControlBox = false;
            this.Controls.Add(this.buttonRetourJournee);
            this.Controls.Add(this.Bouton_Supprimer);
            this.Controls.Add(this.Bouton_Ajouter);
            this.Controls.Add(this.Bouton_Modifier);
            this.Controls.Add(this.Minutes_fin);
            this.Controls.Add(this.Heure_fin);
            this.Controls.Add(this.Minutes_debut);
            this.Controls.Add(this.Heure_debut);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_activite);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Ordonnee);
            this.Controls.Add(this.label_longitude);
            this.Controls.Add(this.label_latitude);
            this.Controls.Add(this.Abscisse);
            this.Controls.Add(this.label_coordonnee);
            this.Controls.Add(this.label_heure_fin);
            this.Controls.Add(this.label_heure_debut);
            this.Controls.Add(this.Numero_mission);
            this.Controls.Add(this.label_numero_mission);
            this.Controls.Add(this.label_description_activite);
            this.Controls.Add(this.description);
            this.Controls.Add(this.label_carte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "WindowLevel3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mars Explorer 2017";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_carte;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label label_description_activite;
        private System.Windows.Forms.Label label_numero_mission;
        private System.Windows.Forms.TextBox Numero_mission;
        private System.Windows.Forms.Label label_heure_debut;
        private System.Windows.Forms.Label label_heure_fin;
        private System.Windows.Forms.Label label_coordonnee;
        private System.Windows.Forms.TextBox Abscisse;
        private System.Windows.Forms.Label label_latitude;
        private System.Windows.Forms.Label label_longitude;
        private System.Windows.Forms.TextBox Ordonnee;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox list_activite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.ComboBox Heure_debut;
        private System.Windows.Forms.ComboBox Minutes_debut;
        private System.Windows.Forms.ComboBox Heure_fin;
        private System.Windows.Forms.ComboBox Minutes_fin;
        private System.Windows.Forms.Button Bouton_Modifier;
        private System.Windows.Forms.Button Bouton_Ajouter;
        private System.Windows.Forms.Button Bouton_Supprimer;
        private System.Windows.Forms.Button buttonRetourJournee;
    }
}

