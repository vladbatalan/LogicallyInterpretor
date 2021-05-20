
namespace LogicalSchemeManager
{ 
    class Atribuire : ICommandType
    {
        private Variable _variabila;
        private IExpression _expresie;

        public Atribuire(Variable variabila, IExpression expresie)
        {
            _variabila = variabila;
            _expresie = expresie;
        }

        public Variable Variabila
        {
            get { return _variabila; }
            set { _variabila = value; }
        }

        public IExpression Expresie
        {
            get { return _expresie; }
            set { _expresie = value; }
        }

        public void Execute()
        {
            _variabila.Value = _expresie.Execute();
        }

        public bool GetNext()
        {
            return true;
        }

        public override string ToString()
        {
            return "Atribuire( " + _variabila.Name + " = " + _expresie.ToString() + " )";
        }
    }
}
