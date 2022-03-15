
/**************************************************************************
 *                                                                        *
 *  File:        StopCommandPanel.cs                                      *
 *  Copyright:   (c) 2021, Cirstea Lucian Catalin                         *
 *  E-mail:      catalin-lucian.cirstea@student.tuiasi.ro                 *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: The block that reprezents the end of the program         *
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
    /// Used to end the program 
    /// </summary>
    class StopCommandPanel : CommandPanel
    {

        #region Fields
        /// <summary>
        /// Label that acts like a button 
        /// </summary>
        private Label label1;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Implicit constructor
        /// </summary>
        public StopCommandPanel()
        {
            Init();
        }
        #endregion Constructors

        #region Methods
        /// <summary>
        /// Imitializator for the class
        /// </summary>
        public void Init()
        {
            this.BackColor = Color.Transparent;
            this.BackgroundImage = Properties.Resources.END;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Location = new Point(431, 615);
            this.Margin = new Padding(15, 10, 15, 10);
            this.Name = "panelEnd";
            this.Size = new Size(140, 92);
            this.TabIndex = 4;
            this.CommandType = new Eticheta("End");


            label1 = new Label();
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(61, -2);
            label1.Name = "label_down";
            label1.Size = new System.Drawing.Size(21, 24);
            label1.TabIndex = 0;
            label1.Text = "+";
            label1.Click += new EventHandler(this.LabelUpClick);

            this.Controls.Add(label1);
        }

        /// <summary>
        /// Returns label1 
        /// </summary>
        /// <returns>Label1</returns>
        override public Label Getlabel1() { return label1; }


        /// <summary>
        /// Retruns location of label1 
        /// </summary>
        /// <returns>Point to label1 </returns>
        public override Point GetUpLocation()
        {
            return new Point(this.Location.X + label1.Location.X + label1.Size.Width / 2, this.Location.Y);
        }

        #endregion Methods
    }
}
