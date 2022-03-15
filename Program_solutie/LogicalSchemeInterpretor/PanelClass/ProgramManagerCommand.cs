using LogicalSchemeManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicalSchemeInterpretor
{
    class ProgramManagerCommand : ProgramManager
    {
        private CommandPanel _in;
        private CommandPanel _outLeft;
        private CommandPanel _outRight;

        public ProgramManagerCommand(CommandPanel start, CommandPanel end): base(start,end)
        {

        }

        public bool SetIn(CommandPanel input)
        {
            _in = input;
            if (_outLeft != null && _outRight != _in)
            {
                this.Connections.BindElementSecond(_outLeft, _in);
                _outLeft = null;
                _outRight = null;
                _in = null;
                return true;
            }
            else if(_outRight != null && _outLeft != _in)
            {
                this.Connections.BindElementFirst(_outRight, _in);
                _outLeft = null;
                _outRight = null;
                _in = null;
                return true;
            }

            return false;


        }

        public void SetOutLeft(CommandPanel outLeft)
        {
            if( outLeft == _in)
            {
                MessageBox.Show("You can't bind same block!");
                return;
            }

            if (_in == null)
            {
                this.Connections.BindElementSecond(outLeft, _in);
                _in = null;
            }
        }

        public void SetOutRight(CommandPanel outRight)
        {
            if (outRight == _in)
            {
                MessageBox.Show("You can't bind same block!");
                return;
            }

            if(_in == null)
            {
                this.Connections.BindElementFirst(outRight, _in);
                _in = null;
            }

        }
    }
}
