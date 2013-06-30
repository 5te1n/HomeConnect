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
        private enum DESIGN_STATE {ROOM, REMOVE_OBJECT, DOOR, MOVE, SCALE, CONNECT, LIGHT, HEATER, MICROWAVE, FRIDGE, PC, TV, WASHING  }
        HouseBuildingFunctions internalFunctions;
        HouseBuilderLoading loadingScreen = null;

        public HouseBuildingLayer()
        {
            InitializeComponent();
            internalFunctions = new HouseBuildingFunctions();
            doorButton.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadingScreen = new HouseBuilderLoading("Grundriss wird gespeichert");
            loadingScreen.ShowDialog(this);
            
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
            moveButton.BackColor = Color.FromKnownColor(KnownColor.Control);
            scaleButton.BackColor = Color.FromKnownColor(KnownColor.Control); ;
            connectButton.BackColor = Color.FromKnownColor(KnownColor.Control);
            lightButton.BackColor = Color.FromKnownColor(KnownColor.Control);
            heaterButton.BackColor = Color.FromKnownColor(KnownColor.Control);
            microWaveButton.BackColor = Color.FromKnownColor(KnownColor.Control);
            fridgeButton.BackColor = Color.FromKnownColor(KnownColor.Control);
            pcButton.BackColor = Color.FromKnownColor(KnownColor.Control);
            tvButton.BackColor = Color.FromKnownColor(KnownColor.Control);
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
                label1.Text = internalFunctions.CheckRoomCollision(Graphics.FromImage(pictureBox1.Image));

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

            else if (internalFunctions.InternalState == (int)DESIGN_STATE.DOOR)
            {
                label1.Text = internalFunctions.PlaceDoor(Graphics.FromImage(pictureBox1.Image), (e as MouseEventArgs).Location);
                this.Refresh();
            }

            else if (internalFunctions.InternalState == (int)DESIGN_STATE.CONNECT)
            {
                label1.Text = internalFunctions.ConnectDevice(Graphics.FromImage(pictureBox1.Image), (e as MouseEventArgs).Location);
                RedrawRooms();
            }

            else if (internalFunctions.InternalState != (int)DESIGN_STATE.ROOM
                && internalFunctions.InternalState != (int) DESIGN_STATE.MOVE
                && internalFunctions.InternalState != (int) DESIGN_STATE.SCALE)
            {
                //State must be an interior item
                if((e as MouseEventArgs).Button == MouseButtons.Left)
                    label1.Text = internalFunctions.DetermineInteriorGraphic(Graphics.FromImage(pictureBox1.Image), (e as MouseEventArgs).Location, false);

                else
                    label1.Text = internalFunctions.DetermineInteriorGraphic(Graphics.FromImage(pictureBox1.Image), (e as MouseEventArgs).Location, true);

                this.Refresh();
            }
        }

        #region Boring Button Click Events
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

        //DOOR BUTTON CLICK EVENT
        private void button2_Click(object sender, EventArgs e)
        {            
            ClearButtonColor();
            internalFunctions.SwitchState((int)DESIGN_STATE.DOOR);
            doorButton.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            ClearButtonColor();
            internalFunctions.SwitchState((int)DESIGN_STATE.MOVE);
            moveButton.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
        }

        private void scaleButton_Click(object sender, EventArgs e)
        {
            ClearButtonColor();
            internalFunctions.SwitchState((int)DESIGN_STATE.SCALE);
            scaleButton.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            ClearButtonColor();
            internalFunctions.SwitchState((int)DESIGN_STATE.CONNECT);
            connectButton.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
        }

        private void lightButton_Click(object sender, EventArgs e)
        {
            ClearButtonColor();
            internalFunctions.SwitchState((int)DESIGN_STATE.LIGHT);
            lightButton.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
        }

        private void heaterButton_Click(object sender, EventArgs e)
        {
            ClearButtonColor();
            internalFunctions.SwitchState((int)DESIGN_STATE.HEATER);
            heaterButton.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
        }

        private void microWaveButton_Click(object sender, EventArgs e)
        {
            ClearButtonColor();
            internalFunctions.SwitchState((int)DESIGN_STATE.MICROWAVE);
            microWaveButton.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
        }

        private void fridgeButton_Click(object sender, EventArgs e)
        {
            ClearButtonColor();
            internalFunctions.SwitchState((int)DESIGN_STATE.FRIDGE);
            fridgeButton.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
        }

        private void pcButton_Click(object sender, EventArgs e)
        {
            ClearButtonColor();
            internalFunctions.SwitchState((int)DESIGN_STATE.PC);
            pcButton.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
        }

        private void tvButton_Click(object sender, EventArgs e)
        {
            ClearButtonColor();
            internalFunctions.SwitchState((int)DESIGN_STATE.TV);
            tvButton.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
        }


        private void washingButton_Click(object sender, EventArgs e)
        {
            ClearButtonColor();
            internalFunctions.SwitchState((int)DESIGN_STATE.WASHING);
            washingButton.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
        }

        #endregion
    }
}
