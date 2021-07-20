using System;
using System.Collections.Generic;
using System.Text;

namespace TareaNum8.ControlItem
{
    class ComboBoxItem
    {
        public string Text { get; set; }
        public object Value { get; set; }
        public override string ToString()
        {
            return Text;
        }
    }
}
