namespace HouseControl
{
    partial class Waschmaschienen_Steuerung
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
            this.label7 = new System.Windows.Forms.Label();
            this.m_panel = new System.Windows.Forms.Panel();
            this.m_Waschmaschinen_Regler = new KnobControl.KnobControl();
            this.m_Waschmaschine_Picture = new System.Windows.Forms.PictureBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.m_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_Waschmaschine_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(333, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Waschmaschine";
            // 
            // m_panel
            // 
            this.m_panel.BackgroundImage = global::HouseControl.Properties.Resources.Waschmaschine_Bedienung;
            this.m_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.m_panel.Controls.Add(this.m_Waschmaschinen_Regler);
            this.m_panel.Location = new System.Drawing.Point(304, 58);
            this.m_panel.Name = "m_panel";
            this.m_panel.Size = new System.Drawing.Size(484, 319);
            this.m_panel.TabIndex = 18;
            // 
            // m_Waschmaschinen_Regler
            // 
            this.m_Waschmaschinen_Regler.BackColor = System.Drawing.Color.Transparent;
            this.m_Waschmaschinen_Regler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Waschmaschinen_Regler.ForeColor = System.Drawing.Color.Red;
            this.m_Waschmaschinen_Regler.ImeMode = System.Windows.Forms.ImeMode.On;
            this.m_Waschmaschinen_Regler.LargeChange = 1;
            this.m_Waschmaschinen_Regler.Location = new System.Drawing.Point(148, 74);
            this.m_Waschmaschinen_Regler.Maximum = 16;
            this.m_Waschmaschinen_Regler.Minimum = 0;
            this.m_Waschmaschinen_Regler.Name = "m_Waschmaschinen_Regler";
            this.m_Waschmaschinen_Regler.ShowLargeScale = true;
            this.m_Waschmaschinen_Regler.ShowSmallScale = true;
            this.m_Waschmaschinen_Regler.Size = new System.Drawing.Size(209, 196);
            this.m_Waschmaschinen_Regler.SmallChange = 1;
            this.m_Waschmaschinen_Regler.TabIndex = 8;
            this.m_Waschmaschinen_Regler.TabStop = false;
            this.m_Waschmaschinen_Regler.Value = 0;
            // 
            // m_Waschmaschine_Picture
            // 
            this.m_Waschmaschine_Picture.Image = global::HouseControl.Properties.Resources.washing_machine_icon;
            this.m_Waschmaschine_Picture.Location = new System.Drawing.Point(68, 58);
            this.m_Waschmaschine_Picture.Name = "m_Waschmaschine_Picture";
            this.m_Waschmaschine_Picture.Size = new System.Drawing.Size(166, 177);
            this.m_Waschmaschine_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_Waschmaschine_Picture.TabIndex = 17;
            this.m_Waschmaschine_Picture.TabStop = false;
            // 
            // button_OK
            // 
            this.button_OK.BackgroundImage = global::HouseControl.Properties.Resources.OK_icon;
            this.button_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_OK.Location = new System.Drawing.Point(728, 428);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(60, 60);
            this.button_OK.TabIndex = 2;
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // Waschmaschienen_Steuerung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.m_panel);
            this.Controls.Add(this.m_Waschmaschine_Picture);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button_OK);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Waschmaschienen_Steuerung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Waschmaschienen_Steuerung";
            this.m_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.m_Waschmaschine_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox m_Waschmaschine_Picture;
        private System.Windows.Forms.Panel m_panel;
        private KnobControl.KnobControl m_Waschmaschinen_Regler;
    }
}