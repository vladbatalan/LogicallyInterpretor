/**************************************************************************
 *                                                                        *
 *  File:        AttribCommandPanel.cs                                    *
 *  Copyright:   (c) 2021, Cirstea Lucian Catalin, Mircea Mihai Adrian    *
 *  E-mail:      mihai-adrian.mircea@student.tuiasi.ro                    *
 *  E-mail:      catalin-lucian.cirstea@student.tuiasi.ro                 *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: Box used for asigning values and making variables        *
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
    /// Create a new variable given after a processed string
    /// </summary>
    class AttribCommandPannel : CommandPanel
    {
        #region Filds
        /// <summary>
        /// The lower label that acts like a button
        /// </summary>
        private Label label2;
        /// <summary>
        /// The upper label tha acts like a button
        /// </summary>
        private Label label1;
        #endregion Filds

        #region Constructors
        /// <summary>
        /// The parameter constructor
        /// </summary>
        /// <param name="pm">the program manager</param>
        /// <param name="contorAtribuire">contor used for controls names</param>
        public AttribCommandPannel(ProgramManagerCommand pm, int contorAtribuire):base(pm)
        {
            TextBox textBox = new TextBox();
            textBox.BackColor = Color.White;
            textBox.Location = new Point(17, 31);
            textBox.Name = "textBoxAtribuire" + contorAtribuire;
            textBox.Size = new Size(141, 20);
            textBox.TabIndex = 0;
            textBox.KeyUp += new KeyEventHandler(this.ProcessString);

            label2 = new Label();
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(78, 58);
            label2.Name = "label_down" + contorAtribuire;
            label2.Size = new System.Drawing.Size(21, 24);
            label2.TabIndex = 0;
            label2.Text = "+";

            label1 = new Label();
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(78, -2);
            label1.Name = "label_up";
            label1.Size = new System.Drawing.Size(21, 24);
            label1.TabIndex = 1;
            label1.Text = "+";

            label2.Click += new EventHandler(this.LabelLeftClick);
            label1.Click += new EventHandler(this.LabelUpClick);

            this.Controls.Add(label1);
            this.Controls.Add(label2);

            this.Controls.Add(textBox);
            
        }
        #endregion Constructors

        #region Methods
        /// <summary>
        /// returns up button location
        /// </summary>
        /// <returns>point of up button location</returns>
        public override Point GetUpLocation()
        {
            return new Point(this.Location.X + label1.Location.X + label1.Size.Width/2, this.Location.Y) ;
        }
        /// <summary>
        /// returns down button location
        /// </summary>
        /// <returns>point of down button location</returns>
        public override Point GetLeftLocation()
        {
            return new Point(this.Location.X + label2.Location.X + label2.Size.Width / 2,  this.Location.Y + label2.Location.Y);
        }

        /// <summary>
        /// Processes the string inserted into the text box
        /// </summary>
        /// <param name="sender">text box inside box</param>
        /// <param name="e">key event args</param>
        public override void ProcessString(object sender, KeyEventArgs e)
         {
            if (e.KeyCode == Keys.Enter)
            {
                string text = ((TextBox)sender).Text;

                string[] text_split = text.Split();

                if (text_split.Length == 1 && text_split[0] != "")
                {
                    Variable var = _programManager.AllVariables.GetVariableByName(text_split[0]);
                    if (var == null)
                    {
                        var = new Variable(text_split[0]);
                        _programManager.AllVariables.AddElement(var);
                    }
                    this.CommandType = new Atribuire(var, new ConstValue(0));
                    ((TextBox)sender).Enabled = false;
                    return;
                }
                if (text_split.Length == 3)
                {
                    if (text_split[1] != "=")
                    {
                        TypingError();
                        return;
                    }

                    try
                    {
                        double value = double.Parse(text_split[2]);
                        Variable var = _programManager.AllVariables.GetVariableByName(text_split[0]);
                        if (var == null)
                        {
                            var = new Variable(text_split[0]);
                            _programManager.AllVariables.AddElement(var);
                        }
                        this.CommandType = new Atribuire(var, new ConstValue(value));
                        ((TextBox)sender).Enabled = false;
                    }
                    catch
                    {
                        Variable temp = _programManager.AllVariables.GetVariableByName(text_split[2]);
                        if (temp == null)
                        {
                            TypingError();
                            return;
                        }

                        Variable var = _programManager.AllVariables.GetVariableByName(text_split[0]);
                        if (var == null)
                        {
                            var = new Variable(text_split[0]);
                            _programManager.AllVariables.AddElement(var);
                        }
                        this.CommandType = new Atribuire(var, temp);
                        ((TextBox)sender).Enabled = false;
                    }
                    ((TextBox)sender).Enabled = false;
                    return;
                }

                if (text_split.Length == 5)
                {
                    if (text_split[1] != "=")
                    {
                        TypingError();
                        return;
                    }

                    if (text_split[3] != "+" && text_split[3] != "-" && text_split[3] != "*" && text_split[3] != "/")
                    {
                        TypingError();
                        return;
                    }

                    try
                    {
                        double value1 = double.Parse(text_split[2]);
                        try
                        {
                            double value2 = double.Parse(text_split[4]);

                            Variable var = _programManager.AllVariables.GetVariableByName(text_split[0]);
                            if (var == null)
                            {
                                var = new Variable(text_split[0]);
                                _programManager.AllVariables.AddElement(var);
                            }
                            this.CommandType = new Atribuire(var, new Expression(new ConstValue(value1), new Operator(text_split[3]), new ConstValue(value2)));
                            ((TextBox)sender).Enabled = false;
                        }
                        catch
                        {
                            Variable temp = _programManager.AllVariables.GetVariableByName(text_split[4]);
                            if (temp == null)
                            {
                                TypingError();
                                return;
                            }

                            Variable var = _programManager.AllVariables.GetVariableByName(text_split[0]);
                            if (var == null)
                            {
                                var = new Variable(text_split[0]);
                                _programManager.AllVariables.AddElement(var);
                            }
                            this.CommandType = new Atribuire(var, new Expression(new ConstValue(value1), new Operator(text_split[3]), temp));
                            ((TextBox)sender).Enabled = false;
                        }
                    }
                    catch
                    {
                        Variable temp = _programManager.AllVariables.GetVariableByName(text_split[2]);
                        if (temp == null)
                        {
                            TypingError();
                            return;
                        }

                        try
                        {
                            double value2 = double.Parse(text_split[4]);

                            Variable var = _programManager.AllVariables.GetVariableByName(text_split[0]);
                            if (var == null)
                            {
                                var = new Variable(text_split[0]);
                                _programManager.AllVariables.AddElement(var);
                            }
                            this.CommandType = new Atribuire(var, new Expression(temp, new Operator(text_split[3]), new ConstValue(value2)));
                            ((TextBox)sender).Enabled = false;
                        }
                        catch
                        {
                            Variable temp2 = _programManager.AllVariables.GetVariableByName(text_split[4]);
                            if (temp2 == null)
                            {
                                TypingError();
                                return;
                            }

                            Variable var = _programManager.AllVariables.GetVariableByName(text_split[0]);
                            if (var == null)
                            {
                                var = new Variable(text_split[0]);
                                _programManager.AllVariables.AddElement(var);
                            }
                            this.CommandType = new Atribuire(var, new Expression(temp, new Operator(text_split[3]), temp2));
                            ((TextBox)sender).Enabled = false;
                        }
                    }
                    ((TextBox)sender).Enabled = false;
                    return;
                }
                TypingError();
            }
        }

        /// <summary>
        /// Used to get up button
        /// </summary>
        /// <returns>label for up button</returns>
        override public Label Getlabel1() { return label1; }
        /// <summary>
        /// Used to get down button
        /// </summary>
        /// <returns>label for down button</returns>
        override public Label Getlabel2() { return label2; }
        


        /// <summary>
        /// Prints the correct format for the text box
        /// </summary>
        public void TypingError()
        {
            _programManager.ConsoleTextBox.AppendText("Typing error! \nCorrect formats:\n", Color.OrangeRed);
            _programManager.ConsoleTextBox.AppendText("[+] variable_name \n[+] variable_name = variable_name1 / value\n" +
                "[+] variable_name = variable_name1/value1 operation variable_name2/value2 \n\n" +
                "  Operations: + - / *\n", Color.Green); 
        }
        #endregion Methods
    }
}
