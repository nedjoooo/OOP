using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentClass
{
    public class PropertyChanged : EventArgs
    {
        private object property;
        private object oldValue;
        private object newValue;

        public PropertyChanged(object property, object oldValue, object newValue)
        {
            this.property = property;
            this.oldValue = oldValue;
            this.newValue = newValue;
        }

        public object Property
        {
            get { return this.property; }
        }
        public object OldValue
        {
            get { return this.oldValue; }
        }
        public object NewValue
        {
            get { return this.newValue; }
        }

        
    }
}
