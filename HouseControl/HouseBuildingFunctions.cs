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
        
        private enum DESIGN_STATE { ROOM, REMOVE_OBJECT, DOOR, MOVE, SCALE, CONNECT, LIGHT, HEATER, MICROWAVE, FRIDGE, PC, TV }
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
            current_state = (int)DESIGN_STATE.MOVE;
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
                _g.DrawRectangle(p, new Rectangle(roomInList.BeginningPoint.X, roomInList.BeginningPoint.Y, roomInList.Width(), roomInList.Height()));
                                
            }
        }

        public void RedrawInterior(Graphics _g)
        {
            foreach (Room roomInList in roomList)
            {
                foreach (Interior items in roomInList.Interior)
                {
                    _g.FillRectangle(new SolidBrush(Color.White), new Rectangle(items.Position.X, items.Position.Y, items.Image.Width, items.Image.Height));
                    _g.DrawImage(items.Image, items.Position);
                }
            }
        }

        public void ClearDrawSpace(Graphics _g)
        {
            _g.FillRectangle(new SolidBrush(Color.White), new Rectangle(0, 0, 5000, 5000));
        }

        public void RemoveRoom(Room r, Graphics _g)
        {
            Pen p = new Pen(Color.White, penSize);
            SolidBrush b = new SolidBrush(Color.White);
            Graphics g = _g;
            r.ClearInterior();
            g.FillRectangle(b, new Rectangle(0,0, 5000, 5000));
            
            
        }

        //Is called to evaluate the last room placed by user;
        public bool CheckRoomCollision(Graphics _g)
        {
            bool intersectsPreviousRooms = false;

            isDrawingRectangle = false;
            newRoom.CheckOrientation();

            roomList.AddFirst(newRoom);

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

        public bool CheckInteriorCollision(Room _r, Interior _i, Point _p)
        {
            Rectangle overlapRec = new Rectangle(_p.X, _p.Y, _i.BoundingBox.Width, _i.BoundingBox.Height);
            if (_i.BoundingBox.IntersectsWith(overlapRec))
                return true;

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
                if (roomInList.IsWall(_p))
                {
                    selectedRoom = roomInList;
                    break;
                }
                else
                {
                    Interior selectedItem = null;
                    foreach (Interior item in roomInList.Interior)
                    {
                        if (item.BoundingBox.Contains(_p))
                            selectedItem = item;
                    }
                    if (selectedItem != null)
                    {
                        roomInList.Interior.Remove(selectedItem);
                        return true;
                    }
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

        public string DetermineInteriorGraphic(Graphics _g, Point _p, bool _connectionError)
        {
            Interior newItem = null;

            switch (current_state)
            {
                case (int) DESIGN_STATE.FRIDGE:
                    if (!_connectionError)
                        newItem = new Interior(Properties.Resources.fridgebig, _p);
                    else
                        newItem = new Interior(Properties.Resources.fridgeerror, Properties.Resources.fridgebig, _p);
                    break;

                case (int) DESIGN_STATE.HEATER:
                    if (!_connectionError)
                        newItem = new Interior(Properties.Resources.icon_heizung, _p);
                    else
                        newItem = new Interior(Properties.Resources.heizungerror, Properties.Resources.icon_heizung, _p);
                    break;

                case (int) DESIGN_STATE.LIGHT:
                    if (!_connectionError)
                        newItem = new Interior(Properties.Resources.lightbulbbig, _p);
                    else
                        newItem = new Interior(Properties.Resources.lightbulberror, Properties.Resources.lightbulbbig, _p);
                    break;

                case (int) DESIGN_STATE.MICROWAVE:
                    if (!_connectionError)
                        newItem = new Interior(Properties.Resources.Microwavebig, _p);
                    else
                        newItem = new Interior(Properties.Resources.Microwaveerror, Properties.Resources.Microwavebig, _p);
                    break;

                case (int) DESIGN_STATE.PC:
                    if (!_connectionError)
                        newItem = new Interior(Properties.Resources.PCbig, _p);
                    else
                        newItem = new Interior(Properties.Resources.pcerror, Properties.Resources.PCbig, _p);
                    break;

                case (int) DESIGN_STATE.TV:
                    if (!_connectionError)
                        newItem = new Interior(Properties.Resources.TVbig, _p);
                    else
                        newItem = new Interior(Properties.Resources.TVerror, Properties.Resources.TVbig, _p);
                    break;

                default:
                    break;

            }

            return PlaceInterior(_g, newItem, _p, _connectionError);
        }

        private string PlaceInterior(Graphics _g, Interior _i, Point _p, bool _connectionError)
        {
            foreach (Room roomInList in roomList)
            {
                if (roomInList.BoundingBox.Contains(_p))
                {
                    foreach (Interior item in roomInList.Interior)
                    {
                        if (CheckInteriorCollision(roomInList, item, _p))
                            return "Fehler: Objekte dürfen sich nicht überschneiden!";
                    }

                    _g.DrawImage(_i.Image, _p);
                    roomInList.AddInterior(_i.Image, _p);
                    if (_connectionError)
                        return "Fehler: Verbindung des Gerätes ist fehlgeschlagen!";
                    else
                        return "";
                }
            }
            return "Fehler: Geräte müssen innerhalb von Räumen platziert werden";
        }

        public string PlaceDoor(Graphics _g, Point _p)
        {
            //Determine the door graphics to be used by checking on which side of the room the user has clicked
            foreach (Room roomInList in roomList)
            {
                foreach (Interior item in roomInList.Interior)
                {
                    if (CheckInteriorCollision(roomInList, item, _p)) 
                        return "Fehler: Objekte dürfen sich nicht überschneiden!";
                }

                //upper or lower edge
                if ((Math.Abs(_p.Y - roomInList.BeginningPoint.Y) <= penSize/2
                    || Math.Abs(_p.Y - roomInList.EndPoint.Y) <= penSize/2)
                    && roomInList.BeginningPoint.X < _p.X
                    && roomInList.EndPoint.X > _p.X)
                {
                    _g.DrawImage(Properties.Resources.door_down, _p);
                    roomInList.AddInterior(Properties.Resources.door_down, _p);
                    return "";
                }
                
                //left or right edge                
                if ((Math.Abs(_p.X - roomInList.BeginningPoint.X) <= penSize/2
                    || Math.Abs(_p.X - roomInList.EndPoint.X) <= penSize/2)
                    && roomInList.BeginningPoint.Y < _p.Y
                    && roomInList.EndPoint.Y > _p.Y )
                {
                    _g.DrawImage(Properties.Resources.door_right, _p);
                    roomInList.AddInterior(Properties.Resources.door_right, _p);
                    return "";
                }
                
            }
            return "Fehler: Türen müssen an Wänden platziert werden!";
        }
    }
}
