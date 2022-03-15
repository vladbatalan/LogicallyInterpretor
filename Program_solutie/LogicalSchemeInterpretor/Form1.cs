
/**************************************************************************
 *                                                                        *
 *  File:        Form1.cs                                                 *
 *  Copyright:   (c) 2021, Cirstea Lucian Catalin, Mircea Mihai Adrian    *
 *  E-mail:      mihai-adrian.mircea@student.tuiasi.ro                    *
 *  E-mail:      catalin-lucian.cirstea@student.tuiasi.ro                 *
 *  Website:     https://github.com/vladbatalan/LogicallyInterpretor      *
 *  Description: The main form of the interface                           *
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
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace LogicalSchemeInterpretor
{

   /// <summary>
   /// The main form of the interface used to contain all panels
   /// </summary>
    public partial class Form1 : Form
    {

        #region Fields

        /// <summary>
        /// The manager that binds all command panels
        /// </summary>
        private ProgramManagerCommand _programManager;
        //private ConsoleTextBox consoleObject;

        /// <summary>
        /// Point of mouse used to move pannels
        /// </summary>
        private Point MouseDownLocation;


        /// <summary>
        /// Contor use for naming
        /// </summary>
        private int contorAtribuire = 0;
        /// <summary>
        /// Contor use for naming
        /// </summary>
        private int contorDecizie = 0;
        /// <summary>
        /// Contor use for naming
        /// </summary>
        private int contorCitesteVar = 0;
        /// <summary>
        /// Contor use for naming
        /// </summary>
        private int contorScrieVar = 0;
        /// <summary>
        /// Contor use for naming
        /// </summary>
        private int contorScrieText = 0;
       
        /// <summary>
        /// Used to initiaze the picturebox for drawing lines
        /// </summary>
        Bitmap _drawArea;

        /// <summary>
        /// Graphics used for drawing lines
        /// </summary>
        Graphics _graphics;

        /// <summary>
        /// Pen used for drawing lines
        /// </summary>
        Pen _myPen;


        /// <summary>
        /// Start label
        /// </summary>
        StartCommandPanel panelStart;

        /// <summary>
        /// End label
        /// </summary>
        StopCommandPanel panelEnd;


        /// <summary>
        /// Imported terminal for reading values
        /// </summary>
        /// <returns></returns>
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        #endregion Fields

        #region Constructors

        /// <summary>
        /// Implicit constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();    

            panelStart = new StartCommandPanel();
            panelStart.MouseDown += new MouseEventHandler(this.MyControl_MouseDown);
            panelStart.MouseMove += new MouseEventHandler(this.MyControl_MouseMove);

            panelEnd = new StopCommandPanel();
            panelEnd.MouseDown += new MouseEventHandler(this.MyControl_MouseDown);
            panelEnd.MouseMove += new MouseEventHandler(this.MyControl_MouseMove);

            panelDrawing.Controls.Add(panelStart);
            panelDrawing.Controls.Add(panelEnd);
            pictureBoxDrawing.SendToBack();

            Console.WriteLine("Creating Program Manager...");
            _programManager = new ProgramManagerCommand(panelStart, panelEnd);
            _programManager.ConsoleTextBox = consoleTextBox;
            panelStart.ProgramManager = _programManager;
            panelEnd.ProgramManager = _programManager;
            Console.WriteLine("Program Manager created!");

            /*consoleObject = new ConsoleTextBox();
            panelDrawing.Controls.Add(consoleObject);
            pictureBoxDrawing.SendToBack();*/


            _drawArea = new Bitmap(1920, 1080);
            pictureBoxDrawing.Image = _drawArea;
            _graphics = Graphics.FromImage(_drawArea);
            _myPen = _myPen = new Pen(Brushes.Black);
            _myPen.Color = Color.BlueViolet;
            _myPen.Width = 3;

            AllocConsole();

        }
        #endregion Constructors

        #region Methods

        /// <summary>
        /// Callback for panel when mouse down 
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event args</param>
        private void MyControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left) 
            { 
                MouseDownLocation = e.Location;
                
            }
        }

        /// <summary>
        /// Callback for panel when mouse is up ; used to delete pannels
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event args</param>
        private void MyControl_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                CommandPanel commandPanel = (sender as CommandPanel);
                _programManager.Connections.RemoveElement(commandPanel);
                panelDrawing.Controls.Remove(commandPanel);
                _programManager.DrawConnections(_graphics, _myPen);
                pictureBoxDrawing.Refresh();
            }
        }

        /// <summary>
        /// Callback for panle when mouse moves ;used to move pannels around
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event args</param>
        private void MyControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Panel pn = sender as Panel;
                pn.Left = e.X + pn.Left - MouseDownLocation.X;
                pn.Top = e.Y + pn.Top - MouseDownLocation.Y;
               
            }
            _programManager.DrawConnections(_graphics, _myPen);
            pictureBoxDrawing.Refresh();
        }

        /// <summary>
        /// Callback for panels; used to generet command panels
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event args</param>
        private void PanelCommand_Click(object sender, System.EventArgs e)
        {
            panelDrawing.Controls.Add(CreatePanel(((Panel)sender).Name, (Panel)sender));
            pictureBoxDrawing.SendToBack();
            _programManager.ClearInput();
        }

        /// <summary>
        /// Used to create command panels
        /// </summary>
        /// <param name="type">panel type name</param>
        /// <param name="p">th pannel that will be copied of </param>
        /// <returns></returns>
        private Panel CreatePanel(String type, Panel p)
        {
            CommandPanel panel;                    
            switch (type)
            {
                case "panelAtribuire":
                    panel = new AttribCommandPannel(_programManager, contorAtribuire);
                    contorAtribuire++;
                    break;
                case "panelDecizie":
                    panel = new DecisionCommandPanel(_programManager, contorDecizie);
                    contorDecizie++;
                    break;
                case "panelCitesteVar":
                    panel = new ReadVariableCommandPanel(_programManager, consoleTextBox, contorCitesteVar);                
                    contorCitesteVar++;
                    break;
                case "panelScrieVar":
                    panel = new WriteVariableCommandPanel(_programManager, consoleTextBox, contorScrieVar);
                    contorScrieVar++;
                    break;
                case "panelScrieText":
                    panel = new WriteTextCommandPanel(_programManager, consoleTextBox, contorScrieText);
                    contorScrieText++;
                    break;
                default:
                    return null;
            }

            panel.MouseMove += new MouseEventHandler(this.MyControl_MouseMove);
            panel.MouseDown += new MouseEventHandler(this.MyControl_MouseDown);
            panel.MouseUp += new MouseEventHandler(this.MyControl_MouseUp);
            panel.Location = new Point(0, 0);
            panel.Enabled = true;
            panel.Visible = true;
            panel.BackColor = p.BackColor;
            panel.Size = p.Size;
            panel.BackgroundImage = p.BackgroundImage;
            panel.BackgroundImageLayout = p.BackgroundImageLayout;

            return panel;
        }


        /// <summary>
        /// Callback for button Run
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event args</param>
        private void buttonRun_Click(object sender, EventArgs e)
        {
            consoleTextBox.AppendText("\n[Program started]\n",Color.Green);
            try
            {
                _programManager.RunProgram();
            }
            catch
            {
                consoleTextBox.AppendText("\n[Incorrect Program]\n",Color.Red);
            }
            consoleTextBox.AppendText("\n[Program executed successfully]\n",Color.Green);
        }


        /// <summary>
        /// Callback for button Delete
        /// </summary>
        /// <param name="sender">sender</param>
        /// <param name="e">event args</param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Dictionary<ICommand, ICommand[]> graph = _programManager.Connections.Graph;
            
            foreach (ICommand command in _programManager.Connections.CommandList)
            {
                if (command != _programManager.Connections.StartPoint && command != _programManager.Connections.EndPoint) 
                {
                    panelDrawing.Controls.Remove((Control)command);
                    _programManager.Connections.RemoveElement(command);
                }
            }

            //SplitContainer savedSplitContainer = splitContainer;
            /*
            panelDrawing.Controls.Add(panelStart);
            panelDrawing.Controls.Add(panelEnd);
            panelDrawing.Controls.Add(consoleTextBox);
            panelDrawing.Controls.Add(splitContainer);
            */
            consoleTextBox.Clear();
            pictureBoxDrawing.SendToBack();

        }

        /// <summary>
        /// Callback for the help button
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event argument</param>
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "Logical Scheme Interpretor.chm");
        }

        #endregion Methods

        private void panelAtribuire_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
