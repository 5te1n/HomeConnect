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
            label1.BackColor = Color.FromArgb(20, 200, 20, 20);
        }

        private void Light1_Click(object sender, EventArgs e)
        {
            if (IS_LIGHT_ON[0]) Light1.Image = Properties.Resources.Gluehbirne_OFF;
            if (!IS_LIGHT_ON[0]) Light1.Image = Properties.Resources.Gluehbirne_ON;
            
            IS_LIGHT_ON[0] = !IS_LIGHT_ON[0];
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            m_HerdSteuerung.ShowDialog(this);
        }
    }
}
