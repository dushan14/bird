﻿namespace flyBird
{
    partial class ContactsOnMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactsOnMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.refrshIpButton = new MetroFramework.Controls.MetroButton();
            this.label2 = new System.Windows.Forms.Label();
            this.myIpLabel = new System.Windows.Forms.Label();
            this.connectIpTokenText = new MetroFramework.Controls.MetroTextBox();
            this.connectBtn = new MetroFramework.Controls.MetroButton();
            this.contactsPanel = new MetroFramework.Controls.MetroPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(151)))), ((int)(((byte)(181)))));
            this.panel1.Controls.Add(this.refrshIpButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.myIpLabel);
            this.panel1.Controls.Add(this.connectIpTokenText);
            this.panel1.Controls.Add(this.connectBtn);
            this.panel1.Controls.Add(this.contactsPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 552);
            this.panel1.TabIndex = 0;
            // 
            // refrshIpButton
            // 
            this.refrshIpButton.BackgroundImage = global::flyBird.Properties.Resources.Refresh;
            this.refrshIpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.refrshIpButton.Location = new System.Drawing.Point(138, 20);
            this.refrshIpButton.Name = "refrshIpButton";
            this.refrshIpButton.Size = new System.Drawing.Size(26, 23);
            this.refrshIpButton.TabIndex = 11;
            this.refrshIpButton.UseSelectable = true;
            this.refrshIpButton.Click += new System.EventHandler(this.refrshIpButton_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "My IP :";
            // 
            // myIpLabel
            // 
            this.myIpLabel.AutoSize = true;
            this.myIpLabel.ForeColor = System.Drawing.Color.White;
            this.myIpLabel.Location = new System.Drawing.Point(53, 24);
            this.myIpLabel.Name = "myIpLabel";
            this.myIpLabel.Size = new System.Drawing.Size(79, 13);
            this.myIpLabel.TabIndex = 8;
            this.myIpLabel.Text = "Not Connected";
            // 
            // connectIpTokenText
            // 
            // 
            // 
            // 
            this.connectIpTokenText.CustomButton.Image = null;
            this.connectIpTokenText.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.connectIpTokenText.CustomButton.Name = "";
            this.connectIpTokenText.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.connectIpTokenText.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.connectIpTokenText.CustomButton.TabIndex = 1;
            this.connectIpTokenText.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.connectIpTokenText.CustomButton.UseSelectable = true;
            this.connectIpTokenText.CustomButton.Visible = false;
            this.connectIpTokenText.Lines = new string[] {
        "127.0.0.1"};
            this.connectIpTokenText.Location = new System.Drawing.Point(16, 60);
            this.connectIpTokenText.MaxLength = 32767;
            this.connectIpTokenText.Name = "connectIpTokenText";
            this.connectIpTokenText.PasswordChar = '\0';
            this.connectIpTokenText.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.connectIpTokenText.SelectedText = "";
            this.connectIpTokenText.SelectionLength = 0;
            this.connectIpTokenText.SelectionStart = 0;
            this.connectIpTokenText.ShortcutsEnabled = true;
            this.connectIpTokenText.Size = new System.Drawing.Size(95, 23);
            this.connectIpTokenText.TabIndex = 7;
            this.connectIpTokenText.Text = "127.0.0.1";
            this.connectIpTokenText.UseSelectable = true;
            this.connectIpTokenText.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.connectIpTokenText.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.connectIpTokenText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.connectIpTokenText_KeyDown);
            // 
            // connectBtn
            // 
            this.connectBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("connectBtn.BackgroundImage")));
            this.connectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.connectBtn.Location = new System.Drawing.Point(138, 60);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(75, 23);
            this.connectBtn.TabIndex = 6;
            this.connectBtn.UseSelectable = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            this.connectBtn.MouseLeave += new System.EventHandler(this.connectBtn_MouseLeave);
            this.connectBtn.MouseHover += new System.EventHandler(this.connectBtn_MouseHover);
            // 
            // contactsPanel
            // 
            this.contactsPanel.AutoScroll = true;
            this.contactsPanel.HorizontalScrollbar = true;
            this.contactsPanel.HorizontalScrollbarBarColor = true;
            this.contactsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.contactsPanel.HorizontalScrollbarSize = 10;
            this.contactsPanel.Location = new System.Drawing.Point(0, 102);
            this.contactsPanel.Name = "contactsPanel";
            this.contactsPanel.Size = new System.Drawing.Size(241, 450);
            this.contactsPanel.TabIndex = 5;
            this.contactsPanel.VerticalScrollbar = true;
            this.contactsPanel.VerticalScrollbarBarColor = true;
            this.contactsPanel.VerticalScrollbarHighlightOnWheel = false;
            this.contactsPanel.VerticalScrollbarSize = 10;
            // 
            // ContactsOnMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "ContactsOnMain";
            this.Size = new System.Drawing.Size(241, 552);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroPanel contactsPanel;
        private MetroFramework.Controls.MetroButton connectBtn;
        private MetroFramework.Controls.MetroTextBox connectIpTokenText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label myIpLabel;
        private MetroFramework.Controls.MetroButton refrshIpButton;
    }
}
