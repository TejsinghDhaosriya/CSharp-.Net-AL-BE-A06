
using WordClassLibrary;

namespace WordReaderConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var instance = Event.GetInstance;
            var consoleReader = new ConsoleReader(new Console());

            consoleReader.Run(instance.EventHandler,instance.EventHandler,instance.EventHandler);
        }
    }
}
