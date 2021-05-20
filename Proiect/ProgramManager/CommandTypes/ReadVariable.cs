

namespace LogicalSchemeManager
{
    class ReadVariable : ICommandType
    {
        private Variable _variabila;
        private ITerminalEntity _terminal;
        public ReadVariable(Variable variabila, ITerminalEntity terminal)
        {
            _variabila = variabila;
            _terminal = terminal;
        }

        public Variable Variabila
        {
            get { return _variabila; }
            set { _variabila = value; }
        }

        public ITerminalEntity Terminal
        {
            get { return _terminal; }
            set { _terminal = value; }
        }

        public void Execute()
        {
            _variabila.Value = double.Parse(_terminal.ReadFromTerminal());
        }

        public bool GetNext()
        {
            return true;
        }

        public override string ToString()
        {
            return "ReadVariable( " + _variabila.Name + " )";
        }
    }
}
