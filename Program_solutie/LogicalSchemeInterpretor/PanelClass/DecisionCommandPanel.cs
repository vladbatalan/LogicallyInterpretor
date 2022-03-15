/**************************************************************************
 *                                                                        *
 *  File:        DecisionCommandPanel.cs                                  *
 *  Copyright:   (c) 2021, Mircea Mihai Adrian                            *
 *  E-mail:      mihai-adrian.mircea@student.tuiasi.ro                    *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: Box used for decision making                             *
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
    /// Class used for decision making 
    /// </summary>
    class DecisionCommandPanel: CommandPanel
    {
        #region Fields

        /// <summary>
        /// First label as button
        /// </summary>
        private Label label1;

        /// <summary>
        /// Second label as button
        /// </summary>
        private Label label2;

        /// <summary>
        /// Tird label as button
        /// </summary>
        private Label label3;

        #endregion Fields

        #region Constructors
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="programManager">reference to programManager</param>
        /// <param name="contorDecizie">index for naming</param>
        public DecisionCommandPanel(ProgramManagerCommand programManager, int contorDecizie):base(programManager)
        {
            TextBox textBox1 = new TextBox();
            textBox1.BackColor = System.Drawing.Color.White;
            textBox1.Location = new System.Drawing.Point(34, 33);
            textBox1.Name = "panelDecizie" + contorDecizie;
            textBox1.Size = new System.Drawing.Size(100, 20);
            textBox1.TabIndex = 0;
            textBox1.KeyUp += new KeyEventHandler(this.ProcessString);

            label1 = new Label();
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(76, -3);
            label1.Name = "label_up" + contorDecizie;
            label1.Size = new System.Drawing.Size(21, 24);
            label1.TabIndex = 0;
            label1.Text = "+";

           label2 = new Label();
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(-1, 33);
            label2.Name = "label_left" + contorDecizie;
            label2.Size = new System.Drawing.Size(21, 24);
            label2.TabIndex = 0;
            label2.Text = "+";

            label3 = new Label();
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.ForeColor = System.Drawing.Color.White;
            label3.Location = new System.Drawing.Point(152, 33);
            label3.Name = "label_right" + contorDecizie;
            label3.Size = new System.Drawing.Size(21, 24);
            label3.TabIndex = 0;
            label3.Text = "+";

            label1.Click += new EventHandler(this.LabelUpClick);
            label2.Click += new EventHandler(this.LabelLeftClick);
            label3.Click += new EventHandler(this.LabelRightClick);


            this.Controls.Add(label1);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(textBox1);
        }
        #endregion Constructors

        #region Methods

        /// <summary>
        /// Gets up label location
        /// </summary>
        /// <returns>Point to label1</returns>
        public override Point GetUpLocation()
        {
            return new Point(this.Location.X + label1.Location.X + label1.Size.Width/2, this.Location.Y);
        }

        /// <summary>
        /// Gets left label button
        /// </summary>
        /// <returns>Point to label2</returns>
        public override Point GetLeftLocation()
        {
            return new Point(this.Location.X + label2.Location.X + label2.Size.Width / 2, this.Location.Y + label2.Location.Y  + label2.Size.Height / 2);
        }

        /// <summary>
        /// Gets the label button
        /// </summary>
        /// <returns>Point to label3</returns>
        public override Point GetRightLocation()
        {
            return new Point(this.Location.X + label3.Location.X + label3.Size.Width / 2, this.Location.Y + label3.Location.Y + label2.Size.Height / 2);
        }


        /// <summary>
        /// Pocesses the string given in the text box
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">key event argumnts</param>
        public override void ProcessString(object sender, KeyEventArgs e)
        {
             if (e.KeyCode == Keys.Enter)
            {
                string text = ((TextBox)sender).Text;
                string[] text_split = text.Split();
                if (text_split.Length == 3)
                {
                    Variable temp = _programManager.AllVariables.GetVariableByName(text_split[0]);
                    if (temp == null || (text_split[1] != "<" && text_split[1] != "<=" && text_split[1] != ">"
                        && text_split[1] != ">=" && text_split[1] != "==" && text_split[1] != "!="))
                    {
                        TypingError();
                        return;
                    }
                    try
                    {
                        double value = double.Parse(text_split[2]);
                        this.CommandType = new Decision(new Condition(temp, new RelationalOperator(text_split[1]), new ConstValue(value)));
                        ((TextBox)sender).Enabled = false;
                    }
                    catch
                    {
                        Variable temp2 = _programManager.AllVariables.GetVariableByName(text_split[2]);
                        if (temp == null)
                        {
                            TypingError();
                            return;
                        }
                        this.CommandType = new Decision(new Condition(temp, new RelationalOperator(text_split[1]), temp2));
                        ((TextBox)sender).Enabled = false;
                    }
                }
                else
                    TypingError();

            }
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
        /// Returns label3
        /// </summary>
        /// <returns>Label3</returns>
        override public Label Getlabel3() { return label3; }

        /// <summary>
        /// Prints the correct format
        /// </summary>
        void TypingError()
        {
            _programManager.ConsoleTextBox.AppendText("Typing error! \nCorrect formats: \n", Color.Red);
            _programManager.ConsoleTextBox.AppendText("[+] variable_name operator variable_name /value \n\n" +
               "  Operators: < <= > >= == !=\n",Color.Green);
        }

        #endregion Methods
    }
}
