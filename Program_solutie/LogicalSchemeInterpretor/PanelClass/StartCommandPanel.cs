/**************************************************************************
 *                                                                        *
 *  File:        StartCommandPanel.cs                                     *
 *  Copyright:   (c) 2021, Mircea Mihai Adrian                            *
 *  E-mail:      mihai-adrian.mircea@student.tuiasi.ro                    *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: Start label for program                                  *
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
    /// The start label for the program
    /// </summary>
    class StartCommandPanel : CommandPanel
    {

        #region Fields
        /// <summary>
        /// Down label that acts like a button
        /// </summary>
        private Label label2;

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Implicit constructor
        /// </summary>
        public StartCommandPanel()
        {
            Init();
        }
        #endregion Constructors

        #region Methods
        /// <summary>
        /// Initializator for this class
        /// </summary>
        public void Init()
        {
            this.BackColor = Color.Transparent;
            this.BackgroundImage = Properties.Resources.START;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.Location = new Point(431, 10);
            this.Margin = new Padding(15, 10, 15, 10);
            this.Name = "panelStart";
            this.Size = new Size(140, 92);
            this.TabIndex = 3;
            this.CommandType = new Eticheta("Start");


            label2 = new Label();
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.ForeColor = System.Drawing.Color.White;
            label2.Location = new System.Drawing.Point(60, 70);
            label2.Name = "label_down";
            label2.Size = new System.Drawing.Size(21, 24);
            label2.TabIndex = 0;
            label2.Text = "+";
            label2.Click += new EventHandler(this.LabelLeftClick);

            this.Controls.Add(label2);
        }


        /// <summary>
        /// Returns Label down button
        /// </summary>
        /// <returns>Label2</returns>
        override public Label Getlabel2() { return label2; }

        /// <summary>
        /// Returns the location of the label
        /// </summary>
        /// <returns>Point to label2</returns>
        public override Point GetLeftLocation()
        {
            return new Point(this.Location.X + label2.Location.X + label2.Size.Width / 2, this.Location.Y + label2.Location.Y);
        }

        #endregion Methods
    }
}
