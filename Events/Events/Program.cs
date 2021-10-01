using System;

// Event is encapsulated delegate:

/*
        public delegate void Notify();  // delegate

        public class ProcessBusinessLogic
        {
            public event Notify ProcessCompleted; // event

        }
*/

//Steps to make an event
//1. In your class that you want to promt the event Make event variable - have event keyword and of type EventHandler
//2. In that class make event firing method that will call the invoke on the event
//3. In your class that uses the event create object of the class that holds the event
//4. write event handler method which will be invoked when event is fired
//5. Bind event to Event Handler method

// Note: If you have a classes that uses your event you need to inherit IDisposable and
// make sure the class has the following method:
/*
        public void Dispose()
        {
            YourClassThatHostsYourEvent.YourEvent -= YourEvent;
        }
*/

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {

            // ------------------------------------------------------------------------------------------------------------------------------------------------------------ //
            // Example 1 - Using the ButtonClass event, i.e. simulating a button clicked
            // ------------------------------------------------------------------------------------------------------------------------------------------------------------ //

            // This is where you want to use your event
            ButtonClass button = new();     // Create object of the class where your event is
            button.ClickEvent += MyEventHandler;  // this is tying up the event to EventHandler method so 
                                                  // that when event is invoked then method is fired

            Console.WriteLine("Press A to simulate a button click");

            var key = Console.ReadLine();
            if(key == "a")
            {
                KeyPressed();
            }
            
            void KeyPressed()
            {
                button.OnClick();   // Here we calling the event firing method that invokes the event and invoking will call the event handelr method
            }

            // our event handler - Every event should have a method that handles the event
            // handle or what to do when the event is invoked
            // IN the invoke method we give 2 arguments so this method is expecting 2 argument, the sender and EventArguments
            void MyEventHandler(object sender, EventArgs e)     // Note you dont make this method public or private
            {
                Console.WriteLine("You clicked the button");
            }


            // ------------------------------------------------------------------------------------------------------------------------------------------------------------ //
            // Example 2 - Passing argument - This example showcases passing argument using events
            // ------------------------------------------------------------------------------------------------------------------------------------------------------------ //

            MyEventClass obj = new();
            obj.myEvent += DoStuff;

            obj.EventFireMethod("dude", 8);

            //Event Handler
            static void DoStuff(object sender, MyEventArgument args)    // Now for the vent handler insted of EventArgs you need your class
                                                                        // that inheritied from EventArgs
            {
                var data1 = args.Data1;
                var data2 = args.Data2;
                Console.WriteLine($"arg1: {data1}, arg2: {data2}");
            }

            // ------------------------------------------------------------------------------------------------------------------------------------------------------------ //
            // Example 3 - Location Changed using NavigationManager
            // ------------------------------------------------------------------------------------------------------------------------------------------------------------ //

            NavManager navManager = new();
            navManager.RouteChanged += RouteChangeHandler;

            void RouteChangeHandler(object s, EventArgs e)
            {
                Console.WriteLine("Route has changed");     //Thus when the route has changed then this will fire
            }


        }

    }
}
