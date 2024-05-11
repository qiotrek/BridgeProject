using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProject
{
    public abstract class ShapeBridge
    {
        protected abstract void initialize();
        protected abstract void proceed(Shape shape);
        protected abstract void finalize();

        public void proceed(List<Shape> shapes)
        {
            initialize();
            foreach (Shape shape in shapes)
            {
                proceed(shape);
            }
            finalize(); 
        }
    }
}
