using LogicalSchemeManager;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace LogicalSchemeInterpretor
{
    public partial class Form1 : Form
    {
        private ProgramManager _programManager;

        private int contorAtribuire = 0;
        private int contorDecizie = 0;
        private int contorCitesteVar = 0;
        private int contorScrieVar = 0;
        private int contorScrieText = 0;
        public Form1()
        {
            InitializeComponent();

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
                    textBox.LostFocus += new EventHandler(panel.ProcessString);
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
    }
}
