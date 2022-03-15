/**************************************************************************
 *                                                                        *
 *  File:        ConsoleTextBox.cs                                        *
 *  Copyright:   (c) 2021, Mircea Mihai Adrian                            *
 *  E-mail:      mihai-adrian.mircea@student.tuiasi.ro                    *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: A ricktextbox that acts like a console                   *
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
    /// Outpusts and read text acting like a console
    /// </summary>
    class ConsoleTextBox: RichTextBox, ITerminalEntity, IObserver
    {
        #region Constructors
        public ConsoleTextBox()
        {
            this.Visible = true;
            this.Enabled = true;
            this.Location = new System.Drawing.Point(11, 200);
            this.Name = "console";
            this.Size = new System.Drawing.Size(284, 96);
            this.TabIndex = 2;
            this.Text = "";
            this.Dock = DockStyle.Right;
            this.BackColor = Color.Black;
            this.ForeColor = Color.White;
            this.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorderStyle = BorderStyle.None;
        }
        #endregion  Constructors

        #region Methods
        /// <summary>
        /// Method implemented from the IObserver interface and is writting text on the terminal
        /// </summary>
        /// <param name="text">Text to be written on the terminal</param>
        public void Notify(string text)
        {
            //WriteToTerminal(text);
            WriteToRichTextBox(text);
        }


        /// <summary>
        /// Method that returns the text introduced by the user on the terminal
        /// </summary>
        /// <returns>The input from the user</returns>
        public string ReadFromTerminal()
        {
            return Console.ReadLine();
        }

        /// <summary>
        /// Method used to write data on the console
        /// </summary>
        /// <param name="text">The string to be written to the console</param>
        public void WriteToTerminal(string text)
        {
            AppendText(text+"\n", Color.White);
        }


        /// <summary>
        /// Method used to write data on the console
        /// </summary>
        /// <param name="text">The string to be written to the console</param>
        public void WriteToRichTextBox(string text)
        {
            AppendText(text + "\n", Color.White);
        }

        /// <summary>
        /// Method used to write data on the console with a secified color
        /// </summary>
        /// <param name="text">The string written to the console</param>
        /// <param name="color">The string's color</param>
        public void AppendText( string text, Color color)
        {
            this.SelectionStart = this.TextLength;
            this.SelectionLength = 0;

            this.SelectionColor = color;
            this.AppendText(text);
            this.SelectionColor = this.ForeColor;
        }
        #endregion Methods

    }

}
