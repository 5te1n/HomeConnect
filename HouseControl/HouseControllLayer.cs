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
        
        public bool[] IS_LIGHT_ON = new bool[5] { false, false, false, false, false };
        
        public HouseControllLayer()
        {
            InitializeComponent();
            m_HerdSteuerung = new Herd_Steuerung();
            m_Eingangstuer_Steuerung = new Eingangstuer_Steuerung();
            m_Heizungs_Steuerung = new Heizungs_Steuerung();

            m_Bells.Parent = m_Eingangstuer;
            m_Bells.Location = new Point(7, 10);
            m_Bells.Hide();
            
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

            m_HerdSteuerung.Show(this);
        }

        public void close_Herd()
        {
            m_HerdSteuerung.Hide();
            pictureBoxVerdunkeln.Hide();
        }

        public void close_Eingangstuer()
        {
            m_Eingangstuer_Steuerung.Hide();
            m_Bells.Hide();
            pictureBoxVerdunkeln.Hide();
        }

        public void close_Heizung()
        {       
            m_Heizungs_Steuerung.Hide();
            pictureBoxVerdunkeln.Hide();
        }

        private void m_Eingangstuer_Click(object sender, EventArgs e)
        {
            pictureBoxVerdunkeln.BringToFront();
            pictureBoxVerdunkeln.Show();

            m_Eingangstuer_Steuerung.Show(this);
        }

        private void HouseControllLayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.K) m_Bells.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((MainMenuLayer)Owner).close_House_Control();
        }

        private void m_Heizung_Click(object sender, EventArgs e)
        {
            pictureBoxVerdunkeln.Show();
            m_Heizungs_Steuerung.Show(this);
        }
    }
}
