using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionBasedEventExample
{
    public class EventHandler
    {
        // Declare an event of type Func<Task>
        public event Func<Task> FunctionEvent;

        // Method to raise the event
        public async Task TriggerEventChanged()
        {
            Func<Task> pEventChanged = FunctionEvent;
            if (pEventChanged != null)
            {
                await pEventChanged();
            }
        }
    }

    public class Subscriber
    {
        // Method to be executed when the event is raised
        public async Task HandleEventAsync()
        {
            Console.WriteLine("Event handled asynchronously");
            await Task.Delay(2000); // Simulating some asynchronous operation
        }
    }
}
