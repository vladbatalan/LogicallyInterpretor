/**************************************************************************
 *                                                                        *
 *  File:        Atribuire.cs                                             *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description:  A command type which execution changes the value of a   *
 *                Variable to the result of an expression.                *
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
    /// The execution of the command change the value of the inner variable to the 
    /// result of the expression
    /// </summary>
    public class Atribuire : ICommandType
    {
        #region Fields
        /// <summary>
        /// The inner variable that changes value at execution
        /// </summary>
        private Variable _variabila;

        /// <summary>
        /// The expression that is executed
        /// </summary>
        private IExpression _expresie;
        #endregion Fields

        #region Constructors
        /// <summary>
        /// The implicit constructor
        /// </summary>
        public Atribuire()
        {
        }

        /// <summary>
        /// The parameter constructor
        /// </summary>
        /// <param name="variabila">The variable that has it's value changed</param>
        /// <param name="expresie">An expression</param>
        public Atribuire(Variable variabila, IExpression expresie)
        {
            _variabila = variabila;
            _expresie = expresie;
        }

        #endregion Consctructors

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
        /// The property that exposes the expression
        /// </summary>
        public IExpression Expresie
        {
            get { return _expresie; }
            set { _expresie = value; }
        }
        #endregion Properties

        #region Methods
        /// <summary>
        /// The method that changes the value of the variable 
        /// </summary>
        public void Execute()
        {
            _variabila.Value = _expresie.Execute();
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
            return "Atribuire( " + _variabila.Name + " = " + _expresie.ToString() + " )";
        }
        #endregion Methods
    }
}
