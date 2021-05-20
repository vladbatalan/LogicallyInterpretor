

namespace LogicalSchemeManager
{
    public interface ICommandType
    {
        public void Execute();
        public bool GetNext();
    }
}
