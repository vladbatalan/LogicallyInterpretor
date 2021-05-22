/**************************************************************************
 *                                                                        *
 *  File:        Operator.cs                                              *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: Contains all the arithmetic operators                    *                              
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
    /// The class incapsulates arithmetic operators such as +, -, * and /
    /// </summary>
    public class Operator : IOperator
    {
        #region Fields
        /// <summary>
        /// The internal operator used
        /// </summary>
        private string _operator;
        #endregion Fields

        #region Constructors
        /// <summary>
        /// The parameter constructor
        /// </summary>
        /// <param name="oper">The operation incapsulated given as a string</param>
        public Operator(String oper)
        {
            _operator = oper;
        }
        #endregion Constructors

        #region Properties
        /// <summary>
        /// The property exposes the internal arithmetic operator
        /// </summary>
        public string Operator_
        {
            get => _operator;
            set => _operator = value;
        }
        #endregion

        #region Methods
        /// <summary>
        /// Executes the operation on two given expressions
        /// </summary>
        /// <param name="firstTerm">The first expression term</param>
        /// <param name="secondTerm">the second expression term</param>
        /// <returns>The result of the operation</returns>
        public double ExecuteOperation(IExpression firstTerm, IExpression secondTerm)
        {
            switch (_operator)
            {
                case "+":
                    return firstTerm.Execute() + secondTerm.Execute();
                case "-":
                    return firstTerm.Execute() - secondTerm.Execute();
                case "*":
                    return firstTerm.Execute() * secondTerm.Execute();
                case "/":
                    double second = secondTerm.Execute();
                    if(second == 0)
                    {
                        throw new ArithmeticException("Cannot divide by zero!");
                    }
                    return firstTerm.Execute() / second;
                default:
                    return 0;
            }
        }
        #endregion Methods

    }
}
