/**************************************************************************
 *                                                                        *
 *  File:        CommandGraph.cs                                          *
 *  Copyright:   (c) 2021, Batalan Vlad                                   *
 *  E-mail:      vlad.batalan@student.tuiasi.ro                           *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description:  A graph full of commands ready to be used.              *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicalSchemeManager
{
    /// <summary>
    /// The class describes a graph full of different commands
    /// </summary>
    class CommandGraph : ICommandConfiguration
    {
        #region Fields
        /// <summary>
        /// A graph which contains a dictionary of different elements
        /// </summary>
        private Dictionary<ICommand, ICommand[]> _graph;

        /// <summary>
        /// The starting point of the element
        /// </summary>
        private ICommand _startPoint;

        /// <summary>
        /// The final point of the element
        /// </summary>
        private ICommand _endPoint;
        #endregion Fields

        #region Constructors
        /// <summary>
        /// The implicit constructor
        /// </summary>
        public CommandGraph()
        {
            _graph = new Dictionary<ICommand, ICommand[]>();
        }

        /// <summary>
        /// The parameter constructor
        /// </summary>
        /// <param name="start">The starting point</param>
        /// <param name="end">The ending point</param>
        public CommandGraph(ICommand start, ICommand end)
        {
            _startPoint = start;
            _endPoint = end;
            _graph = new Dictionary<ICommand, ICommand[]>();
            AddElement(_startPoint);
            AddElement(_endPoint);
        }
        #endregion Constructors

        #region Properties
        /// <summary>
        /// The property that exposes the dictionary
        /// </summary>
        public Dictionary<ICommand, ICommand[]> Graph
        {
            get => _graph;
        }

        /// <summary>
        /// The property that exposes the list of commands
        /// </summary>
        public List<ICommand> CommandList
        {
            get
            {
                return _graph.Keys.ToList<ICommand>();
            }
        }

        /// <summary>
        /// The property that exposes the starting point
        /// </summary>
        public ICommand StartPoint
        {
            get
            {
                return _startPoint;
            }
        }

        /// <summary>
        /// The property that exposes the ending point
        /// </summary>
        public ICommand EndPoint
        {
            get
            {
                return _endPoint;
            }
        }
        #endregion Properties

        #region Methods
        /// <summary>
        /// The method that adds an element
        /// </summary>
        public void AddElement(ICommand command)
        {
            if (!_graph.ContainsKey(command))
            {
                _graph.Add(command, new ICommand[2]);
            }
        }

        /// <summary>
        /// The method that bind the first element
        /// </summary>
        public void BindElementFirst(ICommand father, ICommand firstSon)
        {
            if (_graph.ContainsKey(father))
            {
                if(father == firstSon)
                {
                    throw new Exception("Cannot bind the command to the same one!");
                }
                _graph[father][0] = firstSon;
            }
            else
            {
                throw new Exception("Command Configuration nu contine cheia data!");
            }
        }

        /// <summary>
        /// The method that bind the second element
        /// </summary>
        public void BindElementSecond(ICommand father, ICommand secondSon)
        {
            if (_graph.ContainsKey(father))
            {
                if (father == secondSon)
                {
                    throw new Exception("Cannot bind the command to the same one!");
                }
                _graph[father][1] = secondSon;
            }
            else
            {
                throw new Exception("Command Configuration nu contine cheia data!");
            }
        }

        /// <summary>
        /// The method that removes an output
        /// </summary>
        public void RemoveElement(ICommand command)
        {
            if (_graph.ContainsKey(command))
                _graph.Remove(command);
            foreach (ICommand cmd in CommandList)
                if (_graph[cmd][0] == command) _graph[cmd][0] = null;
                else if (_graph[cmd][1] == command) _graph[cmd][1] = null;
        }

        /// <summary>
        /// The abstract method returns the branch towards the next command
        /// </summary>
        /// <returns>A command that describes the branch taken to the next element to be executed</returns>
        public ICommand GetNextElement(ICommand key, bool isNextTrue)
        {
            if (isNextTrue) return _graph[key][0];
            else return _graph[key][1];
        }
        #endregion Methods

    }
}