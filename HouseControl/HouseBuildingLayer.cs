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
        LinkedList<Room> roomList;    // Contains all the rooms that currently exist. Used for XML exporting
        Room newRoom;                       // Temporary room used when the user is drawing room rectangles.

        public HouseBuildingLayer()
        {
            isDrawingRectangle = false;
            roomList = new LinkedList<Room>();
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

                Pen p = new Pen(Color.White, 2);
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                g.DrawRectangle(p, new Rectangle(upperLeft.X, upperLeft.Y, newRoom.Width(), newRoom.Height()));

                newRoom.EndPoint = e.Location;

                upperLeft = newRoom.ReturnDrawReferencePoint();


                p = new Pen(Color.Red, 2);
                g.DrawRectangle(p, new Rectangle(upperLeft.X, upperLeft.Y, newRoom.Width(), newRoom.Height()));

                this.Refresh();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawingRectangle = false;
            newRoom.CheckOrientation();

            roomList.AddLast(newRoom);

            newRoom = new Room();
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isDrawingRectangle)
            {
                isDrawingRectangle = true;
                newRoom.BeginningPoint = (e as MouseEventArgs).Location;

            }
        }



    }
}
