

namespace LogicalSchemeManager
{
    class Eticheta : ICommandType
    {
        private string _name;

        public Eticheta(string nume)
        {
            _name = nume;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public void Execute()
        {
            // nothing to pe done here
        }

        public bool GetNext()
        {
            return true;
        }

        public override string ToString()
        {
            return "Eticheta( " + _name + " )";
        }
    }
}
