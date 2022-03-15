/**************************************************************************
 *                                                                        *
 *  File:        IVariableConfiguration.cs                                *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: This module denotes the Variable Configuration template. *
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
    /// Interface for the configuration of all the variables in the program
    /// </summary>
    public interface IVariableConfiguration
    {
        #region Abstract Properties
        /// <summary>
        /// This abstract property is used to get the current list of all existing variables
        /// </summary>
        List<Variable> VariableList
        {
            get;
        }
        #endregion Abstract Properties

        #region Abstract Methods
        /// <summary>
        /// This abstract method is used to add a new variable to the program
        /// </summary>
        /// <param name="variable">The new inserted variable</param>
        public void AddElement(Variable variable);

        /// <summary>
        /// This abstract method is used to remove a specific variable from the program
        /// </summary>
        /// <param name="variable">The variable that needs to be removed</param>
        public void RemoveElement(Variable variable);

        /// <summary>
        /// This abstract method is used to get an existing variable using it's name
        /// </summary>
        /// <param name="name">The name of the searched variable</param>
        /// <returns>A variable with the given name or null if it does not exist</returns>
        public Variable GetVariableByName(string name);

        /// <summary>
        /// This abstract method is used to reset the values of all existng variables to 0
        /// </summary>
        public void ResetVariables();
        #endregion Abstract Methods

    }
}
