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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Juntuan
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private string[] address =
        {
            "阿苏纳",
            "风暴峡湾",
            "瓦尔莎拉",
            "至高岭",
            "阿苏纳",
            "瓦尔莎拉",
            "风暴峡湾",
            "阿苏纳",
            "至高岭",
            "风暴峡湾",
            "至高岭",
            "瓦尔莎拉"
        };

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            DateTime dtStart = DateTime.Parse("2018-8-25 23:30");

            DateTime dtToday = DateTime.Today;
            int startAddressIndex = 2;

            int i = 0;
            while(!(dtStart.Day==dtToday.Day && dtStart.Year==dtToday.Year && dtStart.Month == dtToday.Month))
            {
                dtStart = dtStart.AddHours(18.5);
                i++;
            }

            int endAddressIndex = startAddressIndex + i % address.Length;

            DateTime dtRealStart = dtStart.AddHours(-6);
            DateTime dtRealEnd = dtStart;

            lblToday.Content = $"今天是{dtToday.Year}-{dtToday.Month}-{dtToday.Day}";

            lbResult.Content = $"{dtRealStart.ToShortTimeString()}-{dtRealEnd.ToShortTimeString()}";

            lbAddress.Content = address[endAddressIndex];
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
