

namespace LogicalSchemeManager
{
    public class Command : ICommand
    {
        private ICommandType _commandType;

        public Command(ICommandType commandType)
        {
            _commandType = commandType;
        }

        public ICommandType CommandType { 
            get => _commandType; 
            set => _commandType = value; 
        }

        public void Execute()
        {
            CommandType.Execute();
        }
    }
}
