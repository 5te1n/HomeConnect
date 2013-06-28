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
    public partial class HouseBuildingLayer : Form
    {
        private enum DESIGN_STATE {ROOM, REMOVE_OBJECT, DOOR  }
        HouseBuildingFunctions internalFunctions;

        public HouseBuildingLayer()
        {
            InitializeComponent();
            internalFunctions = new HouseBuildingFunctions();
            roomButton.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Owner.Visible = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (internalFunctions.IsDrawingRectangle)
            {
                internalFunctions.DrawWalls(Graphics.FromImage(pictureBox1.Image), e.Location);
                RedrawRooms();
            }
        }

        public void ClearButtonColor()
        {
            roomButton.BackColor = Color.FromKnownColor(KnownColor.Control);
            removeButton.BackColor = Color.FromKnownColor(KnownColor.Control);
            doorButton.BackColor = Color.FromKnownColor(KnownColor.Control);
        }

        private void RedrawRooms()
        {
            internalFunctions.RedrawInterior(Graphics.FromImage(pictureBox1.Image));
            internalFunctions.RedrawRooms(Graphics.FromImage(pictureBox1.Image));
            this.Refresh();
        }
                
        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (internalFunctions.IsDrawingRectangle)
            {
                if (internalFunctions.CheckRoomCollision(Graphics.FromImage(pictureBox1.Image)))
                    label1.Text = "Fehler: Räume dürfen sich nicht überschneiden!";
                else
                    label1.Text = "";

                RedrawRooms();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!internalFunctions.IsDrawingRectangle && internalFunctions.InternalState == (int)DESIGN_STATE.ROOM)
            {
                internalFunctions.StartRoomMode((e as MouseEventArgs).Location);

            }
        }

        private void roomButton_Click(object sender, EventArgs e)
        {
            ClearButtonColor();
            internalFunctions.SwitchState((int)DESIGN_STATE.ROOM);
            roomButton.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            ClearButtonColor();
            internalFunctions.SwitchState((int)DESIGN_STATE.REMOVE_OBJECT);
            removeButton.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (internalFunctions.InternalState == (int)DESIGN_STATE.REMOVE_OBJECT)
            {
                if (internalFunctions.RoomDeletion(Graphics.FromImage(pictureBox1.Image), (e as MouseEventArgs).Location))
                {
                    internalFunctions.ClearDrawSpace(Graphics.FromImage(pictureBox1.Image));
                    RedrawRooms();
                }
            }

            if (internalFunctions.InternalState == (int)DESIGN_STATE.DOOR)
            {
                label1.Text = internalFunctions.PlaceDoor(Graphics.FromImage(pictureBox1.Image), (e as MouseEventArgs).Location);
                this.Refresh();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearButtonColor();
            internalFunctions.SwitchState((int)DESIGN_STATE.DOOR);
            doorButton.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
        }



    }
}
