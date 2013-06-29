namespace HouseControl
{
    partial class HouseControllLayer
    {
        public System.ComponentModel.ComponentResourceManager resources;
        
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
            this.Herd = new System.Windows.Forms.PictureBox();
            this.Light1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Herd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light1)).BeginInit();
            this.SuspendLayout();
            // 
            // Herd
            // 
            this.Herd.Image = global::HouseControl.Properties.Resources.Herd_Aus;
            this.Herd.Location = new System.Drawing.Point(677, 92);
            this.Herd.Name = "Herd";
            this.Herd.Size = new System.Drawing.Size(115, 105);
            this.Herd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Herd.TabIndex = 1;
            this.Herd.TabStop = false;
            this.Herd.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Light1
            // 
            this.Light1.ErrorImage = null;
            this.Light1.Image = global::HouseControl.Properties.Resources.Gluehbirne_OFF;
            this.Light1.Location = new System.Drawing.Point(285, 92);
            this.Light1.Name = "Light1";
            this.Light1.Size = new System.Drawing.Size(109, 87);
            this.Light1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Light1.TabIndex = 0;
            this.Light1.TabStop = false;
            this.Light1.Click += new System.EventHandler(this.Light1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // HouseControllLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Herd);
            this.Controls.Add(this.Light1);
            this.Name = "HouseControllLayer";
            this.Text = "HouseControllLayer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Herd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Light1;
        private System.Windows.Forms.PictureBox Herd;
        private System.Windows.Forms.Label label1;
    }
}