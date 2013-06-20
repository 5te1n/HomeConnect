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
        bool isDrawingRectangle;
        LinkedList<Room> roomList;          // Contains all the rooms that currently exist. Used for XML exporting
        Room newRoom;                       // Temporary room used when the user is drawing room rectangles.

        private enum DESIGN_STATE {ROOM, REMOVE_OBJECT, DOOR  }
        int current_state;

        int penSize = 10;

        public HouseBuildingLayer()
        {
            isDrawingRectangle = false;
            roomList = new LinkedList<Room>();
            current_state = (int) DESIGN_STATE.ROOM;
            InitializeComponent();
            newRoom = new Room();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Owner.Visible = true;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawingRectangle)
            {

                Point upperLeft = newRoom.ReturnDrawReferencePoint();

                Pen p = new Pen(Color.White, penSize);
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                g.DrawRectangle(p, new Rectangle(upperLeft.X, upperLeft.Y, newRoom.Width(), newRoom.Height()));

                newRoom.EndPoint = e.Location;

                upperLeft = newRoom.ReturnDrawReferencePoint();


                p = new Pen(Color.Red, penSize);
                g.DrawRectangle(p, new Rectangle(upperLeft.X, upperLeft.Y, newRoom.Width(), newRoom.Height()));

                this.Refresh();
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
            foreach (Room roomInList in roomList)
            {
                roomInList.CheckOrientation();
                Pen p = new Pen(Color.Black, penSize);
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                g.DrawRectangle(p, new Rectangle(roomInList.BeginningPoint.X, roomInList.BeginningPoint.Y, roomInList.Width(), roomInList.Height()));
                this.Refresh();
            }
        }

        private void RemoveRoom(Room r)
        {
            Pen p = new Pen(Color.White, penSize);
            Graphics g = Graphics.FromImage(pictureBox1.Image);
            g.DrawRectangle(p, new Rectangle(r.BeginningPoint.X, r.BeginningPoint.Y, r.Width(), r.Height()));
            this.Refresh();
            

        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDrawingRectangle)
            {
                bool intersectsPreviousRooms = false;

                isDrawingRectangle = false;
                newRoom.CheckOrientation();

                roomList.AddLast(newRoom);

                foreach (Room roomInList in roomList)
                {
                    if (roomInList.Intersects(newRoom) && roomInList != newRoom)
                    {
                        label1.Text = "Fehler: Räume dürfen sich nicht überschneiden!";
                        intersectsPreviousRooms = true;
                    }
                }

                if (intersectsPreviousRooms)
                {
                    RemoveRoom(newRoom);
                    roomList.Remove(newRoom);
                }
                else
                    label1.Text = "";

                RedrawRooms();
                newRoom = new Room();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isDrawingRectangle && current_state == (int)DESIGN_STATE.ROOM)
            {
                isDrawingRectangle = true;
                newRoom.BeginningPoint = (e as MouseEventArgs).Location;

            }
        }

        private void roomButton_Click(object sender, EventArgs e)
        {
            ClearButtonColor();
            this.current_state = (int)DESIGN_STATE.ROOM;
            roomButton.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            ClearButtonColor();
            this.current_state = (int)DESIGN_STATE.REMOVE_OBJECT;
            removeButton.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (this.current_state == (int)DESIGN_STATE.REMOVE_OBJECT)
            {
                Room selectedRoom = null;
                foreach (Room roomInList in roomList)
                {
                    if (roomInList.Contains((e as MouseEventArgs).Location))
                    {
                        selectedRoom = roomInList;
                        break;
                    }
                }

                if(selectedRoom != null)
                {
                    roomList.Remove(selectedRoom);
                    RemoveRoom(selectedRoom);
                    RedrawRooms();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearButtonColor();
            this.current_state = (int)DESIGN_STATE.DOOR;
            doorButton.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption);
        }



    }
}
