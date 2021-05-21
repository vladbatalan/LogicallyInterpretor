/**************************************************************************
 *                                                                        *
 *  File:        Logger.cs                                                *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: Class created specally for testing purposes.             *                              
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;

namespace LogicalSchemeManager
{
    /// <summary>
    /// This object is the implamenetation of an ITerminalEntity and is used to resemble a console
    /// </summary>
    public class Logger : ITerminalEntity, IObserver
    {
        #region Fields
        /// <summary>
        /// A list of strings that is considered to be input from the user
        /// </summary>
        private List<string> _userInputList;

        /// <summary>
        /// The index of the user input
        /// </summary>
        private int _userInputIndex;

        /// <summary>
        /// All the text that is written is appended to the logText field.
        /// </summary>
        private string _logText;
        #endregion Fields


        #region Constructors
        /// <summary>
        /// Implicit constructor
        /// </summary>
        public Logger()
        {
            // Set the private members
            _userInputList = new List<string>();
            _logText = "";
            _userInputIndex = 0;
        }

        /// <summary>
        /// Parameter constructor
        /// </summary>
        /// <param name="userInputStrings">A list of strings given as input from the user</param>
        public Logger(List<string> userInputStrings)
        {
            // Set the private members
            _userInputList = userInputStrings;
            _logText = "";
            _userInputIndex = 0;
        }
        #endregion Constructors

        #region Properties
        /// <summary>
        /// Property that gets the _logText
        /// </summary>
        public string LoggerText
        {
            get => _logText;
        }
        #endregion Properties


        #region Methods
        /// <summary>
        /// Method implemented from the IObserver interface and is writting text on the terminal
        /// </summary>
        /// <param name="text">Text to be written on the terminal</param>
        public void Notify(string text)
        {
            WriteToTerminal(text);
        }

        /// <summary>
        /// Method that returns the text introduced by the user on the terminal
        /// </summary>
        /// <returns>The input from the user</returns>
        public string ReadFromTerminal()
        {
            if(_userInputIndex >= _userInputList.Count)
            {
                throw new Exception("There are no more user inputs given to be read!");
            }

            // Get the user input
            string result = _userInputList[_userInputIndex];

            // Increment index for the next use
            _userInputIndex++;

            return result;
        }

        /// <summary>
        /// Method used to write data on the console
        /// </summary>
        /// <param name="text">The string to be written to the console</param>
        public void WriteToTerminal(string text)
        {
            // Append the new text to the logger
            _logText += text;
        }
        #endregion
    }
}
