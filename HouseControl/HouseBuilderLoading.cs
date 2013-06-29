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
    public partial class HouseBuilderLoading : Form
    {

        public HouseBuilderLoading(string textMessage)
        {
            InitializeComponent();
            label1.Text = textMessage;

        }

        public HouseBuilderLoading(string textMessage, int max)
        {
            InitializeComponent();
            label1.Text = textMessage;
            progressBar1.Maximum = max;

        }

        public void Updates()
        {
            progressBar1.PerformStep();
            Update();
        }

        private void HouseBuilderLoading_Shown(object sender, EventArgs e)
        {
            while (progressBar1.Value != progressBar1.Maximum)
            {
                Updates();
            }

            this.Hide();
        }
    }
}
