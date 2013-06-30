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
    public partial class HouseControllLayer : Form
    {
        Herd_Steuerung m_HerdSteuerung;
        Eingangstuer_Steuerung m_Eingangstuer_Steuerung;
        Heizungs_Steuerung m_Heizungs_Steuerung;
        Waschmaschienen_Steuerung m_Waschmaschine;
        
        public bool[] IS_LIGHT_ON = new bool[5] { false, false, false, false, false };
        public bool IS_HERD_ON = false;
        
        public HouseControllLayer()
        {
            InitializeComponent();
            m_HerdSteuerung = new Herd_Steuerung();
            m_Eingangstuer_Steuerung = new Eingangstuer_Steuerung();
            m_Heizungs_Steuerung = new Heizungs_Steuerung();
            m_Heizungs_Steuerung.m_HouseControll = this;
            m_Waschmaschine = new Waschmaschienen_Steuerung();

            m_Bells.Parent = m_Eingangstuer;
            m_Bells.Location = new Point(7, 10);
            m_Bells.Hide();

            m_Feuer.Parent = Herd;
            m_Feuer.Location = new Point(18,18);
            m_Feuer.Hide();

            
            
        }

        private void Light1_Click(object sender, EventArgs e)
        {
            if (IS_LIGHT_ON[0]) Light1.Image = Properties.Resources.Gluehbirne_OFF;
            if (!IS_LIGHT_ON[0]) Light1.Image = Properties.Resources.Gluehbirne_ON;
            
            IS_LIGHT_ON[0] = !IS_LIGHT_ON[0];
        }

        private void Herd_Click(object sender, EventArgs e)
        {
            pictureBoxVerdunkeln.BringToFront();
            pictureBoxVerdunkeln.Show();

            m_HerdSteuerung.ShowDialog(this);
        }

        public void close_Herd(bool IS_Herd_ON)
        {
            m_HerdSteuerung.Hide();
            pictureBoxVerdunkeln.Hide();

            if (IS_Herd_ON)
            {
                this.IS_HERD_ON = true;
            }
            else IS_HERD_ON = false;

            m_Feuer.Hide();
        }

        public void close_Eingangstuer()
        {
            m_Eingangstuer_Steuerung.Hide();
            m_Bells.Hide();
            pictureBoxVerdunkeln.Hide();
        }

        public void close_Heizung(bool IS_On)
        {       
            m_Heizungs_Steuerung.Hide();
            pictureBoxVerdunkeln.Hide();

            if (IS_On) m_Heizung.Image = Properties.Resources.icon_heizung;
            else m_Heizung.Image = Properties.Resources.Heizung_Aus;
        }

        public void close_Waschmaschine()
        {
            m_Waschmaschine.Hide();
            pictureBoxVerdunkeln.Hide();
        }

        public void Update_Temperatur(int Temp)
        {
            m_Temperatur.Text = Temp + " °C";
        }

        private void m_Eingangstuer_Click(object sender, EventArgs e)
        {
            pictureBoxVerdunkeln.BringToFront();
            pictureBoxVerdunkeln.Show();

            m_Eingangstuer_Steuerung.ShowDialog(this);
        }

        private void HouseControllLayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.K) m_Bells.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Owner.Visible = true;
            //((MainMenuLayer)Owner).close_House_Control();
        }

        private void m_Heizung_Click(object sender, EventArgs e)
        {
            pictureBoxVerdunkeln.Show();
            m_Heizungs_Steuerung.ShowDialog(this);
        }

        private void m_Washer_Click(object sender, EventArgs e)
        {
            pictureBoxVerdunkeln.Show();
            m_Waschmaschine.ShowDialog(this);
        }

        private void m_Blink_Timer_Show_Tick(object sender, EventArgs e)
        {
            if (IS_HERD_ON)
            {
                m_Feuer.Show(); 
            }
        }

        private void m_Blink_Timer_Hide_Tick(object sender, EventArgs e)
        {
            m_Feuer.Hide();
        }
    }
}
