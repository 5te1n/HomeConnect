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
        public HouseControllLayer m_HouseControllLayer;
        
        public MainMenuLayer()
        {
            InitializeComponent();
            
            this.m_HouseControllLayer = new HouseControllLayer();
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //TODO: Implement Blueprint Loading and switch to Control Mode
            //MessageBox.Show("Es muss ein Grundriss erstellt werden, um die Wohnung zu steuern!");

            m_HouseControllLayer.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HouseBuildingLayer hbl = new HouseBuildingLayer();
            this.Visible = false;
            hbl.ShowDialog(this);
        }

        public void close_House_Control()
        {
            m_HouseControllLayer.Hide();
            this.Activate();
        }
    }
}
