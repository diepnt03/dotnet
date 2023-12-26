using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
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
using TH.QLBH;

namespace TH
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QlbanHangContext db = new QlbanHangContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            hienThi();
            var query = from x in db.LoaiSps
                        select x;
            cboLoaiSP.ItemsSource = query.ToList();
            cboLoaiSP.DisplayMemberPath = "TenLoai";
            cboLoaiSP.SelectedValuePath = "MaLoai";

        }
        private void hienThi()
        {
            var query = from x in db.SanPhams
                        orderby x.DonGia ascending
                        select new
                        {
                            x.MaSp,
                            x.TenSp,
                            x.MaLoaiNavigation.TenLoai,
                            x.SoLuongCo,
                            x.DonGia,
                            ThanhTien = x.DonGia * x.SoLuongCo
                        };
            dtgSanPham.ItemsSource = query.ToList();
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            if (isKT() == true)
            {
                SanPham spMoi = new SanPham();
                spMoi.MaSp = txtMaSP.Text;
                spMoi.TenSp = txtTenSP.Text;
                spMoi.MaLoai = cboLoaiSP.SelectedValue.ToString();
                spMoi.DonGia = int.Parse(txtDonGia.Text);
                spMoi.SoLuongCo = int.Parse(txtSLCo.Text);

                db.SanPhams.Add(spMoi);
                db.SaveChanges();
                hienThi();
                MessageBox.Show("Thêm sản phẩm thành công", "THÔNG BÁO");
            }
        }

        private bool isKT()
        {
            try
            {
                int gia = int.Parse(txtDonGia.Text);
                if(gia <= 0)
                {
                    MessageBox.Show("Đơn giá phải lớn hơn 0", "CHECK DATA", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtDonGia.SelectAll();
                    txtDonGia.Focus();
                    return false;
                }

            }catch(Exception)
            {
                MessageBox.Show("Đơn giá phải là số nguyên và lớn hơn 0", "CHECK DATA", MessageBoxButton.OK, MessageBoxImage.Error);
                txtDonGia.SelectAll();
                txtDonGia.Focus();
                return false;
            }

            try
            {
                int slc = int.Parse(txtSLCo.Text);
                if (slc <= 0)
                {
                    MessageBox.Show("Số lượng có phải lớn hơn 0", "CHECK DATA", MessageBoxButton.OK, MessageBoxImage.Error);
                    txtSLCo.SelectAll();
                    txtSLCo.Focus();
                    return false;
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Số lượng có phải là số nguyên và lớn hơn 0", "CHECK DATA", MessageBoxButton.OK, MessageBoxImage.Error);
                txtSLCo.SelectAll();
                txtSLCo.Focus();
                return false;
            }
            return true;
        }

        private void btnTim_Click(object sender, RoutedEventArgs e)
        {
            // đếm sl mỗi loại sp
            var queryTim = from x in db.LoaiSps
                           select new
                           {
                               x.MaLoai,
                               x.TenLoai,
                               SoSP = x.SanPhams.Count()
                           };

            // tính sl đã bán của mỗi sp
            var query = from x in db.SanPhams
                        select new
                        {
                            x.MaSp,
                            x.TenSp, 
                            x.MaLoaiNavigation.TenLoai,
                            tongSL = x.ChiTietHoaDons.Sum(s=>s.SoLuongMua)
                        };

            //tính tổng sl đã bán, tổng tiền của mỗi mã sp
            var query1 = from x in db.ChiTietHoaDons
                         group x by x.MaSp into xGroup
                         select new
                         {
                             MaSp = xGroup.Key,
                             sldaban = xGroup.Sum(s=>s.SoLuongMua),
                             tong = xGroup.Sum(s=>s.SoLuongMua * s.MaSpNavigation.DonGia)
                         };
            //kết nối với lớp để lấy tên sp và tên loại
            var query2 = from x in query1
                         join y in db.SanPhams
                         on x.MaSp equals y.MaSp
                         select new
                         {
                             x.MaSp,
                             y.TenSp,
                             y.MaLoaiNavigation.TenLoai,
                             x.sldaban,
                             x.tong
                         };
            Window1 wd1 = new Window1();
            wd1.dtgTim.ItemsSource = query.ToList(); //gán nguồn dl
            wd1.Show();
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            var querySua = from x in db.SanPhams
                           where x.MaSp == txtMaSP.Text
                           select x;
            if(querySua.Count() > 0)
            {
                SanPham sp = querySua.SingleOrDefault();
                sp.TenSp = txtTenSP.Text;
                sp.MaLoai = cboLoaiSP.SelectedValue.ToString();
                sp.DonGia = int.Parse(txtDonGia.Text);
                sp.SoLuongCo = int.Parse(txtSLCo.Text);
                db.SaveChanges();
                hienThi();
                MessageBox.Show("Sửa thành công!", "THÔNG BÁO");
            }
        }

        private void dtgSanPham_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var dongchon = dtgSanPham.SelectedItem;
            if(dongchon != null)
            {
                Type t = dongchon.GetType();
                PropertyInfo[] dongchoninf = t.GetProperties();
                txtMaSP.Text = dongchoninf[0].GetValue(dongchon).ToString();
                txtTenSP.Text = dongchoninf[1].GetValue(dongchon).ToString();
                cboLoaiSP.Text = dongchoninf[2].GetValue(dongchon).ToString();
                txtDonGia.Text = dongchoninf[3].GetValue(dongchon).ToString();
                txtSLCo.Text = dongchoninf[4].GetValue(dongchon).ToString();
            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            var queryXoa = from x in db.SanPhams
                           where x.MaSp == txtMaSP.Text
                           select x;
            if(queryXoa.Count() > 0 )
            {
                SanPham sp = queryXoa.SingleOrDefault();
                db.SanPhams.Remove(sp);
                db.SaveChanges();
                hienThi();
                MessageBox.Show("Xóa thành công!", "THÔNG BÁO");
            }
        }
    }
}
