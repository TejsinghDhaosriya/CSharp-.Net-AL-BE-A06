using WordClassLibrary;

namespace WordReaderTestProject;

public class ConsoleStub : IConsole
{
    private int _counter;
    public bool IsScreenClear { get; set; }
    public int CountWriteInput { get; set; }

    public string? Input { get; set; }

    public string? GetInput()
    {
        if (_counter >= 1) return "exit";
        _counter += 1;
        return Input;

    }

    public void WriteInput(string data)
    {
        CountWriteInput += 1;
    }

    public void ClearScreen()
    {
        IsScreenClear = true;
    }
}