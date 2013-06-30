using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HouseControl
{
    public partial class Herd_Steuerung : Form
    {
        bool m_Is_Fire1 = false;
        bool m_Is_Fire2 = false;
        bool m_Is_Fire3 = false;
        bool m_Is_Fire4 = false;

        public Herd_Steuerung()
        {
            InitializeComponent();
        }

        private void button_OK_Click(object sender, EventArgs e)
        {
            bool fireON = false;

            if (m_Is_Fire1 || m_Is_Fire2 || m_Is_Fire3 || m_Is_Fire4) fireON = true;

            ((HouseControllLayer)Owner).close_Herd(fireON);
            
        }

        #region Feuer1
        public void Panel_1_Manager(object sender, EventArgs e)
        {
            Bitmap bitmap = Properties.Resources.Control_Knob;

            if (m_radioButton10.Checked)
            {
                m_Regler1.Image = bitmap;
                m_Is_Fire1 = false;
                m_Feuer1.Hide();
            }
            
            if (m_radioButton11.Checked)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                m_Regler1.Image = bitmap;
                m_Is_Fire1 = true;
            }

            if (m_radioButton12.Checked)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                m_Regler1.Image = bitmap;
                m_Is_Fire1 = true;
            }

            if (m_radioButton13.Checked)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
                m_Regler1.Image = bitmap;
                m_Is_Fire1 = true;
            }
        }

        private void m_Feuer1_Paint(object sender, PaintEventArgs e)
        {
            Control s = (Control)sender;

            GraphicsPath pa = new GraphicsPath();
            pa.AddEllipse(0, 0, 20, 20);
            s.Region = new Region(pa);
        }
        #endregion

        #region Feuer2
        public void Panel_2_Manager(object sender, EventArgs e)
        {
            Bitmap bitmap = Properties.Resources.Control_Knob;

            if (m_radioButton20.Checked)
            {
                m_Regler2.Image = bitmap;
                m_Is_Fire2 = false;
                m_Feuer2.Hide();
            }

            if (m_radioButton21.Checked)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                m_Regler2.Image = bitmap;
                m_Is_Fire2 = true;
            }

            if (m_radioButton22.Checked)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                m_Regler2.Image = bitmap;
                m_Is_Fire2 = true;
            }

            if (m_radioButton23.Checked)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
                m_Regler2.Image = bitmap;
                m_Is_Fire2 = true;
            }
        }

        private void m_Feuer2_Paint(object sender, PaintEventArgs e)
        {
            Control s = (Control)sender;

            GraphicsPath pa = new GraphicsPath();
            pa.AddEllipse(0, 0, 25, 25);
            s.Region = new Region(pa);
        }
        #endregion

        #region Feuer3
        public void Panel_3_Manager(object sender, EventArgs e)
        {
            Bitmap bitmap = Properties.Resources.Control_Knob;

            if (m_radioButton30.Checked)
            {
                m_Regler3.Image = bitmap;
                m_Is_Fire3 = false;
                m_Feuer3.Hide();
            }

            if (m_radioButton31.Checked)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                m_Regler3.Image = bitmap;
                m_Is_Fire3 = true;
            }

            if (m_radioButton32.Checked)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                m_Regler3.Image = bitmap;
                m_Is_Fire3 = true;
            }

            if (m_radioButton33.Checked)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
                m_Regler3.Image = bitmap;
                m_Is_Fire3 = true;
            }
        }

        private void m_Feuer3_Paint(object sender, PaintEventArgs e)
        {
            Control s = (Control)sender;

            GraphicsPath pa = new GraphicsPath();
            pa.AddEllipse(0, 0, 42, 40);
            s.Region = new Region(pa);
        }
        #endregion

        #region Feuer4
        public void Panel_4_Manager(object sender, EventArgs e)
        {
            Bitmap bitmap = Properties.Resources.Control_Knob;

            if (m_radioButton40.Checked)
            {
                m_Regler4.Image = bitmap;
                m_Is_Fire4 = false;
                m_Feuer4.Hide();
            }

            if (m_radioButton41.Checked)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                m_Regler4.Image = bitmap;
                m_Is_Fire4 = true;
            }

            if (m_radioButton42.Checked)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                m_Regler4.Image = bitmap;
                m_Is_Fire4 = true;
            }

            if (m_radioButton43.Checked)
            {
                bitmap.RotateFlip(RotateFlipType.Rotate270FlipNone);
                m_Regler4.Image = bitmap;
                m_Is_Fire4 = true;
            }
        }

        private void m_Feuer4_Paint(object sender, PaintEventArgs e)
        {
            Control s = (Control)sender;

            GraphicsPath pa = new GraphicsPath();
            pa.AddEllipse(0, 0, 35, 35);
            s.Region = new Region(pa);
        }
        #endregion

        private void m_Blink_Timer_Show_Tick(object sender, EventArgs e)
        {
            if (m_Is_Fire1) m_Feuer1.Show();
            if (m_Is_Fire2) m_Feuer2.Show();
            if (m_Is_Fire3) m_Feuer3.Show();
            if (m_Is_Fire4) m_Feuer4.Show();
        }
        

        private void m_Blink_Timer_Hide_Tick(object sender, EventArgs e)
        {
            if (m_Is_Fire1) m_Feuer1.Hide();
            if (m_Is_Fire2) m_Feuer2.Hide();
            if (m_Is_Fire3) m_Feuer3.Hide();
            if (m_Is_Fire4) m_Feuer4.Hide();
        }

        private void m_Aus_Button_Click(object sender, EventArgs e)
        {
            m_radioButton10.Checked = true;
            m_radioButton20.Checked = true;
            m_radioButton30.Checked = true;
            m_radioButton40.Checked = true;
        }
    }
}
