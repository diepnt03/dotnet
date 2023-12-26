using System;
using System.Collections.Generic;
using System.Data;
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

namespace On_de1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        List<NhanVien> dsNV = new List<NhanVien>();
        private void nhap_Click(object sender, RoutedEventArgs e)
        {
            if (ktra())
            {
                NhanVien nv = new NhanVien();
                nv.maNV = txtMa.Text;
                nv.hoTen = txtHoTen.Text;
                nv.ngSinh = (DateTime)slecNgay.SelectedDate;
                if (rdNam.IsChecked == true)
                {
                    nv.gTinh = "Nam";
                }
                else
                {
                    nv.gTinh = "Nữ";
                }
                nv.phongBan = cbb_phong.Text;
                nv.HSL = double.Parse(txtHSL.Text);
                dsNV.Add(nv);
                dataGr.ItemsSource = null;
                dataGr.ItemsSource = dsNV;
            }
        }

        List<NhanVien> dsMaxTuoi = new List<NhanVien>();
        private void Window2_click(object sender, RoutedEventArgs e)
        {
            //Tìm tuooir cao nhất
            int max = dsNV[0].tuoi;
            for(int i = 1; i< dsNV.Count; i++)
            {
                if(max < dsNV[i].tuoi)
                {
                    max = dsNV[i].tuoi;
                }
            }
            foreach(var item in dsNV)
            {
                if(item.tuoi == max)
                {
                    dsMaxTuoi.Add(item);
                }
            }
            //Hiển thị win2
            Window2 wd2 = new Window2();
            wd2.DsCaoTuoi.ItemsSource = null;
            wd2.DsCaoTuoi.ItemsSource = dsMaxTuoi;
            wd2.Show();
        }
        public bool ktra()
        {
            try
            {
                if(txtMa.Text == "")
                {
                    MessageBox.Show("Mã nhân viên rỗng, vui lòng nhập lại!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    txtMa.Focus();
                    return false;
                }
                if (txtHoTen.Text == "")
                {
                    MessageBox.Show("MHọ tên rỗng, vui lòng nhập lại!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    txtHoTen.Focus();
                    return false;
                }
                if (txtHSL.Text == "")
                {
                    MessageBox.Show("Hệ số lương rỗng, vui lòng nhập lại!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    txtHSL.Focus();
                    return false;
                }

                //Kiểm tra tuổi lớn hơn18:
                DateTime dt = (DateTime)slecNgay.SelectedDate;
                if((DateTime.Now.Year - dt.Year) < 18)
                {
                    MessageBox.Show("Số tuổi phải lớn hơn 18!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    return false;
                }
            }catch (Exception)
            {
                MessageBox.Show("Có lỗi dữ liệu!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            return true;
        }
        //public static int SStuoi(NhanVien nv1, NhanVien nv2)
        //{
        //    //int tuoi1 = DateTime.Now.Year - nv1.ngSinh.Year;
        //    //int tuoi2 = DateTime.Now.Year - nv2.ngSinh.Year;
        //    return nv1.tuoi.CompareTo(nv2.tuoi);
        //}
        //private void bt_chiTiet_Click(object sender, RoutedEventArgs e)
        //{
        //    // Lấy danh sách nhân viên từ dataGrid
        //    var dsNhanVien = ((IEnumerable<NhanVien>)dataGr.ItemsSource).ToList();

        //    // Sắp xếp danh sách theo chiều tăng dần của tuổi
        //    dsNhanVien.Sort(NhanVien.SStuoi);

        //    // Cập nhật dữ liệu cho dataGrid
        //    dataGr.ItemsSource = dsNhanVien;
        //}

        private void hienthi(object sender, SelectionChangedEventArgs e)
        {
            if(dataGr.SelectedIndex.ToString() != null)
            {
                NhanVien nv = dataGr.SelectedItem as NhanVien;
                if(nv != null)
                {
                    txtMa.Text = nv.maNV;
                    txtHoTen.Text = nv.hoTen;
                    slecNgay.SelectedDate = nv.ngSinh.Date;
                    if (nv.gTinh == "Nam")
                    {
                        rdNam.IsChecked = true;
                    }
                    else
                    {
                        rdNu.IsChecked = true;
                    }
                    cbb_phong.Text = nv.phongBan;
                    txtHSL.Text = nv.HSL.ToString();
                }
                else
                {
                    txtMa.Text = "";
                    txtHoTen.Text = "";
                    slecNgay.SelectedDate = null;
                    cbb_phong.Text = "";
                    txtHSL.Text = "";
                }
            }
        }
    }
}
