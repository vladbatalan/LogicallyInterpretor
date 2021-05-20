using System.Collections.Generic;

namespace LogicalSchemeManager
{
    public interface IVariableConfiguration
    {
        public void AddElement(Variable variable);
        public void RemoveElement(Variable variable);
        public Variable GetVariableByName(string name);
        List<Variable> VariableList
        {
            get;
        }
        public void ResetVariables();


    }
}
