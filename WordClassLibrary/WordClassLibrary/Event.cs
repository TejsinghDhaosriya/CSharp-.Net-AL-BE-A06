using static System.Console;

namespace WordClassLibrary
{
    public sealed class Event
    {
        private static Event _instance;

        private Event(){}

        public static Event GetInstance => _instance ?? (_instance = new Event());

        public void EventHandler(string msg)
        {
            WriteLine(msg);
        }
    }
}
