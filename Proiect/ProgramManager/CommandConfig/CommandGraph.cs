
using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicalSchemeManager
{
    class CommandGraph : ICommandConfiguration
    {
        private Dictionary<ICommand, ICommand[]> _graph;

        public CommandGraph()
        {
            _graph = new Dictionary<ICommand, ICommand[]>();
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
                foreach(ICommand cmd in CommandList)
                {
                    if(cmd.CommandType is Eticheta)
                    {
                        Eticheta start = (Eticheta)cmd.CommandType;
                        if(start.Name == "Start")
                        {
                            return cmd;
                        }
                    }
                    
                }
                return null;
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
