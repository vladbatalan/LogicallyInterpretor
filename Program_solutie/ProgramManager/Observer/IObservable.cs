/**************************************************************************
 *                                                                        *
 *  File:        IObservable.cs                                           *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: The template of an object that can be observed by an     *
 *               IObserver object type                                    *                              
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
    /// This object can be observer by an IObservable
    /// </summary>
    public interface IObservable
    {
        #region Abstract Methods
        /// <summary>
        /// Adds a new observer that can be notified
        /// </summary>
        /// <param name="observer">The observer that subscribes to this</param>
        void AddObserver(IObserver observer);

        /// <summary>
        /// Removes an existing observer
        /// </summary>
        /// <param name="observer">The observer that is to be removed</param>
        void RemoveObserver(IObserver observer);

        /// <summary>
        /// Send a message to all the observers that are subscribed
        /// </summary>
        /// <param name="text">The notification message</param>
        void NotifyObservers(string text);

        /// <summary>
        /// Removes all the observers that are subscribed to this
        /// </summary>
        void ClearAllObservers();
        #endregion Abstract Methods
    }
}
