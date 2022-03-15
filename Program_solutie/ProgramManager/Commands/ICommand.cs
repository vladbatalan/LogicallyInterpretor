
/**************************************************************************
 *                                                                        *
 *  File:        ICommand.cs                                              *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description:  Interface that resembles the type of a command          *
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
    /// A representation of a command
    /// </summary>
    public interface ICommand
    {

        #region Abstract Properties
        /// <summary>
        /// The abstract property exposes the command's type
        /// </summary>
        public ICommandType CommandType
        {
            get; set;
        }
        #endregion Abstract Properties

        #region Abstract Methods
        /// <summary>
        /// The abstract method incapsulates the execution of the command
        /// </summary>
        public void Execute();

        #endregion Abstract Methods

    }
}