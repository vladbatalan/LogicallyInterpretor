using System.Collections.Generic;

namespace LogicalSchemeManager
{
    class GlobalVariables : IVariableConfiguration
    {
        private List<Variable> _listOfVariables;

        public GlobalVariables()
        {
            _listOfVariables = new List<Variable>();
        }
        public List<Variable> VariableList {
            get{
                return _listOfVariables;
            }
        }

        public void AddElement(Variable variable)
        {
            _listOfVariables.Add(variable);
        }

        public Variable GetVariableByName(string name)
        {
            foreach(Variable variable in _listOfVariables)
            {
                if (variable.Name == name)
                    return variable;
            }
            return null;
        }

        public void RemoveElement(Variable variable)
        {
            _listOfVariables.Remove(variable);
        }

        public void ResetVariables()
        {
            foreach(Variable var in _listOfVariables)
            {
                var.Value = 0;
            }
        }
    }
}
