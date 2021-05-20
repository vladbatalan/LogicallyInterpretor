
namespace LogicalSchemeManager
{
    interface ITerminalEntity
    {
        public string ReadFromTerminal();
        public void WriteToTerminal(string text);
    }
}
