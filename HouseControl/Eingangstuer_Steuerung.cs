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
    public partial class Eingangstuer_Steuerung : Form
    {
        public Eingangstuer_Steuerung()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            ((HouseControllLayer)this.Owner).close_Eingangstuer();
        }
    }
}
