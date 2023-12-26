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

namespace On_deNVD
{
    /// <summary>
    /// Interaction logic for DanhSachCNTT.xaml
    /// </summary>
    public partial class DanhSachCNTT : Window
    {
        public DanhSachCNTT()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, RoutedEventArgs e)
        {
            if(MessageBox.Show("Bạn chắc chắn muốn thoát", "Thông báo", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Close();
            }
        }
    }
}
