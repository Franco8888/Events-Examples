using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class MyEventClass
    {
        public event EventHandler<MyEventArgument> myEvent;   //Event that will be able to send data with it

        public void EventFireMethod(string myStr, int myInt)
        {
            MyEventArgument eventArgs = new() { Data1 = myStr, Data2 = myInt };     // Populate Event Args Data
            myEvent.Invoke(this, eventArgs);
        }
    }

    class MyEventArgument : EventArgs // We will use this class to pass multiple argument with our event
                                      // thus let your class inherit from EventArgs giving it the same functionality
    {
        public string Data1 { get; set; }

        public int Data2 { get; set; }
    }
}
