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
using System.Windows.Shapes;
using LuyenTapj.Models;

namespace LuyenTapj
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        QLBHContext db = new QLBHContext();
        private void HienThiTT(object sender, RoutedEventArgs e)
        {
            /*var tim = from sp in db.SanPhams
                      join ban in db.HoaDonChiTiets on sp.MaLoai equals ban.MaSp
                      join lSP in db.LoaiSps on sp.MaLoai equals lSP.MaLoai
                      select new
                      {
                          sp.MaSp,
                          sp.TenSp,
                          lSP.TenLoai,
                          ban.SoLuongMua,
                          TongTien = sp.DonGia * ban.SoLuongMua
                      };
            dataBH.ItemsSource = tim.ToList();*/
        }
    }
}
