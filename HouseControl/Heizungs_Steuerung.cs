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
    public partial class Heizungs_Steuerung : Form
    {
        public int m_Temp = 18;

        public HouseControllLayer m_HouseControll;
        
        public Heizungs_Steuerung()
        {
            InitializeComponent();
           
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            ((HouseControllLayer)Owner).close_Heizung(m_Heizungs_Regler.Value > 0);
        }

        private void m_Heizungs_Regler_ValueChanged(object Sender)
        {
            //m_Heizungstimer.Enabled = true;
            if (m_Heizungs_Regler.Value > 0) m_Heizung_Picture.Image = Properties.Resources.icon_heizung;
            else m_Heizung_Picture.Image = Properties.Resources.Heizung_Aus;
        }

        private void m_Heizungstimer_Tick(object sender, EventArgs e)
        {
            if (m_Heizungs_Regler.Value > 0 && m_Temp < 40)
            {
                m_Temp++;
                m_Temperatur_Label.Text = m_Temp + " °C";

                m_HouseControll.Update_Temperatur(m_Temp);
            }

            if (m_Heizungs_Regler.Value == 0 && m_Temp > 18)
            {
                m_Temp--;
                m_Temperatur_Label.Text = m_Temp + " °C";

                m_HouseControll.Update_Temperatur(m_Temp);
            }
        }

        private void m_Aus_Button_Click(object sender, EventArgs e)
        {
            m_Heizungs_Regler.Value = 0;
        }

        public void Ausschalten()
        {
            m_Heizungs_Regler.Value = 0;
        }
    }
}
