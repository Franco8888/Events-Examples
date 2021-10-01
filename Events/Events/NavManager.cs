using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class NavManager
    {
        private readonly NavigationManager _navManager;

        public event EventHandler<LocationChangedEventArgs> RouteChanged
        {
            add => _navManager.LocationChanged += value;    // This is basically your event firing method that invokes your event. 
                                                            // Note that Locationchanged and your event is of the same type, i.e. EventHandler<LocationChangedEventARgs>
                                                            // So using add keyword to add an event firing function to your event without writing it yourself
            remove => _navManager.LocationChanged -= value;
        }   // Event
    }
}
