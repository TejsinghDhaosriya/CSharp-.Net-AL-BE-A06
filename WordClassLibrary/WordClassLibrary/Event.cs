using static System.Console;

namespace WordClassLibrary
{
    public class Event
    {
        public Event(){}


        public void EventHandler(string msg)
        {
            WriteLine(msg);
        }
    }
}
