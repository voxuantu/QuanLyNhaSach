using BookStoreClone.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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

namespace BookStoreClone.View
{
    /// <summary>
    /// Interaction logic for BaoCaoUC.xaml
    /// </summary>
    /// 

    public partial class BaoCaoUC : UserControl
    {
        public struct sachs
        {
            public string tensach { get; set; }
            public int soluongban { get; set; }
            public int soluongnhap { get; set; }
        }
        //private ObservableCollection<CTHD> _listCTHD;
        //private ObservableCollection<Sach> sach;

        //private ObservableCollection<HoaDon> _listHD;
        //private ObservableCollection<PhieuThuTien> _listPTT;
        //private ObservableCollection<CTPhieuNhap> _listCTPN;
        //private ObservableCollection<CTBaoCaoCongNo> _listCTBaoCaoCongNo;
        //private ObservableCollection<CTBaoCaoTon> _listCTBaoCaoTon;
        private List<Category> Categories { get; set; }
        private List<sachs> n { get; set; }

        public BaoCaoUC()
        {
            InitializeComponent();
            //change();
            //void change()
            float pieWidth = 200, pieHeight = 200, centerX = pieWidth / 2, centerY = pieHeight / 2, radius = pieWidth / 2;
        }

        private void Button_xuat_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                this.IsEnabled = false;
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == true)
                {
                    printDialog.PrintVisual(pnlpnl, "Báo Cáo");
                }
            }
            finally
            {
                this.IsEnabled = true;
            }

        }

        private void ComboBox_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        //int sachnhap;
        //sachs b;
        //int q;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ////_listCTHD = new ObservableCollection<CTHD>(DataProvider.Ins.DB.CTHDs.Where(x => x.HoaDon.NgayBan.Value.Month == int.Parse(Thang.SelectedItem.ToString()) && x.HoaDon.NgayBan.Value.Year == int.Parse(Nam.Text.ToString())));
            //         //a1 = new sachs() { tensach = 0; };
            //         n = new List<sachs>();
            // b=new sachs();
            //         foreach (CTHD a in _listCTHD)
            //{
            //             bool k=false;
            //             for(int i=0;i<n.Count();i++) /*( var s in n)*/
            //             { 
            //                 if (a.Sach.TenSach == n[i].tensach)
            //                 {
            //                     k = true;
            //   //                  n[i].soluongban += (int)a.SoLuong;
            //			//n[i].soluongban += (int)a.SoLuong;
            //                 }

            //             }
            //             //n[q].soluongban+= (int)a.SoLuong;
            //             sachnhap += (int)a.SoLuong;
            //}
        }
    }
    public class Category
    {
        public float Percentage { get; set; }
        public string Title { get; set; }
        public Brush ColorBrush { get; set; }
    }

}


