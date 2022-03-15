/**************************************************************************
 *                                                                        *
 *  File:        IExpression.cs                                           *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: An expression is an abstract concept for an object that  *
 *               incapsulates directly or indirectly a value              *                              
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
    /// The interface of an object that has a value incapsulated
    /// </summary>
    public interface IExpression
    {
        #region Abstract Methods
        /// <summary>
        /// The method evaluates the expression and return it's resultig value
        /// </summary>
        /// <returns>The result</returns>
        double Execute();
        #endregion Abstract Methods
    }
}
