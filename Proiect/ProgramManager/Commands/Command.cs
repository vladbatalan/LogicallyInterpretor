/**************************************************************************
 *                                                                        *
 *  File:        Command.cs                                               *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description:  A basic command                                         *
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
    /// The class describes a basic command
    /// </summary>
    class Command : ICommand
    {
        #region Fields
        /// <summary>
        /// The type of command that is executed
        /// </summary>
        private ICommandType _commandType;
        #endregion Fields

        #region Constructors
        /// <summary>
        /// The parameter constructor
        /// </summary>
        /// <param name="commandType">The command type that will be executed</param>
        public Command(ICommandType commandType)
        {
            _commandType = commandType;
        }
        #endregion Constructors

        #region Properties
        /// <summary>
        /// The property that exposes the command type
        /// </summary>
        public ICommandType CommandType { 
            get => _commandType; 
            set => _commandType = value; 
        }
        #endregion Properties

        #region Methods
        /// <summary>
        /// The method that executes a command
        /// </summary>
        public void Execute()
        {
            CommandType.Execute();
        }
        #endregion Methods
    }
}
