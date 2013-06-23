using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseControl
{
    class HouseBuildingFunctions
    {
        bool isDrawingRectangle;
        int penSize = 10;

        LinkedList<Room> roomList;          // Contains all the rooms that currently exist. Used for XML exporting
        Room newRoom;                       // Temporary room used when the user is drawing room rectangles.

        private enum DESIGN_STATE { ROOM, REMOVE_OBJECT, DOOR }
        int current_state;

        public bool IsDrawingRectangle
        {
            get { return isDrawingRectangle; }
        }

        public int InternalState
        {
            get { return current_state; }
            set { current_state = value; }
        }

        public HouseBuildingFunctions()
        {
            isDrawingRectangle = false;
            roomList = new LinkedList<Room>();
            current_state = (int)DESIGN_STATE.ROOM;
            newRoom = new Room();
        }

        public void DrawWalls(Graphics _g, Point _mousePosition)
        {
            Point upperLeft = newRoom.ReturnDrawReferencePoint();

            Pen p = new Pen(Color.White, penSize);
            Graphics g = _g;
            g.DrawRectangle(p, new Rectangle(upperLeft.X, upperLeft.Y, newRoom.Width(), newRoom.Height()));

            newRoom.EndPoint = _mousePosition;

            upperLeft = newRoom.ReturnDrawReferencePoint();


            p = new Pen(Color.Red, penSize);
            g.DrawRectangle(p, new Rectangle(upperLeft.X, upperLeft.Y, newRoom.Width(), newRoom.Height()));

            //RedrawRooms();
        }

        public void RedrawRooms(Graphics _g)
        {
            foreach (Room roomInList in roomList)
            {
                roomInList.CheckOrientation();
                Pen p = new Pen(Color.Black, penSize);
                Graphics g = _g;
                g.DrawRectangle(p, new Rectangle(roomInList.BeginningPoint.X, roomInList.BeginningPoint.Y, roomInList.Width(), roomInList.Height()));
                
            }
        }

        public void RemoveRoom(Room r, Graphics _g)
        {
            Pen p = new Pen(Color.White, penSize);
            Graphics g = _g;
            g.DrawRectangle(p, new Rectangle(r.BeginningPoint.X, r.BeginningPoint.Y, r.Width(), r.Height()));
            
        }

        public bool CheckRoomCollision(Graphics _g)
        {
            bool intersectsPreviousRooms = false;

            isDrawingRectangle = false;
            newRoom.CheckOrientation();

            roomList.AddLast(newRoom);

            foreach (Room roomInList in roomList)
            {
                if (roomInList.Intersects(newRoom) && roomInList != newRoom)
                    intersectsPreviousRooms = true;
            }

            if (intersectsPreviousRooms)
            {
                RemoveRoom(newRoom, _g);
                roomList.Remove(newRoom);
                newRoom = new Room();
                return true;
            }
            else
                newRoom = new Room();
                return false;
        }

        public void StartRoomMode(Point _p)
        {
            isDrawingRectangle = true;
            newRoom.BeginningPoint = _p;
        }

        public void SwitchState(int _i)
        {
            current_state = _i;
        }

        public bool RoomDeletion(Graphics _g, Point _p)
        {
            Room selectedRoom = null;
            foreach (Room roomInList in roomList)
            {
                if (roomInList.Contains(_p))
                {
                    selectedRoom = roomInList;
                    break;
                }
            }

            if (selectedRoom != null)
            {
                roomList.Remove(selectedRoom);
                RemoveRoom(selectedRoom, _g);
                return true;
            }

            return false;
        }

        public void PlaceDoor(Graphics _g, Point _p)
        {
            //Determine the door graphics to be used by checking on which side of the room the user has clicked
            foreach (Room roomInList in roomList)
            {
                //upper or lower edge
                if (Math.Abs(_p.Y - roomInList.BeginningPoint.Y) <= penSize
                    || Math.Abs(_p.Y - roomInList.EndPoint.Y) <= penSize
                    && Math.Abs(_p.X - roomInList.BeginningPoint.X) >= penSize
                    && Math.Abs(_p.X - roomInList.EndPoint.X) >= penSize)
                {
                    _g.DrawImage(Properties.Resources.door_down, _p);
                }

                //left or right edge                
                if (Math.Abs(_p.X - roomInList.BeginningPoint.X) <= penSize
                    || Math.Abs(_p.X - roomInList.EndPoint.X) <= penSize
                    && Math.Abs(_p.Y - roomInList.BeginningPoint.Y) >= penSize
                    && Math.Abs(_p.Y - roomInList.EndPoint.Y) >= penSize)
                {
                    _g.DrawImage(Properties.Resources.door_right, _p);
                }

            }
        }
    }
}
