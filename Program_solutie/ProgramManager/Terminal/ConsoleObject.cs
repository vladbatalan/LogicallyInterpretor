/**************************************************************************
 *                                                                        *
 *  File:        ConsoleObject.cs                                         *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: Class used for CLI testing of the module.                *                              
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
    /// This object is the implamenetation of an ITerminalEntity and is used to resemble a console
    /// </summary>
    public class ConsoleObject : ITerminalEntity, IObserver
    {
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
            return Console.ReadLine();
        }

        /// <summary>
        /// Method used to write data on the console
        /// </summary>
        /// <param name="text">The string to be written to the console</param>
        public void WriteToTerminal(string text)
        {
            Console.WriteLine(text);
        }
        #endregion
    }
}
