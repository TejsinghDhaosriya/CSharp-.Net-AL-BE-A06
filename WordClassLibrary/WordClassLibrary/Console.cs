using static System.Console;

namespace WordClassLibrary
{
    public class Console:IConsole
    {
        public string GetInput()
        {
           return ReadLine();
        }

        public void WriteInput(string data)
        {
            WriteLine(data);
        }

        public void ClearScreen()
        {
            Clear();
        }
    }
}
