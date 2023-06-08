namespace FrezDBZ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            расчетToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            NavigationPanel = new Panel();
            menuStrip2 = new MenuStrip();
            типРезцаToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            InfoPanel = new Panel();
            RezecTypeDescription = new Label();
            RezecTypeName = new Label();
            FrezPicture = new PictureBox();
            BDPanel = new Panel();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            toppanel = new Panel();
            menuStrip1.SuspendLayout();
            NavigationPanel.SuspendLayout();
            menuStrip2.SuspendLayout();
            InfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FrezPicture).BeginInit();
            BDPanel.SuspendLayout();
            toppanel.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Dock = DockStyle.Fill;
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(964, 26);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { расчетToolStripMenuItem, выходToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 22);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // расчетToolStripMenuItem
            // 
            расчетToolStripMenuItem.Name = "расчетToolStripMenuItem";
            расчетToolStripMenuItem.Size = new Size(180, 22);
            расчетToolStripMenuItem.Text = "Расчет";
            расчетToolStripMenuItem.Click += расчетToolStripMenuItem_Click;
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(180, 22);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // NavigationPanel
            // 
            NavigationPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            NavigationPanel.BackColor = SystemColors.ControlLight;
            NavigationPanel.BorderStyle = BorderStyle.FixedSingle;
            NavigationPanel.Controls.Add(menuStrip2);
            NavigationPanel.ForeColor = SystemColors.ControlText;
            NavigationPanel.Location = new Point(0, 30);
            NavigationPanel.Name = "NavigationPanel";
            NavigationPanel.Size = new Size(243, 630);
            NavigationPanel.TabIndex = 1;
            // 
            // menuStrip2
            // 
            menuStrip2.AutoSize = false;
            menuStrip2.Dock = DockStyle.None;
            menuStrip2.Items.AddRange(new ToolStripItem[] { типРезцаToolStripMenuItem });
            menuStrip2.Location = new Point(19, 33);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(0);
            menuStrip2.Size = new Size(180, 20);
            menuStrip2.TabIndex = 0;
            menuStrip2.Text = "menuStrip2";
            // 
            // типРезцаToolStripMenuItem
            // 
            типРезцаToolStripMenuItem.AutoSize = false;
            типРезцаToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem3, toolStripMenuItem4 });
            типРезцаToolStripMenuItem.ForeColor = SystemColors.ControlText;
            типРезцаToolStripMenuItem.Name = "типРезцаToolStripMenuItem";
            типРезцаToolStripMenuItem.Padding = new Padding(0);
            типРезцаToolStripMenuItem.Size = new Size(180, 20);
            типРезцаToolStripMenuItem.Text = "Тип Резцов";
            типРезцаToolStripMenuItem.TextAlign = ContentAlignment.MiddleLeft;
            типРезцаToolStripMenuItem.DropDownItemClicked += типРезцаToolStripMenuItem_DropDownItemClicked;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.BackColor = SystemColors.Control;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(80, 22);
            toolStripMenuItem1.Text = "1";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.BackColor = SystemColors.Control;
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(80, 22);
            toolStripMenuItem3.Text = "2";
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.BackColor = SystemColors.Control;
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(80, 22);
            toolStripMenuItem4.Text = "3";
            // 
            // InfoPanel
            // 
            InfoPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            InfoPanel.BackColor = SystemColors.Control;
            InfoPanel.BorderStyle = BorderStyle.FixedSingle;
            InfoPanel.Controls.Add(RezecTypeDescription);
            InfoPanel.Controls.Add(RezecTypeName);
            InfoPanel.Controls.Add(FrezPicture);
            InfoPanel.Location = new Point(249, 30);
            InfoPanel.Margin = new Padding(3, 3, 0, 3);
            InfoPanel.Name = "InfoPanel";
            InfoPanel.Size = new Size(715, 173);
            InfoPanel.TabIndex = 2;
            // 
            // RezecTypeDescription
            // 
            RezecTypeDescription.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            RezecTypeDescription.AutoEllipsis = true;
            RezecTypeDescription.Location = new Point(175, 43);
            RezecTypeDescription.Name = "RezecTypeDescription";
            RezecTypeDescription.Size = new Size(529, 116);
            RezecTypeDescription.TabIndex = 2;
            // 
            // RezecTypeName
            // 
            RezecTypeName.AutoSize = true;
            RezecTypeName.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            RezecTypeName.Location = new Point(167, 14);
            RezecTypeName.Name = "RezecTypeName";
            RezecTypeName.Size = new Size(80, 19);
            RezecTypeName.TabIndex = 1;
            RezecTypeName.Text = "Тип Резцов";
            // 
            // FrezPicture
            // 
            FrezPicture.BackColor = SystemColors.ControlDarkDark;
            FrezPicture.BackgroundImageLayout = ImageLayout.None;
            FrezPicture.ImageLocation = "";
            FrezPicture.Location = new Point(10, 10);
            FrezPicture.Name = "FrezPicture";
            FrezPicture.Size = new Size(148, 151);
            FrezPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            FrezPicture.TabIndex = 0;
            FrezPicture.TabStop = false;
            // 
            // BDPanel
            // 
            BDPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            BDPanel.BackColor = Color.Lime;
            BDPanel.BorderStyle = BorderStyle.FixedSingle;
            BDPanel.Controls.Add(listView1);
            BDPanel.Location = new Point(249, 209);
            BDPanel.Name = "BDPanel";
            BDPanel.Size = new Size(716, 451);
            BDPanel.TabIndex = 3;
            // 
            // listView1
            // 
            listView1.AllowDrop = true;
            listView1.BorderStyle = BorderStyle.None;
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Dock = DockStyle.Fill;
            listView1.FullRowSelect = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(0, 0);
            listView1.Name = "listView1";
            listView1.Size = new Size(714, 449);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Тип";
            columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Марка Стали";
            columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Прочность Стали";
            columnHeader3.Width = 90;
            // 
            // toppanel
            // 
            toppanel.BorderStyle = BorderStyle.FixedSingle;
            toppanel.Controls.Add(menuStrip1);
            toppanel.Dock = DockStyle.Top;
            toppanel.Location = new Point(0, 0);
            toppanel.Margin = new Padding(0, 3, 0, 3);
            toppanel.Name = "toppanel";
            toppanel.Size = new Size(966, 28);
            toppanel.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(966, 661);
            Controls.Add(toppanel);
            Controls.Add(BDPanel);
            Controls.Add(InfoPanel);
            Controls.Add(NavigationPanel);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Резцы";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            NavigationPanel.ResumeLayout(false);
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            InfoPanel.ResumeLayout(false);
            InfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FrezPicture).EndInit();
            BDPanel.ResumeLayout(false);
            toppanel.ResumeLayout(false);
            toppanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private Panel NavigationPanel;
        private Panel InfoPanel;
        private Panel BDPanel;
        private Label RezecTypeName;
        private PictureBox FrezPicture;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem расчетToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem типРезцаToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem4;
        private Panel toppanel;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label RezecTypeDescription;
    }
}