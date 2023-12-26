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

namespace Helloword
{
    public partial class MainWindow : Window
    {
        Button button;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void bt1_Click(object sender, RoutedEventArgs e)
        {
            string tbao, hoten, tieude, ngoaiNgu = "";
            hoten = txt1.Text + " " + txt2.Text;
            if(rabt1.IsChecked == true )
            {
                tieude = "Mr.";
            }
            else
            {
                tieude = "Miss/Mrs.";
            }
            tbao = "Xin chao" + tieude + " " + hoten;
            if(cbox1.IsChecked == true )
            {
                ngoaiNgu = "Tiếng Anh";
            }
            if(cbox2.IsChecked == true )
            {
                ngoaiNgu = (ngoaiNgu.Length == 0) ? "Tiếng Trung" : (ngoaiNgu + " và Tiếng Trung");
            }
            tbao += "\n Ngoại ngữ: " + ngoaiNgu;
            if(lsBox1.SelectedIndex >= 0)
            {
                tbao += "\n Quê quán: " + lsBox1.Text;
            }
            MessageBox.Show(tbao);
        }

        private void bt2_Click(object sender, RoutedEventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            rabt1.IsChecked = true;
            rabt2.IsChecked = false;
            cbox1.IsChecked = false;
            cbox2.IsChecked = false;
            lsBox1.SelectedIndex = 0;
        }
    }
}
