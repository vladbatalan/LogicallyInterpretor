/**************************************************************************
 *                                                                        *
 *  File:        WriteTextCommandPanel.cs                                 *
 *  Copyright:   (c) 2021, Mircea Mihai Adrian                            *
 *  E-mail:      mihai-adrian.mircea@student.tuiasi.ro                    *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: CLass box that writes text to console                    *
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
    /// Used to write text to class
    /// </summary>
    class WriteTextCommandPanel : CommandPanel
    {

        #region Fields 
        /// <summary>
        /// reference to the terminal that the string will be writen to 
        /// </summary>
        private ConsoleTextBox _terminal;
        /// <summary>
        /// Dawn label that acts liek a button
        /// </summary>
        private Label label2;

        /// <summary>
        /// Up label that acts like a button
        /// </summary>
        private Label label1;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="programManager">reference to programManager</param>
        /// <param name="terminal">reference to the terminal that the string will be writen</param>
        /// <param name="contorScrieText">constor used for naming</param>
        public WriteTextCommandPanel(ProgramManagerCommand programManager, ConsoleTextBox terminal, int contorScrieText) : base(programManager) {
            _terminal = terminal;

            RichTextBox richTextBox = new RichTextBox();
            richTextBox.BackColor = System.Drawing.Color.White;
            richTextBox.Location = new System.Drawing.Point(21, 28);
            richTextBox.Name = "panelScrieText" + contorScrieText;
            richTextBox.Size = new System.Drawing.Size(136, 53);
            richTextBox.TabIndex = 0;
            richTextBox.Text = "";
            richTextBox.KeyUp += new KeyEventHandler(this.ProcessString);

            label1 = new Label();
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(79, -1);
            label1.Name = "label_up" + contorScrieText;
            label1.Size = new System.Drawing.Size(21, 24);
            label1.TabIndex = 0;
            label1.Text = "+";

            label2 = new Label();
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(80, 86);
            label2.Name = "label_down" + contorScrieText;
            label2.Size = new System.Drawing.Size(21, 24);
            label2.TabIndex = 0;
            label2.Text = "+";

            label1.Click += new EventHandler(this.LabelUpClick);
            label2.Click += new EventHandler(this.LabelLeftClick);

            this.Controls.Add(label1);
            this.Controls.Add(label2);

            

            this.Controls.Add(richTextBox);
        }
        #endregion Constructors

        #region Methods

        /// <summary>
        /// Locagton of first label
        /// </summary>
        /// <returns>Point to label1</returns>
        public override Point GetUpLocation()
        {
            return new Point(this.Location.X + label1.Location.X + label1.Size.Width / 2, this.Location.Y);
        }

        /// <summary>
        /// Location of label2
        /// </summary>
        /// <returns>Point to label2</returns>
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
        /// Returns label2
        /// </summary>
        /// <returns>Label2</returns>
        override public Label Getlabel2() { return label2; }

        /// <summary>
        /// Callback for the text box to process the string
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public override void ProcessString(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string text = ((RichTextBox)sender).Text;
                this.CommandType = new WriteText(text, _terminal);
                ((RichTextBox)sender).Enabled = false;
            }
        }
        #endregion Methods
    }
}
