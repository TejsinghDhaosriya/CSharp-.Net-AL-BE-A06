using System;

namespace WordClassLibrary
{
    public class Event
    {
        public Event(){}


        public void EventHandler(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
