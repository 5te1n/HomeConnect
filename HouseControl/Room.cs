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

        public Point BeginningPoint{
            get { return beginningPoint; }
            set { beginningPoint = value;} 
        }

        public Point EndPoint 
        {
            get { return endPoint; } 
            set { endPoint = value;}
        }

        //TODO: Add Appliance Interface once implemented
                
        public Room()
        {
            beginningPoint = new Point();
            endPoint = new Point();
        }

        public Room(Point _bP, Point _eP)
        {
            beginningPoint = _bP;
            endPoint = _eP;
        }

        public int Width()
        {
            return Math.Abs(endPoint.X - beginningPoint.X);
        }

        public int Height()
        {
            return Math.Abs(endPoint.Y - beginningPoint.Y);
        }

        public bool Contains(Point p)
        {
            return (p.X > beginningPoint.X
                && p.X < endPoint.X
                && p.Y > beginningPoint.Y
                && p.Y < endPoint.Y);
        }

        // Since EndPoint can be in any of the four rectangle corners while dragging, this
        // function is needed to return the 
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
    }
}
