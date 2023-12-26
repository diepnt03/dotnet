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

namespace on_de3
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public Window2()
        {
            InitializeComponent();
        }

        private void btThoat_inclick(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn thoát chương trình!", "Thông báo", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Close();
            }
        }
    }
}
