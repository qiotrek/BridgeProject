using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProject
{
    public class ShapeTriangle:Shape
    {
        private int ax,ay,bx,by,cx,cy;
        public ShapeTriangle(string parameters)
        {
            SetParameters(parameters, v => ax = v, v => ay = v, v => bx = v, v => by = v, v => cx = v, v => cy = v);
        }

        public override void Draw(Graphics g)
        {
            g.DrawPolygon(Pens.Green,new Point[] { new Point(ax, ay), new Point(bx, by), new Point(cx, cy) });
        }
        public override string toXml()
        {
            return $"<triangle ax=\"{ax}\" ay=\"{ay}\" bx=\"{bx}\" by=\"{by}\" cx=\"{cx}\" cy=\"{cy}\" />";
        }

        public override string ToString()
        {
            return $"Triangle({ax},{ay},{bx},{by},{cx},{cy})";
        }
    }
}
