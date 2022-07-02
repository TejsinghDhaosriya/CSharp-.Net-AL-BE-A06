
using WordClassLibrary;

namespace WordReaderConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var consoleReader = new ConsoleReader(new Console());
            consoleReader.Run();
        }
    }
}
