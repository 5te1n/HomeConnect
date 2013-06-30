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
        public Waschmaschienen_Steuerung()
        {
            InitializeComponent();
            m_Waschmaschinen_Regler.Parent = m_panel;
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            ((HouseControllLayer)Owner).close_Waschmaschine();
        }
    }
}
