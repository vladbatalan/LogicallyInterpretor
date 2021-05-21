
using System.Collections.Generic;

namespace LogicalSchemeManager
{
    public interface ICommandConfiguration
    {
        public void AddElement(ICommand command);
        public void RemoveElement(ICommand command);
        public void BindElementFirst(ICommand father, ICommand firstSon);  
        public void BindElementSecond(ICommand father, ICommand secondSon);
        public Dictionary<ICommand, ICommand[]> Graph
        {
            get; 
        }

        public List<ICommand> CommandList
        {
            get; 
        }

        public ICommand StartPoint
        {
            get;
        }

        public ICommand EndPoint
        {
            get;
        }

        public ICommand GetNextElement(ICommand key, bool isNextTrue);
    }
}
