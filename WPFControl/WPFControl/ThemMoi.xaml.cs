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

namespace WPFControl
{
    /// <summary>
    /// Interaction logic for ThemMoi.xaml
    /// </summary>
    public partial class ThemMoi : Window
    {
        public ThemMoi()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            thongtin.masv = txtMaSV.Text;
            thongtin.hoten = txtHoten.Text;
            string gt;
            if (radNam.IsChecked == true)
                gt = "Nam";
            else gt = "Nữ";
            thongtin.gioitinh = gt;
            thongtin.ngaysinh = dpkNgaySinh.Text;
            thongtin.sotc = int.Parse(txtSoTC.Text);
            thongtin.diem = int.Parse(txtDiem.Text);

            this.Close();
            MainWindow f = new MainWindow();
            f.Show();
        }
    }
}














