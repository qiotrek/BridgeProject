using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProject
{
    class ShapeBridgeToPictureBox:ShapeBridge
    {


        private PictureBox control;
        private Bitmap bmp;
        private Graphics graphics;
        public ShapeBridgeToPictureBox(PictureBox control)
        {
            this.control = control;
        }

        protected override void initialize()
        {
            bmp = new Bitmap(control.Width, control.Height);
            graphics = Graphics.FromImage(bmp);
        }
        protected override void finalize()
        {
            control.Image=bmp;
        }

        protected override void proceed(Shape shape)
        {
           shape.Draw(graphics);
        }
    }
}
