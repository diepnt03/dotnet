﻿using System;
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

namespace Demo1
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

        private void cboQuequan_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txthodem_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void butXem_Click(object sender, RoutedEventArgs e)
        {
            string strMessage, strHoten, strTitle, strNgoaiNgu = "";
            strHoten = txthodem.Text + " " + txtten.Text;
            if (radioNam.IsChecked == true)
            {
                strTitle = "Mr.";
            }
            else
            {
                strTitle = "Miss/Mrs.";
            }
            strMessage = "Xin chào: " + strTitle + " " + strHoten;
            if (chkAnh.IsChecked == true)
            {
                strNgoaiNgu = "Tiếng Anh";
            }
            if (chkTrung.IsChecked == true)
            {
                strNgoaiNgu = (strNgoaiNgu.Length == 0) ? "Tiếng Trung" : (strNgoaiNgu + " và Tiếng Trung");
            }
            strMessage += "\n Ngoại ngữ: " + strNgoaiNgu;
            if (cboQuequan.SelectedIndex >= 0)
            {
                strMessage += "\n Quê quán: " + cboQuequan.Text;
            }
            MessageBox.Show(strMessage);
        }

        private void butNhap_Click(object sender, RoutedEventArgs e)
        {
            txthodem.Text = "";
            txtten.Text = "";
            radioNam.IsChecked = true;
            radioNu.IsChecked = false;
            chkAnh.IsChecked = false;
            chkTrung.IsChecked = false;
            cboQuequan.SelectedIndex = 0;
        }
    }
}
















