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
            this.buttonChargementMission = new System.Windows.Forms.Button();
            this.buttonNouvelleMission = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.listBoxMissions = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonChargementMission
            // 
            this.buttonChargementMission.Location = new System.Drawing.Point(6, 120);
            this.buttonChargementMission.Name = "buttonChargementMission";
            this.buttonChargementMission.Size = new System.Drawing.Size(174, 49);
            this.buttonChargementMission.TabIndex = 0;
            this.buttonChargementMission.Text = "Lancer la mission";
            this.buttonChargementMission.UseVisualStyleBackColor = true;
            this.buttonChargementMission.Click += new System.EventHandler(this.buttonChargementMission_Click);
            // 
            // buttonNouvelleMission
            // 
            this.buttonNouvelleMission.Location = new System.Drawing.Point(156, 262);
            this.buttonNouvelleMission.Name = "buttonNouvelleMission";
            this.buttonNouvelleMission.Size = new System.Drawing.Size(174, 49);
            this.buttonNouvelleMission.TabIndex = 1;
            this.buttonNouvelleMission.Text = "Nouvelle mission";
            this.buttonNouvelleMission.UseVisualStyleBackColor = true;
            this.buttonNouvelleMission.Click += new System.EventHandler(this.buttonNouvelleMission_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(77, 19);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(335, 39);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "SpaceShip Schedule";
            // 
            // listBoxMissions
            // 
            this.listBoxMissions.FormattingEnabled = true;
            this.listBoxMissions.Location = new System.Drawing.Point(6, 19);
            this.listBoxMissions.Name = "listBoxMissions";
            this.listBoxMissions.Size = new System.Drawing.Size(174, 95);
            this.listBoxMissions.TabIndex = 3;
            this.listBoxMissions.SelectedIndexChanged += new System.EventHandler(this.listBoxMissions_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBoxMissions);
            this.groupBox1.Controls.Add(this.buttonChargementMission);
            this.groupBox1.Location = new System.Drawing.Point(150, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 183);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Missions éxistantes";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PapayaWhip;
            this.panel1.Controls.Add(this.labelTitle);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.buttonNouvelleMission);
            this.panel1.Location = new System.Drawing.Point(173, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 412);
            this.panel1.TabIndex = 5;
            // 
            // WindowLevel0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(864, 593);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WindowLevel0";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spaceship Schedule";
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChargementMission;
        private System.Windows.Forms.Button buttonNouvelleMission;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListBox listBoxMissions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;

    }
}