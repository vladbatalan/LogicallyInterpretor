/**************************************************************************
 *                                                                        *
 *  File:        ICommandConfiguration.cs                                 *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: Interface that resembles the configurations of a command *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System.Collections.Generic;

namespace LogicalSchemeManager
{
    /// <summary>
    /// A representation of a command configurations
    /// </summary>
    public interface ICommandConfiguration
    {
        #region Abstract Methods
        /// <summary>
        /// The method that adds an element
        /// </summary>
        public void AddElement(ICommand command);
        /// <summary>
        /// The method that removes an output
        /// </summary>
        public void RemoveElement(ICommand command);
        /// <summary>
        /// The method that bind the first element
        /// </summary>
        public void BindElementFirst(ICommand father, ICommand firstSon);
        /// <summary>
        /// The method that bind the second element
        /// </summary>
        public void BindElementSecond(ICommand father, ICommand secondSon);
        /// <summary>
        /// The abstract method returns the branch towards the next command
        /// </summary>
        /// <returns>A command that describes the branch taken to the next element to be executed</returns>
        public ICommand GetNextElement(ICommand key, bool isNextTrue);
        #endregion Abstract Methods

        #region Abstract Properties
        /// <summary>
        /// The abstract property exposes a dictionary
        /// </summary>
        public Dictionary<ICommand, ICommand[]> Graph
        {
            get; 
        }

        /// <summary>
        /// The abstract property exposes a list of commands
        /// </summary>
        public List<ICommand> CommandList
        {
            get; 
        }

        /// <summary>
        /// The abstract property exposes the starting point of the command
        /// </summary>
        public ICommand StartPoint
        {
            get;
        }

        #endregion Abstract Properties
    }
}
