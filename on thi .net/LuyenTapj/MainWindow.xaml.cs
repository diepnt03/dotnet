using LuyenTapj.Models;
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
using LuyenTapj.Models;
using System.Text.RegularExpressions;
using System.Reflection;

namespace LuyenTapj
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
        QLBHContext db = new QLBHContext();

        private void LoadTT(object sender, RoutedEventArgs e)
        {
            HienThi();
            loadCBB();
        }
        private void HienThi()
        {
            var query = from sp in db.SanPhams
                        where sp.DonGia > 100 orderby sp.TenSp descending
                        select new
                        {
                            sp.MaSp, sp.TenSp, sp.MaLoai, sp.DonGia, sp.SoLuongCo,
                            ThanhTien = sp.DonGia*sp.SoLuongCo
                        };
            dataGr.ItemsSource = query.ToList();
        }
        private void loadCBB()
        {
            var cbb = from lsp in db.LoaiSps select lsp;
            cbbLoai.ItemsSource = cbb.ToList();
            cbbLoai.DisplayMemberPath = "TenLoai";
            cbbLoai.SelectedValuePath = "MaLoai";
            cbbLoai.SelectedIndex = 0;
        }

        private void dataGr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(dataGr.SelectedItem != null)
            {
                try
                {
                    dynamic SP = dataGr.SelectedItem;
                    txtmaSP.Text = SP.MaSp;
                    txttenSP.Text = SP.TenSp;
                    cbbLoai.SelectedValue = SP.MaLoai;
                    txtdgia.Text = SP.DonGia.ToString();
                    txtsoluong.Text = SP.SoLuongCo.ToString();
                }
                catch(Exception)
                {
                    MessageBox.Show("Có lỗi", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private bool ktra()
        {
            try
            {
                if (txtmaSP.Text == "" || txttenSP.Text == "" || txtdgia.Text == "" || txtsoluong.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    return false;
                }
                if(!int.TryParse(txtsoluong.Text, out int SoLuong) || SoLuong < 0)
                {
                    MessageBox.Show("Số ượng có phải là số nguyên lớn hơn 0!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
                if(!int.TryParse(txtdgia.Text, out int DonGia) || DonGia < 100)
                {
                    MessageBox.Show("Dơn giá phải là số nguyên lớn hơn 100!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi dữ liệu");
            }
            return true;
        }
        private void lamTrong()
        {
            txtdgia.Text = "";
            txtmaSP.Text = "";
            txtsoluong.Text = "";
            txttenSP.Text = "";
        }

        private void btThem_Click(object sender, RoutedEventArgs e)
        {
            if(ktra())
            {
                var spN = db.SanPhams.SingleOrDefault(x => x.MaSp.Equals(txtmaSP.Text));
                if(spN != null)
                {
                    MessageBox.Show("Mã sản phẩm đac tồn tại.", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error );
                    HienThi();
                }
                else
                {
                    SanPham sp = new SanPham();
                    sp.MaSp = txtmaSP.Text;
                    sp.TenSp = txttenSP.Text;
                    sp.DonGia = int.Parse(txtdgia.Text);
                    sp.SoLuongCo = int.Parse(txtsoluong.Text);
                    LoaiSp lsp = (LoaiSp)cbbLoai.SelectedItem;
                    sp.MaLoai = lsp.MaLoai;
                    db.SanPhams.Add(sp);
                    db.SaveChanges();
                    MessageBox.Show("Thêm mới thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information );
                    HienThi();
                    lamTrong();
                }
            }
        }

        private void btSua_Click(object sender, RoutedEventArgs e)
        {
            if (ktra())
            {
                var sua = db.SanPhams.SingleOrDefault(x => x.MaSp.Equals(txtmaSP.Text));
                if(sua != null)
                {
                    sua.TenSp = txttenSP.Text;
                    LoaiSp lsp = (LoaiSp)cbbLoai.SelectedItem;
                    sua.MaLoai = lsp.MaLoai;
                    sua.DonGia = int.Parse(txtdgia.Text);
                    sua.SoLuongCo = int.Parse(txtsoluong.Text);
                    db.SaveChanges();
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information );
                    HienThi();
                    lamTrong();
                }
                else
                {
                    MessageBox.Show("Sản phẩm không tồn tại", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                }
            }
        }

        private void btXoa_Click(object sender, RoutedEventArgs e)
        {
            var xoa = db.SanPhams.SingleOrDefault(x => x.MaSp.Equals(txtmaSP.Text));
            if(xoa != null)
            {
                MessageBoxResult d = MessageBox.Show("Bạn chắc chắn muốn xoá sản phẩm này!", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Information);
                if(d == MessageBoxResult.Yes)
                {
                    db.SanPhams.Remove(xoa);
                    db.SaveChanges();
                    MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information) ;
                    HienThi();
                    lamTrong();
                }
            }
            else
            {
                MessageBox.Show("Sản phẩm không tồn tại", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }

        private void btTim_Click(object sender, RoutedEventArgs e)
        {
            var tim = from sp in db.SanPhams
                      join ban in db.HoaDonChiTiets on sp.MaSp equals ban.MaSp
                      join lSP in db.LoaiSps on sp.MaLoai equals lSP.MaLoai
                      group new { sp, ban, lSP } by new { sp.MaSp, sp.TenSp, lSP.MaLoai, lSP.TenLoai } into g
                      select new
                      {
                          g.Key.MaSp,
                          g.Key.TenSp,
                          g.Key.MaLoai,
                          g.Key.TenLoai,
                          SoLuongMua = g.Sum(x => x.ban.SoLuongMua),
                          TongTien = g.Sum(x => x.sp.DonGia * x.ban.SoLuongMua)
                      };
            Window1 tk = new Window1();
            tk.dataBH.ItemsSource = tim.ToList();
            tk.Show();
        }
    }
}
