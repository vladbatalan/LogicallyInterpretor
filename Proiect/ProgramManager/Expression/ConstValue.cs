/**************************************************************************
 *                                                                        *
 *  File:        ConstValue.cs                                            *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: This is a class that encapsulates a constant value.      *
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
    /// This class incapsulates a value that remain constant when the program is executed
    /// </summary>
    public class ConstValue : IExpression
    {
        #region Fields
        /// <summary>
        /// The value incapsulated
        /// </summary>
        private double _value;
        #endregion

        #region Constructors
        /// <summary>
        /// The parameter constructor
        /// </summary>
        /// <param name="value">The constant value</param>
        public ConstValue(double value)
        {
            _value = value;
        }
        #endregion Consctuctors


        #region Properties
        /// <summary>
        /// The property exposes the inner value
        /// </summary>
        public double Value
        {
            get => _value;
            set => _value = value;
        }
        #endregion

        #region Methods
        /// <summary>
        /// The execution of this IExpression object returns only the constant incapsulated value
        /// </summary>
        /// <returns>The constant inner value </returns>
        public double Execute()
        {
            return _value;
        }
        #endregion Methods

        /// <summary>
        /// Override method that returns the constant value
        /// </summary>
        /// <returns>The constant value of the class</returns>
        public override string ToString()
        {
            return  _value.ToString();
        }
    }
}
