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
using System.Windows.Shapes;

namespace CHAOSHI
{
    /// <summary>
    /// QueryWindow.xaml 的交互逻辑
    /// </summary>
    public partial class QueryWindow : Window
    {
        public QueryWindow()
        {
            InitializeComponent();
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Escape)
            {
                this.Close();
            }
        }

        public void DataGridGoods_Load()
        {
            try
            {
                DBHelperMySQL msql = new DBHelperMySQL("chaoshi", "root", "zc5454554", "localhost");
                DataSet da = msql.Select("select * from goods");

                DataGridGoods.ItemsSource = da.Tables[0].DefaultView;
                DataGridGoods.LoadingRow += new EventHandler<DataGridRowEventArgs>(DataGridGoods_LoadingRow);

            }
            catch
            {
                MessageBox.Show("查询失败");
            }
        }

        private void DataGridGoods_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex() + 1;
        }

        private void BtnQueryAllGoods_Click(object sender, RoutedEventArgs e)
        {
            DataGridGoods_Load();
        }

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            return;
        }

        private void BtnQuery_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DBHelperMySQL msql = new DBHelperMySQL("chaoshi", "root", "zc5454554", "localhost");
                DataSet da = msql.Select("select * from goods where goodsID="+'"'+TxtBoxId.Text+'"'+";");

                DataGridGoods.ItemsSource = da.Tables[0].DefaultView;
                DataGridGoods.LoadingRow += new EventHandler<DataGridRowEventArgs>(DataGridGoods_LoadingRow);

            }
            catch
            {
                MessageBox.Show("查询失败");
            }
        }
    }
}
