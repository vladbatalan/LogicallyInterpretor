
namespace LogicalSchemeManager
{
    class Condition : ICondition
    {
        private IExpression _firstExpression;
        private IExpression _secondExpression;
        private IRelationalOperator _relationalOperator;

        public Condition(IExpression firstExpression, IRelationalOperator relOperator, IExpression secondExpression)
        {
            _firstExpression = firstExpression;
            _secondExpression = secondExpression;
            _relationalOperator = relOperator;
        }

        public IExpression FirstExpression
        {
            get => _firstExpression;
            set => _firstExpression = value;
        }

        public IExpression SecondExpression
        {
            get => _secondExpression;
            set => _secondExpression = value;
        }

        public IRelationalOperator RelationalOperator
        {
            get => _relationalOperator;
            set => _relationalOperator = value;
        }

        public bool ExecuteCondition()
        {
            return RelationalOperator.ExecuteCondition(FirstExpression, SecondExpression);
        }


        public override string ToString()
        {
            return  _firstExpression.ToString() + " " + _relationalOperator.Operator_ + " " + _secondExpression.ToString();
        }
    }
}
