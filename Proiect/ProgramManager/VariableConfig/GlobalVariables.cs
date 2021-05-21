/**************************************************************************
 *                                                                        *
 *  File:        GlobalVariables.cs                                       *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: The class contains the implementation of the methods     *
 *               required for variable handeling                          *                              
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
    /// This class is responsible for the Variable manipulations
    /// </summary>
    class GlobalVariables : IVariableConfiguration
    {
        #region Fields
        /// <summary>
        /// This is a list containins the existing variables
        /// </summary>
        private List<Variable> _listOfVariables;
        #endregion Fields

        #region Constructors
        /// <summary>
        /// The implicit constructor of the class
        /// </summary>
        public GlobalVariables()
        {
            _listOfVariables = new List<Variable>();
        }

        #endregion

        #region Properties
        /// <summary>
        /// This property returns the current list of the variables
        /// </summary>
        public List<Variable> VariableList {
            get{
                return _listOfVariables;
            }
        }
        #endregion Properties

        #region Methods
        /// <summary>
        /// Method used to add a new variable
        /// </summary>
        /// <param name="variable">The new variable that is included in the list</param>
        public void AddElement(Variable variable)
        {
            _listOfVariables.Add(variable);
        }

        /// <summary>
        /// Search for a variable that has a specific given name
        /// </summary>
        /// <param name="name">The name of the searched variable</param>
        /// <returns>Returns the variable with the given name or null if not found</returns>
        public Variable GetVariableByName(string name)
        {
            foreach(Variable variable in _listOfVariables)
            {
                if (variable.Name == name)
                    return variable;
            }
            return null;
        }

        /// <summary>
        /// Remove the given variable form the current variable list
        /// </summary>
        /// <param name="variable">The variable that needs to be removed</param>
        public void RemoveElement(Variable variable)
        {
            _listOfVariables.Remove(variable);
        }

        /// <summary>
        /// Resets all the variable values to 0
        /// </summary>
        public void ResetVariables()
        {
            foreach(Variable var in _listOfVariables)
            {
                var.Value = 0;
            }
        }
        #endregion Methods
    }
}
