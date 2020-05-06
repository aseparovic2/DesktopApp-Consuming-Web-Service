namespace Project3_Separovic
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.searchPanel = new System.Windows.Forms.Panel();
            this.countyLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.townLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.orgTypeLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orgTypeComboBox = new MetroFramework.Controls.MetroComboBox();
            this.nameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.stateComboBox = new MetroFramework.Controls.MetroComboBox();
            this.townComboBox = new MetroFramework.Controls.MetroComboBox();
            this.countyTextBox = new MetroFramework.Controls.MetroTextBox();
            this.searchButton = new MetroFramework.Controls.MetroButton();
            this.Search = new MetroFramework.Components.MetroToolTip();
            this.searchPanel.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // searchPanel
            // 
            this.searchPanel.Controls.Add(this.searchButton);
            this.searchPanel.Controls.Add(this.countyTextBox);
            this.searchPanel.Controls.Add(this.townComboBox);
            this.searchPanel.Controls.Add(this.stateComboBox);
            this.searchPanel.Controls.Add(this.nameTextBox);
            this.searchPanel.Controls.Add(this.orgTypeComboBox);
            this.searchPanel.Controls.Add(this.countyLabel);
            this.searchPanel.Controls.Add(this.stateLabel);
            this.searchPanel.Controls.Add(this.townLabel);
            this.searchPanel.Controls.Add(this.nameLabel);
            this.searchPanel.Controls.Add(this.orgTypeLabel);
            this.searchPanel.Location = new System.Drawing.Point(869, 80);
            this.searchPanel.Name = "searchPanel";
            this.searchPanel.Size = new System.Drawing.Size(314, 391);
            this.searchPanel.TabIndex = 0;
            // 
            // countyLabel
            // 
            this.countyLabel.AutoSize = true;
            this.countyLabel.Location = new System.Drawing.Point(10, 233);
            this.countyLabel.Name = "countyLabel";
            this.countyLabel.Size = new System.Drawing.Size(56, 17);
            this.countyLabel.TabIndex = 4;
            this.countyLabel.Text = "County:";
            this.countyLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(14, 134);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(45, 17);
            this.stateLabel.TabIndex = 3;
            this.stateLabel.Text = "State:";
            this.stateLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // townLabel
            // 
            this.townLabel.AutoSize = true;
            this.townLabel.Location = new System.Drawing.Point(14, 186);
            this.townLabel.Name = "townLabel";
            this.townLabel.Size = new System.Drawing.Size(46, 17);
            this.townLabel.TabIndex = 2;
            this.townLabel.Text = "Town:";
            this.townLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(10, 91);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 17);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name:";
            this.nameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // orgTypeLabel
            // 
            this.orgTypeLabel.AutoSize = true;
            this.orgTypeLabel.Location = new System.Drawing.Point(10, 37);
            this.orgTypeLabel.Name = "orgTypeLabel";
            this.orgTypeLabel.Size = new System.Drawing.Size(68, 17);
            this.orgTypeLabel.TabIndex = 0;
            this.orgTypeLabel.Text = "OrgType:";
            this.orgTypeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(161, 33);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 27);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(374, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(409, 391);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(12, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 299);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // orgTypeComboBox
            // 
            this.orgTypeComboBox.FormattingEnabled = true;
            this.orgTypeComboBox.ItemHeight = 24;
            this.orgTypeComboBox.Location = new System.Drawing.Point(91, 34);
            this.orgTypeComboBox.Name = "orgTypeComboBox";
            this.orgTypeComboBox.Size = new System.Drawing.Size(148, 30);
            this.orgTypeComboBox.TabIndex = 7;
            this.orgTypeComboBox.UseSelectable = true;
            // 
            // nameTextBox
            // 
            // 
            // 
            // 
            this.nameTextBox.CustomButton.Image = null;
            this.nameTextBox.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.nameTextBox.CustomButton.Name = "";
            this.nameTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameTextBox.CustomButton.TabIndex = 1;
            this.nameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameTextBox.CustomButton.UseSelectable = true;
            this.nameTextBox.CustomButton.Visible = false;
            this.nameTextBox.Lines = new string[0];
            this.nameTextBox.Location = new System.Drawing.Point(91, 85);
            this.nameTextBox.MaxLength = 32767;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.SelectionLength = 0;
            this.nameTextBox.SelectionStart = 0;
            this.nameTextBox.ShortcutsEnabled = true;
            this.nameTextBox.Size = new System.Drawing.Size(148, 23);
            this.nameTextBox.TabIndex = 7;
            this.nameTextBox.UseSelectable = true;
            this.nameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.ItemHeight = 24;
            this.stateComboBox.Location = new System.Drawing.Point(91, 131);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(148, 30);
            this.stateComboBox.TabIndex = 12;
            this.stateComboBox.UseSelectable = true;
            this.stateComboBox.SelectedIndexChanged += new System.EventHandler(this.stateComboBox_SelectedIndexChanged_1);
            // 
            // townComboBox
            // 
            this.townComboBox.FormattingEnabled = true;
            this.townComboBox.ItemHeight = 24;
            this.townComboBox.Location = new System.Drawing.Point(91, 183);
            this.townComboBox.Name = "townComboBox";
            this.townComboBox.Size = new System.Drawing.Size(148, 30);
            this.townComboBox.TabIndex = 13;
            this.townComboBox.UseSelectable = true;
            // 
            // countyTextBox
            // 
            // 
            // 
            // 
            this.countyTextBox.CustomButton.Image = null;
            this.countyTextBox.CustomButton.Location = new System.Drawing.Point(126, 1);
            this.countyTextBox.CustomButton.Name = "";
            this.countyTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.countyTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.countyTextBox.CustomButton.TabIndex = 1;
            this.countyTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.countyTextBox.CustomButton.UseSelectable = true;
            this.countyTextBox.CustomButton.Visible = false;
            this.countyTextBox.Lines = new string[0];
            this.countyTextBox.Location = new System.Drawing.Point(91, 233);
            this.countyTextBox.MaxLength = 32767;
            this.countyTextBox.Name = "countyTextBox";
            this.countyTextBox.PasswordChar = '\0';
            this.countyTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.countyTextBox.SelectedText = "";
            this.countyTextBox.SelectionLength = 0;
            this.countyTextBox.SelectionStart = 0;
            this.countyTextBox.ShortcutsEnabled = true;
            this.countyTextBox.Size = new System.Drawing.Size(148, 23);
            this.countyTextBox.TabIndex = 14;
            this.countyTextBox.UseSelectable = true;
            this.countyTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.countyTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.searchButton.Location = new System.Drawing.Point(91, 273);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(148, 37);
            this.searchButton.TabIndex = 7;
            this.searchButton.Text = "Search";
            this.searchButton.UseSelectable = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // Search
            // 
            this.Search.Style = MetroFramework.MetroColorStyle.Blue;
            this.Search.StyleManager = null;
            this.Search.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 565);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.searchPanel.ResumeLayout(false);
            this.searchPanel.PerformLayout();
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel searchPanel;
        private System.Windows.Forms.Label countyLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label townLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label orgTypeLabel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTextBox countyTextBox;
        private MetroFramework.Controls.MetroComboBox townComboBox;
        private MetroFramework.Controls.MetroComboBox stateComboBox;
        private MetroFramework.Controls.MetroTextBox nameTextBox;
        private MetroFramework.Controls.MetroComboBox orgTypeComboBox;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroButton searchButton;
        private MetroFramework.Components.MetroToolTip Search;
    }
}

