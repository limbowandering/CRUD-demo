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
    /// POSWindow.xaml 的交互逻辑
    /// </summary>
    public partial class POSWindow : Window
    {
        private List<string> nameList = new List<string>();
        private List<int> amountList = new List<int>();
        private List<double> priceList = new List<double>();
        private List<double> totalList = new List<double>();
        private List<string> pdfList = new List<string>();

        public string p
        {
            get
            {
                string temp="";
                foreach(string s in pdfList)
                {
                    temp += s;
                }
                return temp;
            }
        }

        public POSWindow()
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

        private void BtnCheckIn_Click(object sender, RoutedEventArgs e)
        {
            DBHelperMySQL msql = new DBHelperMySQL("chaoshi", "root", "zc5454554", "localhost");
            try
            {
                msql.Open();
                int t = pdfList.Count();
                for (int i = 0; i < t; i++)
                {
                    string sql = "update goods set goodsAmount=goodsAmount-" + amountList[i].ToString() + " where goodsName=" + '"' + nameList[i].ToString() + '"' + ";";
                    //MessageBox.Show(sql);
                    msql.cmd = new MySqlCommand(sql, msql.cnt);
                    msql.cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                msql.Close();
            }
            this.Close();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            amountList.Add(int.Parse(TxtBoxAmount.Text));
            DBHelperMySQL msql = new DBHelperMySQL("chaoshi", "root", "zc5454554", "localhost");
            try
            {
                msql.Open();
                string sql = "select goodsName,goodsPriceOut from goods where goodsId=" + TxtBoxId.Text + "";
                msql.cmd = new MySqlCommand(sql, msql.cnt);
                MySqlDataReader dr;
                dr = msql.cmd.ExecuteReader();
                dr.Read();
                //MessageBox.Show(dr[0].ToString()+dr[1].ToString());
                nameList.Add(dr[0].ToString());
                amountList.Add(int.Parse(TxtBoxAmount.Text));
                priceList.Add(double.Parse(dr[1].ToString()));
                totalList.Add(double.Parse(TxtBoxAmount.Text) * int.Parse(dr[1].ToString()));
                int t = pdfList.Count();
                string tmp = nameList[t].ToString() + ':' + amountList[t].ToString() + '*' + priceList[t].ToString() + '=' + totalList[t].ToString()+"\n";
                pdfList.Add(tmp);
                //MessageBox.Show(tmp);
                //MessageBox.Show(nameList[0]);
                //MessageBox.Show(amountList[0].ToString());
                //MessageBox.Show(priceList[0].ToString());
                //MessageBox.Show(totalList[0].ToString());
                txtBlkPdf.Text += tmp;
                TxtBoxId.Text = "";
                TxtBoxAmount.Text = "";
                double price = 0;
                foreach(double s in totalList)
                {
                    price += s;
                }
                TxtBoxTotalPrice.Text = price.ToString();
                dr.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                msql.Close();
            }
        }

        private void BtnDiscount_Click(object sender, RoutedEventArgs e)
        {
            DBHelperMySQL msql = new DBHelperMySQL("chaoshi", "root", "zc5454554", "localhost");
            try
            {
                msql.Open();
                string sql = "select VipDiscount from vip where vipId=" + TxtBoxVip.Text + "";
                msql.cmd = new MySqlCommand(sql, msql.cnt);
                MySqlDataReader dr;
                dr = msql.cmd.ExecuteReader();
                dr.Read();
                if(dr[0].ToString() == null)
                {
                    MessageBox.Show("会员不存在");
                }
                else
                {
                    double dis = double.Parse(dr[0].ToString());
                    //MessageBox.Show(dis.ToString());
                    double price = double.Parse(TxtBoxTotalPrice.Text);
                    price *= dis;
                    TxtBoxTotalPrice.Text = price.ToString();
                }
                //nameList.Add(dr[0].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                msql.Close();
            }
        }

        private void BtnPrint_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog pdlg = new PrintDialog();
            if (pdlg.ShowDialog() == true)
            {
                pdlg.PrintVisual(txtBlkPdf, "Print Receipt");
            }
        }


    }
}
