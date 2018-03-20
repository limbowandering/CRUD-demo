using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

//namespace CHAOSHI
//{
//    /// <summary>
//    /// MainWindow.xaml 的交互逻辑
//    /// </summary>
//    public partial class MainWindow : Window
//    {
//        public MainWindow()
//        {
//            InitializeComponent();
//        }

//        private void menuItemLogin_Click(object sender, RoutedEventArgs e)
//        {
//            LoginWindows lw = new LoginWindows();
//            lw.ShowDialog();
//        }

//        public void GoodsTable_Load()
//        {
//            try
//            {
//                DBHelperMySQL msql = new DBHelperMySQL("chaoshi", "root", "zc5454554", "localhost");
//                DataSet da = msql.Select("select * from goods");
//                //Console.WriteLine(da);
//                GoodsTable.ItemsSource = da.Tables[0].DefaultView;
//                GoodsTable.LoadingRow += new EventHandler<DataGridRowEventArgs>(GoodsTable_LoadingRow);
//            }
//            catch
//            {
//                MessageBox.Show("Initialize Failed");
//            }
//        }

//        private void GoodsTable_LoadingRow(object sender,DataGridRowEventArgs e)
//        {
//            e.Row.Header = e.Row.GetIndex() + 1;
//        }

//        private void Grid_Loaded(object sender, RoutedEventArgs e)
//        {
//            GoodsTable_Load();
//        }

//        private void menuItemTEST_Click(object sender, RoutedEventArgs e)
//        {
//            TestWindow tw = new TestWindow();
//            tw.ShowDialog();
//        }
//    }
//}
