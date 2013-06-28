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
            this.pictureBoxVerdunkeln = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Herd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVerdunkeln)).BeginInit();
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
            this.Herd.Click += new System.EventHandler(this.Herd_Click);
            // 
            // Light1
            // 
            this.Light1.ErrorImage = null;
            this.Light1.Image = global::HouseControl.Properties.Resources.Gluehbirne_OFF;
            this.Light1.Location = new System.Drawing.Point(142, 102);
            this.Light1.Name = "Light1";
            this.Light1.Size = new System.Drawing.Size(109, 95);
            this.Light1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Light1.TabIndex = 0;
            this.Light1.TabStop = false;
            this.Light1.Click += new System.EventHandler(this.Light1_Click);
            // 
            // pictureBoxVerdunkeln
            // 
            this.pictureBoxVerdunkeln.Image = global::HouseControl.Properties.Resources.Verdunkelndes_Grau_halb_transparent;
            this.pictureBoxVerdunkeln.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxVerdunkeln.Name = "pictureBoxVerdunkeln";
            this.pictureBoxVerdunkeln.Size = new System.Drawing.Size(1366, 768);
            this.pictureBoxVerdunkeln.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxVerdunkeln.TabIndex = 2;
            this.pictureBoxVerdunkeln.TabStop = false;
            this.pictureBoxVerdunkeln.Visible = false;
            // 
            // HouseControllLayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.Herd);
            this.Controls.Add(this.Light1);
            this.Controls.Add(this.pictureBoxVerdunkeln);
            this.Name = "HouseControllLayer";
            this.Text = "HouseControllLayer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.Herd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVerdunkeln)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Light1;
        private System.Windows.Forms.PictureBox Herd;
        private System.Windows.Forms.PictureBox pictureBoxVerdunkeln;
    }
}