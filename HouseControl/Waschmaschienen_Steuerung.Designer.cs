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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Waschmaschienen_Steuerung));
            this.label7 = new System.Windows.Forms.Label();
            this.m_Progress = new System.Windows.Forms.ProgressBar();
            this.m_Start_Button = new System.Windows.Forms.Button();
            this.m_Timer = new System.Windows.Forms.Timer(this.components);
            this.m_Zeit_Label = new System.Windows.Forms.Label();
            this.m_panel = new System.Windows.Forms.Panel();
            this.m_Waschmaschinen_Regler = new KnobControl.KnobControl();
            this.m_Waschmaschine_Picture = new System.Windows.Forms.PictureBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.m_Progress_Circel = new System.Windows.Forms.PictureBox();
            this.m_Aus_Button = new System.Windows.Forms.Button();
            this.m_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.m_Waschmaschine_Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m_Progress_Circel)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Helvetica-Narrow", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(333, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 28);
            this.label7.TabIndex = 16;
            this.label7.Text = "Waschmaschine";
            // 
            // m_Progress
            // 
            this.m_Progress.Location = new System.Drawing.Point(68, 241);
            this.m_Progress.Maximum = 5400;
            this.m_Progress.Name = "m_Progress";
            this.m_Progress.Size = new System.Drawing.Size(166, 23);
            this.m_Progress.Step = 1;
            this.m_Progress.TabIndex = 19;
            // 
            // m_Start_Button
            // 
            this.m_Start_Button.Font = new System.Drawing.Font("Helvetica-Narrow", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Start_Button.Location = new System.Drawing.Point(68, 313);
            this.m_Start_Button.Name = "m_Start_Button";
            this.m_Start_Button.Size = new System.Drawing.Size(166, 64);
            this.m_Start_Button.TabIndex = 20;
            this.m_Start_Button.Text = "Start";
            this.m_Start_Button.UseVisualStyleBackColor = true;
            this.m_Start_Button.Click += new System.EventHandler(this.m_Start_Button_Click);
            // 
            // m_Timer
            // 
            this.m_Timer.Interval = 1;
            this.m_Timer.Tick += new System.EventHandler(this.m_Timer_Tick);
            // 
            // m_Zeit_Label
            // 
            this.m_Zeit_Label.AutoSize = true;
            this.m_Zeit_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Zeit_Label.ForeColor = System.Drawing.Color.MediumBlue;
            this.m_Zeit_Label.Location = new System.Drawing.Point(85, 267);
            this.m_Zeit_Label.Name = "m_Zeit_Label";
            this.m_Zeit_Label.Size = new System.Drawing.Size(0, 31);
            this.m_Zeit_Label.TabIndex = 21;
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
            this.m_Waschmaschinen_Regler.ValueChanged += new KnobControl.ValueChangedEventHandler(this.m_Waschmaschinen_Regler_ValueChanged);
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
            this.button_OK.Location = new System.Drawing.Point(703, 402);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(85, 86);
            this.button_OK.TabIndex = 2;
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.button_OK_Click);
            // 
            // m_Progress_Circel
            // 
            this.m_Progress_Circel.BackColor = System.Drawing.Color.Transparent;
            this.m_Progress_Circel.Image = ((System.Drawing.Image)(resources.GetObject("m_Progress_Circel.Image")));
            this.m_Progress_Circel.Location = new System.Drawing.Point(91, 108);
            this.m_Progress_Circel.Name = "m_Progress_Circel";
            this.m_Progress_Circel.Size = new System.Drawing.Size(94, 90);
            this.m_Progress_Circel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.m_Progress_Circel.TabIndex = 22;
            this.m_Progress_Circel.TabStop = false;
            // 
            // m_Aus_Button
            // 
            this.m_Aus_Button.BackgroundImage = global::HouseControl.Properties.Resources.Turn_Off_icon;
            this.m_Aus_Button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.m_Aus_Button.Font = new System.Drawing.Font("Miramonte", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_Aus_Button.ForeColor = System.Drawing.Color.Black;
            this.m_Aus_Button.Location = new System.Drawing.Point(12, 402);
            this.m_Aus_Button.Name = "m_Aus_Button";
            this.m_Aus_Button.Size = new System.Drawing.Size(90, 86);
            this.m_Aus_Button.TabIndex = 23;
            this.m_Aus_Button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.m_Aus_Button.UseVisualStyleBackColor = true;
            this.m_Aus_Button.Click += new System.EventHandler(this.m_Aus_Button_Click);
            // 
            // Waschmaschienen_Steuerung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.m_Aus_Button);
            this.Controls.Add(this.m_Progress_Circel);
            this.Controls.Add(this.m_Zeit_Label);
            this.Controls.Add(this.m_Start_Button);
            this.Controls.Add(this.m_Progress);
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
            ((System.ComponentModel.ISupportInitialize)(this.m_Progress_Circel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox m_Waschmaschine_Picture;
        private System.Windows.Forms.Panel m_panel;
        private KnobControl.KnobControl m_Waschmaschinen_Regler;
        private System.Windows.Forms.ProgressBar m_Progress;
        private System.Windows.Forms.Button m_Start_Button;
        private System.Windows.Forms.Timer m_Timer;
        private System.Windows.Forms.Label m_Zeit_Label;
        private System.Windows.Forms.PictureBox m_Progress_Circel;
        private System.Windows.Forms.Button m_Aus_Button;
    }
}