using WordClassLibrary;
using static WordClassLibrary.Event;

namespace WordReaderTestProject;

public class ConsoleReaderTest
{
    [Fact]
    public void ShouldRunInputParserReturnOnWordWhenInputIsAlphabets()
    {
        var input = "abc";
        var instance = GetInstance;
        var console = new ConsoleReader(new ConsoleStub());
        var res = console.InputParser(input, instance.EventHandler, instance.EventHandler, instance.EventHandler);

        Assert.Equal("OnWord", res);
    }

    [Fact]
    public void ShouldRunInputParserReturnOnNumberWhenInputIsNumeric()
    {
        var input = "123";
        var instance = GetInstance;
        var console = new ConsoleReader(new ConsoleStub());
        var res = console.InputParser(input, instance.EventHandler, instance.EventHandler, instance.EventHandler);

        Assert.Equal("OnNumber", res);
    }

    [Fact]
    public void ShouldRunInputParserReturnOnWordWhenInputIsAlphaNumeric()
    {
        var input = "abc123";
        var instance = GetInstance;
        var console = new ConsoleReader(new ConsoleStub());
        var res = console.InputParser(input, instance.EventHandler, instance.EventHandler, instance.EventHandler);


        Assert.Equal("OnWord", res);
    }

    [Fact]
    public void ShouldRunInputParserReturnOnJunkWhenInputIsSymbols()
    {
        var input = "$%$";
        var instance = GetInstance;
        var console = new ConsoleReader(new ConsoleStub());
        var res = console.InputParser(input, instance.EventHandler, instance.EventHandler, instance.EventHandler);


        Assert.Equal("OnJunk", res);
    }

    [Fact]
    public void ShouldRunInputParserReturnOnJunkWhenInputIsSymbolsAndNumbers()
    {
        var input = "$%$123";
        var instance = GetInstance;
        var console = new ConsoleReader(new ConsoleStub());
        var res = console.InputParser(input, instance.EventHandler, instance.EventHandler, instance.EventHandler);


        Assert.Equal("OnJunk", res);
    }

    [Fact]
    public void ShouldRunInputParserReturnOnJunkWhenInputIsSymbolsAndAlphabets()
    {
        var input = "abcdef$%$";
        var instance = GetInstance;
        var console = new ConsoleReader(new ConsoleStub());
        var res = console.InputParser(input, instance.EventHandler, instance.EventHandler, instance.EventHandler);


        Assert.Equal("OnJunk", res);
    }

    [Fact]
    public void ShouldRunInputParserReturnOnJunkWhenInputIsSymbolsAndAlphaNumberic()
    {
        var input = "abc123$%$";
        var instance = GetInstance;
        var console = new ConsoleReader(new ConsoleStub());
        var res = console.InputParser(input, instance.EventHandler, instance.EventHandler, instance.EventHandler);


        Assert.Equal("OnJunk", res);
    }

    [Fact]
    public void ShouldContinueRunConsoleReaderWhenNoInputIsPassed()
    {
        var consoleStub = new ConsoleStub
        {
            Input = null
        };
        var console = new ConsoleReader(consoleStub);
        var instance = GetInstance;
        console.Run(instance.EventHandler, instance.EventHandler, instance.EventHandler);
    
        Assert.Equal(3,consoleStub.CountWriteInput);
        Assert.True(consoleStub.IsScreenClear);
    }
    
    [Fact]
    public void ShouldRunConsoleReaderWithoutAnyError()
    {
    
        var consoleStub = new ConsoleStub
        {
            Input = "abc"
        };
        var console = new ConsoleReader(consoleStub);
        var instance = GetInstance;
        console.Run(instance.EventHandler, instance.EventHandler, instance.EventHandler);
        Assert.Equal(3, consoleStub.CountWriteInput);
        Assert.True(consoleStub.IsScreenClear);
    }
}