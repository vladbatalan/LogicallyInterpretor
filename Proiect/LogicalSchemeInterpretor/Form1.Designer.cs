
namespace LogicalSchemeInterpretor
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flowLayoutPanelBlocks = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.richTextBoxConsole = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanelVariables = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDrawing = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanelBlocks.SuspendLayout();
            this.panelDrawing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelBlocks
            // 
            this.flowLayoutPanelBlocks.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanelBlocks.Controls.Add(this.panel5);
            this.flowLayoutPanelBlocks.Controls.Add(this.panel1);
            this.flowLayoutPanelBlocks.Controls.Add(this.panel2);
            this.flowLayoutPanelBlocks.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelBlocks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelBlocks.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelBlocks.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.flowLayoutPanelBlocks.Name = "flowLayoutPanelBlocks";
            this.flowLayoutPanelBlocks.Size = new System.Drawing.Size(198, 609);
            this.flowLayoutPanelBlocks.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Chartreuse;
            this.panel5.Location = new System.Drawing.Point(11, 12);
            this.panel5.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(173, 90);
            this.panel5.TabIndex = 1;
            this.panel5.Click += new System.EventHandler(this.PanelCommand_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Location = new System.Drawing.Point(11, 126);
            this.panel1.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 87);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Yellow;
            this.panel2.Location = new System.Drawing.Point(11, 237);
            this.panel2.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 84);
            this.panel2.TabIndex = 1;
            // 
            // richTextBoxConsole
            // 
            this.richTextBoxConsole.BackColor = System.Drawing.Color.LightGray;
            this.richTextBoxConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxConsole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxConsole.ForeColor = System.Drawing.Color.Navy;
            this.richTextBoxConsole.Location = new System.Drawing.Point(198, 455);
            this.richTextBoxConsole.Margin = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.richTextBoxConsole.Name = "richTextBoxConsole";
            this.richTextBoxConsole.Size = new System.Drawing.Size(830, 154);
            this.richTextBoxConsole.TabIndex = 1;
            this.richTextBoxConsole.Text = "";
            // 
            // flowLayoutPanelVariables
            // 
            this.flowLayoutPanelVariables.BackColor = System.Drawing.Color.DarkGray;
            this.flowLayoutPanelVariables.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelVariables.Location = new System.Drawing.Point(805, 0);
            this.flowLayoutPanelVariables.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanelVariables.Name = "flowLayoutPanelVariables";
            this.flowLayoutPanelVariables.Size = new System.Drawing.Size(223, 455);
            this.flowLayoutPanelVariables.TabIndex = 3;
            // 
            // panelDrawing
            // 
            this.panelDrawing.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panelDrawing.Controls.Add(this.pictureBox1);
            this.panelDrawing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDrawing.Location = new System.Drawing.Point(198, 0);
            this.panelDrawing.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelDrawing.Name = "panelDrawing";
            this.panelDrawing.Size = new System.Drawing.Size(607, 455);
            this.panelDrawing.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(607, 455);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyControl_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MyControl_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.panelDrawing);
            this.Controls.Add(this.flowLayoutPanelVariables);
            this.Controls.Add(this.richTextBoxConsole);
            this.Controls.Add(this.flowLayoutPanelBlocks);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = " ";
            this.flowLayoutPanelBlocks.ResumeLayout(false);
            this.panelDrawing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBlocks;
        private System.Windows.Forms.RichTextBox richTextBoxConsole;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelVariables;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelDrawing;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

