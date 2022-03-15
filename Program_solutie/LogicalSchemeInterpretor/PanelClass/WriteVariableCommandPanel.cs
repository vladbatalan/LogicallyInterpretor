/**************************************************************************
 *                                                                        *
 *  File:        WriteVariableCommandPanel.cs                             *
 *  Copyright:   (c) 2021, Cirstea Lucian Catalin                         *
 *  E-mail:      catalin-lucian.cirstea@student.tuiasi.ro                 *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: Class used to write a variable's value to the terminal   *
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
    /// Write variable given to the terminal
    /// </summary>
    class WriteVariableCommandPanel:CommandPanel
    {
        #region Fields

        /// <summary>
        /// Terminal that the value will be writen in
        /// </summary>
        private ConsoleTextBox _terminal;

        /// <summary>
        /// Down label that acts like a button
        /// </summary>
        private Label label2;

        /// <summary>
        /// Up label tha acts like a button
        /// </summary>
        private Label label1;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="programManager">reference to programManger</param>
        /// <param name="terminal">Terminal use to write</param>
        /// <param name="contorScrieVar">index used for naming</param>
        public WriteVariableCommandPanel(ProgramManagerCommand programManager, ConsoleTextBox terminal, int contorScrieVar) : base(programManager)
        {
            _terminal = terminal;

            TextBox textBox3 = new TextBox();
            textBox3.BackColor = System.Drawing.Color.White;
            textBox3.Location = new System.Drawing.Point(13, 30);
            textBox3.Name = "panelScrieVar" + contorScrieVar;
            textBox3.Size = new System.Drawing.Size(145, 20);
            textBox3.TabIndex = 0;
            textBox3.KeyUp += new KeyEventHandler(this.ProcessString);
            this.Controls.Add(textBox3);


            label1 = new Label();
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(76, -2);
            label1.Name = "label_up" + contorScrieVar;
            label1.Size = new System.Drawing.Size(21, 24);
            label1.TabIndex = 0;
            label1.Text = "+";

            label2 = new Label();
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(76, 58);
            label2.Name = "label_down" + contorScrieVar;
            label2.Size = new System.Drawing.Size(21, 24);
            label2.TabIndex = 0;
            label2.Text = "+";

            label1.Click += new EventHandler(this.LabelUpClick);
            label2.Click += new EventHandler(this.LabelLeftClick);

            this.Controls.Add(label1);
            this.Controls.Add(label2);
        }
        #endregion Constructors

        #region Methods

        /// <summary>
        /// Location of label1 
        /// </summary>
        /// <returns>Point to Label1</returns>
        public override Point GetUpLocation()
        {
            return new Point(this.Location.X + label1.Location.X + label1.Size.Width / 2, this.Location.Y);
        }


        /// <summary>
        /// Location of label2 
        /// </summary>
        /// <returns>Point to Label2</returns>
        public override Point GetLeftLocation()
        {
            return new Point(this.Location.X + label2.Location.X + label2.Size.Width / 2, this.Location.Y + label2.Location.Y);
        }

        /// <summary>
        /// Returns label1
        /// </summary>
        /// <returns>Label1</returns>
        override public Label Getlabel1() { return label1; }

        /// <summary>
        /// Returns Label2
        /// </summary>
        /// <returns>Label2</returns>
        override public Label Getlabel2() { return label2; }



        /// <summary>
        /// Callack for text box for processing imput
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">key event argument</param>
        public override void ProcessString(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
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

                    this.CommandType = new WriteVariableValue(temp, _terminal);
                    ((TextBox)sender).Enabled = false;
                }
                else
                    _programManager.ConsoleTextBox.AppendText("!! Please don't use SPACES !! \nJust variable name!",Color.OrangeRed);
            }
        }

        #endregion Methods
    }
}
