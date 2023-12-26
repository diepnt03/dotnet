using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace LT_de1
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

        private void btnXoa_OnClick(object sender, RoutedEventArgs e)
        {
            txtTen.Clear();
            txtNgCong.Clear();
            txtLuong.Clear();
            rdNam.IsChecked = true;
            txtTen.Focus();
        }

        private void btnChiTiet_OnClick(object sender, RoutedEventArgs e)
        {
            Employee epl = lv_NhanVien.SelectedItem as Employee;
            if (epl == null) 
            {
                MessageBox.Show("Bạn chưa chọn nhân viên nào!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Window2 wd2 = new Window2();
            wd2.txtHoten.Text = epl.HoTen; 
            if (epl.IsGT)
            {
                wd2.rdNam.IsChecked = true;
            }
            else
            {
                wd2.rdNu.IsChecked = true;
            }
            wd2.txtngCong.Text = epl.soNgCong.ToString();
            wd2.txtLuong.Text = epl.luong.ToString();
            wd2.txtThuong.Text = epl.Thuong.ToString();

            wd2.Show();
            Close();

        }

        private void btnThem_onClick(object sender, RoutedEventArgs e)
        {
            try
            { 
                string ktra = "";
                if(string.IsNullOrWhiteSpace(txtTen.Text) || string.IsNullOrWhiteSpace(txtNgCong.Text) || string.IsNullOrWhiteSpace(txtLuong.Text))
                {
                    ktra += "Vui lòng nhập hết các thông tin!\n";
                }
                if(!Regex.IsMatch(txtNgCong.Text, @"^[0-9]+$"))
                {
                    ktra += "Số ngày công là số nguyên!\n";
                }
                if(!Regex.IsMatch(txtLuong.Text, @"[0-9]+$"))
                {
                    ktra += "Luong phải là các con số!";
                }
                if(!string.IsNullOrWhiteSpace(ktra))
                {
                    MessageBox.Show(ktra);
                    return;
                }

                string ktra2 = "";
                if(int.Parse(txtNgCong.Text) < 20 || int.Parse(txtNgCong.Text) > 30)
                {
                    ktra2 += "Số ngày công phải nằm trong khoảng [20, 30]\n";
                }
                if(double.Parse(txtLuong.Text) < 3000 || double.Parse(txtLuong.Text) > 5000)
                {
                    ktra2 += "Lương phải trong khoảng [3000, 5000]";
                }
                if (!string.IsNullOrWhiteSpace(ktra2))
                {
                    MessageBox.Show(ktra2);
                    return;
                }
                bool GTinh = (bool)rdNam.IsChecked;
                foreach (Employee d in lv_NhanVien.Items)
                {
                    if (d.HoTen == txtTen.Text)
                    {
                        MessageBox.Show("Không được trùng tên!");
                        return;
                    }
                }
                lv_NhanVien.Items.Add(new Employee(txtTen.Text, GTinh, int.Parse(txtNgCong.Text), double.Parse(txtLuong.Text)));
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi thêm!!", "Thông báo lỗi", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnDong_onClick(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                Close();
            }
        }

        private void lv_NhanVien_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
