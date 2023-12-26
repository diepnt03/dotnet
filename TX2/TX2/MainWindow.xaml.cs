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

namespace TX2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<NhanVien> nhanViens = new List<NhanVien>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cbbphongban_Selected(object sender, RoutedEventArgs e)
        {

        }

        private bool isCheck()
        {
            if (txtma.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập mã nhân viên", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtma.Focus();
                return false;
            }

            if (nhanViens.Any(x => x.maNV.Equals(txtma.Text)))
            {
                MessageBox.Show("Mã nhân viên đã tồn tại ", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txtma.Focus();
                return false;
            }
            if (txthoten.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập họ tên", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txthoten.Focus();
                return false;
            }
            if (txthsluong.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập hệ số lương", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txthsluong.Focus();
                return false;
            }
            DateTime ngaySinh = (DateTime)dtpngaysinh.SelectedDate;
            if ((DateTime.Now.Year - ngaySinh.Year) < 18)
            {
                MessageBox.Show("Tuổi nhân viên phải lơn hơn 18", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            try
            {
                double hsl = double.Parse(txthsluong.Text);
                if (hsl < 0)
                {
                    MessageBox.Show("Hệ số lương phải lớn hơn 0", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    txthsluong.Focus();
                    return false;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hệ số lương phải là số", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                txthsluong.Focus();
                return false;
            }
            return true;
        }

        private void btnNhap_Click(object sender, RoutedEventArgs e)
        {
            if (isCheck())
            {
                string maNV = txtma.Text;
                NhanVien nhanVien = new NhanVien();
                nhanVien.maNV = txtma.Text;

                nhanVien.hoTen = txthoten.Text;
                nhanVien.ngaySinh = (DateTime)dtpngaysinh.SelectedDate;
                if (radioNam.IsChecked == true)
                    nhanVien.gioiTinh = "Nam";
                else
                    nhanVien.gioiTinh = "Nữ";
                nhanVien.phong = cbbphongban.Text;
                nhanVien.heSoLuong = double.Parse(txthsluong.Text);
                nhanViens.Add(nhanVien);
                dgDSNV.ItemsSource = null;
                dgDSNV.ItemsSource = nhanViens;
            }
        }

        private void btnw2_Click(object sender, RoutedEventArgs e)
        {
            var max = nhanViens.Max(x => x.tuoi);
            var list = nhanViens.Where(x => x.tuoi == max);
            ThemMoi window2 = new ThemMoi();
            window2.dtgtuoicao.ItemsSource = list;
            window2.Show();
        }
    }
}
