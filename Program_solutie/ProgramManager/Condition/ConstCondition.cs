/**************************************************************************
 *                                                                        *
 *  File:        ConstCondition.cs                                        *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: A constant condition that                                *
 *              encapsulates a constant bool value.                       *
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
    /// A class that encapsulates a constant bool value
    /// </summary>
    public class ConstCondition : ICondition
    {
        #region Fields
        /// <summary>
        /// The constant bool value incapsulated
        /// </summary>
        private bool _value;
        #endregion Fields

        #region Constructors
        /// <summary>
        /// The parameter constuctor
        /// </summary>
        /// <param name="value">A bool value</param>
        public ConstCondition(bool value)
        {
            _value = value;
        }
        #endregion Constructors

        #region Properties
        /// <summary>
        /// The bool value incapsulated
        /// </summary>
        public bool Value
        {
            get => _value;
            set => _value = value;
        }
        #endregion Properties

        #region Methods
        /// <summary>
        /// The execution of the Condition returns the inner value
        /// </summary>
        /// <returns> The bool const value</returns>
        public bool ExecuteCondition()
        {
            return Value;
        }

        /// <summary>
        /// The override method that returns the cosnt bool value to string
        /// </summary>
        /// <returns>True of False value of the private member to string</returns>
        public override string ToString()
        {
            return _value.ToString();
        }
        #endregion Methods
    }
}
