/**************************************************************************
 *                                                                        *
 *  File:        Variable.cs                                              *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: This is a class that encapsulates a value that can       *
 *              be changed at runtime                                     *                              
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
    /// This class encapsulates a value that can be change at runtime
    /// </summary>
    public class Variable : IExpression
    {
        #region Fields
        /// <summary>
        /// The inner value incapsulated by the variable
        /// </summary>
        private double _value;

        /// <summary>
        /// The name of the variable
        /// </summary>
        private String _name;
        #endregion Fields

        #region Constructors
        /// <summary>
        /// Parameter constructor
        /// </summary>
        /// <param name="name">The name of the variable</param>
        public Variable(String name)
        {
            _name = name;
            _value = 0;
        }
        #endregion Constructors

        #region Properties
        /// <summary>
        /// Property that exposes the value of the variable
        /// </summary>
        public double Value
        {
            get => _value;
            set => _value = value;
        }

        /// <summary>
        /// Property that exposes the name ov the variable
        /// </summary>
        public String Name
        {
            get => _name;
            set => _name = value;
        }
        #endregion Properties

        #region Methods
        /// <summary>
        /// The execute method will return the inner value of the Variable
        /// </summary>
        /// <returns>The value of the variable</returns>
        public double Execute()
        {
            return Value;
        }

        /// <summary>
        /// Override method to show the name of the variable then ToString is applied
        /// </summary>
        /// <returns>The name of the variable</returns>
        public override string ToString() {
            return _name;
        }
        #endregion Methods
    }
}
