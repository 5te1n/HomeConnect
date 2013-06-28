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
        
        public bool[] IS_LIGHT_ON = new bool[5] { false, false, false, false, false };
        
        public HouseControllLayer()
        {
            InitializeComponent();
            m_HerdSteuerung = new Herd_Steuerung();
            
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
    }
}
