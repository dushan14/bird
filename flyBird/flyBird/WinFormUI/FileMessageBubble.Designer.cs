﻿namespace flyBird.WinFormUI
{
    partial class FileMessageBubble
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstTransfers = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pauseStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.overallProgressBar = new MetroFramework.Controls.MetroProgressBar();
            this.bubbleTime = new System.Windows.Forms.Label();
            this.outputButton = new MetroFramework.Controls.MetroButton();
            this.fileOpenBtn = new MetroFramework.Controls.MetroButton();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTransfers
            // 
            this.lstTransfers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstTransfers.ContextMenuStrip = this.contextMenuStrip1;
            this.lstTransfers.Location = new System.Drawing.Point(3, 3);
            this.lstTransfers.Name = "lstTransfers";
            this.lstTransfers.Size = new System.Drawing.Size(327, 92);
            this.lstTransfers.TabIndex = 0;
            this.lstTransfers.UseCompatibleStateImageBehavior = false;
            this.lstTransfers.View = System.Windows.Forms.View.Details;
            this.lstTransfers.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Filename";
            this.columnHeader2.Width = 229;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Progress";
            this.columnHeader3.Width = 93;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pauseStartToolStripMenuItem,
            this.stopToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 48);
            // 
            // pauseStartToolStripMenuItem
            // 
            this.pauseStartToolStripMenuItem.Name = "pauseStartToolStripMenuItem";
            this.pauseStartToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.pauseStartToolStripMenuItem.Text = "Pause/Start";
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.stopToolStripMenuItem.Text = "Stop";
            // 
            // overallProgressBar
            // 
            this.overallProgressBar.Location = new System.Drawing.Point(3, 98);
            this.overallProgressBar.Name = "overallProgressBar";
            this.overallProgressBar.Size = new System.Drawing.Size(327, 16);
            this.overallProgressBar.TabIndex = 1;
            // 
            // bubbleTime
            // 
            this.bubbleTime.AutoSize = true;
            this.bubbleTime.Location = new System.Drawing.Point(5, 118);
            this.bubbleTime.Name = "bubbleTime";
            this.bubbleTime.Size = new System.Drawing.Size(35, 13);
            this.bubbleTime.TabIndex = 3;
            this.bubbleTime.Text = "label1";
            // 
            // outputButton
            // 
            this.outputButton.Location = new System.Drawing.Point(173, 116);
            this.outputButton.Name = "outputButton";
            this.outputButton.Size = new System.Drawing.Size(75, 15);
            this.outputButton.TabIndex = 6;
            this.outputButton.Text = "Output";
            this.outputButton.UseSelectable = true;
            this.outputButton.Click += new System.EventHandler(this.outputButton_Click);
            // 
            // fileOpenBtn
            // 
            this.fileOpenBtn.Location = new System.Drawing.Point(255, 116);
            this.fileOpenBtn.Name = "fileOpenBtn";
            this.fileOpenBtn.Size = new System.Drawing.Size(75, 15);
            this.fileOpenBtn.TabIndex = 7;
            this.fileOpenBtn.Text = "Open file";
            this.fileOpenBtn.UseSelectable = true;
            this.fileOpenBtn.Click += new System.EventHandler(this.fileOpenBtn_Click);
            // 
            // FileMessageBubble
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fileOpenBtn);
            this.Controls.Add(this.outputButton);
            this.Controls.Add(this.bubbleTime);
            this.Controls.Add(this.overallProgressBar);
            this.Controls.Add(this.lstTransfers);
            this.Name = "FileMessageBubble";
            this.Size = new System.Drawing.Size(333, 134);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstTransfers;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MetroFramework.Controls.MetroProgressBar overallProgressBar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pauseStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.Label bubbleTime;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private MetroFramework.Controls.MetroButton outputButton;
        private MetroFramework.Controls.MetroButton fileOpenBtn;
    }
}
