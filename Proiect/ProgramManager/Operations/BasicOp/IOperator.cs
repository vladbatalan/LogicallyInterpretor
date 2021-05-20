

namespace LogicalSchemeManager
{
    public interface IOperator
    {
        double ExecuteOperation(IExpression firstTerm, IExpression secondTerm);

        public string Operator_
        {
            get;
            set;
        }
    }
}
