using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProject
{
    public abstract class ShapeFactory
    {
        private delegate Shape ShapeMaker(string parameters);
        private static Dictionary<string, ShapeMaker> map = new Dictionary<string, ShapeMaker>()
        {
            { "Triangle",(p)=> new ShapeTriangle(p)},
            { "Rectangle",(p)=> new Rectangle(p)},
            { "Circle",(p)=> new ShapeCircle(p)},
        };
        public static  readonly string[] Keys= map.Keys.OrderBy(x=>x).ToArray();
        public static Shape make(string kind, string parameters)
        {
            return map[kind](parameters);
        }
    }
}
