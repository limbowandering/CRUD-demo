using System;
using System.Windows;

namespace CHAOSHI
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public string notification;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void menuItemLogin_Click(object sender, RoutedEventArgs e)
        {
            LoginWindow lw = new LoginWindow();
            lw.ShowDialog();
            lw.Owner = this;
            
            //MessageBox.Show(lw.isLogined.ToString());
            //等下回来再改 isLogined应该是private 类外只能get； public的话也能set了；
            if(lw.isLogined == true)
            {
                MessageBox.Show("登录成功");
                BtnChaXun.IsEnabled = true;
                BtnGengXin.IsEnabled = true;
                BtnJinHuo.IsEnabled = true;
                BtnShouYin.IsEnabled = true;
                menuItemLogin.IsEnabled = false;
                menuItemLogOut.IsEnabled = true;
                BtnVip.IsEnabled = true;
                menuItemLogOut.Visibility = Visibility.Visible;
                menuItemLogin.Header = lw.User.Text;
            }
            //else
            //{
            //    MessageBox.Show("登录失败");
            //}

            if (lw.isBoss == true)
            {
                BtnTongJi.IsEnabled = true;
                BtnChange.IsEnabled = true;
            }
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            BtnChaXun.IsEnabled = false;
            BtnGengXin.IsEnabled = false;
            BtnJinHuo.IsEnabled = false;
            BtnShouYin.IsEnabled = false;
            menuItemLogOut.IsEnabled = false;
            BtnTongJi.IsEnabled = false;
            BtnChange.IsEnabled = false;
            BtnVip.IsEnabled = false;
            menuItemLogOut.Visibility = Visibility.Hidden;
        }

        private void menuItemLogOut_Click(object sender, RoutedEventArgs e)
        {
            menuItemLogin.IsEnabled = true;
            menuItemLogOut.IsEnabled = false;
            BtnChaXun.IsEnabled = false;
            BtnGengXin.IsEnabled = false;
            BtnJinHuo.IsEnabled = false;
            BtnShouYin.IsEnabled = false;
            BtnChange.IsEnabled = false;
            BtnTongJi.IsEnabled = false;
            BtnVip.IsEnabled = false;
            menuItemLogin.Header = "登录";
            menuItemLogOut.Visibility = Visibility.Hidden;
        }

        private void BtnChange_Click(object sender, RoutedEventArgs e)
        {
            NotificationWindow nw = new NotificationWindow();
            nw.ShowDialog();
            notification = nw.content;
            if(notification != null)
            {
                TextNotification.Text = notification;
            }
        }

        private void BtnShouYin_Click(object sender, RoutedEventArgs e)
        {
            POSWindow pw = new POSWindow();
            pw.ShowDialog();
        }

        private void BtnTongJi_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow aw = new AdminWindow();
            aw.ShowDialog();
        }

        private void BtnChaXun_Click(object sender, RoutedEventArgs e)
        {
            QueryWindow qw = new QueryWindow();
            qw.ShowDialog();
        }

        private void BtnJinHuo_Click(object sender, RoutedEventArgs e)
        {
            JinHuoWindow jw = new JinHuoWindow();
            jw.ShowDialog();
        }

        private void BtnVip_Click(object sender, RoutedEventArgs e)
        {
            VipWindow vw = new VipWindow();
            vw.ShowDialog();
        }

        private void BtnGengXin_Click(object sender, RoutedEventArgs e)
        {
            UpdateWindow uw = new UpdateWindow();
            uw.ShowDialog();
        }
    }
}
