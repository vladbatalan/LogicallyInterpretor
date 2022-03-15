/**************************************************************************
 *                                                                        *
 *  File:        IObserver.cs                                             *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: The template of an object that can observe an            *
 *               IObservable object type                                  *                              
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

    public interface IObserver
    {
        #region Abstract Methods
        /// <summary>
        /// The method that is called by an IObservable to notify the observer
        /// </summary>
        /// <param name="text">The notification message</param>
        public void Notify(string text);
        #endregion Abstract Methods
    }
}
