using WordClassLibrary;

namespace WordReaderTestProject;

public class ConsoleStub : IConsole
{
    private int _counter;

    public string GetIntput()
    {
        if (_counter < 1)
        {
            _counter += 1;
            return "abc";
        }

        return "exit";
    }

    public void WriteInput(string data)
    {
    }

    public void ClearScreen()
    {
    }
}