using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProject
{
    class ShapeBridgeToXMLTextBox:ShapeBridge
    {
        private TextBox control;
        private StringBuilder sb;

        public ShapeBridgeToXMLTextBox(TextBox control)
        {
            this.control = control;
        }

        protected override void initialize()
        {
            sb = new StringBuilder().AppendLine("<shapes>");
        }
        protected override void finalize()
        {
            control.Text=sb.AppendLine("</shapes>").ToString();
        }

        protected override void proceed(Shape shape)
        {
            sb.Append("\t").AppendLine(shape.toXml());
        }
    }
}
