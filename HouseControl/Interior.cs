using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseControl
{
    class Interior
    {
        private Rectangle boundingBox;

        public Rectangle BoundingBox
        {
            get { return boundingBox; }
        }
        private Point position;

        public Point Position
        {
            get { return position; }
            set { position = value; }
        }
        private Bitmap image;
        private Bitmap altImage;
        public Bitmap Image
        {
            get { return image; }
            set { image = value; }
        }

        private bool isConnected;

        public Interior(Bitmap _b, Point _p)
        {
            image = _b;
            altImage = null;
            position = _p;
            isConnected = true;
            boundingBox = new Rectangle(_p.X, _p.Y, _b.Width, _b.Height);
        }

        // _b is the image used for a disconnected item
        public Interior(Bitmap _b, Bitmap _alt, Point _p)
        {
            image = _b;
            altImage = _alt;
            position = _p;
            isConnected = false;
            boundingBox = new Rectangle(_p.X, _p.Y, _b.Width, _b.Height);
        }

        //used for simulating the connection of items
        public void SwitchImage()
        {
            if (!isConnected)
            {
                Bitmap temp = image;
                image = altImage;
                altImage = temp;
            }
        }
    }
}
