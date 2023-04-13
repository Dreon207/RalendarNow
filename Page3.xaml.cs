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

namespace KalendfrNow
{
    /// <summary>
    /// Логика взаимодействия для _3.xaml
    /// </summary>
    public partial class _3 : Page
    {
        public _3()
        {
            InitializeComponent();

            Kartoka D1 = new Kartoka();
            D1.TextBlock.Text = "1";
            Den1.Content = D1;
            Kartoka D2 = new Kartoka();
            D2.TextBlock.Text = "2";
            Den2.Content = D2;
            Kartoka D3 = new Kartoka();
            D3.TextBlock.Text = "3";
            Den3.Content = D3;

            Kartoka D4 = new Kartoka();
            D4.TextBlock.Text = "4";
            Den4.Content = D4;

            Kartoka D5 = new Kartoka();
            D5.TextBlock.Text = "5";
            Den5.Content = D5;

            Kartoka D6 = new Kartoka();
            D6.TextBlock.Text = "6";
            Den6.Content = D6;

            Kartoka D7 = new Kartoka();
            D7.TextBlock.Text = "7";
            Den7.Content = D7;

            Kartoka D8 = new Kartoka();
            D8.TextBlock.Text = "8";
            Den8.Content = D8;

            Kartoka D9 = new Kartoka();
            D9.TextBlock.Text = "9";
            Den9.Content = D9;

            Kartoka D10 = new Kartoka();
            D10.TextBlock.Text = "10";
            Den10.Content = D10;
            Kartoka D11 = new Kartoka();
            D11.TextBlock.Text = "11";
            Den11.Content = D11;

            Kartoka D12 = new Kartoka();
            D12.TextBlock.Text = "12";
            Den12.Content = D12;

            Kartoka D13 = new Kartoka();
            D13.TextBlock.Text = "13";
            Den13.Content = D13;

            Kartoka D14 = new Kartoka();
            D14.TextBlock.Text = "14";
            Den14.Content = D14;

            Kartoka D15 = new Kartoka();
            D15.TextBlock.Text = "15";
            Den15.Content = D15;

            Kartoka D16 = new Kartoka();
            D16.TextBlock.Text = "16";
            Den16.Content = D16;

            Kartoka D17 = new Kartoka();
            D17.TextBlock.Text = "17";
            Den17.Content = D17;

            Kartoka D18 = new Kartoka();
            D18.TextBlock.Text = "18";
            Den18.Content = D18;

            Kartoka D19 = new Kartoka();
            D19.TextBlock.Text = "19";
            Den19.Content = D19;

            Kartoka D20 = new Kartoka();
            D20.TextBlock.Text = "20";
            Den20.Content = D20;

            Kartoka D21 = new Kartoka();
            D21.TextBlock.Text = "21";
            Den21.Content = D21;

            Kartoka D22 = new Kartoka();
            D22.TextBlock.Text = "22";
            Den22.Content = D22;

            Kartoka D23 = new Kartoka();
            D23.TextBlock.Text = "23";
            Den23.Content = D23;

            Kartoka D24 = new Kartoka();
            D24.TextBlock.Text = "24";
            Den24.Content = D24;

            Kartoka D25 = new Kartoka();
            D25.TextBlock.Text = "25";
            Den25.Content = D25;

            Kartoka D26 = new Kartoka();
            D26.TextBlock.Text = "26";
            Den26.Content = D26;
            Kartoka D27 = new Kartoka();
            D27.TextBlock.Text = "27";
            Den27.Content = D27;

            Kartoka D28 = new Kartoka();
            D28.TextBlock.Text = "28";
            Den28.Content = D28;

            Kartoka D29 = new Kartoka();
            D29.TextBlock.Text = "29";
            Den29.Content = D29;

            Kartoka D30 = new Kartoka();
            D30.TextBlock.Text = "30";
            Den30.Content = D30;

            Kartoka D31 = new Kartoka();
            D31.TextBlock.Text = "31";
            Den31.Content = D31;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Pageper.Content = new _4();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Pageper.Content = new _2();
        }
    }
}
