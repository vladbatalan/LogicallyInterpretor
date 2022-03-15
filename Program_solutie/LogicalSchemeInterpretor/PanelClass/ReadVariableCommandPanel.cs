
/**************************************************************************
 *                                                                        *
 *  File:        ReadVariableCommandPanel.cs                              *
 *  Copyright:   (c) 2021, Cirstea Lucian Catalin                         *
 *  E-mail:      catalin-lucian.cirstea@student.tuiasi.ro                 *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: Box tha is used to read variable value                   *
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
    /// Used to read variable values
    /// </summary>
    class ReadVariableCommandPanel: CommandPanel
    {

        #region Fields
        /// <summary>
        /// Reference to the terminal
        /// </summary>
        private ITerminalEntity _terminal;

        /// <summary>
        /// Secons button label
        /// </summary>
        private Label label2;

        /// <summary>
        /// Firts button label
        /// </summary>
        private Label label1;

        #endregion Fields

        #region Constructors
        /// <summary>
        /// Constructoe with parameters
        /// </summary>
        /// <param name="programManager">reference to programManager</param>
        /// <param name="terminal">reference to the terminal</param>
        /// <param name="contorCitesteVar">contor for naming</param>
        public ReadVariableCommandPanel(ProgramManagerCommand programManager, ITerminalEntity terminal, int contorCitesteVar) : base(programManager)
        {
            _terminal = terminal;

            TextBox textBox2 = new TextBox();
            textBox2.BackColor = System.Drawing.Color.White;
            textBox2.Location = new System.Drawing.Point(13, 30);
            textBox2.Name = "panelCitesteVar" + contorCitesteVar;
            textBox2.Size = new System.Drawing.Size(145, 20);
            textBox2.TabIndex = 0;
            textBox2.KeyUp += new KeyEventHandler(this.ProcessString);

            label1 = new Label();
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(76, -2);
            label1.Name = "label_up" + contorCitesteVar;
            label1.Size = new System.Drawing.Size(21, 24);
            label1.TabIndex = 0;
            label1.Text = "+";

            label2 = new Label();
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(76, 58);
            label2.Name = "label_down" + contorCitesteVar;
            label2.Size = new System.Drawing.Size(21, 24);
            label2.TabIndex = 0;
            label2.Text = "+";

            label1.Click += new EventHandler(this.LabelUpClick);
            label2.Click += new EventHandler(this.LabelLeftClick);

            this.Controls.Add(label1);
            this.Controls.Add(label2);

            this.Controls.Add(textBox2);
        }
        #endregion Constructors

        #region Methods
        /// <summary>
        /// Return labe1 button
        /// </summary>
        /// <returns>Label1</returns>
        override public Label Getlabel1() { return label1; }

        /// <summary>
        /// Returns label2 button
        /// </summary>
        /// <returns>Label2</returns>
        override public Label Getlabel2() { return label2; }

        /// <summary>
        /// Up label button location
        /// </summary>
        /// <returns>Point to up label</returns>
        public override Point GetUpLocation()
        {
            return new Point(this.Location.X + label1.Location.X + label2.Size.Width / 2, this.Location.Y);
        }


        /// <summary>
        /// Down label button location
        /// </summary>
        /// <returns>Point to down label</returns>
        public override Point GetLeftLocation()
        {
            return new Point(this.Location.X + label2.Location.X + label1.Size.Width / 2, this.Location.Y + label2.Location.Y);
        }

    

        /// <summary>
        /// Callback for textbox to process the string
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">key envent args</param>
        public override void ProcessString(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                string text = ((TextBox)sender).Text;
                string[] text_split = text.Split();
                if (text_split.Length == 1)
                {
                    Variable temp = _programManager.AllVariables.GetVariableByName(text_split[0]);
                    if (temp == null)
                    {
                        _programManager.ConsoleTextBox.AppendText("!! Variable does not exits !!",Color.Red);
                        return;
                    }

                    this.CommandType = new ReadVariable(temp, _terminal);
                    ((TextBox)sender).Enabled = false;
                }
                else
                    _programManager.ConsoleTextBox.AppendText("!! Please don't use SPACES !! \n Just variable name!",Color.OrangeRed);
            }
        }
        #endregion Methods
    }
}
