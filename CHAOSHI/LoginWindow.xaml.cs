using System;
using System.Windows;
using System.Data;

namespace CHAOSHI
{
    /// <summary>
    /// LoginWindows.xaml 的交互逻辑
    /// </summary>
    public partial class LoginWindow : Window
    {
        public bool isLogined = false;
        public bool isBoss = false;
        public bool reLogin = false;

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnLog_Click(object sender, RoutedEventArgs e)
        {
            DBHelperMySQL msql = new DBHelperMySQL("chaoshi", "root", "zc5454554", "localhost");
            msql.Open();
            DataSet da = msql.Select($"select staffPassword from staff where staffName = '{User.Text}'");
            msql.Close();
            if (da.Tables[0].Rows.Count == 0)
            {
                MessageBox.Show("账户不存在");
                this.Close();
                reLogin = true;
                return;
            }

            if(da.Tables[0].Rows[0][0].ToString() != Pwd.Password)
            {
                MessageBox.Show("密码错误");
                this.Close();
                reLogin = true;
                return;
            }
            else
            {
                if(User.Text == "boss")
                {
                    isBoss = true;
                }
                isLogined = true;
                this.Close();
                return;
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
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

        //private void Window_Loaded(object sender, RoutedEventArgs e)
        //{
        //    User.GotFocus();
        //}

        //private void Pwd_KeyDown(object sender, KeyEventArgs e)
        //{
        //    if(e.Key == Key.Enter)
        //    {
        //        this.btnLog_Click();
        //    }
        //}
    }
}
