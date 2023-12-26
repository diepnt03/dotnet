using System;
using System.Collections.Generic;
using System.Data;
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

namespace on_De1_NVD
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
        List<SinhVien> dsSV = new List<SinhVien>();
        public bool ktra()
        {
            try
            {
                if(txtMaSV.Text == "")
                {
                    MessageBox.Show("Mã SV trống, vui lòng nhập mã SV!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtMaSV.Focus();
                    return false;
                }
                if(txtTen.Text == "")
                {
                    MessageBox.Show("Tên trống, vui lòng nhập lại!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtTen.Focus();
                    return false;
                }
                if (!Regex.IsMatch(txtSoLanSX.Text, @"^[0-9]+$") || int.Parse(txtSoLanSX.Text) < 1)
                {
                    MessageBox.Show("Số lần xuất sắc phải số nguyên >= 1, vui lòng nhập lại!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtSoLanSX.Focus();
                    return false;
                }
                if(dsSV.Exists(p => p.maSV.CompareTo(txtMaSV.Text) == 0))
                {
                    MessageBox.Show("Mã sinh viên đã tồn tại, Nhập lại!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtMaSV.Focus();
                    return false;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Có lỗi dữ liệu!");
            }
            return true;
        }
        private void btThem_onclick(object sender, RoutedEventArgs e)
        {
            if (ktra())
            {
                SinhVien sv = new SinhVien();
                sv.maSV = txtMaSV.Text;
                sv.hoTen = txtTen.Text;
                sv.solanXS   = int.Parse(txtSoLanSX.Text);
                sv.khoa = cbb_khoa.Text;
                if(rdNam.IsChecked == true)
                {
                    sv.gTinh = "Nam";
                }
                else
                {
                    sv.gTinh = "Nữ";
                }

                dsSV.Add(sv);
                dataGr.ItemsSource = null;
                dataGr.ItemsSource = dsSV;

            }
        }
        List<SinhVien> dsCNTT = new List<SinhVien>();
        private void btTim_onclick(object sender, RoutedEventArgs e)
        {
            dsCNTT.Clear();
            foreach (SinhVien v in dsSV)
            {
                //if (v.khoa.CompareTo("Khoa công nghệ thông tin") == 0)
                //    dsCNTT.Add(v);
                if(v.khoa == "Khoa công nghệ thông tin")
                {
                    dsCNTT.Add(v);
                }
            }
            
            ThongTin tt = new ThongTin();
            tt.SVCNTT.ItemsSource = null;
            tt.SVCNTT.ItemsSource = dsCNTT;
            tt.Show();
        }

        private void dataGr_HienThi(object sender, SelectionChangedEventArgs e)
        {
            if(dataGr.SelectedIndex.ToString() != null)
            {
                SinhVien sv = dataGr.SelectedItem as SinhVien;
                if (sv != null)
                {
                    txtTen.Text = sv.hoTen;
                    txtSoLanSX.Text = sv.solanXS.ToString();
                    cbb_khoa.Text = sv.khoa;
                    if (sv.gTinh == "Nam")
                    {
                        rdNam.IsChecked = true;
                    }
                    else
                    {
                        rdNu.IsChecked = true;
                    }
                }
                else
                {
                    txtMaSV.Text = "";
                    txtTen.Text = "";
                    txtSoLanSX.Text = "";
                    cbb_khoa.Text = "";
                    rdNu.IsChecked = false;
                }
            }

        }
    }
}
