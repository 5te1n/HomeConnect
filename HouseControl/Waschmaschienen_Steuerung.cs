using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseControl
{
    public partial class Waschmaschienen_Steuerung : Form
    {
        bool IS_ON = false;
        int m_Zeit_bleibend = 5400;
        public HouseControllLayer m_House_Control;
        
        
        public Waschmaschienen_Steuerung()
        {
            InitializeComponent();
            m_Waschmaschinen_Regler.Parent = m_panel;
            m_Waschmaschinen_Regler.Value = 8;

            m_Progress_Circel.Parent = m_Waschmaschine_Picture;
            m_Progress_Circel.Location = new Point(40, 50);
            m_Progress_Circel.Hide();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            ((HouseControllLayer)Owner).close_Waschmaschine();
        }

        private void m_Waschmaschinen_Regler_ValueChanged(object Sender)
        {
            m_Progress.Value = m_Waschmaschinen_Regler.Value;
        }

        private void m_Start_Button_Click(object sender, EventArgs e)
        {
            if (!IS_ON && m_Waschmaschinen_Regler.Value != 8)
            {
                m_Zeit_bleibend = 5400;
                IS_ON = true;
                m_Progress.Show();
                m_Progress.Value = 0;
                m_Start_Button.Text = "Pause";
                m_Timer.Enabled = true;
                m_Zeit_Label.Show();

                TimeSpan time = new TimeSpan(0, 0, m_Zeit_bleibend);
                m_Zeit_Label.Text = time.ToString();
                m_Progress_Circel.Show();
                m_Progress_Circel.Enabled = true;

                m_House_Control.show_Waschmaschine_Progress(1);
                return;
            }

            if (IS_ON && m_Start_Button.Text == "Fortsetzen")
            {
                m_Start_Button.Text = "Pause";
                m_Timer.Enabled = true;
                m_Progress_Circel.Enabled = true;

                m_House_Control.show_Waschmaschine_Progress(1);
                return;
            }

            if (m_Start_Button.Text == "Pause")
            {
                m_Timer.Enabled = false;
                m_Start_Button.Text = "Fortsetzen";
                m_Progress_Circel.Enabled = false;

                m_House_Control.show_Waschmaschine_Progress(2);
            }
        }

        private void m_Timer_Tick(object sender, EventArgs e)
        {
            m_Zeit_bleibend--;
            m_Progress.PerformStep();
            
            TimeSpan time = new TimeSpan(0, 0, m_Zeit_bleibend);
            m_Zeit_Label.Text = time.ToString();

            if (m_Progress.Value >= m_Progress.Maximum)
            {
                m_Start_Button.Text = "Start";
                m_Zeit_Label.Text = "Fertig";
                IS_ON = false;
                m_Progress.Hide();
                m_Timer.Enabled = false;
                m_Progress_Circel.Hide();

                m_House_Control.show_Waschmaschine_Progress(4);
            }
        }

        private void m_Aus_Button_Click(object sender, EventArgs e)
        {
            IS_ON = false;
            m_Waschmaschinen_Regler.Value = 8;
            m_Timer.Enabled = false;
            m_Progress_Circel.Hide();
            m_Zeit_Label.Hide();
            m_Progress.Hide();
            m_Start_Button.Text = "Start";

            m_House_Control.show_Waschmaschine_Progress(3);
        }
    }
}
