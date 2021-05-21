/**************************************************************************
 *                                                                        *
 *  File:        Condition.cs                                             *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: The class incapsulates a condition that can be evaluated *
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
    /// The class incapsulates a condition that can be evaluated
    /// </summary>
    class Condition : ICondition
    {
        #region Fields
        /// <summary>
        /// The first expression from the condition
        /// </summary>
        private IExpression _firstExpression;

        /// <summary>
        /// The second expression from the condition
        /// </summary>
        private IExpression _secondExpression;

        /// <summary>
        /// The relational operator
        /// </summary>
        private IRelationalOperator _relationalOperator;
        #endregion Fields


        #region Constructors
        /// <summary>
        /// The parameter constructor
        /// </summary>
        /// <param name="firstExpression">The left term of the condition</param>
        /// <param name="relOperator">The relational operator of the condition</param>
        /// <param name="secondExpression">The right term of the condition</param>
        public Condition(IExpression firstExpression, IRelationalOperator relOperator, IExpression secondExpression)
        {
            _firstExpression = firstExpression;
            _secondExpression = secondExpression;
            _relationalOperator = relOperator;
        }
        #endregion

        #region Properties
        /// <summary>
        /// The property exposes the left term of the condition
        /// </summary>
        public IExpression FirstExpression
        {
            get => _firstExpression;
            set => _firstExpression = value;
        }

        /// <summary>
        /// The property exposes the right term of the condition
        /// </summary>
        public IExpression SecondExpression
        {
            get => _secondExpression;
            set => _secondExpression = value;
        }

        /// <summary>
        /// The property exposes the RelationalOperator of the condition
        /// </summary>
        public IRelationalOperator RelationalOperator
        {
            get => _relationalOperator;
            set => _relationalOperator = value;
        }
        #endregion Properties

        #region Methods
        /// <summary>
        /// The execution of the method returns the boolean result of the condition
        /// </summary>
        /// <returns>The boolean result of the condition</returns>
        public bool ExecuteCondition()
        {
            return RelationalOperator.ExecuteCondition(FirstExpression, SecondExpression);
        }

        /// <summary>
        /// The override method returns a string that describes the elements of the condition
        /// </summary>
        /// <returns>String that descrribes the content of the class</returns>
        public override string ToString()
        {
            return  _firstExpression.ToString() + " " + _relationalOperator.Operator_ + " " + _secondExpression.ToString();
        }
        #endregion Methods
    }
}
