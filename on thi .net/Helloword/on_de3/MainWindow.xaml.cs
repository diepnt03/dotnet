using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
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

namespace on_de3
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

        List<NhanVien> dsNV = new List<NhanVien>();

        private bool kTra()
        {
            try
            {
                if (txtSoTien.Text == "" || txtTen.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                foreach(var item in dsNV)
                {
                    if(item.hoTen == txtTen.Text)
                    {
                        MessageBox.Show("Trùng tên", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        txtTen.Focus();
                        return false;
                    }
                }
                DateTime dt = (DateTime)dtNgay.SelectedDate;
                int tuoi = DateTime.Now.Year - dt.Year;
                if (tuoi < 18 || tuoi > 60)
                {
                    MessageBox.Show("Tuổi phải >=18 và <= 60", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    dtNgay.Focus();
                    return false;
                }
                if (!Regex.IsMatch(txtSoTien.Text, @"[0-9]+$") || double.Parse(txtSoTien.Text) < 0)
                {
                    MessageBox.Show("Só tiền phải là số thực >0 !!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtSoTien.Focus();
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi nhập dữ liệu!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return true;
        }
        private void btNhap_onclick(object sender, RoutedEventArgs e)
        {
            if (kTra())
            {
                NhanVien nv = new NhanVien();
                nv.hoTen = txtTen.Text;
                nv.loaNV = cbb_loai.Text;
                nv.ngSinh = (DateTime)dtNgay.SelectedDate;
                nv.soTien = double.Parse(txtSoTien.Text);
                dsNV.Add(nv);
                dataGr.ItemsSource = null;
                dataGr.ItemsSource = dsNV;
            }
        }
        private void btXoa_onclick(object sender, RoutedEventArgs e)
        {
            NhanVien nv = dataGr.SelectedItem as NhanVien;
            if(nv != null)
            {
                dsNV.Remove(nv);
                txtSoTien.Text = "";
                txtTen.Text = "";
                dtNgay.Text = "12/10/2002";
                cbb_loai.Text = "Cố hữu";
                dataGr.ItemsSource = null;
                dataGr.ItemsSource = dsNV;
            }
        }
        private void btHienThi_Click(object sender, RoutedEventArgs e)
        {
            NhanVien nv = dataGr.SelectedItem as NhanVien;
            if(nv == null)
            {
                MessageBox.Show("Bạn chưa chọn nhân viên nào!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                Window2 wd = new Window2();
                wd.txtTen.Text = nv.hoTen;
                wd.txtLoai.Text = nv.loaNV;
                wd.txtSoTien.Text = nv.soTien.ToString();
                wd.dtNS.SelectedDate = nv.ngSinh;

                wd.Show();
            }
        }

        private void dataGr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dataGr.SelectedIndex.ToString() != null)
            {
                NhanVien nv = dataGr.SelectedItem as NhanVien;
                if (nv != null)
                {
                    txtTen.Text = nv.hoTen;
                    txtSoTien.Text = nv.soTien.ToString();
                    cbb_loai.Text = nv.loaNV;
                    dtNgay.SelectedDate = nv.ngSinh;
                }
                else
                {
                    txtTen.Text = "";
                    txtSoTien.Text = "";
                    dtNgay.Text = "";
                    cbb_loai.Text = "";
                }
            }
        }

        private void btSua_Click(object sender, RoutedEventArgs e)
        {
            NhanVien nv = dataGr.SelectedItem as NhanVien;
            if (nv != null)
            {
                nv.hoTen = txtTen.Text;
                nv.soTien = double.Parse(txtSoTien.Text);
                nv.loaNV = cbb_loai.Text;
                nv.ngSinh = (DateTime)dtNgay.SelectedDate;

                dataGr.ItemsSource = null;
                dataGr.ItemsSource = dsNV;
            }
        }
    }
}
