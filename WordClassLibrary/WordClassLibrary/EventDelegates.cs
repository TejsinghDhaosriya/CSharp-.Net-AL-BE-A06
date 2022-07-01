namespace WordClassLibrary
{
    public class  EventDelegates
    {
        public delegate void OnWord(string msg);
        public delegate void OnNumber(string msg);
        public delegate void OnJunk(string msg);

    }
}
