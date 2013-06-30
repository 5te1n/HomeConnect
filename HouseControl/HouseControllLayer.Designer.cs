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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HouseControllLayer));
            this.m_Blink_Timer_Show = new System.Windows.Forms.Timer(this.components);
            this.m_Blink_Timer_Hide = new System.Windows.Forms.Timer(this.components);
            this.m_Alles_Aus_Button = new System.Windows.Forms.Button();
            this.m_Panel = new System.Windows.Forms.Panel();
            this.Light3 = new System.Windows.Forms.PictureBox();
            this.Light4 = new System.Windows.Forms.PictureBox();
            this.Light2 = new System.Windows.Forms.PictureBox();
            this.Herd = new System.Windows.Forms.PictureBox();
            this.m_Temperatur = new System.Windows.Forms.Label();
            this.m_Bells = new System.Windows.Forms.PictureBox();
            this.m_Progress_Circel = new System.Windows.Forms.PictureBox();
            this.m_Eingangstuer = new System.Windows.Forms.PictureBox();
            this.m_Heizung = new System.Windows.Forms.PictureBox();
            this.Light1 = new System.Windows.Forms.PictureBox();
            this.m_Feuer = new System.Windows.Forms.PictureBox();
            this.m_Washer = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBoxVerdunkeln = new System.Windows.Forms.PictureBox();
            this.m_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Light3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Herd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Bells)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Progress_Circel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Eingangstuer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Heizung)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Feuer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Washer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxVerdunkeln)).BeginInit();
            this.SuspendLayout();
            // 
            // m_Blink_Timer_Show
            // 
            this.m_Blink_Timer_Show.Enabled = true;
            this.m_Blink_Timer_Show.Interval = 500;
            this.m_Blink_Timer_Show.Tick += new System.EventHandler(this.m_Blink_Timer_Show_Tick);
            // 
            // m_Blink_Timer_Hide
            // 
            this.m_Blink_Timer_Hide.Enabled = true;
            this.m_Blink_Timer_Hide.Interval = 750;
            this.m_Blink_Timer_Hide.Tick += new System.EventHandler(this.m_Blink_Timer_Hide_Tick);
            // 
            // m_Alles_Aus_Button
            // 
            this.m_Alles_Aus_Button.BackgroundImage = global::HouseControl.Properties.Resources.Turn_Off_icon;
            resources.ApplyResources(this.m_Alles_Aus_Button, "m_Alles_Aus_Button");
            this.m_Alles_Aus_Button.Name = "m_Alles_Aus_Button";
            this.m_Alles_Aus_Button.UseVisualStyleBackColor = true;
            // 
            // m_Panel
            // 
            this.m_Panel.BackgroundImage = global::HouseControl.Properties.Resources.Grundriss;
            resources.ApplyResources(this.m_Panel, "m_Panel");
            this.m_Panel.Controls.Add(this.Light3);
            this.m_Panel.Controls.Add(this.Light4);
            this.m_Panel.Controls.Add(this.Light2);
            this.m_Panel.Controls.Add(this.Herd);
            this.m_Panel.Controls.Add(this.m_Temperatur);
            this.m_Panel.Controls.Add(this.m_Bells);
            this.m_Panel.Controls.Add(this.m_Progress_Circel);
            this.m_Panel.Controls.Add(this.m_Eingangstuer);
            this.m_Panel.Controls.Add(this.m_Heizung);
            this.m_Panel.Controls.Add(this.Light1);
            this.m_Panel.Controls.Add(this.m_Feuer);
            this.m_Panel.Controls.Add(this.m_Washer);
            this.m_Panel.Name = "m_Panel";
            // 
            // Light3
            // 
            this.Light3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.Light3, "Light3");
            this.Light3.Image = global::HouseControl.Properties.Resources.Gluehbirne_OFF;
            this.Light3.Name = "Light3";
            this.Light3.TabStop = false;
            this.Light3.Click += new System.EventHandler(this.Llight3_Click);
            // 
            // Light4
            // 
            this.Light4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.Light4, "Light4");
            this.Light4.Image = global::HouseControl.Properties.Resources.Gluehbirne_OFF;
            this.Light4.Name = "Light4";
            this.Light4.TabStop = false;
            this.Light4.Click += new System.EventHandler(this.Light4_Click);
            // 
            // Light2
            // 
            this.Light2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.Light2, "Light2");
            this.Light2.Image = global::HouseControl.Properties.Resources.Gluehbirne_OFF;
            this.Light2.Name = "Light2";
            this.Light2.TabStop = false;
            this.Light2.Click += new System.EventHandler(this.Light2_Click);
            // 
            // Herd
            // 
            this.Herd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Herd.Image = global::HouseControl.Properties.Resources.Herd_Aus;
            resources.ApplyResources(this.Herd, "Herd");
            this.Herd.Name = "Herd";
            this.Herd.TabStop = false;
            this.Herd.Click += new System.EventHandler(this.Herd_Click);
            // 
            // m_Temperatur
            // 
            resources.ApplyResources(this.m_Temperatur, "m_Temperatur");
            this.m_Temperatur.BackColor = System.Drawing.Color.Silver;
            this.m_Temperatur.ForeColor = System.Drawing.Color.Maroon;
            this.m_Temperatur.Name = "m_Temperatur";
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
            // m_Progress_Circel
            // 
            this.m_Progress_Circel.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.m_Progress_Circel, "m_Progress_Circel");
            this.m_Progress_Circel.Name = "m_Progress_Circel";
            this.m_Progress_Circel.TabStop = false;
            this.m_Progress_Circel.Click += new System.EventHandler(this.m_Washer_Click);
            // 
            // m_Eingangstuer
            // 
            this.m_Eingangstuer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_Eingangstuer.Image = global::HouseControl.Properties.Resources.Eingangstuer;
            resources.ApplyResources(this.m_Eingangstuer, "m_Eingangstuer");
            this.m_Eingangstuer.Name = "m_Eingangstuer";
            this.m_Eingangstuer.TabStop = false;
            this.m_Eingangstuer.Click += new System.EventHandler(this.m_Eingangstuer_Click);
            // 
            // m_Heizung
            // 
            this.m_Heizung.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_Heizung.Image = global::HouseControl.Properties.Resources.Heizung_Aus;
            resources.ApplyResources(this.m_Heizung, "m_Heizung");
            this.m_Heizung.Name = "m_Heizung";
            this.m_Heizung.TabStop = false;
            this.m_Heizung.Click += new System.EventHandler(this.m_Heizung_Click);
            // 
            // Light1
            // 
            this.Light1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.Light1, "Light1");
            this.Light1.Image = global::HouseControl.Properties.Resources.Gluehbirne_OFF;
            this.Light1.Name = "Light1";
            this.Light1.TabStop = false;
            this.Light1.Click += new System.EventHandler(this.Light1_Click);
            // 
            // m_Feuer
            // 
            this.m_Feuer.BackColor = System.Drawing.Color.Transparent;
            this.m_Feuer.Image = global::HouseControl.Properties.Resources.Feuer_Achtung;
            resources.ApplyResources(this.m_Feuer, "m_Feuer");
            this.m_Feuer.Name = "m_Feuer";
            this.m_Feuer.TabStop = false;
            this.m_Feuer.Click += new System.EventHandler(this.Herd_Click);
            // 
            // m_Washer
            // 
            this.m_Washer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.m_Washer.Image = global::HouseControl.Properties.Resources.washing_machine_icon;
            resources.ApplyResources(this.m_Washer, "m_Washer");
            this.m_Washer.Name = "m_Washer";
            this.m_Washer.TabStop = false;
            this.m_Washer.Click += new System.EventHandler(this.m_Washer_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBoxVerdunkeln
            // 
            this.pictureBoxVerdunkeln.Image = global::HouseControl.Properties.Resources.Grundriss_Verdunkelt;
            resources.ApplyResources(this.pictureBoxVerdunkeln, "pictureBoxVerdunkeln");
            this.pictureBoxVerdunkeln.Name = "pictureBoxVerdunkeln";
            this.pictureBoxVerdunkeln.TabStop = false;
            // 
            // HouseControllLayer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ControlBox = false;
            this.Controls.Add(this.m_Alles_Aus_Button);
            this.Controls.Add(this.m_Panel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBoxVerdunkeln);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HouseControllLayer";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HouseControllLayer_KeyDown);
            this.m_Panel.ResumeLayout(false);
            this.m_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Light3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Herd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Bells)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Progress_Circel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Eingangstuer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Heizung)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Light1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Feuer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Washer)).EndInit();
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
        private System.Windows.Forms.PictureBox m_Feuer;
        private System.Windows.Forms.Timer m_Blink_Timer_Show;
        private System.Windows.Forms.Timer m_Blink_Timer_Hide;
        private System.Windows.Forms.Label m_Temperatur;
        private System.Windows.Forms.PictureBox m_Progress_Circel;
        private System.Windows.Forms.Panel m_Panel;
        private System.Windows.Forms.PictureBox Light3;
        private System.Windows.Forms.PictureBox Light4;
        private System.Windows.Forms.PictureBox Light2;
        private System.Windows.Forms.Button m_Alles_Aus_Button;
    }
}