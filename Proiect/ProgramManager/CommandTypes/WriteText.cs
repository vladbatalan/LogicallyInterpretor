/**************************************************************************
 *                                                                        *
 *  File:        WriteText.cs                                             *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description:  A command type which execution writes and displays a    *
 *                text.                                                   *
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
    /// The execution of the command writes an text
    /// </summary>
    public class WriteText : ICommandType, IObservable
    {
        #region Fields
        /// <summary>
        /// The text that will be written
        /// </summary>
        private string _text;

        /// <summary>
        /// The output on terminal
        /// </summary>
        private IObserver _afisareObserver;
        #endregion Fields

        #region Constructors
        /// <summary>
        /// The one-parameter constructor
        /// </summary>
        /// <param name="text">The text to be written</param>
        public WriteText(string text)
        {
            _text = text;
        }

        /// <summary>
        /// The two-parameters constructor
        /// </summary>
        /// <param name="text">The text to be written</param>
        /// <param name="terminal">The terminal</param>
        public WriteText(string text, IObserver terminal)
        {
            _text = text;
            AddObserver(terminal);
        }
        #endregion Constructors

        #region Properties

        /// <summary>
        /// The property that exposes the text
        /// </summary>
        public string Text
        {
            get => _text;
            set => _text = value;
        }

        #endregion Properties

        #region Methods
        /// <summary>
        /// The method that add an output
        /// </summary>
        public void AddObserver(IObserver observer)
        {
            _afisareObserver = observer;
        }
        /// <summary>
        /// The method that writes a text
        /// </summary>
        public void Execute()
        {
            if (_afisareObserver != null)
            {
                NotifyObservers(_text);
            }
            else
            {
                throw new Exception("Write object does not have an observer to send the text!");
            }
        }

        /// <summary>
        /// The command type has only the true branch
        /// </summary>
        /// <returns>Always returns true</returns>
        public bool GetNext()
        {
            return true;
        }
        /// <summary>
        /// The command type notify if there's a text to be outputed
        /// </summary>
        public void NotifyObservers(string text)
        {
            if(_afisareObserver != null)
            {
                _afisareObserver.Notify(text);
            }
        }
        /// <summary>
        /// The command type removes a text
        /// </summary>
        public void RemoveObserver(IObserver observer)
        {
            _afisareObserver = null;
        }

        /// <summary>
        /// The command type removes the text
        /// </summary>
        public void ClearAllObservers()
        {
            _afisareObserver = null;
        }

        /// <summary>
        /// Override method that returns a description of the class elements
        /// </summary>
        /// <returns>A string that resembles the description of the class</returns>
        public override string ToString()
        {
            return "WriteText( \"" + _text + "\" )";
        }
        #endregion Methods
    }
}
