/**************************************************************************
 *                                                                        *
 *  File:        Expression.cs                                            *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: This is a class that encapsulates a complex expression   *                              
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

namespace LogicalSchemeManager
{
    /// <summary>
    /// This class is a composite of expressions 
    /// </summary>
    public class Expression : IExpression 
    {
        #region Fields
        /// <summary>
        /// The first expression from this composite
        /// </summary>
        private IExpression _firstTerm;

        /// <summary>
        /// The second expression from this composite
        /// </summary>
        private IExpression _secondTerm;

        /// <summary>
        /// The operator of the complex expression
        /// </summary>
        private IOperator _operator;
        #endregion Fields

        #region Constructors
        /// <summary>
        /// The parameter constructor
        /// </summary>
        /// <param name="firstTerm">The first expression</param>
        /// <param name="operator_">The operator</param>
        /// <param name="secondTerm">The second expression</param>
        public Expression(IExpression firstTerm, IOperator operator_, IExpression secondTerm)
        {
            _firstTerm = firstTerm;
            _secondTerm = secondTerm;
            _operator = operator_;

        }
        #endregion Constructors

        #region Properties
        /// <summary>
        /// Property that exposes the first expression
        /// </summary>
        public IExpression FirstTerm
        {
            get => _firstTerm;
            set => _firstTerm = value;
        }

        /// <summary>
        /// Property that exposes the second expression
        /// </summary>
        public IExpression SecondTerm
        {
            get => _secondTerm;
            set => _secondTerm = value;
        }
        #endregion Properties

        #region Methods
        /// <summary>
        /// This method executes the operation inside the expression
        /// </summary>
        /// <returns>The result of the operation</returns>
        public double Execute()
        {
            return _operator.ExecuteOperation(FirstTerm, SecondTerm);
        }

        /// <summary>
        /// Override Method to show the representative elements of the expression
        /// </summary>
        /// <returns> A string that contains the represetative elements of the expression</returns>
        public override string ToString()
        {
            return "(" + _firstTerm.ToString() + " " + _operator.Operator_ + " " + _secondTerm.ToString() + ")";
        }
        #endregion Methods
    }
}
