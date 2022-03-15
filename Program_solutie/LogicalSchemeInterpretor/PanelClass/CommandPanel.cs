/**************************************************************************
 *                                                                        *
 *  File:        CommandPanel.cs                                          *
 *  Copyright:   (c) 2021, Cirstea Lucian Catalin                         *
 *  E-mail:      catalin-lucian.cirstea@student.tuiasi.ro                 *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: Base class for all boxes                                 *
 *                                                                        *
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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicalSchemeManager;

namespace LogicalSchemeInterpretor
{
    /// <summary>
    /// Base class for all the pannels on display implements the panel and Icomand
    /// </summary>
    class CommandPanel : Panel, ICommand
    {
        #region Fields
        /// <summary>
        /// The Icommand keept for execution
        /// </summary>
        private ICommandType _commandType;

        /// <summary>
        /// Reference to the programManager
        /// </summary>
        protected ProgramManagerCommand _programManager;
        #endregion Fields

        #region Constructors
        /// <summary>
        /// Implicit constructor
        /// </summary>
        public CommandPanel()
        {
        }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="programManager">reference to programManager</param>
        public CommandPanel(ProgramManagerCommand programManager) {
            _programManager = programManager;
        }

        #endregion Constructors


        #region Properties
        /// <summary>
        /// The property that exposses programManager
        /// </summary>
        public ProgramManagerCommand ProgramManager
        {
            get => _programManager;
            set => _programManager = value;
        }

        /// <summary>
        /// The property that exposses the command type 
        /// </summary>
        public ICommandType CommandType
        {
            get => _commandType;
            set => _commandType = value;
        }
        #endregion Properties

        #region Methods
        /// <summary>
        /// Execute the block of commands
        /// </summary>
        public void Execute()
        {
            CommandType.Execute();
        }


        /// <summary>
        /// Virtual callback method for the textbox process
        /// </summary>
        /// <param name="sender">sender of callback </param>
        /// <param name="e">key envent arguments</param>
        virtual public void ProcessString(object sender, KeyEventArgs e) { }


        /// <summary>
        /// Returns reference to this class
        /// </summary>
        /// <returns>Cammandpannel class</returns>
        public CommandPanel getPanel()
        {
            return this;
        }


        /// <summary>
        /// Callback for up label
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">envent args</param>
        protected void LabelUpClick(object sender, EventArgs e)
        {
            
                _programManager.SetIn(this);
        }

        /// <summary>
        /// Callback for left label
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event args</param>
        protected void LabelLeftClick(object sender, EventArgs e)
        {
            _programManager.SetOutLeft(this);
        }

        /// <summary>
        /// Callback for right label
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event args</param>
        protected void LabelRightClick(object sender, EventArgs e)
        {
            _programManager.SetOutRight(this);
        }


        /// <summary>
        /// Return point ot up label location
        /// </summary>
        /// <returns>Point to label </returns>
        virtual public Point GetUpLocation()
        {
            return new Point(0, 0);
        }

        /// <summary>
        /// Return point ot left label location
        /// </summary>
        /// <returns>Point to label </returns>
        virtual public Point GetLeftLocation()
        {
            return new Point(0, 0);
        }

        /// <summary>
        /// Return point ot right label location
        /// </summary>
        /// <returns>Point to label </returns>
        virtual public Point GetRightLocation()
        {
            return new Point(0, 0);
        }


        /// <summary>
        /// Returns up label
        /// </summary>
        /// <returns>label1</returns>
        virtual public Label Getlabel1() { return null; }

        /// <summary>
        /// Return left label
        /// </summary>
        /// <returns>label2</returns>
        virtual public Label Getlabel2() { return null; }

        /// <summary>
        /// Return right label
        /// </summary>
        /// <returns>label3</returns>
        virtual public Label Getlabel3() { return null; }

        #endregion Methods
    }
}
