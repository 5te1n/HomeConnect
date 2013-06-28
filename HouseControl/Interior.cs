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

        public Bitmap Image
        {
            get { return image; }
            set { image = value; }
        }

        public Interior(Bitmap _g, Point _p)
        {
            image = _g;
            position = _p;
            boundingBox = new Rectangle(_p.X, _p.Y, _g.Width, _g.Height);
        }
    }
}
