using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicalSchemeManager;

namespace LogicalSchemeInterpretor
{
    class CommandPanel : Panel, ICommand
    {
        private ICommandType _commandType;

        public CommandPanel() { 
        }
        public ICommandType CommandType
        {
            get => _commandType;
            set => _commandType = value;
        }

        public void Execute()
        {
            CommandType.Execute();
        }

    }
}
