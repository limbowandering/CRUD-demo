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

namespace CHAOSHI
{
    /// <summary>
    /// JinHuoWindow.xaml 的交互逻辑
    /// </summary>
    public partial class JinHuoWindow : Window
    {
        private int ist;
        //private string insertString;

        public JinHuoWindow()
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

        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            
        }


        //下次再看看这个：采用SqlParameter的；
        private void BtnInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //string goodsInsert = $""
                DBHelperMySQL msql = new DBHelperMySQL("chaoshi", "root", "zc5454554", "localhost");
                msql.Open();

                //MessageBox.Show("insert into goods" +
                //" values('" + TxtBoxId.Text + "','" + TxtBoxName.Text + "','" + TxtBoxPriceOut.Text + "','" + TxtBoxAmount.Text + "','" + TxtBoxPriceIn.Text + "','" + TxtBoxUnit.Text + "');");
                ist = msql.Execute("insert into goods" +
                " values('" + TxtBoxId.Text + "','" + TxtBoxName.Text + "','" + TxtBoxPriceOut.Text + "','" + TxtBoxAmount.Text + "','" + TxtBoxPriceIn.Text + "','" + TxtBoxUnit.Text + "');");
                msql.Close();
                if(ist > 0)
                {
                    MessageBox.Show("插入成功");
                    TxtBoxId.Text = "";
                    TxtBoxName.Text = "";
                    TxtBoxPriceOut.Text = "";
                    TxtBoxAmount.Text = "";
                    TxtBoxPriceIn.Text = "";
                    TxtBoxUnit.Text = "";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
