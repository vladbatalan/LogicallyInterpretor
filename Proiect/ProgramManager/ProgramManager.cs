/**************************************************************************
 *                                                                        *
 *  File:        ProgramManager.cs                                        *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: The main program coordonator used to controll all the    *
 *               commands and the variables.                              *
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
    /// The class that coordonates the logical scheme from command configurations to variable configuration
    /// </summary>
    public class ProgramManager
    {
        #region Fields
        /// <summary>
        /// The entity responsable for variable management
        /// </summary>
        private IVariableConfiguration _variableConfiguration;

        /// <summary>
        /// The entity responsable for command management
        /// </summary>
        private ICommandConfiguration _commandConfiguration;

        /// <summary>
        /// This field can be used to store the current command executed at runtime
        /// </summary>
        private ICommand _currentCommand;
        #endregion Fields

        #region Constructors
        /// <summary>
        /// The implicit constructor
        /// </summary>
        public ProgramManager()
        {
            // initializez cele 2 componente primare
            _variableConfiguration = new GlobalVariables();
            _commandConfiguration = new CommandGraph();

            // trebuie sa existe o instanta de tip Eticheta cu numele "Start" pentru a incepe
            ICommand startCmd = new Command(new Eticheta("Start"));

            // adaug comanda in lista de comenzi
            _commandConfiguration.AddElement(startCmd);
        }

        /// <summary>
        /// This constructor is used to import a program from file - not implemented (feature)
        /// </summary>
        /// <param name="filePath">The path to the file that contains the program serialization</param>
        public ProgramManager(string filePath)
        {
            throw new Exception("Functionality not implemented yet!");
        }
        #endregion Constructors

        #region Properties
        /// <summary>
        /// The property that exposes the Variable Configuration entity
        /// </summary>
        public IVariableConfiguration AllVariables
        {
            get => _variableConfiguration;
            set => _variableConfiguration = value;
        }
        
        /// <summary>
        /// The property that exposes the Command Configuration entity
        /// </summary>
        public ICommandConfiguration Connections
        {
            get => _commandConfiguration;
            set => _commandConfiguration = value;
        }
        #endregion Properties

        #region Methods
        /// <summary>
        /// This method is used to execute the program
        /// </summary>
        public void RunProgram()
        {
            // Get the starting point
            ICommand startCommand = _commandConfiguration.StartPoint;

            // If there is no starting point, throw exception
            if(startCommand == null)
            {
                throw new Exception("Programul nu contine nicio eticheta cu numele de \"Start\"!");
            }

            // Reset all existing variables
            _variableConfiguration.ResetVariables();

            // The pointer used to iterate through commands
            ICommand programCounter = startCommand;

            // Starting the iteration as long as the pointer is not null
            while(programCounter != null)
            {
                try
                {
                    // Set the _currentCommand to the current value of the pointer
                    _currentCommand = programCounter;

                    // Execute the current command
                    programCounter.Execute();
                    
                    // Get the next branch of the execution
                    bool isNextTrue = programCounter.CommandType.GetNext();

                    // Change the value of the pointer to the next command
                    programCounter = _commandConfiguration.GetNextElement(programCounter, isNextTrue);

                }
                catch (Exception ex)
                {
                    // The command that threw the exception is attached to the exception message
                    throw new Exception(_currentCommand.ToString() + " has generated: " + ex.Message);
                }
            }

            // Reset the _curentCommand value to null (the program isn't executing anymore)
            _currentCommand = null;
        }
        #endregion Methods
    }
}
