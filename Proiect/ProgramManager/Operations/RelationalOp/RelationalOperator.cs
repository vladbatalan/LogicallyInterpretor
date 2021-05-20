
using System;

namespace LogicalSchemeManager
{
    class RelationalOperator : IRelationalOperator
    {
        private string _operator;
        public RelationalOperator(String operator_)
        {
            _operator = operator_;
        }

        public string Operator_
        {
            get => _operator;
            set => _operator = value;
        }

        public bool ExecuteCondition(IExpression firstExpression, IExpression secondExpression)
        {
            switch (Operator_)
            {
                case "<":
                    return firstExpression.Execute() < secondExpression.Execute();
                case "<=":
                    return firstExpression.Execute() <= secondExpression.Execute();
                case "==":
                    return firstExpression.Execute() == secondExpression.Execute();
                case ">":
                    return firstExpression.Execute() > secondExpression.Execute();
                case ">=":
                    return firstExpression.Execute() >= secondExpression.Execute();
                case "!=":
                    return firstExpression.Execute() != secondExpression.Execute();
                default:
                    return false;
            }

        }
    }
}
