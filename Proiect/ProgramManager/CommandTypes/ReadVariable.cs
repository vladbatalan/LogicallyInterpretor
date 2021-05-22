/**************************************************************************
 *                                                                        *
 *  File:        ReadVariable.cs                                          *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description:  A command type which execution reads a variable and its *
 *                atributions.                                            *
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
    /// The execution of the command retain atributions of the variable read
    /// </summary>
    class ReadVariable : ICommandType
    {
        #region Fields
        /// <summary>
        /// The variable that is read
        /// </summary>
        private Variable _variabila;

        /// <summary>
        /// The terminal entity that is executed
        /// </summary>
        private ITerminalEntity _terminal;
        #endregion Fields

        #region Constructor
        /// <summary>
        /// The parameter constructor
        /// </summary>
        /// <param name="variabila">The variable</param>
        /// <param name="terminal">The terminal</param>
        public ReadVariable(Variable variabila, ITerminalEntity terminal)
        {
            _variabila = variabila;
            _terminal = terminal;
        }
        #endregion Constructor

        #region Properties
        /// <summary>
        /// The property that exposes the variable
        /// </summary>
        public Variable Variabila
        {
            get { return _variabila; }
            set { _variabila = value; }
        }

        /// <summary>
        /// The property that exposes the terminal
        /// </summary>
        public ITerminalEntity Terminal
        {
            get { return _terminal; }
            set { _terminal = value; }
        }
        #endregion Properties

        #region Methods

        /// <summary>
        /// The method that reads the value of the variable 
        /// </summary>
        public void Execute()
        {
            _variabila.Value = double.Parse(_terminal.ReadFromTerminal());
        }

        /// <summary>
        /// The command type has only the true branch
        /// </summary>
        /// <returns>Always returns true</returns>
        public bool GetNext()
        {
            return true;
        }

        /// <summary>
        /// Override method that returns a description of the class elements
        /// </summary>
        /// <returns>A string that resembles the description of the class</returns>
        public override string ToString()
        {
            return "ReadVariable( " + _variabila.Name + " )";
        }

        #endregion Methods
    }
}