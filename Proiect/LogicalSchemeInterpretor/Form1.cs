using LogicalSchemeManager;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LogicalSchemeInterpretor
{
    public partial class Form1 : Form
    {
        private ProgramManager _programManager;
        private ConsoleObject consoleObject;

        private int contorAtribuire = 0;
        private int contorDecizie = 0;
        private int contorCitesteVar = 0;
        private int contorScrieVar = 0;
        private int contorScrieText = 0;
        public Form1()
        {
            InitializeComponent();

            

            CommandPanel panelStart = new CommandPanel(); 
            panelStart.BackColor = Color.Transparent;
            panelStart.BackgroundImage = Properties.Resources.START;
            panelStart.BackgroundImageLayout = ImageLayout.Stretch;
            panelStart.Location = new Point(431, 10);
            panelStart.Margin = new Padding(15, 10, 15, 10);
            panelStart.Name = "panelStart";
            panelStart.Size = new Size(140, 92);
            panelStart.TabIndex = 3;
            panelStart.MouseDown += new MouseEventHandler(this.MyControl_MouseDown);
            panelStart.MouseMove += new MouseEventHandler(this.MyControl_MouseMove);
            panelStart.CommandType = new Eticheta("Start");

            CommandPanel panelEnd = new CommandPanel();
            panelEnd.BackColor = Color.Transparent;
            panelEnd.BackgroundImage = Properties.Resources.END;
            panelEnd.BackgroundImageLayout = ImageLayout.Stretch;
            panelEnd.Location = new Point(431, 615);
            panelEnd.Margin = new Padding(15, 10, 15, 10);
            panelEnd.Name = "panelEnd";
            panelEnd.Size = new Size(140, 92);
            panelEnd.TabIndex = 4;
            panelEnd.MouseDown += new MouseEventHandler(this.MyControl_MouseDown);
            panelEnd.MouseMove += new MouseEventHandler(this.MyControl_MouseMove);
            panelEnd.CommandType = new Eticheta("End");


            panelDrawing.Controls.Add(panelStart);
            panelDrawing.Controls.Add(panelEnd);
            pictureBoxDrawing.SendToBack();


            Console.WriteLine("Creating Program Manager...");
            ProgramManager myManager = new ProgramManager(panelStart, panelEnd);
            Console.WriteLine("Program Manager created!");
            consoleObject = new ConsoleObject();
        }

        private Point MouseDownLocation;

        private void MyControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left) 
            { 
                MouseDownLocation = e.Location; 
            }
            foreach (Control cnt in ((Panel)sender).Controls)
            {
                Console.WriteLine(cnt.Name);
            }
           
        }

        private void MyControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                Panel pn = sender as Panel;
                pn.Left = e.X + pn.Left - MouseDownLocation.X;
                pn.Top = e.Y + pn.Top - MouseDownLocation.Y;
            }
        }

        private void panelDrawing_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

        }

        private void pictureBox1_Validated(object sender, System.EventArgs e)
        {
            panelDrawing.Focus();
        }

        private void pictureBox1_Click(object sender, System.EventArgs e)
        {
            System.Console.WriteLine("focused");
        }


        
        private void PanelCommand_Click(object sender, System.EventArgs e)
        {
            panelDrawing.Controls.Add(CreatePanel(((Panel)sender).Name, (Panel)sender));
            pictureBoxDrawing.SendToBack();
        }


        private Panel CreatePanel(String type, Panel p)
        {
            CommandPanel panel = new CommandPanel();                    
            panel.MouseMove += new MouseEventHandler(this.MyControl_MouseMove);
            panel.MouseDown += new MouseEventHandler(this.MyControl_MouseDown);
            panel.Location = new Point(0, 0);
            panel.Enabled = true;
            panel.Visible = true;
            panel.BackColor = p.BackColor;
            panel.Size = p.Size;
            panel.BackgroundImage = p.BackgroundImage;
            panel.BackgroundImageLayout = p.BackgroundImageLayout;


            switch (type)
            {
                case "panelAtribuire":
                    TextBox textBox = new TextBox();
                    textBox.BackColor = Color.White;
                    textBox.Location = new Point(17, 31);
                    textBox.Name = "textBoxAtribuire" + contorAtribuire;
                    textBox.Size = new Size(141, 20);
                    textBox.TabIndex = 0;
                    panel.Controls.Add(textBox);
                    panel.CommandType = new Atribuire();
                    contorAtribuire++;
                    break;
                case "panelDecizie":
                    TextBox textBox1 = new TextBox();
                    textBox1.BackColor = System.Drawing.Color.White;
                    textBox1.Location = new System.Drawing.Point(34, 33);
                    textBox1.Name = "panelDecizie" + contorDecizie;
                    textBox1.Size = new System.Drawing.Size(100, 20);
                    textBox1.TabIndex = 0;
                    panel.Controls.Add(textBox1);
                    contorDecizie++;
                    break;
                case "panelCitesteVar":
                    TextBox textBox2 = new TextBox();
                    textBox2.BackColor = System.Drawing.Color.White;
                    textBox2.Location = new System.Drawing.Point(13, 30);
                    textBox2.Name = "panelCitesteVar" + contorCitesteVar;
                    textBox2.Size = new System.Drawing.Size(145, 20);
                    textBox2.TabIndex = 0;
                    panel.Controls.Add(textBox2);
                    contorCitesteVar++;
                    break;
                case "panelScrieVar":
                    TextBox textBox3 = new TextBox();
                    textBox3.BackColor = System.Drawing.Color.White;
                    textBox3.Location = new System.Drawing.Point(13, 30);
                    textBox3.Name = "panelCitesteVar" + contorScrieVar;
                    textBox3.Size = new System.Drawing.Size(145, 20);
                    textBox3.TabIndex = 0;
                    panel.Controls.Add(textBox3);
                    contorScrieVar++;
                    break;
                case "panelScrieText":
                    RichTextBox richTextBox = new RichTextBox();
                    richTextBox.BackColor = System.Drawing.Color.White;
                    richTextBox.Location = new System.Drawing.Point(21, 28);
                    richTextBox.Name = "panelScrieText" + contorScrieText;
                    richTextBox.Size = new System.Drawing.Size(136, 53);
                    richTextBox.TabIndex = 0;
                    richTextBox.Text = "";
                    panel.Controls.Add(richTextBox);
                    contorScrieText++;
                    break;
                default:
                    break;
            }

            return panel;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panelEtichetaIn_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
