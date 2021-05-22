/**************************************************************************
 *                                                                        *
 *  File:        Eticheta.cs                                              *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description:  A command type which execution sets the name of a       *
 *                Label.                                                  *
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
    /// The execution of the command sets a label
    /// </summary>
    public class Eticheta : ICommandType
    {
        #region Fields
        /// <summary>
        /// The name of the chosen label
        /// </summary>
        private string _name;
        #endregion Fields

        #region Constructors
        /// <summary>
        /// The parameter constructor
        /// </summary>
        /// <param name="nume">The label name</param>
        public Eticheta(string nume)
        {
            _name = nume;
        }
        /// <summary>
        /// The implicit constructor
        /// </summary>
        public Eticheta( )
        {
        }
        #endregion Constructors

        #region Properties
        /// <summary>
        /// The property that exposes the label name
        /// </summary>
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        #endregion Properties

        #region Methods
        /// <summary>
        /// This command does nothing
        /// </summary>
        public void Execute()
        {
            // nothing to be done here
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
            return "Eticheta( " + _name + " )";
        }

        #endregion Methods
    }
}
