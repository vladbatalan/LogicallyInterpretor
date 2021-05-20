
namespace LogicalSchemeManager
{
    class Expression : IExpression
    {
        private IExpression _firstTerm;
        private IExpression _secondTerm;
        private IOperator _operator;

        public Expression(IExpression firstTerm, IOperator operator_, IExpression secondTerm)
        {
            _firstTerm = firstTerm;
            _secondTerm = secondTerm;
            _operator = operator_;

        }

        public IExpression FirstTerm
        {
            get => _firstTerm;
            set => _firstTerm = value;
        }
        public IExpression SecondTerm
        {
            get => _secondTerm;
            set => _secondTerm = value;
        }

        public double Execute()
        {
            return _operator.ExecuteOperation(FirstTerm, SecondTerm);
        }

        public override string ToString()
        {
            return "(" + _firstTerm.ToString() + " " + _operator.Operator_ + " " + _secondTerm.ToString() + ")";
        }
    }
}
