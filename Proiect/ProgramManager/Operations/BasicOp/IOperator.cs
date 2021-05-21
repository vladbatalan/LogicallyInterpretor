/**************************************************************************
 *                                                                        *
 *  File:        IOperator.cs                                             *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: Incapsulates all the arithmetic operators                *                              
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
     /// The interface incapsulates arithmetic operators such as +, -, * and /
     /// </summary>
    public interface IOperator
    {
        #region Abstract Properties
        /// <summary>
        /// Exposes the internal arithmetic operator
        /// </summary>
        public string Operator_
        {
            get;
            set;
        }
        #endregion Abstract Properties

        #region Abstract Methods
        /// <summary>
        /// Executes the operation on two given expressions
        /// </summary>
        /// <param name="firstTerm">The first expression term</param>
        /// <param name="secondTerm">the second expression term</param>
        /// <returns>The result of the operation</returns>
        double ExecuteOperation(IExpression firstTerm, IExpression secondTerm);
        #endregion Abstract Methods
    }
}
