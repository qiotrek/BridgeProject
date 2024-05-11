using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProject
{
    public class Rectangle:Shape
    {
        private int x,y,width,height;
        public Rectangle(string parameters)
        {
            SetParameters(parameters, v => x = v, v => y = v, v => width = v, v => height = v);
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Blue, x,y,width,height);
        }
        public override string toXml()
        {
            return $"<Rectangle x=\"{x}\"  y=\"{y}\" width=\"{width}\" height=\"{height}\" />";
        }

        public override string ToString()
        {
            return $"Rectangle({x},{y},{width},{height})";
        }


    }
}
