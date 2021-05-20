using System;

namespace LogicalSchemeManager
{
    class WriteVariableValue : ICommandType, IObservable
    {
        private Variable _internalVar;
        private IObserver _afisareObserver;

        public WriteVariableValue(Variable var)
        {
            _internalVar = var;
        }
        public WriteVariableValue(Variable var, IObserver terminal)
        {
            _internalVar = var;
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
                NotifyObservers(_internalVar.Name + "(" +_internalVar.Value  +")");
            }
            else
            {
                throw new Exception("Write variable object does not have an observer to send the text!");
            }
        }

        public Variable Variable
        {
            get => _internalVar;
            set => _internalVar = value;
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
            return "WriteVariableValue( " + _internalVar.Name + ", value = " + _internalVar.Value + " )";
        }
    }
}
