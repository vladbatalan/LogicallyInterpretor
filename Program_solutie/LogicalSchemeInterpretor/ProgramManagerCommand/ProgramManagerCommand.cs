/**************************************************************************
 *                                                                        *
 *  File:        ProgramManagerCommand.cs                                 *
 *  Copyright:   (c) 2021, Cirstea Lucian Catalin, Mircea Mihai Adrian    *
 *  E-mail:      mihai-adrian.mircea@student.tuiasi.ro                    *
 *  E-mail:      catalin-lucian.cirstea@student.tuiasi.ro                 *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: Class used to managin all the Panel clases               *
 *                                                                        *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using LogicalSchemeManager;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogicalSchemeInterpretor
{

    /// <summary>
    /// Manager for all panel classes
    /// </summary>
    class ProgramManagerCommand : ProgramManager
    {

        #region Fields
        /// <summary>
        /// reference for bind start
        /// </summary>
        private CommandPanel _in;
        
        /// <summary>
        /// reference for bind end right
        /// </summary>
        private CommandPanel _outLeft;

        /// <summary>
        /// reference for bind end left
        /// </summary>
        private CommandPanel _outRight;

        /// <summary>
        /// reference to console 
        /// </summary>
        private ConsoleTextBox _consoleTextBox;

        #endregion Fields

        #region Constructors
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="start">Start label</param>
        /// <param name="end">End Label</param>
        public ProgramManagerCommand(CommandPanel start, CommandPanel end): base(start,end)
        {
        }
        #endregion Constructors


        #region Properties

        /// <summary>
        /// The property that exposes the console
        /// </summary>
        public ConsoleTextBox ConsoleTextBox {
            get => _consoleTextBox;
            set => _consoleTextBox = value;
        }
        #endregion Properties

        #region Methods
        /// <summary>
        /// Clears the refecences and the colors of the labels
        /// </summary>
        public void ClearInput()
        {
            if (_outLeft!=null)
            {
                _outLeft.Getlabel2().ForeColor = Color.White;
                _outLeft = null;
            }
            if (_outRight != null)
            {
                _outRight.Getlabel3().ForeColor = Color.White;
                _outRight = null;
            }
            if (_in != null)
            {
                _in.Getlabel1().ForeColor = Color.White;
                _in = null;
            }
        }

        /// <summary>
        /// Sets the start panelCommand and if end is set then bineds them
        /// </summary>
        /// <param name="input">The commandPannel to be as start pannel</param>
        public void SetIn(CommandPanel input)
        {   
            if (input == _outLeft || input == _outRight)
            {
                _consoleTextBox.AppendText("\n-- Can't bind same block --\n", Color.OrangeRed);
                return;
            }
            if (_outLeft != null && _outLeft != input)
            {

                if (_outLeft.CommandType != null)
                {
                    this.Connections.AddElement(_outLeft);
                    this.Connections.BindElementFirst(_outLeft, input);
                    ClearInput();
                }
                else
                    _consoleTextBox.AppendText("!!! PLEASE ASIGN BLOCK FIRST !!! \n", Color.Red);
                return;
            }
            else if(_outRight != null && _outRight != input)
            {
                if (_outRight.CommandType != null)
                {
                    this.Connections.AddElement(_outRight);
                    this.Connections.BindElementSecond(_outRight, input);
                    ClearInput();
                }
                else
                    _consoleTextBox.AppendText("!!! PLEASE ASIGN BLOCK FIRST !!! \n", Color.Red);
                return;
            }
            if (input.CommandType != null)
            {
                _in = input;
                _in.Getlabel1().ForeColor = Color.Black;
            }
            else
            {
                _consoleTextBox.AppendText("!!! PLEASE ASIGN BLOCK FIRST !!! \n", Color.Red);
            }
        }

        /// <summary>
        ///  Sets the end left panelCommand and if sart is set then bineds them
        /// </summary>
        /// <param name="outLeft">Command pannel for end left</param>
        public void SetOutLeft(CommandPanel outLeft)
        {
            if( outLeft == _in)
            {
                _consoleTextBox.AppendText("\n-- Can't bind same block --\n", Color.OrangeRed);
                return;
            }

            if (_in != null)
            {
                if (_in.CommandType != null)
                {
                    this.Connections.AddElement(outLeft);
                    this.Connections.BindElementFirst(outLeft, _in);
                    ClearInput();
                }
                else
                    _consoleTextBox.AppendText("!!! PLEASE ASIGN BLOCK FIRST !!! \n", Color.Red);
                return;
            }
            if (outLeft.CommandType != null)
            {
                _outLeft = outLeft;
                _outLeft.Getlabel2().ForeColor = Color.Black;
            }
            else
            {
                _consoleTextBox.AppendText("!!! PLEASE ASIGN BLOCK FIRST !!! \n", Color.Red);
            }
        }


        /// <summary>
        /// Sets the end right panelCommand and if sart is set then bineds them
        /// </summary>
        /// <param name="outRight">command panel to be set as end right</param>
        public void SetOutRight(CommandPanel outRight)
        {
            if ( outRight == _in)
            {
                _consoleTextBox.AppendText("\n-- Can't bind same block --\n", Color.OrangeRed);
                return;
            }

            if(_in != null)
            {
                if (_in.CommandType != null)
                {
                    this.Connections.AddElement(outRight);
                    this.Connections.BindElementSecond(outRight, _in);
                    ClearInput();
                }
                else
                    _consoleTextBox.AppendText("!!! PLEASE ASIGN BLOCK FIRST !!! \n", Color.Red);
                return;
            }
            if (outRight.CommandType != null)
            {
                _outRight = outRight;
                _outRight.Getlabel1().ForeColor = Color.Black;
            }
            else
            {
                _consoleTextBox.AppendText("!!! PLEASE ASIGN BLOCK FIRST !!! \n",Color.Red);

            }
        }


        /// <summary>
        /// Draw line between conected Commandpannels
        /// </summary>
        /// <param name="graphics">Graphis use to draw</param>
        /// <param name="pen">Pen used to draw</param>
        public void DrawConnections(Graphics graphics, Pen pen)
        {
            Dictionary<ICommand, ICommand[]> graph = this.Connections.Graph;
            graphics.Clear(Color.Transparent);
            foreach( ICommand command in 
                this.Connections.CommandList)
            {
               
                if( graph[command][0] != null)
                {
                    graphics.DrawLine(pen, ((CommandPanel)command).GetLeftLocation(), ((CommandPanel)graph[command][0]).GetUpLocation());
                }
                if (graph[command][1] != null)
                {
                    graphics.DrawLine(pen, ((CommandPanel)command).GetRightLocation(), ((CommandPanel)graph[command][1]).GetUpLocation());
                }
            }
        }
        #endregion Methods
    }
}
