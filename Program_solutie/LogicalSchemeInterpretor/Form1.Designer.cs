
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
            this.panelAtribuire = new System.Windows.Forms.Panel();
            this.panelDecizie = new System.Windows.Forms.Panel();
            this.panelCitesteVar = new System.Windows.Forms.Panel();
            this.panelScrieVar = new System.Windows.Forms.Panel();
            this.panelScrieText = new System.Windows.Forms.Panel();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.panelEtichetaOut = new System.Windows.Forms.Panel();
            this.panelEtichetaIn = new System.Windows.Forms.Panel();
            this.panelDrawing = new System.Windows.Forms.Panel();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.buttonRun = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.consoleTextBox = new LogicalSchemeInterpretor.ConsoleTextBox();
            this.pictureBoxDrawing = new System.Windows.Forms.PictureBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.flowLayoutPanelBlocks.SuspendLayout();
            this.panelDrawing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawing)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelBlocks
            // 
            this.flowLayoutPanelBlocks.BackColor = System.Drawing.Color.YellowGreen;
            this.flowLayoutPanelBlocks.Controls.Add(this.panelAtribuire);
            this.flowLayoutPanelBlocks.Controls.Add(this.panelDecizie);
            this.flowLayoutPanelBlocks.Controls.Add(this.panelCitesteVar);
            this.flowLayoutPanelBlocks.Controls.Add(this.panelScrieVar);
            this.flowLayoutPanelBlocks.Controls.Add(this.panelScrieText);
            this.flowLayoutPanelBlocks.Controls.Add(this.buttonHelp);
            this.flowLayoutPanelBlocks.Controls.Add(this.panelEtichetaOut);
            this.flowLayoutPanelBlocks.Controls.Add(this.panelEtichetaIn);
            this.flowLayoutPanelBlocks.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelBlocks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelBlocks.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelBlocks.Margin = new System.Windows.Forms.Padding(8);
            this.flowLayoutPanelBlocks.Name = "flowLayoutPanelBlocks";
            this.flowLayoutPanelBlocks.Size = new System.Drawing.Size(198, 691);
            this.flowLayoutPanelBlocks.TabIndex = 0;
            // 
            // panelAtribuire
            // 
            this.panelAtribuire.BackColor = System.Drawing.Color.Transparent;
            this.panelAtribuire.BackgroundImage = global::LogicalSchemeInterpretor.Properties.Resources.atribuire;
            this.panelAtribuire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAtribuire.Location = new System.Drawing.Point(11, 20);
            this.panelAtribuire.Margin = new System.Windows.Forms.Padding(11, 20, 11, 20);
            this.panelAtribuire.Name = "panelAtribuire";
            this.panelAtribuire.Size = new System.Drawing.Size(170, 80);
            this.panelAtribuire.TabIndex = 1;
            this.panelAtribuire.Click += new System.EventHandler(this.PanelCommand_Click);
            this.panelAtribuire.Paint += new System.Windows.Forms.PaintEventHandler(this.panelAtribuire_Paint);
            // 
            // panelDecizie
            // 
            this.panelDecizie.BackColor = System.Drawing.Color.Transparent;
            this.panelDecizie.BackgroundImage = global::LogicalSchemeInterpretor.Properties.Resources.decizie;
            this.panelDecizie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDecizie.Location = new System.Drawing.Point(11, 140);
            this.panelDecizie.Margin = new System.Windows.Forms.Padding(11, 20, 11, 20);
            this.panelDecizie.Name = "panelDecizie";
            this.panelDecizie.Size = new System.Drawing.Size(170, 80);
            this.panelDecizie.TabIndex = 1;
            this.panelDecizie.Click += new System.EventHandler(this.PanelCommand_Click);
            // 
            // panelCitesteVar
            // 
            this.panelCitesteVar.BackColor = System.Drawing.Color.Transparent;
            this.panelCitesteVar.BackgroundImage = global::LogicalSchemeInterpretor.Properties.Resources.citeste_var;
            this.panelCitesteVar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCitesteVar.Location = new System.Drawing.Point(11, 260);
            this.panelCitesteVar.Margin = new System.Windows.Forms.Padding(11, 20, 11, 20);
            this.panelCitesteVar.Name = "panelCitesteVar";
            this.panelCitesteVar.Size = new System.Drawing.Size(170, 80);
            this.panelCitesteVar.TabIndex = 2;
            this.panelCitesteVar.Click += new System.EventHandler(this.PanelCommand_Click);
            // 
            // panelScrieVar
            // 
            this.panelScrieVar.BackColor = System.Drawing.Color.Transparent;
            this.panelScrieVar.BackgroundImage = global::LogicalSchemeInterpretor.Properties.Resources.scrie_var;
            this.panelScrieVar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelScrieVar.Location = new System.Drawing.Point(11, 380);
            this.panelScrieVar.Margin = new System.Windows.Forms.Padding(11, 20, 11, 20);
            this.panelScrieVar.Name = "panelScrieVar";
            this.panelScrieVar.Size = new System.Drawing.Size(170, 80);
            this.panelScrieVar.TabIndex = 2;
            this.panelScrieVar.Click += new System.EventHandler(this.PanelCommand_Click);
            // 
            // panelScrieText
            // 
            this.panelScrieText.BackColor = System.Drawing.Color.Transparent;
            this.panelScrieText.BackgroundImage = global::LogicalSchemeInterpretor.Properties.Resources.AFIS_TEXT;
            this.panelScrieText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelScrieText.Location = new System.Drawing.Point(11, 500);
            this.panelScrieText.Margin = new System.Windows.Forms.Padding(11, 20, 11, 20);
            this.panelScrieText.Name = "panelScrieText";
            this.panelScrieText.Size = new System.Drawing.Size(170, 110);
            this.panelScrieText.TabIndex = 2;
            this.panelScrieText.Click += new System.EventHandler(this.PanelCommand_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonHelp.FlatAppearance.BorderSize = 0;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHelp.ForeColor = System.Drawing.Color.White;
            this.buttonHelp.Location = new System.Drawing.Point(3, 633);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(191, 37);
            this.buttonHelp.TabIndex = 3;
            this.buttonHelp.Text = "Help";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // panelEtichetaOut
            // 
            this.panelEtichetaOut.BackColor = System.Drawing.Color.Transparent;
            this.panelEtichetaOut.BackgroundImage = global::LogicalSchemeInterpretor.Properties.Resources.eticheta_out;
            this.panelEtichetaOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEtichetaOut.Location = new System.Drawing.Point(208, 8);
            this.panelEtichetaOut.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.panelEtichetaOut.Name = "panelEtichetaOut";
            this.panelEtichetaOut.Size = new System.Drawing.Size(105, 75);
            this.panelEtichetaOut.TabIndex = 2;
            this.panelEtichetaOut.Visible = false;
            this.panelEtichetaOut.Click += new System.EventHandler(this.PanelCommand_Click);
            // 
            // panelEtichetaIn
            // 
            this.panelEtichetaIn.BackColor = System.Drawing.Color.Transparent;
            this.panelEtichetaIn.BackgroundImage = global::LogicalSchemeInterpretor.Properties.Resources.eticheta_in;
            this.panelEtichetaIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEtichetaIn.Location = new System.Drawing.Point(208, 99);
            this.panelEtichetaIn.Margin = new System.Windows.Forms.Padding(11, 8, 11, 8);
            this.panelEtichetaIn.Name = "panelEtichetaIn";
            this.panelEtichetaIn.Size = new System.Drawing.Size(105, 75);
            this.panelEtichetaIn.TabIndex = 1;
            this.panelEtichetaIn.Visible = false;
            this.panelEtichetaIn.Click += new System.EventHandler(this.PanelCommand_Click);
            // 
            // panelDrawing
            // 
            this.panelDrawing.BackColor = System.Drawing.Color.Azure;
            this.panelDrawing.Controls.Add(this.splitContainer);
            this.panelDrawing.Controls.Add(this.consoleTextBox);
            this.panelDrawing.Controls.Add(this.pictureBoxDrawing);
            this.panelDrawing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDrawing.Location = new System.Drawing.Point(198, 0);
            this.panelDrawing.Margin = new System.Windows.Forms.Padding(2);
            this.panelDrawing.Name = "panelDrawing";
            this.panelDrawing.Size = new System.Drawing.Size(964, 691);
            this.panelDrawing.TabIndex = 4;
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.splitContainer.Location = new System.Drawing.Point(0, 653);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.buttonRun);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.buttonDelete);
            this.splitContainer.Size = new System.Drawing.Size(708, 38);
            this.splitContainer.SplitterDistance = 340;
            this.splitContainer.SplitterWidth = 3;
            this.splitContainer.TabIndex = 3;
            // 
            // buttonRun
            // 
            this.buttonRun.BackColor = System.Drawing.Color.LimeGreen;
            this.buttonRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRun.FlatAppearance.BorderSize = 0;
            this.buttonRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRun.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRun.Location = new System.Drawing.Point(0, 0);
            this.buttonRun.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRun.Name = "buttonRun";
            this.buttonRun.Size = new System.Drawing.Size(340, 38);
            this.buttonRun.TabIndex = 1;
            this.buttonRun.Text = "RUN";
            this.buttonRun.UseVisualStyleBackColor = false;
            this.buttonRun.Click += new System.EventHandler(this.buttonRun_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Crimson;
            this.buttonDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDelete.FlatAppearance.BorderSize = 0;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Mongolian Baiti", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.Location = new System.Drawing.Point(0, 0);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(365, 38);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "DELETE";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // consoleTextBox
            // 
            this.consoleTextBox.BackColor = System.Drawing.Color.Black;
            this.consoleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.consoleTextBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.consoleTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleTextBox.ForeColor = System.Drawing.Color.White;
            this.consoleTextBox.Location = new System.Drawing.Point(708, 0);
            this.consoleTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.consoleTextBox.Name = "consoleTextBox";
            this.consoleTextBox.Size = new System.Drawing.Size(256, 691);
            this.consoleTextBox.TabIndex = 2;
            this.consoleTextBox.Text = "";
            // 
            // pictureBoxDrawing
            // 
            this.pictureBoxDrawing.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDrawing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDrawing.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDrawing.Name = "pictureBoxDrawing";
            this.pictureBoxDrawing.Size = new System.Drawing.Size(964, 691);
            this.pictureBoxDrawing.TabIndex = 0;
            this.pictureBoxDrawing.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1162, 691);
            this.Controls.Add(this.panelDrawing);
            this.Controls.Add(this.flowLayoutPanelBlocks);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanelBlocks.ResumeLayout(false);
            this.panelDrawing.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBlocks;
        private System.Windows.Forms.Panel panelEtichetaIn;
        private System.Windows.Forms.Panel panelDecizie;
        private System.Windows.Forms.Panel panelAtribuire;
        private System.Windows.Forms.Panel panelDrawing;
        private System.Windows.Forms.Panel panelCitesteVar;
        private System.Windows.Forms.Panel panelScrieVar;
        private System.Windows.Forms.Panel panelScrieText;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox pictureBoxDrawing;
        private System.Windows.Forms.Panel panelEtichetaOut;
        private System.Windows.Forms.Button buttonRun;
        private System.Windows.Forms.Button buttonDelete;
        private ConsoleTextBox consoleTextBox;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button buttonHelp;
    }
}

