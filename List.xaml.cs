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
    /// Логика взаимодействия для List.xaml
    /// </summary>
    public partial class List : Page
    {
        public List()
        {
            InitializeComponent();

            Spisok string1 = new Spisok();
            string1.TextBlock.Text = "Гулять с собакой";
            Spisok string2 = new Spisok();
            string1.TextBlock.Text = "Играть с котом";
            Spisok string3 = new Spisok();
            string1.TextBlock.Text = "Утопить хомячка";
            Spisok string4 = new Spisok();
            string1.TextBlock.Text = "Пожарить золутую рыбку";
            
            List<Spisok> list = new List<Spisok>() { string1 , string2 , string3 , string4 };   
            listic.ItemsSource = list;
            
        }
    }
}
