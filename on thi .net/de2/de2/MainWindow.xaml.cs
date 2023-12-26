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
using de2.Models;

namespace de2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QuanLySanPhamDBContext ql = new QuanLySanPhamDBContext();
        public MainWindow()
        {
            InitializeComponent();
            LoadItem();
            DTComBobox();
        }
        private void DTComBobox()
        {
            //combobox là mã nhóm hàng
            var qr = from nh in ql.NhomHangs
                     select nh.MaNhomHang;
            cbbNhomHang.ItemsSource = qr.ToList();
           
        }

        private void LoadItem()
        {
            //load bảng sx theo chiều giảm dần sl bán
            var qr = from sp in ql.SanPhams
                     join nh in ql.NhomHangs
                     on sp.MaNhomHang equals nh.MaNhomHang
                     orderby sp.SoLuongBan descending
                     select new
                     {
                         sp.MaSp,
                         sp.TenSanPham,
                         sp.DonGia,
                         sp.SoLuongBan,
                         nh.TenNhomHang,
                         TienBan = sp.DonGia * sp.SoLuongBan
                     };
            dgDSSP.ItemsSource = qr.ToList();
            
        }
        private void Hienthi()
        {
            var qr = from sp in ql.SanPhams
                     join nh in ql.NhomHangs
                     on sp.MaNhomHang equals nh.MaNhomHang
                     select new
                     {
                         sp.MaSp,
                         sp.TenSanPham,
                         sp.DonGia,
                         sp.SoLuongBan,
                         nh.TenNhomHang,
                         TienBan = sp.DonGia * sp.SoLuongBan
                     };
            dgDSSP.ItemsSource = qr.ToList();
        }
        private void Clear()
        {
            txtmasp.Clear();
            txttensp.Clear();
            txtdongia.Clear();
            txtslban.Clear();
            cbbNhomHang.SelectedIndex = 0;
        }

        private void dgDSSP_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           var item = dgDSSP.SelectedItem;
            if (item != null)
            {
                var _tennhomhang = (dgDSSP.SelectedCells[4].Column.GetCellContent(item) as TextBlock).Text;
                var _manhomhang = (from nh in ql.NhomHangs
                                  where nh.TenNhomHang == _tennhomhang
                                  select nh.MaNhomHang).Single();
                cbbNhomHang.SelectedItem = _manhomhang;
            }
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            int num1, num2;
            double num3;
            bool ktmasp = int.TryParse(txtmasp.Text, out num1);
            bool ktraslban = int.TryParse(txtslban.Text,out num2);
            bool ktradongia = double.TryParse(txtdongia.Text, out num3);
            try
            {
                if (txtmasp.Text == "" || txttensp.Text == "" || txtdongia.Text == "" || txtslban.Text == "")
                    throw new Exception("Vui long nhap du thong tin");
                if (!ktmasp || !ktradongia || !ktraslban)
                    throw new Exception("Vui long nhap dung dinh dang");
                var _masp = (from sp in ql.SanPhams
                            where sp.MaSp == int.Parse(txtmasp.Text)
                            select sp.MaSp).SingleOrDefault();
                if (_masp != 0) throw new Exception("Ma sp bi trung");
                int sl = int.Parse(txtslban.Text);
                if (sl <= 1) throw new Exception("Sl ban phai >1");
                
                SanPham sp1 = new SanPham();
                sp1.MaSp = int.Parse(txtmasp.Text);
                sp1.TenSanPham = txttensp.Text;
                sp1.DonGia = double.Parse(txtdongia.Text);
                sp1.SoLuongBan = int.Parse(txtslban.Text);
                sp1.MaNhomHang = int.Parse(cbbNhomHang.Text);
                sp1.TienBan = sp1.DonGia * sp1.SoLuongBan;

                ql.SanPhams.Add(sp1);
                ql.SaveChanges();
                Clear();
                Hienthi();

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            //hiển thị sản phầm có mã nhóm hàng = 1;
            Window1 w = new Window1();
            w.ShowDialog();
           
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            int num1, num2;
            double num3;
            bool ktmasp = int.TryParse(txtmasp.Text, out num1);
            bool ktraslban = int.TryParse(txtslban.Text, out num2);
            bool ktradongia = double.TryParse(txtdongia.Text, out num3);
            try
            {
                if (txtmasp.Text == "" || txttensp.Text == "" || txtdongia.Text == "" || txtslban.Text == "")
                    throw new Exception("Vui long nhap du thong tin");
                if (!ktmasp || !ktradongia || !ktraslban)
                    throw new Exception("Vui long nhap dung dinh dang");
                int sl = int.Parse(txtslban.Text);
                if (sl <= 1) throw new Exception("Sl ban phai >1");

                var item = dgDSSP.SelectedItem;
                var _masp = (dgDSSP.SelectedCells[0].Column.GetCellContent(item) as TextBlock).Text;
                if (_masp != txtmasp.Text) throw new Exception("Khong duoc sua ma sp");
                MessageBoxResult kq = MessageBox.Show("Ban chac chan muon xoa khong","thong bao",MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
                if (kq == MessageBoxResult.Yes)
                {
                    var sp1 = (from sp in ql.SanPhams
                               where sp.MaSp == int.Parse(txtmasp.Text)
                               select sp).Single();

                    sp1.TenSanPham = txttensp.Text;
                    sp1.DonGia = double.Parse(txtdongia.Text);
                    sp1.SoLuongBan = int.Parse(txtslban.Text);
                    sp1.MaNhomHang = int.Parse(cbbNhomHang.Text);
                    sp1.TienBan = sp1.DonGia * sp1.SoLuongBan;
                    ql.SaveChanges();
                    Clear();
                    Hienthi();
                    MessageBox.Show("Sua thanh cong");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtmasp.Text == "") throw new Exception("Vui long nhap ma sp de xoa");
                var sp1 = (from sp in ql.SanPhams
                           where sp.MaSp == int.Parse(txtmasp.Text)
                           select sp).Single();
                ql.SanPhams.Remove(sp1);
                ql.SaveChanges();
                Clear();
                Hienthi();
                MessageBox.Show("Xoa thanh cong");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnThongke_Click(object sender, RoutedEventArgs e)
        {
            Window2 w = new Window2();
            w.ShowDialog();
        }
    }
}
