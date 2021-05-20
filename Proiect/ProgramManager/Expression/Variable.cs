using System;

namespace LogicalSchemeManager
{
    public class Variable : IExpression
    {
        private double _value;
        private String _name;

        public Variable(String name)
        {
            _name = name;
            _value = 0;
        }

        public double Value
        {
            get => _value;
            set => _value = value;
        }

        public String Name
        {
            get => _name;
            set => _name = value;
        }

        public double Execute()
        {
            return Value;
        }

        public override string ToString() {
            return _name;
        }  
    }
}
