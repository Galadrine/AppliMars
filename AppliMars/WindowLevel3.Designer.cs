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
            this.SuspendLayout();
            // 
            // label_carte
            // 
            this.label_carte.AutoSize = true;
            this.label_carte.Location = new System.Drawing.Point(844, 52);
            this.label_carte.Name = "label_carte";
            this.label_carte.Size = new System.Drawing.Size(37, 17);
            this.label_carte.TabIndex = 1;
            this.label_carte.Text = "MAP";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // description
            // 
            this.description.Location = new System.Drawing.Point(234, 347);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(328, 212);
            this.description.TabIndex = 2;
            this.description.Text = "Ceci est une description des activités";
            // 
            // label_description_activite
            // 
            this.label_description_activite.AutoSize = true;
            this.label_description_activite.Location = new System.Drawing.Point(62, 350);
            this.label_description_activite.Name = "label_description_activite";
            this.label_description_activite.Size = new System.Drawing.Size(153, 17);
            this.label_description_activite.TabIndex = 3;
            this.label_description_activite.Text = "Description de l\'activite";
            // 
            // label_numero_mission
            // 
            this.label_numero_mission.AutoSize = true;
            this.label_numero_mission.Location = new System.Drawing.Point(23, 208);
            this.label_numero_mission.Name = "label_numero_mission";
            this.label_numero_mission.Size = new System.Drawing.Size(192, 17);
            this.label_numero_mission.TabIndex = 4;
            this.label_numero_mission.Text = "Numero du jour de la mission";
            // 
            // Numero_mission
            // 
            this.Numero_mission.Location = new System.Drawing.Point(234, 208);
            this.Numero_mission.Name = "Numero_mission";
            this.Numero_mission.Size = new System.Drawing.Size(192, 22);
            this.Numero_mission.TabIndex = 5;
            // 
            // label_heure_debut
            // 
            this.label_heure_debut.AutoSize = true;
            this.label_heure_debut.Location = new System.Drawing.Point(108, 254);
            this.label_heure_debut.Name = "label_heure_debut";
            this.label_heure_debut.Size = new System.Drawing.Size(46, 17);
            this.label_heure_debut.TabIndex = 6;
            this.label_heure_debut.Text = "Debut";
            // 
            // label_heure_fin
            // 
            this.label_heure_fin.AutoSize = true;
            this.label_heure_fin.Location = new System.Drawing.Point(127, 292);
            this.label_heure_fin.Name = "label_heure_fin";
            this.label_heure_fin.Size = new System.Drawing.Size(27, 17);
            this.label_heure_fin.TabIndex = 8;
            this.label_heure_fin.Text = "Fin";
            // 
            // label_coordonnee
            // 
            this.label_coordonnee.AutoSize = true;
            this.label_coordonnee.Location = new System.Drawing.Point(8, 610);
            this.label_coordonnee.Name = "label_coordonnee";
            this.label_coordonnee.Size = new System.Drawing.Size(207, 17);
            this.label_coordonnee.TabIndex = 10;
            this.label_coordonnee.Text = "Coordonnee du lieu d\'operation";
            // 
            // Abscisse
            // 
            this.Abscisse.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Abscisse.Location = new System.Drawing.Point(248, 610);
            this.Abscisse.Name = "Abscisse";
            this.Abscisse.Size = new System.Drawing.Size(45, 22);
            this.Abscisse.TabIndex = 11;
            // 
            // label_latitude
            // 
            this.label_latitude.AutoSize = true;
            this.label_latitude.Location = new System.Drawing.Point(339, 579);
            this.label_latitude.Name = "label_latitude";
            this.label_latitude.Size = new System.Drawing.Size(54, 17);
            this.label_latitude.TabIndex = 12;
            this.label_latitude.Text = "latitude";
            // 
            // label_longitude
            // 
            this.label_longitude.AutoSize = true;
            this.label_longitude.Location = new System.Drawing.Point(231, 579);
            this.label_longitude.Name = "label_longitude";
            this.label_longitude.Size = new System.Drawing.Size(66, 17);
            this.label_longitude.TabIndex = 13;
            this.label_longitude.Text = "longitude";
            // 
            // Ordonnee
            // 
            this.Ordonnee.Location = new System.Drawing.Point(342, 610);
            this.Ordonnee.Name = "Ordonnee";
            this.Ordonnee.Size = new System.Drawing.Size(45, 22);
            this.Ordonnee.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(635, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 17);
            this.label9.TabIndex = 15;
            this.label9.Text = "Niveau 3";
            // 
            // list_activite
            // 
            this.list_activite.FormattingEnabled = true;
            this.list_activite.ItemHeight = 16;
            this.list_activite.Location = new System.Drawing.Point(234, 23);
            this.list_activite.Name = "list_activite";
            this.list_activite.ScrollAlwaysVisible = true;
            this.list_activite.Size = new System.Drawing.Size(328, 164);
            this.list_activite.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "liste des activites";
            // 
            // panel
            // 
            this.panel.AutoScroll = true;
            this.panel.Location = new System.Drawing.Point(585, 86);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(566, 596);
            this.panel.TabIndex = 18;
            // 
            // Heure_debut
            // 
            this.Heure_debut.FormattingEnabled = true;
            this.Heure_debut.Location = new System.Drawing.Point(234, 254);
            this.Heure_debut.Name = "Heure_debut";
            this.Heure_debut.Size = new System.Drawing.Size(40, 24);
            this.Heure_debut.TabIndex = 21;
            // 
            // Minutes_debut
            // 
            this.Minutes_debut.FormattingEnabled = true;
            this.Minutes_debut.Location = new System.Drawing.Point(301, 254);
            this.Minutes_debut.Name = "Minutes_debut";
            this.Minutes_debut.Size = new System.Drawing.Size(40, 24);
            this.Minutes_debut.TabIndex = 22;
            // 
            // Heure_fin
            // 
            this.Heure_fin.FormattingEnabled = true;
            this.Heure_fin.Location = new System.Drawing.Point(234, 292);
            this.Heure_fin.Name = "Heure_fin";
            this.Heure_fin.Size = new System.Drawing.Size(40, 24);
            this.Heure_fin.TabIndex = 23;
            // 
            // Minutes_fin
            // 
            this.Minutes_fin.FormattingEnabled = true;
            this.Minutes_fin.Location = new System.Drawing.Point(301, 292);
            this.Minutes_fin.Name = "Minutes_fin";
            this.Minutes_fin.Size = new System.Drawing.Size(40, 24);
            this.Minutes_fin.TabIndex = 24;
            // 
            // Bouton_Modifier
            // 
            this.Bouton_Modifier.Location = new System.Drawing.Point(87, 643);
            this.Bouton_Modifier.Name = "Bouton_Modifier";
            this.Bouton_Modifier.Size = new System.Drawing.Size(144, 39);
            this.Bouton_Modifier.TabIndex = 25;
            this.Bouton_Modifier.Text = "Modifier";
            this.Bouton_Modifier.UseVisualStyleBackColor = true;
            // 
            // Bouton_Ajouter
            // 
            this.Bouton_Ajouter.Location = new System.Drawing.Point(248, 643);
            this.Bouton_Ajouter.Name = "Bouton_Ajouter";
            this.Bouton_Ajouter.Size = new System.Drawing.Size(144, 39);
            this.Bouton_Ajouter.TabIndex = 26;
            this.Bouton_Ajouter.Text = "Ajouter";
            this.Bouton_Ajouter.UseVisualStyleBackColor = true;
            // 
            // Bouton_Supprimer
            // 
            this.Bouton_Supprimer.Location = new System.Drawing.Point(418, 643);
            this.Bouton_Supprimer.Name = "Bouton_Supprimer";
            this.Bouton_Supprimer.Size = new System.Drawing.Size(144, 39);
            this.Bouton_Supprimer.TabIndex = 27;
            this.Bouton_Supprimer.Text = "Supprimer";
            this.Bouton_Supprimer.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 694);
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
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

