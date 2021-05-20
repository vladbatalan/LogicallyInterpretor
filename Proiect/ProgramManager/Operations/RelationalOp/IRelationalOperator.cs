

namespace LogicalSchemeManager
{
    public interface IRelationalOperator
    {
        bool ExecuteCondition(IExpression firstExpression, IExpression secondExpression);
        public string Operator_
        {
            get;
            set;
        }
    }
}
