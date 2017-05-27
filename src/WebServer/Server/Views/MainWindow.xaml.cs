using Server.Properties;
using System;
using System.Windows;
using System.Net;

namespace Server
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private Method.Server Server;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Lock(bool value)
        {
            tb_ipaddress.IsReadOnly = value;
            tb_port.IsReadOnly = value;
            filePath.btn_open.IsEnabled = !value;
            btn_stop.IsEnabled = value;
            btn_test.IsEnabled = value;
            btn_start.IsEnabled = !value;
        }

        private void btn_start_Click(object sender, RoutedEventArgs e)
        {
            if (tb_ipaddress.Text != "" && tb_port.Text != "" && filePath.tb_path.Text != "")
            {
                try
                {
                    IPEndPoint ipEndPoint = new IPEndPoint
                        (IPAddress.Parse(tb_ipaddress.Text), Convert.ToInt32(tb_port.Text));
                    if (!Server.Start(ipEndPoint, 100, filePath.tb_path.Text))
                        MessageBox.Show("Server not run,check data");
                    else
                        Lock(true);
                }
                catch
                {
                    MessageBox.Show("Data does not conform to the format");
                }
            }
            else
            {
                MessageBox.Show("input ip address , port and root path");
            }
        }

        private void btn_test_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://" + tb_ipaddress.Text.ToString() + ":" 
                + tb_port.Text.ToString());
        }

        private void btn_stop_Click(object sender, RoutedEventArgs e)
        {
            Server.Stop();
            Lock(false);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Settings.Default.Save();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Server = new Method.Server();
            Method.ControlWriter controlWriter = new Method.ControlWriter(tb_status);
        }

        private void tb_status_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            tb_status.ScrollToEnd();
        }
    }
}
