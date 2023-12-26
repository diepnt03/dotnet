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

namespace WPFControl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        static private List<SinhVien> items = new List<SinhVien>();

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            ThemMoi f = new ThemMoi();
            f.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SinhVien sv = new SinhVien(thongtin.masv, thongtin.hoten, thongtin.gioitinh, thongtin.ngaysinh, thongtin.sotc, thongtin.diem);
            items.Add(sv);
            hienthi();
        }

        private void hienthi()
        {
            lvSinhVien.ItemsSource = items;
            lvSinhVien.Items.Refresh();
        }
        private void lvSinhVien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SinhVien item = (SinhVien)lvSinhVien.SelectedItem;
            txtMaSV.Text = item.MaSV;
            txtHoten.Text = item.HoTen;
            dpkNgaySinh.Text = item.NgaySinh;
            if (item.GioiTinh == "Nam")
                radNam.IsChecked = true;
            else radNu.IsChecked = true;
            txtDiem.Text = item.Diem.ToString();
            txtSoTC.Text = item.SoTC.ToString();
        }

        //xóa
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].MaSV.Equals(txtMaSV.Text))
                {
                    items.RemoveAt(i);
                }
            }
            hienthi();
        }

       
    }
}
