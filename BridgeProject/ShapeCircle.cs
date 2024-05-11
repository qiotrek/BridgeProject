using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProject
{
    public class ShapeCircle:Shape
    {
        private int cy, cx, r;
        public ShapeCircle(string parameters)
        {
            SetParameters(parameters,v=>cx=v,v=>cy=v,v=>r=v);
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.Red, cx - r, cy - r, 2 * r, 2 * r);   
        }
        public override string toXml()
        {
            return $"<circle cy=\"{cy}\" cx=\"{cx}\" r=\"{r}\" />";
        }

        public override string ToString()
        {
            return $"Circle({cx},{cy},{r})";
        }
    }
}
