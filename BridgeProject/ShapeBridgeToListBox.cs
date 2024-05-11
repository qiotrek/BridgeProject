using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeProject
{
    class ShapeBridgeToListBox :ShapeBridge
    {
        private ListBox control;
        public ShapeBridgeToListBox(ListBox control) 
        {
            this.control=control;
        }

        protected override void initialize()
        {
            control.Items.Clear();
        }
        protected override void finalize()
        {
            control.SelectedIndex=control.Items.Count-1;
        }

        protected override void proceed(Shape shape)
        {
            control.Items.Add(shape.ToString());
        }

    }
}
