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
using KiemTra.Models;
using System.Text.RegularExpressions;
using System.Reflection;

namespace KiemTra
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QLSachContext db = new QLSachContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            HienThiDL();
            HienThiCB();
        }
        private void HienThiCB()
        {
            var query = from t in db.TacGia
                        select t;
            cboTacGia.ItemsSource = query.ToList();
            cboTacGia.DisplayMemberPath = "TenTacGia";
            cboTacGia.SelectedValuePath = "MaTG";
            cboTacGia.SelectedIndex = 0;
        }

        private List<TT> LayDL()
        {
            var query = from t in db.Saches
                        where t.SoTrang >= 120
                        orderby t.SoTrang descending
                        select new TT
                        {
                            MaSach = t.MaSach,
                            TenSach = t.TenSach,
                            MaTG = t.MaTg,
                            NamXB = t.NamXuatBan,
                            SoTrang = t.SoTrang,
                            TongTien = t.SoTrang * 80000
                        };
            return query.ToList<TT>();
        }

        private void HienThiDL()
        {
            dgvdsSach.ItemsSource = LayDL();
        }

        private void dgvdsSach_SelectedCellsChanged(object sender, SelectedCellsChangedEventArgs e)
        {
            if(dgvdsSach.SelectedItem != null)
            {
                try
                {
                    Type t = dgvdsSach.SelectedItem.GetType();
                    PropertyInfo[] p = t.GetProperties();
                    txtMaSach.Text = p[0].GetValue(dgvdsSach.SelectedValue).ToString();
                    txtTenSach.Text = p[1].GetValue(dgvdsSach.SelectedValue).ToString();
                    txtNamXB.Text = p[2].GetValue(dgvdsSach.SelectedValue).ToString();
                    txtSoTrang.Text = p[3].GetValue(dgvdsSach.SelectedValue).ToString();
                    cboTacGia.SelectedValue = p[4].GetValue(dgvdsSach.SelectedValue).ToString();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message,"Thông báo",MessageBoxButton.OK,MessageBoxImage.Error);

                }
            }
        }

        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            var query = db.Saches.SingleOrDefault(t=>t.MaSach.Equals(txtMaSach.Text));
            if(query != null)
            {
                MessageBox.Show("Đã tồn tại", "Thông báo", MessageBoxButton.OK);
            }
            else
            {
                Sach a = new Sach();
                a.MaSach = txtMaSach.Text;
                a.TenSach = txtTenSach.Text;
                a.SoTrang = int.Parse(txtSoTrang.Text);
                a.NamXuatBan = int.Parse(txtNamXB.Text);
                TacGium dm = new TacGium();
                a.MaTg = dm.MaTg;
                db.Saches.Add(a);
                db.SaveChanges();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButton.OK);
                HienThiDL();
            }
        }

        private void btnSua_Click(object sender, RoutedEventArgs e)
        {
            var spsua = db.Saches.SingleOrDefault(t => t.MaSach == txtMaSach.Text);
            if(spsua != null)
            {
                spsua.TenSach = txtTenSach.Text;
                spsua.SoTrang = int.Parse(txtSoTrang.Text) ;
                spsua.NamXuatBan = int.Parse (txtNamXB.Text) ;
                spsua.MaTg = ((TacGium)cboTacGia.SelectedItem).MaTg;
                db.SaveChanges() ;
                HienThiDL() ;
            }
            else
            {
                MessageBox.Show("Không có mã này", "Thông báo", MessageBoxButton.OK);

            }
        }

        private void btnXoa_Click(object sender, RoutedEventArgs e)
        {
            var spxoa = db.Saches.SingleOrDefault(t => t.MaSach == txtMaSach.Text);
            if (spxoa != null)
            {
                db.Saches.Remove(spxoa);
                db.SaveChanges();
                HienThiDL();
            }
            else
            {
                MessageBox.Show("Không có mã này", "Thông báo", MessageBoxButton.OK);

            }
        }
    }
}






















