using System;
using System.Collections.Generic;
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
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CHAOSHI
{
    /// <summary>
    /// UpdateWindow.xaml 的交互逻辑
    /// </summary>
    public partial class UpdateWindow : Window
    {
        public UpdateWindow()
        {
            InitializeComponent();
        }
        //public int goodsAmount
        //{
        //    set
        //    {
        //        try
        //        {
        //            DBHelperMySQL msql = new DBHelperMySQL("chaoshi", "root", "zc5454554", "localhost");
        //            string = 
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message.ToString());
        //        }
        //    }
        //}

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Escape)
            {
                this.Close();
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                DBHelperMySQL msql = new DBHelperMySQL("chaoshi", "root", "zc5454554", "localhost");
                System.Data.DataSet da = msql.Select("select * from goods");

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

        private void DataGridGoods_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {

        }

        private void BtnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DBHelperMySQL msql = new DBHelperMySQL("chaoshi", "root", "zc5454554", "localhost");
                msql.Open();
                string sql = "update goods set goodsPriceOut = " + TxtBoxPriceOut.Text + " where goodsID = " + '"' + TxtBoxId.Text +'"'+ ";";
                //MessageBox.Show(sql);
                msql.cmd = new MySqlCommand(sql,msql.cnt);
                msql.cmd.ExecuteNonQuery();
                msql.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            TxtBoxId.Text = "";
            TxtBoxPriceOut.Text = "";

            try
            {
                DBHelperMySQL msql = new DBHelperMySQL("chaoshi", "root", "zc5454554", "localhost");
                System.Data.DataSet da = msql.Select("select * from goods");

                DataGridGoods.ItemsSource = da.Tables[0].DefaultView;
                DataGridGoods.LoadingRow += new EventHandler<DataGridRowEventArgs>(DataGridGoods_LoadingRow);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
