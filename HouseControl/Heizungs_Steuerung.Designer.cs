﻿namespace HouseControl
{
    partial class Heizungs_Steuerung
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
            this.components = new System.ComponentModel.Container();
            this.button_OK = new System.Windows.Forms.Button();
            this.m_Heizung_Picture = new System.Windows.Forms.PictureBox();
            this.m_Temperatur_Label = new System.Windows.Forms.Label();
            this.m_Heizungs_Regler = new KnobControl.KnobControl();
            this.label0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.m_Heizungstimer = new System.Windows.Forms.Timer(this.components);
            this.m_Aus_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.m_Heizung_Picture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_OK
            // 
            this.button_OK.BackgroundImage = global::HouseControl.Properties.Resources.OK_icon;
            this.button_OK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_OK.Location = new System.Drawing.Point(664, 360);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(124, 128);
            this.button_OK.TabIndex = 1;
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // m_Heizung_Picture
            // 
            this.m_Heizung_Picture.Image = global::HouseControl.Properties.Resources.Heizung_Aus;
            this.m_Heizung_Picture.Location = new System.Drawing.Point(109, 114);
            this.m_Heizung_Picture.Name = "m_Heizung_Picture";
            this.m_Heizung_Picture.Size = new System.Drawing.Size(185, 172);
            this.m_Heizung_Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_Heizung_Picture.TabIndex = 2;
            this.m_Heizung_Picture.TabStop = false;
            // 
            // m_Temperatur_Label
            // 
            this.m_Temperatur_Label.AutoSize = true;
            this.m_Temperatur_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Temperatur_Label.Location = new System.Drawing.Point(151, 303);
            this.m_Temperatur_Label.Name = "m_Temperatur_Label";
            this.m_Temperatur_Label.Size = new System.Drawing.Size(125, 46);
            this.m_Temperatur_Label.TabIndex = 3;
            this.m_Temperatur_Label.Text = "18 °C";
            // 
            // m_Heizungs_Regler
            // 
            this.m_Heizungs_Regler.BackColor = System.Drawing.SystemColors.Control;
            this.m_Heizungs_Regler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Heizungs_Regler.ForeColor = System.Drawing.Color.Red;
            this.m_Heizungs_Regler.ImeMode = System.Windows.Forms.ImeMode.On;
            this.m_Heizungs_Regler.LargeChange = 2;
            this.m_Heizungs_Regler.Location = new System.Drawing.Point(486, 114);
            this.m_Heizungs_Regler.Maximum = 12;
            this.m_Heizungs_Regler.Minimum = 0;
            this.m_Heizungs_Regler.Name = "m_Heizungs_Regler";
            this.m_Heizungs_Regler.ShowLargeScale = true;
            this.m_Heizungs_Regler.ShowSmallScale = true;
            this.m_Heizungs_Regler.Size = new System.Drawing.Size(207, 197);
            this.m_Heizungs_Regler.SmallChange = 1;
            this.m_Heizungs_Regler.TabIndex = 7;
            this.m_Heizungs_Regler.TabStop = false;
            this.m_Heizungs_Regler.Value = 0;
            this.m_Heizungs_Regler.ValueChanged += new KnobControl.ValueChangedEventHandler(this.m_Heizungs_Regler_ValueChanged);
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label0.Location = new System.Drawing.Point(493, 275);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(24, 25);
            this.label0.TabIndex = 8;
            this.label0.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(456, 199);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(493, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(571, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 11;
            this.label3.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(649, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(690, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(659, 275);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "6";
            // 
            // m_Heizungstimer
            // 
            this.m_Heizungstimer.Enabled = true;
            this.m_Heizungstimer.Interval = 2000;
            this.m_Heizungstimer.Tick += new System.EventHandler(this.m_Heizungstimer_Tick);
            // 
            // m_Aus_Button
            // 
            this.m_Aus_Button.BackgroundImage = global::HouseControl.Properties.Resources.Turn_Off_icon;
            this.m_Aus_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.m_Aus_Button.Font = new System.Drawing.Font("Miramonte", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Aus_Button.ForeColor = System.Drawing.Color.Black;
            this.m_Aus_Button.Location = new System.Drawing.Point(12, 360);
            this.m_Aus_Button.Name = "m_Aus_Button";
            this.m_Aus_Button.Size = new System.Drawing.Size(130, 128);
            this.m_Aus_Button.TabIndex = 16;
            this.m_Aus_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.m_Aus_Button.UseVisualStyleBackColor = true;
            this.m_Aus_Button.Click += new System.EventHandler(this.m_Aus_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 53);
            this.panel1.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(351, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 26);
            this.label7.TabIndex = 15;
            this.label7.Text = "Heizung";
            // 
            // Heizungs_Steuerung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_Aus_Button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.m_Heizungs_Regler);
            this.Controls.Add(this.m_Temperatur_Label);
            this.Controls.Add(this.m_Heizung_Picture);
            this.Controls.Add(this.button_OK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Heizungs_Steuerung";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Heizungs_Steuerung";
            ((System.ComponentModel.ISupportInitialize)(this.m_Heizung_Picture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.PictureBox m_Heizung_Picture;
        private System.Windows.Forms.Label m_Temperatur_Label;
        private KnobControl.KnobControl m_Heizungs_Regler;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer m_Heizungstimer;
        private System.Windows.Forms.Button m_Aus_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
    }
}