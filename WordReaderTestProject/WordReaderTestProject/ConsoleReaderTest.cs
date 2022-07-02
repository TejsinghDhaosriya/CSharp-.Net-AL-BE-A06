using WordClassLibrary;

namespace WordReaderTestProject;

public class ConsoleReaderTest
{
    [Fact]
    public void ShouldRunInputParserReturnOnWordWhenInputIsAlphabets()
    {
        var input = "abc";
        var console = new ConsoleReader(new ConsoleStub());
        var res = console.InputParser(input);

        Assert.Equal("OnWord", res);
    }

    [Fact]
    public void ShouldRunInputParserReturnOnNumberWhenInputIsNumeric()
    {
        var input = "123";
        var console = new ConsoleReader(new ConsoleStub());
        var res = console.InputParser(input);

        Assert.Equal("OnNumber", res);
    }

    [Fact]
    public void ShouldRunInputParserReturnOnWordWhenInputIsAlphaNumeric()
    {
        var input = "abc123";
        var console = new ConsoleReader(new ConsoleStub());
        var res = console.InputParser(input);

        Assert.Equal("OnWord", res);
    }

    [Fact]
    public void ShouldRunInputParserReturnOnJunkWhenInputIsSymbols()
    {
        var input = "$%$";
        var console = new ConsoleReader(new ConsoleStub());
        var res = console.InputParser(input);

        Assert.Equal("OnJunk", res);
    }

    [Fact]
    public void ShouldRunInputParserReturnOnJunkWhenInputIsSymbolsAndNumbers()
    {
        var input = "$%$123";
        var console = new ConsoleReader(new ConsoleStub());
        var res = console.InputParser(input);

        Assert.Equal("OnJunk", res);
    }

    [Fact]
    public void ShouldRunInputParserReturnOnJunkWhenInputIsSymbolsAndAlphabets()
    {
        var input = "abcdef$%$";
        var console = new ConsoleReader(new ConsoleStub());
        var res = console.InputParser(input);

        Assert.Equal("OnJunk", res);
    }

    [Fact]
    public void ShouldRunInputParserReturnOnJunkWhenInputIsSymbolsAndAlphaNumberic()
    {
        var input = "abc123$%$";
        var console = new ConsoleReader(new ConsoleStub());
        var res = console.InputParser(input);

        Assert.Equal("OnJunk", res);
    }

    [Fact]
    public void ShouldRunConsoleReaderWithoutAnyError()
    {
        var console = new ConsoleReader(new ConsoleStub());
        console.Run();
    }
}