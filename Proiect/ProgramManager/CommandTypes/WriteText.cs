
using System;

namespace LogicalSchemeManager
{
    class WriteText : ICommandType, IObservable
    {
        private string _text;
        private IObserver _afisareObserver;

        public WriteText(string text)
        {
            _text = text;
        }
        public WriteText(string text, IObserver terminal)
        {
            _text = text;
            AddObserver(terminal);
        }

        public void AddObserver(IObserver observer)
        {
            _afisareObserver = observer;
        }

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

        public string Text
        {
            get => _text;
            set => _text = value;
        }

        public bool GetNext()
        {
            return true;
        }

        public void NotifyObservers(string text)
        {
            if(_afisareObserver != null)
            {
                _afisareObserver.Notify(text);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            _afisareObserver = null;
        }

        public void ClearAllObservers()
        {
            _afisareObserver = null;
        }

        public override string ToString()
        {
            return "WriteText( \"" + _text + "\" )";
        }
    }
}
