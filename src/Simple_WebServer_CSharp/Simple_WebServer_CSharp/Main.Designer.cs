namespace Simple_WebServer_CSharp
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel_main = new System.Windows.Forms.Panel();
            this.gb_mode = new System.Windows.Forms.GroupBox();
            this.cb_qsmode = new System.Windows.Forms.CheckBox();
            this.cb_minMode = new System.Windows.Forms.CheckBox();
            this.btn_test = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.gb_rootPath = new System.Windows.Forms.GroupBox();
            this.btn_path = new System.Windows.Forms.Button();
            this.tb_path = new System.Windows.Forms.TextBox();
            this.gb_port = new System.Windows.Forms.GroupBox();
            this.nud_port = new System.Windows.Forms.NumericUpDown();
            this.gb_ipaddress = new System.Windows.Forms.GroupBox();
            this.nud1 = new System.Windows.Forms.NumericUpDown();
            this.nud2 = new System.Windows.Forms.NumericUpDown();
            this.nud3 = new System.Windows.Forms.NumericUpDown();
            this.nud4 = new System.Windows.Forms.NumericUpDown();
            this.btn_start = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tssl_label1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_main.SuspendLayout();
            this.gb_mode.SuspendLayout();
            this.gb_rootPath.SuspendLayout();
            this.gb_port.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_port)).BeginInit();
            this.gb_ipaddress.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud4)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Controls.Add(this.gb_mode);
            this.panel_main.Controls.Add(this.btn_test);
            this.panel_main.Controls.Add(this.btn_stop);
            this.panel_main.Controls.Add(this.gb_rootPath);
            this.panel_main.Controls.Add(this.gb_port);
            this.panel_main.Controls.Add(this.gb_ipaddress);
            this.panel_main.Controls.Add(this.btn_start);
            this.panel_main.Location = new System.Drawing.Point(12, 12);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(465, 303);
            this.panel_main.TabIndex = 14;
            // 
            // gb_mode
            // 
            this.gb_mode.Controls.Add(this.cb_qsmode);
            this.gb_mode.Controls.Add(this.cb_minMode);
            this.gb_mode.Location = new System.Drawing.Point(14, 162);
            this.gb_mode.Name = "gb_mode";
            this.gb_mode.Size = new System.Drawing.Size(435, 61);
            this.gb_mode.TabIndex = 13;
            this.gb_mode.TabStop = false;
            this.gb_mode.Text = "Mode";
            // 
            // cb_qsmode
            // 
            this.cb_qsmode.AutoSize = true;
            this.cb_qsmode.Checked = global::Simple_WebServer_CSharp.Properties.Settings.Default.quickStart;
            this.cb_qsmode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_qsmode.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::Simple_WebServer_CSharp.Properties.Settings.Default, "quickStart", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.cb_qsmode.Location = new System.Drawing.Point(263, 24);
            this.cb_qsmode.Name = "cb_qsmode";
            this.cb_qsmode.Size = new System.Drawing.Size(117, 19);
            this.cb_qsmode.TabIndex = 7;
            this.cb_qsmode.Text = "Quick start";
            this.cb_qsmode.UseVisualStyleBackColor = true;
            // 
            // cb_minMode
            // 
            this.cb_minMode.AutoSize = true;
            this.cb_minMode.Location = new System.Drawing.Point(26, 24);
            this.cb_minMode.Name = "cb_minMode";
            this.cb_minMode.Size = new System.Drawing.Size(149, 19);
            this.cb_minMode.TabIndex = 6;
            this.cb_minMode.Text = "Run minimized  ";
            this.cb_minMode.UseVisualStyleBackColor = true;
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(174, 238);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(100, 45);
            this.btn_test.TabIndex = 9;
            this.btn_test.Text = "Test";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(322, 238);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(100, 45);
            this.btn_stop.TabIndex = 10;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // gb_rootPath
            // 
            this.gb_rootPath.Controls.Add(this.btn_path);
            this.gb_rootPath.Controls.Add(this.tb_path);
            this.gb_rootPath.Location = new System.Drawing.Point(14, 88);
            this.gb_rootPath.Name = "gb_rootPath";
            this.gb_rootPath.Size = new System.Drawing.Size(435, 67);
            this.gb_rootPath.TabIndex = 12;
            this.gb_rootPath.TabStop = false;
            this.gb_rootPath.Text = "Root path";
            // 
            // btn_path
            // 
            this.btn_path.Location = new System.Drawing.Point(374, 24);
            this.btn_path.Name = "btn_path";
            this.btn_path.Size = new System.Drawing.Size(34, 25);
            this.btn_path.TabIndex = 5;
            this.btn_path.Text = "...";
            this.btn_path.UseVisualStyleBackColor = true;
            this.btn_path.Click += new System.EventHandler(this.btn_path_Click);
            // 
            // tb_path
            // 
            this.tb_path.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::Simple_WebServer_CSharp.Properties.Settings.Default, "path", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.tb_path.Location = new System.Drawing.Point(16, 24);
            this.tb_path.Name = "tb_path";
            this.tb_path.ReadOnly = true;
            this.tb_path.Size = new System.Drawing.Size(341, 25);
            this.tb_path.TabIndex = 16;
            this.tb_path.Text = global::Simple_WebServer_CSharp.Properties.Settings.Default.path;
            // 
            // gb_port
            // 
            this.gb_port.Controls.Add(this.nud_port);
            this.gb_port.Location = new System.Drawing.Point(335, 15);
            this.gb_port.Name = "gb_port";
            this.gb_port.Size = new System.Drawing.Size(114, 67);
            this.gb_port.TabIndex = 9;
            this.gb_port.TabStop = false;
            this.gb_port.Text = "Port";
            // 
            // nud_port
            // 
            this.nud_port.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Simple_WebServer_CSharp.Properties.Settings.Default, "port", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nud_port.Location = new System.Drawing.Point(26, 24);
            this.nud_port.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nud_port.Name = "nud_port";
            this.nud_port.Size = new System.Drawing.Size(61, 25);
            this.nud_port.TabIndex = 4;
            this.nud_port.Value = global::Simple_WebServer_CSharp.Properties.Settings.Default.port;
            // 
            // gb_ipaddress
            // 
            this.gb_ipaddress.Controls.Add(this.nud1);
            this.gb_ipaddress.Controls.Add(this.nud2);
            this.gb_ipaddress.Controls.Add(this.nud3);
            this.gb_ipaddress.Controls.Add(this.nud4);
            this.gb_ipaddress.Location = new System.Drawing.Point(14, 14);
            this.gb_ipaddress.Name = "gb_ipaddress";
            this.gb_ipaddress.Size = new System.Drawing.Size(298, 68);
            this.gb_ipaddress.TabIndex = 11;
            this.gb_ipaddress.TabStop = false;
            this.gb_ipaddress.Text = "IP Address";
            // 
            // nud1
            // 
            this.nud1.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Simple_WebServer_CSharp.Properties.Settings.Default, "ip1", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nud1.Location = new System.Drawing.Point(16, 24);
            this.nud1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud1.Name = "nud1";
            this.nud1.Size = new System.Drawing.Size(61, 25);
            this.nud1.TabIndex = 0;
            this.nud1.Value = global::Simple_WebServer_CSharp.Properties.Settings.Default.ip1;
            // 
            // nud2
            // 
            this.nud2.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Simple_WebServer_CSharp.Properties.Settings.Default, "ip2", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nud2.Location = new System.Drawing.Point(83, 24);
            this.nud2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud2.Name = "nud2";
            this.nud2.Size = new System.Drawing.Size(61, 25);
            this.nud2.TabIndex = 1;
            this.nud2.Value = global::Simple_WebServer_CSharp.Properties.Settings.Default.ip2;
            // 
            // nud3
            // 
            this.nud3.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Simple_WebServer_CSharp.Properties.Settings.Default, "ip3", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nud3.Location = new System.Drawing.Point(150, 24);
            this.nud3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud3.Name = "nud3";
            this.nud3.Size = new System.Drawing.Size(61, 25);
            this.nud3.TabIndex = 2;
            this.nud3.Value = global::Simple_WebServer_CSharp.Properties.Settings.Default.ip3;
            // 
            // nud4
            // 
            this.nud4.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::Simple_WebServer_CSharp.Properties.Settings.Default, "ip4", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.nud4.Location = new System.Drawing.Point(217, 24);
            this.nud4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nud4.Name = "nud4";
            this.nud4.Size = new System.Drawing.Size(61, 25);
            this.nud4.TabIndex = 3;
            this.nud4.Value = global::Simple_WebServer_CSharp.Properties.Settings.Default.ip4;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(30, 238);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(100, 45);
            this.btn_start.TabIndex = 8;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tssl_label1});
            this.statusStrip.Location = new System.Drawing.Point(0, 321);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(487, 22);
            this.statusStrip.TabIndex = 17;
            this.statusStrip.Text = "statusStrip";
            // 
            // tssl_label1
            // 
            this.tssl_label1.Name = "tssl_label1";
            this.tssl_label1.Size = new System.Drawing.Size(0, 17);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "adsa";
            this.notifyIcon.BalloonTipTitle = "asdas";
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.startToolStripMenuItem,
            this.stopToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(155, 106);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.startToolStripMenuItem.Text = "Start Server";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // stopToolStripMenuItem
            // 
            this.stopToolStripMenuItem.Name = "stopToolStripMenuItem";
            this.stopToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.stopToolStripMenuItem.Text = "Stop Server";
            this.stopToolStripMenuItem.Click += new System.EventHandler(this.stopToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(151, 6);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 343);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.panel_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple WebServer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.panel_main.ResumeLayout(false);
            this.gb_mode.ResumeLayout(false);
            this.gb_mode.PerformLayout();
            this.gb_rootPath.ResumeLayout(false);
            this.gb_rootPath.PerformLayout();
            this.gb_port.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_port)).EndInit();
            this.gb_ipaddress.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud4)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nud1;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.NumericUpDown nud_port;
        private System.Windows.Forms.NumericUpDown nud4;
        private System.Windows.Forms.NumericUpDown nud3;
        private System.Windows.Forms.NumericUpDown nud2;
        private System.Windows.Forms.GroupBox gb_port;
        private System.Windows.Forms.GroupBox gb_ipaddress;
        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.GroupBox gb_rootPath;
        private System.Windows.Forms.Button btn_path;
        private System.Windows.Forms.TextBox tb_path;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tssl_label1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.CheckBox cb_minMode;
        private System.Windows.Forms.GroupBox gb_mode;
        private System.Windows.Forms.CheckBox cb_qsmode;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
    }
}

