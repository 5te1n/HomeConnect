using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseControl
{
    class Room
    {
        Point beginningPoint, endPoint;
        LinkedList<Interior> interior;

        internal LinkedList<Interior> Interior
        {
            get { return interior; }
        }

        private int offset = 6;

        public Point BeginningPoint{
            get { return beginningPoint; }
            set { beginningPoint = value;} 
        }

        public Rectangle BoundingBox
        {
            get { return new Rectangle(BeginningPoint, new Size(EndPoint.X - BeginningPoint.X, EndPoint.Y - BeginningPoint.Y)); }
        }

        public Point EndPoint 
        {
            get { return endPoint; } 
            set { endPoint = value;}
        }

        public int BeginningOffsetX
        {
            get { return beginningPoint.X + offset; }
        }

        public int BeginningOffsetY
        {
            get { return beginningPoint.Y + offset; }
        }

        public int EndOffsetX
        {
            get { return endPoint.X - offset; }
        }

        public int EndOffsetY
        {
            get { return endPoint.Y - offset; }
        }


        //TODO: Add Appliance Interface once implemented
                
        public Room()
        {
            beginningPoint = new Point();
            endPoint = new Point();
            interior = new LinkedList<Interior>();
        }

        public Room(Point _bP, Point _eP)
        {
            beginningPoint = _bP;
            endPoint = _eP;
        }

        public int Width
        {
            get { return Math.Abs(endPoint.X - beginningPoint.X); }
        }

        public int Height
        {
            get{return Math.Abs(endPoint.Y - beginningPoint.Y);}
        }

        public bool Contains(Point p)
        {
            return (p.X >= beginningPoint.X + offset
                && p.X <= endPoint.X - offset
                && p.Y >= beginningPoint.Y + offset
                && p.Y <= endPoint.Y - offset);
        }

        public bool Intersects(Room r)
        {
            Rectangle ri = new Rectangle(BeginningOffsetX, BeginningOffsetY, Width- offset, Height- offset);
            return ri.IntersectsWith(new Rectangle(r.BeginningOffsetX, r.BeginningOffsetY, r.Width - offset, r.Height - offset));
            /*
            return (Contains(r.BeginningPoint) 
                || Contains(r.EndPoint) 
                || Contains(new Point(r.BeginningPoint.X+Width(), r.BeginningPoint.Y)) 
                || Contains(new Point(r.EndPoint.X-Width(), r.EndPoint.Y)));*/
        }

        // Since EndPoint can be in any of the four rectangle corners while dragging, this
        // function is needed to return the UpperLeft point
        public Point ReturnDrawReferencePoint()
        {
            if (endPoint.Y < beginningPoint.Y)
            {
                if (endPoint.X < beginningPoint.X)
                {
                    return endPoint;
                }
                else
                {
                    return new Point(beginningPoint.X, endPoint.Y);
                }
            }
            else if (endPoint.X < beginningPoint.X)
            {
                return new Point(endPoint.X, beginningPoint.Y);
            }

            return beginningPoint;
        }

        
        public void CheckOrientation()
        {
            Point temp = beginningPoint;

            if (endPoint.Y < beginningPoint.Y)
            {
                if (endPoint.X < beginningPoint.X)
                {
                    beginningPoint = endPoint;
                    endPoint = temp;
                }
                else
                {
                    beginningPoint.Y = endPoint.Y;
                    endPoint.Y = temp.Y;
                }
            }
            else if (endPoint.X < beginningPoint.X)
            {
                beginningPoint.X = endPoint.X;
                endPoint.X = temp.X;
            }
        }

        public bool IsWall(Point _p)
        {
            return Math.Abs(_p.X - BeginningPoint.X) <= offset
                || Math.Abs(_p.Y - BeginningPoint.Y) <= offset
                || Math.Abs(_p.X - EndPoint.X) <= offset
                || Math.Abs(_p.Y - EndPoint.Y) <= offset;
        }

        public void AddInterior(Bitmap _g, Point _p, bool _d)
        {
            interior.AddFirst(new Interior(_g, _p, _d));
        }

        public void AddInterior(Interior _i)
        {
            interior.AddLast(_i);
        }

        public void ClearInterior()
        {
            interior = new LinkedList<Interior>();
        }
    }
}
