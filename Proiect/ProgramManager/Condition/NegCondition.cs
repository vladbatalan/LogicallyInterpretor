/**************************************************************************
 *                                                                        *
 *  File:        NEgCondition.cs                                          *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: The class incapsulates a condition which the negated     *
 *              boolean result                                            *
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
    /// Contains a condition and the execution negates it's result
    /// </summary>
    class NegCondition : ICondition
    {
        #region Fields
        /// <summary>
        /// The condition that is negated
        /// </summary>
        private ICondition _condition;
        #endregion Fields

        #region Constructors
        /// <summary>
        /// The parameter constructor
        /// </summary>
        /// <param name="condition">The condition that will be negated</param>
        public NegCondition(ICondition condition)
        {
            _condition = condition;
        }
        #endregion Constructors

        #region Properties
        /// <summary>
        /// The property exposes the inner condition
        /// </summary>
        public ICondition Condition
        {
            get => _condition;
            set => _condition = value;
        }
        #endregion Properties

        #region Methods
        /// <summary>
        /// The execution of the method evaluates the condition and negates it
        /// </summary>
        /// <returns>The negated result of the condition</returns>
        public bool ExecuteCondition()
        {
            return !Condition.ExecuteCondition();
        }

        /// <summary>
        /// Override method returns a description of the content of the class
        /// </summary>
        /// <returns>The conntent of the class as a string</returns>
        public override string ToString()
        {
            return "!(" + _condition.ToString() + ")";
        }
        #endregion Methods
    }
}
