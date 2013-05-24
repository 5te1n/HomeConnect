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
    public partial class MainMenuLayer : Form
    {
        public MainMenuLayer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: Implement Blueprint Loading and switch to Control Mode
            MessageBox.Show("Es muss ein Grundriss erstellt werden, um die Wohnung zu steuern!");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HouseBuildingLayer hbl = new HouseBuildingLayer();
            this.Visible = false;
            hbl.ShowDialog(this);
        }
    }
}
