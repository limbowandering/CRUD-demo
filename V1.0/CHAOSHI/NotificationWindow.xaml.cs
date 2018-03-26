using System;
using System.Windows;

namespace CHAOSHI
{
    /// <summary>
    /// NotificationWindow.xaml 的交互逻辑
    /// </summary>
    public partial class NotificationWindow : Window
    {
        public string content = null;

        public NotificationWindow()
        {
            InitializeComponent();
        }

        private void BtnNo_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            return;
        }

        private void BtnYes_Click(object sender, RoutedEventArgs e)
        {
            if(TxtBoxNotification.Text != "")
            {
                content = TxtBoxNotification.Text;
            }
            this.Close();
            return;
        }

        private void Window_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if(e.Key == System.Windows.Input.Key.Escape)
            {
                this.Close();
            }
        }
    }
}
