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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonCreer = new System.Windows.Forms.Button();
            this.buttonCharger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(89, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 279);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creation d\'une mission";
            // 
            // buttonCreer
            // 
            this.buttonCreer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCreer.Location = new System.Drawing.Point(732, 122);
            this.buttonCreer.Name = "buttonCreer";
            this.buttonCreer.Size = new System.Drawing.Size(162, 34);
            this.buttonCreer.TabIndex = 3;
            this.buttonCreer.Text = "Créer une mission";
            this.buttonCreer.UseVisualStyleBackColor = true;
            // 
            // buttonCharger
            // 
            this.buttonCharger.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCharger.Location = new System.Drawing.Point(732, 162);
            this.buttonCharger.Name = "buttonCharger";
            this.buttonCharger.Size = new System.Drawing.Size(162, 34);
            this.buttonCharger.TabIndex = 3;
            this.buttonCharger.Text = "Charger une mission";
            this.buttonCharger.UseVisualStyleBackColor = true;
            // 
            // WindowLevel0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 791);
            this.Controls.Add(this.buttonCharger);
            this.Controls.Add(this.buttonCreer);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "WindowLevel0";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spaceship Organisator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonCreer;
        private System.Windows.Forms.Button buttonCharger;
    }
}