/**************************************************************************
 *                                                                        *
 *  File:        IRelationalOperators.cs                                  *
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

namespace LogicalSchemeManager
{
    /// <summary>
    /// The interface is incapsulating a realtional operator such as >=, >, <, <=, ==, !=
    /// </summary>
    public interface IRelationalOperator
    {
        #region Abstract Properties
        /// <summary>
        /// Property that provide access to the internal operator
        /// </summary>
        public string Operator_
        {
            get;
            set;
        }
        #endregion Abstract Properties

        #region Abstract Methods
        /// <summary>
        /// Abstract method that execute the relational operation between two expressions
        /// </summary>
        /// <param name="firstExpression">The first expression term</param>
        /// <param name="secondExpression">The second expression term</param>
        /// <returns>The result of the operation</returns>
        bool ExecuteCondition(IExpression firstExpression, IExpression secondExpression);
        #endregion Abstract Methods


    }
}
