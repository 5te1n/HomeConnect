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
        
        
        public Waschmaschienen_Steuerung()
        {
            InitializeComponent();
            m_Waschmaschinen_Regler.Parent = m_panel;
            m_Waschmaschinen_Regler.Value = 8;
            
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

                TimeSpan time = new TimeSpan(0, 0, m_Zeit_bleibend);
                m_Zeit_Label.Text = time.ToString();

                return;
            }

            if (IS_ON && m_Start_Button.Text == "Fortsetzen")
            {
                m_Start_Button.Text = "Pause";
                m_Timer.Enabled = true;

                return;
            }

            if (m_Start_Button.Text == "Pause")
            {
                m_Timer.Enabled = false;
                m_Start_Button.Text = "Fortsetzen";
            }
        }

        private void m_Timer_Tick(object sender, EventArgs e)
        {
            m_Zeit_bleibend--;
            m_Progress.PerformStep();
            
            TimeSpan time = new TimeSpan(0, 0, m_Zeit_bleibend);
            m_Zeit_Label.Text = time.ToString();

            if (m_Progress.Value == m_Progress.Maximum)
            {
                m_Start_Button.Text = "Start";
                m_Zeit_Label.Text = "Fertig";
                IS_ON = false;
                m_Progress.Hide();
                m_Timer.Enabled = false;
            }
        }
    }
}
