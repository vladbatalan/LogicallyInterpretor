using System;

namespace LogicalSchemeManager
{
    public class ConsoleObject : ITerminalEntity, IObserver
    {
        public void Notify(string text)
        {
            WriteToTerminal(text);
        }

        public string ReadFromTerminal()
        {
            return Console.ReadLine();
        }

        public void WriteToTerminal(string text)
        {
            Console.WriteLine(text);
        }
    }
}
