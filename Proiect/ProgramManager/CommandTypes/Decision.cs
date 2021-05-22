/**************************************************************************
 *                                                                        *
 *  File:        Decision.cs                                              *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description:  A command type which execution decides the branch on    * 
 *                which the program will continue.                        *
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
    /// The execution of the command decides the branch on which the program will continue
    /// </summary>
    public class Decision : ICommandType
    {
        #region Fields
        /// <summary>
        /// The condition that is executed
        /// </summary>
        private ICondition _condition;

        /// <summary>
        /// The inner variable that tells the program to do somethng or not
        /// </summary>
        private Boolean _nextElement;
        #endregion Fields

        #region Constructors
        /// <summary>
        /// The parameter constructor
        /// </summary>
        /// <param name="conditie">A condition</param>
        public Decision(ICondition conditie)
        {
            _condition = conditie;
        }

        /// <summary>
        /// The implicit constructor
        /// </summary>
        public Decision()
        {
        }
        #endregion Constructors

        #region Properties
        /// <summary>
        /// The property that exposes the condition
        /// </summary>
        public ICondition Conditie
        {
            get { return _condition; }
            set { _condition = value; }
        }
        #endregion Properties

        #region Methods
        /// <summary>
        /// The method that execute the condition 
        /// </summary>
        public void Execute()
        {
            _nextElement = _condition.ExecuteCondition();
        }

        /// <summary>
        /// This command decides if there is another command type or not next to it
        /// </summary>
        /// <returns>
        /// Returns true if there is another command type next to it or false if it's not
        /// </returns>
        public bool GetNext()
        {
            return _nextElement;
        }

        /// <summary>
        /// Override method that returns a description of the class elements
        /// </summary>
        /// <returns>A string that resembles the description of the class</returns>
        public override string ToString()
        {
            return "Decision( " + _condition.ToString() + " )";
        }
        #endregion Methods
    }
}
