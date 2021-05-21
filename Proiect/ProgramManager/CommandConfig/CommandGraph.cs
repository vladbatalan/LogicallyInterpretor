
using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicalSchemeManager
{
    class CommandGraph : ICommandConfiguration
    {
        private Dictionary<ICommand, ICommand[]> _graph;
        private ICommand _startPoint;
        private ICommand _endPoint;

        public CommandGraph()
        {
            _graph = new Dictionary<ICommand, ICommand[]>();
        }
        public CommandGraph(ICommand start, ICommand end)
        {
            _startPoint = start;
            _endPoint = end;
            _graph = new Dictionary<ICommand, ICommand[]>();
            AddElement(_startPoint);
            AddElement(_endPoint);
        }

        public Dictionary<ICommand, ICommand[]> Graph {
            get => _graph;
        }
        public List<ICommand> CommandList {
            get {
                return _graph.Keys.ToList<ICommand>();
            }
        }

        public ICommand StartPoint {
            get
            {
                return _startPoint;
            }
        }

        public ICommand EndPoint
        {
            get
            {
                return _endPoint;
            }
        }

        public void AddElement(ICommand command)
        {
            if (!_graph.ContainsKey(command))
            {
                _graph.Add(command, new ICommand[2]);
            }
        }

        public void BindElementFirst(ICommand father, ICommand firstSon)
        {
            if (_graph.ContainsKey(father))
            {
                _graph[father][0] = firstSon;
            }
            else
            {
                throw new Exception("Command Configuration nu contine cheia data!");
            }
        }

        public void BindElementSecond(ICommand father, ICommand secondSon)
        {
            if (_graph.ContainsKey(father))
            {
                _graph[father][1] = secondSon;
            }
            else
            {
                throw new Exception("Command Configuration nu contine cheia data!");
            }
        }

        public void RemoveElement(ICommand command)
        {
            if(_graph.ContainsKey(command))
                _graph.Remove(command);
        }

        public ICommand GetNextElement(ICommand key, bool isNextTrue)
        {
            if (isNextTrue) return _graph[key][0];
            else return _graph[key][1];
        }

    }
}
