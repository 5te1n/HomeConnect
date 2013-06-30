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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HouseControllLayer));
            this.m_Washer = new System.Windows.Forms.PictureBox();
            this.m_Heizung = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.m_Bells = new System.Windows.Forms.PictureBox();
            this.m_Eingangstuer = new System.Windows.Forms.PictureBox();
            this.Herd = new System.Windows.Forms.PictureBox();
            this.Light1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxVerdunkeln = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.m_Washer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Heizung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Bells)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Eingangstuer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Herd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVerdunkeln)).BeginInit();
            this.SuspendLayout();
            // 
            // m_Washer
            // 
            this.m_Washer.Image = global::HouseControl.Properties.Resources.washing_machine_icon;
            resources.ApplyResources(this.m_Washer, "m_Washer");
            this.m_Washer.Name = "m_Washer";
            this.m_Washer.TabStop = false;
            this.m_Washer.Click += new System.EventHandler(this.m_Washer_Click);
            // 
            // m_Heizung
            // 
            this.m_Heizung.Image = global::HouseControl.Properties.Resources.icon_heizung;
            resources.ApplyResources(this.m_Heizung, "m_Heizung");
            this.m_Heizung.Name = "m_Heizung";
            this.m_Heizung.TabStop = false;
            this.m_Heizung.Click += new System.EventHandler(this.m_Heizung_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // m_Bells
            // 
            this.m_Bells.BackColor = System.Drawing.Color.Transparent;
            this.m_Bells.Image = global::HouseControl.Properties.Resources.bells;
            resources.ApplyResources(this.m_Bells, "m_Bells");
            this.m_Bells.Name = "m_Bells";
            this.m_Bells.TabStop = false;
            this.m_Bells.Click += new System.EventHandler(this.m_Eingangstuer_Click);
            // 
            // m_Eingangstuer
            // 
            this.m_Eingangstuer.Image = global::HouseControl.Properties.Resources.Eingangstuer;
            resources.ApplyResources(this.m_Eingangstuer, "m_Eingangstuer");
            this.m_Eingangstuer.Name = "m_Eingangstuer";
            this.m_Eingangstuer.TabStop = false;
            this.m_Eingangstuer.Click += new System.EventHandler(this.m_Eingangstuer_Click);
            // 
            // Herd
            // 
            this.Herd.Image = global::HouseControl.Properties.Resources.Herd_Aus;
            resources.ApplyResources(this.Herd, "Herd");
            this.Herd.Name = "Herd";
            this.Herd.TabStop = false;
            this.Herd.Click += new System.EventHandler(this.Herd_Click);
            // 
            // Light1
            // 
            resources.ApplyResources(this.Light1, "Light1");
            this.Light1.Image = global::HouseControl.Properties.Resources.Gluehbirne_OFF;
            this.Light1.Name = "Light1";
            this.Light1.TabStop = false;
            this.Light1.Click += new System.EventHandler(this.Light1_Click);
            // 
            // pictureBoxVerdunkeln
            // 
            this.pictureBoxVerdunkeln.Image = global::HouseControl.Properties.Resources.Verdunkelndes_Grau_halb_transparent;
            resources.ApplyResources(this.pictureBoxVerdunkeln, "pictureBoxVerdunkeln");
            this.pictureBoxVerdunkeln.Name = "pictureBoxVerdunkeln";
            this.pictureBoxVerdunkeln.TabStop = false;
            // 
            // HouseControllLayer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.m_Washer);
            this.Controls.Add(this.m_Heizung);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.m_Bells);
            this.Controls.Add(this.m_Eingangstuer);
            this.Controls.Add(this.Herd);
            this.Controls.Add(this.Light1);
            this.Controls.Add(this.pictureBoxVerdunkeln);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HouseControllLayer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HouseControllLayer_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.m_Washer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Heizung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Bells)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Eingangstuer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Herd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVerdunkeln)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Light1;
        private System.Windows.Forms.PictureBox Herd;
        private System.Windows.Forms.PictureBox pictureBoxVerdunkeln;
        private System.Windows.Forms.PictureBox m_Eingangstuer;
        private System.Windows.Forms.PictureBox m_Bells;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox m_Heizung;
        private System.Windows.Forms.PictureBox m_Washer;
    }
}