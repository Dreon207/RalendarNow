using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
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
using System.Xml.Serialization;

namespace KalendfrNow
{
    /// <summary>
    /// Логика взаимодействия для Okno.xaml
    /// </summary>
    public partial class Okno : Window
    
    {
        public string m;
        public string d;
       

        public Okno(string a, string b)
        {
            InitializeComponent();
            m = a;
            d = b;
            string path = "C:\\kalendar\\" + m + "\\" + d + ".xml";
            MessageBox.Show(path);


            Spisok string1 = new Spisok();
            string1.TextBlock.Text = "Погулять с собакой";
            Image image1 = new Image();
            //U
            image1.Source = new BitmapImage();
            Spisok string2 = new Spisok();
            string2.TextBlock.Text = "Поиграть с котом";
            Image image2 = new Image();
            Spisok string3 = new Spisok();
            string3.TextBlock.Text = "Поймать рыбку";
            Image image3 = new Image();

            List<Spisok> list = new List<Spisok>() { string1, string2, string3 };
            
            
            if (File.Exists(path))
            {
                XmlSerializer data = new XmlSerializer(typeof(Spisok));
                using (FileStream fs = new FileStream(path, FileMode.Open))
                    {
                    list = (List<Spisok>)data.Deserialize(fs);
                    }

            }
            listic.ItemsSource = list;



        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {

            foreach (int selecteditem in listic.SelectedItems) 
            {
                MessageBox.Show(listic.Items[selecteditem].);
            }

            Dela td = new Dela();
            //td.Delo = listic.Items[1].ToString;
            //MessageBox.Show(td.Delo);
            //XmlSerializer data = new XmlSerializer(typeof(ListBox));
            //using (FileStream fs = new FileStream("C:\\kalendar\\" + m + "\\" + d + ".xml", FileMode.OpenOrCreate))
            {

                


                //data.Serialize(fs, listic.ItemsSource);
                //Close();
            }

        }


    }
}
