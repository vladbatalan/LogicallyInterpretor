﻿
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
            this.panelEtichetaIn = new System.Windows.Forms.Panel();
            this.panelEtichetaOut = new System.Windows.Forms.Panel();
            this.panelAtribuire = new System.Windows.Forms.Panel();
            this.panelDecizie = new System.Windows.Forms.Panel();
            this.panelCitesteVar = new System.Windows.Forms.Panel();
            this.panelScrieVar = new System.Windows.Forms.Panel();
            this.panelScrieText = new System.Windows.Forms.Panel();
            this.richTextBoxConsole = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanelVariables = new System.Windows.Forms.FlowLayoutPanel();
            this.panelDrawing = new System.Windows.Forms.Panel();
            this.panelEnd = new System.Windows.Forms.Panel();
            this.panelStart = new System.Windows.Forms.Panel();
            this.pictureBoxDrawing = new System.Windows.Forms.PictureBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.flowLayoutPanelBlocks.SuspendLayout();
            this.panelDrawing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawing)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelBlocks
            // 
            this.flowLayoutPanelBlocks.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanelBlocks.Controls.Add(this.panelEtichetaIn);
            this.flowLayoutPanelBlocks.Controls.Add(this.panelEtichetaOut);
            this.flowLayoutPanelBlocks.Controls.Add(this.panelAtribuire);
            this.flowLayoutPanelBlocks.Controls.Add(this.panelDecizie);
            this.flowLayoutPanelBlocks.Controls.Add(this.panelCitesteVar);
            this.flowLayoutPanelBlocks.Controls.Add(this.panelScrieVar);
            this.flowLayoutPanelBlocks.Controls.Add(this.panelScrieText);
            this.flowLayoutPanelBlocks.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelBlocks.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelBlocks.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelBlocks.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.flowLayoutPanelBlocks.Name = "flowLayoutPanelBlocks";
            this.flowLayoutPanelBlocks.Size = new System.Drawing.Size(264, 1095);
            this.flowLayoutPanelBlocks.TabIndex = 0;
            // 
            // panelEtichetaIn
            // 
            this.panelEtichetaIn.BackColor = System.Drawing.Color.Transparent;
            this.panelEtichetaIn.BackgroundImage = global::LogicalSchemeInterpretor.Properties.Resources.eticheta_in;
            this.panelEtichetaIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEtichetaIn.Location = new System.Drawing.Point(15, 10);
            this.panelEtichetaIn.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelEtichetaIn.Name = "panelEtichetaIn";
            this.panelEtichetaIn.Size = new System.Drawing.Size(140, 92);
            this.panelEtichetaIn.TabIndex = 1;
            this.panelEtichetaIn.Click += new System.EventHandler(this.PanelCommand_Click);
            // 
            // panelEtichetaOut
            // 
            this.panelEtichetaOut.BackColor = System.Drawing.Color.Transparent;
            this.panelEtichetaOut.BackgroundImage = global::LogicalSchemeInterpretor.Properties.Resources.eticheta_out;
            this.panelEtichetaOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEtichetaOut.Location = new System.Drawing.Point(15, 122);
            this.panelEtichetaOut.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelEtichetaOut.Name = "panelEtichetaOut";
            this.panelEtichetaOut.Size = new System.Drawing.Size(140, 92);
            this.panelEtichetaOut.TabIndex = 2;
            this.panelEtichetaOut.Click += new System.EventHandler(this.PanelCommand_Click);
            // 
            // panelAtribuire
            // 
            this.panelAtribuire.BackColor = System.Drawing.Color.Transparent;
            this.panelAtribuire.BackgroundImage = global::LogicalSchemeInterpretor.Properties.Resources.atribuire;
            this.panelAtribuire.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelAtribuire.Location = new System.Drawing.Point(15, 234);
            this.panelAtribuire.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelAtribuire.Name = "panelAtribuire";
            this.panelAtribuire.Size = new System.Drawing.Size(227, 98);
            this.panelAtribuire.TabIndex = 1;
            this.panelAtribuire.Click += new System.EventHandler(this.PanelCommand_Click);
            // 
            // panelDecizie
            // 
            this.panelDecizie.BackColor = System.Drawing.Color.Transparent;
            this.panelDecizie.BackgroundImage = global::LogicalSchemeInterpretor.Properties.Resources.decizie;
            this.panelDecizie.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDecizie.Location = new System.Drawing.Point(15, 352);
            this.panelDecizie.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelDecizie.Name = "panelDecizie";
            this.panelDecizie.Size = new System.Drawing.Size(227, 98);
            this.panelDecizie.TabIndex = 1;
            this.panelDecizie.Click += new System.EventHandler(this.PanelCommand_Click);
            // 
            // panelCitesteVar
            // 
            this.panelCitesteVar.BackColor = System.Drawing.Color.Transparent;
            this.panelCitesteVar.BackgroundImage = global::LogicalSchemeInterpretor.Properties.Resources.citeste_var;
            this.panelCitesteVar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCitesteVar.Location = new System.Drawing.Point(15, 470);
            this.panelCitesteVar.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelCitesteVar.Name = "panelCitesteVar";
            this.panelCitesteVar.Size = new System.Drawing.Size(227, 98);
            this.panelCitesteVar.TabIndex = 2;
            this.panelCitesteVar.Click += new System.EventHandler(this.PanelCommand_Click);
            // 
            // panelScrieVar
            // 
            this.panelScrieVar.BackColor = System.Drawing.Color.Transparent;
            this.panelScrieVar.BackgroundImage = global::LogicalSchemeInterpretor.Properties.Resources.scrie_var;
            this.panelScrieVar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelScrieVar.Location = new System.Drawing.Point(15, 588);
            this.panelScrieVar.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelScrieVar.Name = "panelScrieVar";
            this.panelScrieVar.Size = new System.Drawing.Size(227, 98);
            this.panelScrieVar.TabIndex = 2;
            this.panelScrieVar.Click += new System.EventHandler(this.PanelCommand_Click);
            // 
            // panelScrieText
            // 
            this.panelScrieText.BackColor = System.Drawing.Color.Transparent;
            this.panelScrieText.BackgroundImage = global::LogicalSchemeInterpretor.Properties.Resources.AFIS_TEXT;
            this.panelScrieText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelScrieText.Location = new System.Drawing.Point(15, 706);
            this.panelScrieText.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelScrieText.Name = "panelScrieText";
            this.panelScrieText.Size = new System.Drawing.Size(227, 135);
            this.panelScrieText.TabIndex = 2;
            this.panelScrieText.Click += new System.EventHandler(this.PanelCommand_Click);
            // 
            // richTextBoxConsole
            // 
            this.richTextBoxConsole.BackColor = System.Drawing.Color.LightGray;
            this.richTextBoxConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxConsole.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.richTextBoxConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxConsole.ForeColor = System.Drawing.Color.Navy;
            this.richTextBoxConsole.Location = new System.Drawing.Point(264, 905);
            this.richTextBoxConsole.Margin = new System.Windows.Forms.Padding(11, 10, 11, 10);
            this.richTextBoxConsole.Name = "richTextBoxConsole";
            this.richTextBoxConsole.Size = new System.Drawing.Size(1293, 190);
            this.richTextBoxConsole.TabIndex = 1;
            this.richTextBoxConsole.Text = "";
            // 
            // flowLayoutPanelVariables
            // 
            this.flowLayoutPanelVariables.BackColor = System.Drawing.Color.DarkGray;
            this.flowLayoutPanelVariables.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelVariables.Location = new System.Drawing.Point(1383, 0);
            this.flowLayoutPanelVariables.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelVariables.Name = "flowLayoutPanelVariables";
            this.flowLayoutPanelVariables.Size = new System.Drawing.Size(174, 905);
            this.flowLayoutPanelVariables.TabIndex = 3;
            // 
            // panelDrawing
            // 
            this.panelDrawing.BackColor = System.Drawing.Color.Azure;
            this.panelDrawing.Controls.Add(this.panelEnd);
            this.panelDrawing.Controls.Add(this.panelStart);
            this.panelDrawing.Controls.Add(this.pictureBoxDrawing);
            this.panelDrawing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDrawing.Location = new System.Drawing.Point(264, 0);
            this.panelDrawing.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelDrawing.Name = "panelDrawing";
            this.panelDrawing.Size = new System.Drawing.Size(1119, 905);
            this.panelDrawing.TabIndex = 4;
            // 
            // panelEnd
            // 
            this.panelEnd.BackColor = System.Drawing.Color.Transparent;
            this.panelEnd.BackgroundImage = global::LogicalSchemeInterpretor.Properties.Resources.END;
            this.panelEnd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelEnd.Location = new System.Drawing.Point(431, 615);
            this.panelEnd.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelEnd.Name = "panelEnd";
            this.panelEnd.Size = new System.Drawing.Size(140, 92);
            this.panelEnd.TabIndex = 4;
            this.panelEnd.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyControl_MouseDown);
            this.panelEnd.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MyControl_MouseMove);
            // 
            // panelStart
            // 
            this.panelStart.BackColor = System.Drawing.Color.Transparent;
            this.panelStart.BackgroundImage = global::LogicalSchemeInterpretor.Properties.Resources.START;
            this.panelStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelStart.Location = new System.Drawing.Point(431, 10);
            this.panelStart.Margin = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.panelStart.Name = "panelStart";
            this.panelStart.Size = new System.Drawing.Size(140, 92);
            this.panelStart.TabIndex = 3;
            this.panelStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MyControl_MouseDown);
            this.panelStart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MyControl_MouseMove);
            // 
            // pictureBoxDrawing
            // 
            this.pictureBoxDrawing.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDrawing.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxDrawing.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDrawing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBoxDrawing.Name = "pictureBoxDrawing";
            this.pictureBoxDrawing.Size = new System.Drawing.Size(1119, 905);
            this.pictureBoxDrawing.TabIndex = 0;
            this.pictureBoxDrawing.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1557, 1095);
            this.Controls.Add(this.panelDrawing);
            this.Controls.Add(this.flowLayoutPanelVariables);
            this.Controls.Add(this.richTextBoxConsole);
            this.Controls.Add(this.flowLayoutPanelBlocks);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = " ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanelBlocks.ResumeLayout(false);
            this.panelDrawing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDrawing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelBlocks;
        private System.Windows.Forms.RichTextBox richTextBoxConsole;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelVariables;
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
        private System.Windows.Forms.Panel panelStart;
        private System.Windows.Forms.Panel panelEnd;
    }
}

