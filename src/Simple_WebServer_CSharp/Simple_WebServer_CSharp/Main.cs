using Simple_WebServer;
using System;
using System.Net;
using System.Windows.Forms;

namespace Simple_WebServer_CSharp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Server server = new Server();

        private void btn_start_Click(object sender, EventArgs e)
        {
            IPAddress ipAddress = IPAddress.Parse(nud1.Value.ToString() + "." +
                nud2.Value.ToString() + "." + nud3.Value.ToString() + "." + nud4.Value.ToString());

            if (!server.Start(ipAddress, Convert.ToInt32(nud_port.Value), 100, tb_path.Text))
            {

                MessageBox.Show(Properties.Resources.NotStart);
            }

            if (cb_minMode.Checked && server.RUN_STATUS)
                Hide();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (server.RUN_STATUS)
            {
                nud1.ReadOnly = true;
                nud2.ReadOnly = true;
                nud3.ReadOnly = true;
                nud4.ReadOnly = true;
                nud1.Increment = 0;
                nud2.Increment = 0;
                nud3.Increment = 0;
                nud4.Increment = 0;
                nud_port.Increment = 0;
                nud_port.ReadOnly = true;
                btn_stop.Enabled = true;
                btn_test.Enabled = true;
                stopToolStripMenuItem.Enabled = true;
                btn_path.Enabled = false;
                btn_start.Enabled = false;
                cb_minMode.Enabled = false;
                startToolStripMenuItem.Enabled = false;
                tssl_label1.Text = Properties.Resources.running;
                notifyIcon.Text = Properties.Resources.running;
            }
            else
            {
                nud1.ReadOnly = false;
                nud2.ReadOnly = false;
                nud3.ReadOnly = false;
                nud4.ReadOnly = false;
                nud1.Increment = 1;
                nud2.Increment = 1;
                nud3.Increment = 1;
                nud4.Increment = 1;
                nud_port.Increment = 1;
                nud_port.ReadOnly = false;
                btn_stop.Enabled = false;
                btn_test.Enabled = false;
                stopToolStripMenuItem.Enabled = false;
                btn_path.Enabled = true;
                btn_start.Enabled = true;
                cb_minMode.Enabled = true;
                startToolStripMenuItem.Enabled = true;
                tssl_label1.Text = Properties.Resources.Stop;
                notifyIcon.Text = Properties.Resources.Stop;
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            server.Stop();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.quickStart)
            {
                btn_start.PerformClick();
                Hide();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            btn_stop.PerformClick();
            Properties.Settings.Default.Save();
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            btn_stop.PerformClick();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            btn_start.PerformClick();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_path_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK)
            {
                tb_path.Text = folder.SelectedPath;
            }
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://" + nud1.Value.ToString() +"."+
                nud2.Value.ToString()+"."+nud3.Value.ToString()+"."+nud4.Value.ToString()+":"+
                nud_port.Value.ToString());
        }
    }
}
