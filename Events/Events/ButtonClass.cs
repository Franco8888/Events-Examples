using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This class showcases how events work by simulating a button

namespace Events
{
    public class ButtonClass
    {
        public event EventHandler ClickEvent; // Events is of type EventHandler and need event keyword

        // This is our event firing method, aka the method that will call the invoke on the event which will in turn call event handler
        public void OnClick()
        {
            ClickEvent.Invoke(this, EventArgs.Empty);    // Invoke has 2 arguments. Sender adn EventArgs (aka information you are sending)
                                                         // we say this meaning it's coming from this class
        }
    }
}
