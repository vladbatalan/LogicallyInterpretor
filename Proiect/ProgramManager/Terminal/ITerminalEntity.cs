/**************************************************************************
 *                                                                        *
 *  File:        ITerminalEntity.cs                                       *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: The interface resembles a terminal object.               *                              
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
    /// This interface resembles a terminal entity. It can read or write information from and to a terminal
    /// </summary>
    public interface ITerminalEntity
    {
        #region Abstract Methods
        /// <summary>
        /// This abstract method is used to get information from a terminal
        /// </summary>
        /// <returns>A string with the read information</returns>
        public string ReadFromTerminal();

        /// <summary>
        /// This abstract method is used to write a string to the terminal
        /// </summary>
        /// <param name="text">The string that is to be written</param>
        public void WriteToTerminal(string text);
        #endregion Abstract Methods
    }
}
