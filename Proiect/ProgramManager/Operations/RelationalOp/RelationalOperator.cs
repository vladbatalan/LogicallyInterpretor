/**************************************************************************
 *                                                                        *
 *  File:        RelationalOperatos.cs                                    *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: Contains all the Relational operators                    *                              
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;

namespace LogicalSchemeManager
{
    /// <summary>
    /// The Class is incapsulating a realtional operator such as >=, >, <, <=, ==, !=
    /// </summary>
    public class RelationalOperator : IRelationalOperator
    {
        #region Fields
        /// <summary>
        /// The relational operator
        /// </summary>
        private string _operator;
        #endregion Fields

        #region Constructors
        /// <summary>
        /// The parameter constructor
        /// </summary>
        /// <param name="operator_">The internal operator as a string</param>
        public RelationalOperator(String operator_)
        {
            _operator = operator_;
        }
        #endregion Constructors

        #region Properties
        /// <summary>
        /// This property offer acces to the internal operator
        /// </summary>
        public string Operator_
        {
            get => _operator;
            set => _operator = value;
        }
        #endregion Properties

        #region Methods
        /// <summary>
        /// Compares two given expressions using the internal operator
        /// </summary>
        /// <param name="firstExpression">The first expression term</param>
        /// <param name="secondExpression">The second expression term</param>
        /// <returns>The result of the operation</returns>
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
                    throw new Exception("Wrong relational operator! It must be one of ('<', '<=', '==', '>', '>=', '!=').");
            }

        }
        #endregion Methods
    }
}
