﻿namespace AppliMars {
    partial class WindowRecord {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowRecord));
            this.tB_CR = new System.Windows.Forms.TextBox();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.labelCompteRendu = new System.Windows.Forms.Label();
            this.buttonRetourJournee = new System.Windows.Forms.Button();
            this.labelDanger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tB_CR
            // 
            this.tB_CR.AcceptsReturn = true;
            this.tB_CR.Location = new System.Drawing.Point(177, 145);
            this.tB_CR.MaxLength = 1000;
            this.tB_CR.Multiline = true;
            this.tB_CR.Name = "tB_CR";
            this.tB_CR.Size = new System.Drawing.Size(663, 338);
            this.tB_CR.TabIndex = 3;
            this.tB_CR.TextChanged += new System.EventHandler(this.textBoxCompteRendu_TextChanged);
            this.tB_CR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCompteRendu_KeyPress);
            // 
            // buttonModifier
            // 
            this.buttonModifier.Location = new System.Drawing.Point(895, 145);
            this.buttonModifier.Margin = new System.Windows.Forms.Padding(2);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(98, 32);
            this.buttonModifier.TabIndex = 27;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = true;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // labelCompteRendu
            // 
            this.labelCompteRendu.AutoSize = true;
            this.labelCompteRendu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompteRendu.Location = new System.Drawing.Point(173, 108);
            this.labelCompteRendu.Name = "labelCompteRendu";
            this.labelCompteRendu.Size = new System.Drawing.Size(184, 20);
            this.labelCompteRendu.TabIndex = 28;
            this.labelCompteRendu.Text = "Compte rendu du jour 00";
            // 
            // buttonRetourJournee
            // 
            this.buttonRetourJournee.Image = ((System.Drawing.Image)(resources.GetObject("buttonRetourJournee.Image")));
            this.buttonRetourJournee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRetourJournee.Location = new System.Drawing.Point(12, 12);
            this.buttonRetourJournee.Name = "buttonRetourJournee";
            this.buttonRetourJournee.Size = new System.Drawing.Size(141, 34);
            this.buttonRetourJournee.TabIndex = 2;
            this.buttonRetourJournee.Text = "Revenir à la journée";
            this.buttonRetourJournee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRetourJournee.UseVisualStyleBackColor = true;
            this.buttonRetourJournee.Click += new System.EventHandler(this.buttonRetourJournee_Click);
            // 
            // labelDanger
            // 
            this.labelDanger.AutoSize = true;
            this.labelDanger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDanger.ForeColor = System.Drawing.Color.LightCoral;
            this.labelDanger.Location = new System.Drawing.Point(527, 101);
            this.labelDanger.Name = "labelDanger";
            this.labelDanger.Size = new System.Drawing.Size(466, 20);
            this.labelDanger.TabIndex = 29;
            this.labelDanger.Text = "Votre rapport dépasse 1000 caractères ! Il sera tronqué !";
            this.labelDanger.Visible = false;
            // 
            // WindowRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 750);
            this.ControlBox = false;
            this.Controls.Add(this.labelDanger);
            this.Controls.Add(this.labelCompteRendu);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.tB_CR);
            this.Controls.Add(this.buttonRetourJournee);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WindowRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compte rendu du jour XX";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRetourJournee;
        private System.Windows.Forms.TextBox tB_CR;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Label labelCompteRendu;
        private System.Windows.Forms.Label labelDanger;
    }
}