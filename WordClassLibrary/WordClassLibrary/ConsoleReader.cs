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

        public void Run()
        {
            while (true)
            {
                _console.WriteInput("Please enter word for console read , for stop please enter \'exit\'");
                var input = _console.GetInput();

                if (string.IsNullOrEmpty(input))
                {
                    _console.ClearScreen();
                    _console.WriteInput("Not Word Passed Please try Again ! ");
                    continue;
                }

                if ("exit".Equals(input, StringComparison.OrdinalIgnoreCase)) return;

                InputParser(input);

                _console.WriteInput("Press any key to continue...");
                _console.GetInput();
                _console.ClearScreen();
            }
        }

        public string InputParser(string input)
        {
            var r = new Regex("^[a-zA-Z0-9]*$");
            var handle = Event.GetInstance;
            string type;
            if (input.All(char.IsDigit))
            {
                EventDelegates.OnNumber delegateRef = handle.EventHandler;
                type = "OnNumber";
                delegateRef.Invoke("OnNumber called - Given string is numeric");
            }
            else if (r.IsMatch(input))
            {
                EventDelegates.OnWord delegateRef = handle.EventHandler;
                type = "OnWord";
                delegateRef.Invoke("OnWord called - Given string is alphanumeric");
            }
            else
            {
                EventDelegates.OnJunk delegateRef = handle.EventHandler;
                type = "OnJunk";
                delegateRef.Invoke("OnJunk called - Given string is other");
            }

            return type;
        }
    }
}