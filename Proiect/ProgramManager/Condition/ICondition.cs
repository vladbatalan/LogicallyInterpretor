/**************************************************************************
 *                                                                        *
 *  File:        ICondition.cs                                            *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: A representation of a Condition that returns a boolean   *
 *              value                                                     *
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
    /// A representation of a condition
    /// </summary>
    public interface ICondition
    {
        #region Abstract Methods
        /// <summary>
        /// The execution of the condition returns it's boolean value
        /// </summary>
        /// <returns>A boolean value which is the result of the condition</returns>
        bool ExecuteCondition();
        #endregion
    }
}
