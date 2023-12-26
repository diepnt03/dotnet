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

namespace On_deNVD
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<SinhVien1> dsSV = new List<SinhVien1>();
        private bool ktra()
        {
            try
            {
                if (txtMa.Text == "" || txtTen.Text == "")
                {
                    MessageBox.Show("Vui lòng điền đủ mã SV và họ tên!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                foreach (var s in dsSV)
                {
                    if(s.maSV == txtMa.Text)
                    {
                        MessageBox.Show("Mã SV trùng!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                        txtMa.Focus();
                        return false;
                    }
                }
                if (!Regex.IsMatch(txtSoLanXS.Text, @"^[0-9]+$") || int.Parse(txtSoLanXS.Text) < 1)
                {
                    MessageBox.Show("Số lần xuất sắc phải số nguyên >= 1, vui lòng nhập lại!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtSoLanXS.Focus();
                    return false;
                }
            }
            catch(Exception) 
            {
                MessageBox.Show("Có lỗi dữ liệu!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            return true;
        }
        private void btThem_Click(object sender, RoutedEventArgs e)
        {
            if (ktra())
            {
                SinhVien1 sv = new SinhVien1();
                sv.maSV = txtMa.Text;
                sv.hoTen = txtTen.Text;
                sv.solanXS = int.Parse(txtSoLanXS.Text);
                sv.khoa = cbbKhoa.Text;

                dsSV.Add(sv);
                dataGr.ItemsSource = null;
                dataGr.ItemsSource = dsSV;
            }

        }

        List<SinhVien1> SVCNTT = new List<SinhVien1>();
        private void btTim_Click(object sender, RoutedEventArgs e)
        {
            SVCNTT.Clear();
            foreach(SinhVien1 sv in dsSV)
            {
                if(sv.khoa == "Khoa công nghệ thông tin")
                {
                    SVCNTT.Add(sv);
                }
            }
            DanhSachCNTT ds = new DanhSachCNTT();
            ds.DSCNTT.ItemsSource = null;
            ds.DSCNTT.ItemsSource = SVCNTT;
            ds.Show();
        }
        private void dataGr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(dataGr.SelectedIndex.ToString() != null) 
            {
                SinhVien1 sv =  dataGr.SelectedItem as SinhVien1;
                if(sv != null)
                {
                    txtMa.Text = sv.maSV;
                    txtTen.Text = sv.hoTen;
                    txtSoLanXS.Text = sv.solanXS.ToString();
                    cbbKhoa.Text = sv.khoa;
                }
                else
                {
                    txtMa.Text = "";
                    txtTen.Text = "";
                    txtSoLanXS.Text = "";
                    cbbKhoa.Text = "";
                }
            }
        }
    }
}
