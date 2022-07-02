using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordClassLibrary
{
    public class ConsoleReader
    {
        private readonly IConsole _console;

        public ConsoleReader(IConsole iConsole)
        {
            _console = iConsole;
        }

        public void Run(EventDelegates.OnNumber onNumberDelegateRef,
            EventDelegates.OnWord onWordDelegateRef, EventDelegates.OnJunk onJunkDelegateRef)
        {
            while (true)
            {
                _console.WriteInput("Please enter word for console read , for stop please enter \'exit\'");
                var input = _console.GetInput();

                if (string.IsNullOrEmpty(input))
                {
                    _console.ClearScreen();
                    _console.WriteInput("No Word Passed Please try Again ! ");
                    continue;
                }

                if ("exit".Equals(input, StringComparison.OrdinalIgnoreCase)) return;

                InputParser(input,onNumberDelegateRef,onWordDelegateRef,onJunkDelegateRef);

                _console.WriteInput("Press any key to continue...");
                _console.GetInput();
                _console.ClearScreen();
            }
        }

        public string InputParser(string input, EventDelegates.OnNumber onNumberDelegateRef,
            EventDelegates.OnWord onWordDelegateRef, EventDelegates.OnJunk onJunkDelegateRe)
        {
            var r = new Regex("^[a-zA-Z0-9]*$");
            string type;
            if (input.All(char.IsDigit))
            {
                type = "OnNumber";
                onNumberDelegateRef.Invoke("OnNumber called - Given string is numeric");
            }
            else if (r.IsMatch(input))
            {
                type = "OnWord";
                onWordDelegateRef.Invoke("OnWord called - Given string is alphanumeric");
            }
            else
            {
                type = "OnJunk";
                onJunkDelegateRe.Invoke("OnJunk called - Given string is other");
            }

            return type;
        }
    }
}