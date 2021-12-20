﻿using BookStoreClone.Model;
using BookStoreClone.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using LiveCharts;
using LiveCharts.Wpf;
namespace BookStoreClone.ViewModel
{
    class BaoCaoViewModel : BaseViewModel
    {

        private Visibility _visibilityBaoCaoTon;
        private Visibility _visibilityBCCongNo;
        private int _thang;
        private int _nam;
        private int _tongSoSachNhap;
        private int _tongSoSachBan;
        private int _tongSoNo;
        private int _tongSoTra;
        private ObservableCollection<CTHD> _listCTHD;
        private ObservableCollection<HoaDon> _listHD;
        private ObservableCollection<PhieuNhap> _listPN;
        private ObservableCollection<PhieuThuTien> _listPTT;
        private ObservableCollection<CTPhieuNhap> _listCTPN;
        private ObservableCollection<CTBaoCaoCongNo> _listCTBaoCaoCongNo;
        private ObservableCollection<BaoCaoTon> _listBaoCaoTon;
        private ObservableCollection<CTBaoCaoTon> _listCTBaoCaoTon;
        private DataGrid _dGBaoCaoNo;
        private DataGrid _dGBaoCaoTon;
        public ICommand ShowBCCongNoCommand { get; set; }
        public ICommand ShowBCTonCommand { get; set; }
        public ICommand datechange { get; set; }

        public ICommand TimKiemCommand { get; set; }
        public Visibility VisibilityBaoCaoTon { get => _visibilityBaoCaoTon; set { _visibilityBaoCaoTon = value; OnPropertyChanged(); } }
        public Visibility VisibilityBCCongNo { get => _visibilityBCCongNo; set { _visibilityBCCongNo = value; OnPropertyChanged(); } }

        public ObservableCollection<CTBaoCaoCongNo> ListCTBaoCaoCongNo { get => _listCTBaoCaoCongNo; set { _listCTBaoCaoCongNo = value; OnPropertyChanged(); } }

        public ObservableCollection<CTBaoCaoTon> ListCTBaoCaoTon { get => _listCTBaoCaoTon; set { _listCTBaoCaoTon = value; OnPropertyChanged(); } }

        public ObservableCollection<BaoCaoTon> ListBaoCaoTon { get => _listBaoCaoTon; set { _listBaoCaoTon = value; OnPropertyChanged(); } }

        public int Thang
        {
            get => _thang; set
            {
                _thang = value; OnPropertyChanged();
                //ShowBCCongNoCommand;
            }
        }
        public int Nam { get => _nam; set { _nam = value; OnPropertyChanged(); } }

        public DataGrid DGBaoCaoNo { get => _dGBaoCaoNo; set { _dGBaoCaoNo = value; OnPropertyChanged(); } }
        public DataGrid DGBaoCaoTon { get => _dGBaoCaoTon; set { _dGBaoCaoTon = value; OnPropertyChanged(); } }

        public int TongSoSachNhap { get => _tongSoSachNhap; set { _tongSoSachNhap = value; OnPropertyChanged(); } }

        public int TongSoSachBan { get => _tongSoSachBan; set { _tongSoSachBan = value; OnPropertyChanged(); } }
        public int TongSoNo { get => _tongSoNo; set { _tongSoNo = value; OnPropertyChanged(); } }
        public int TongSoTra { get => _tongSoTra; set { _tongSoTra = value; OnPropertyChanged(); } }

        public SeriesCollection SeriesCollection { get; set; }
        public string[] Labels { get; set; }
        public Func<double, string> Formatter { get; set; }

        public BaoCaoViewModel()
        {



            TongSoSachNhap = 0;
            TongSoSachBan = 0;

            SeriesCollection = new SeriesCollection()
                {
                    new ColumnSeries
                    {
                        Title = "Số lượng sách nhập",
                        Values = new ChartValues<int>{}
                       // Values = new ChartValues<double> { 10, 50, 39, 50 }
                    }
                };

            //adding series will update and animate the chart automatically
            SeriesCollection.Add(new ColumnSeries
            {
                Title = "Số lượng sách xuất",
                Values = new ChartValues<int> { }
                //Values = new ChartValues<double> { 11, 56, 42 }
            });

            //also adding values updates and animates the chart automatically
            //    SeriesCollection[1].Values.Add(48d);

            Labels = new[] { "Tháng 1", "Tháng 2", "Tháng 3", "Tháng 4", "Tháng 5", "Tháng 6", "Tháng 7", "Tháng 8", "Tháng 9", "Tháng 10", "Tháng 11", "Tháng 12" };
            Formatter = value => value.ToString("N");

            for (int i = 1; i <= 12; i++)
            {
                _listHD = new ObservableCollection<HoaDon>(DataProvider.Ins.DB.HoaDons.Where(x => x.NgayBan.Value.Month == i && x.NgayBan.Value.Year == DateTime.Now.Year - 1));
                _listCTHD = new ObservableCollection<CTHD>(DataProvider.Ins.DB.CTHDs);
                int s = 0;
                foreach (var a in _listHD)
                {
                    foreach (var b in _listCTHD)
                    {
                        if (a.MaHD == b.MaHD && b.PhuongThuc == "Mua") { s += (int)b.SoLuong; }
                    }
                }
                SeriesCollection[1].Values.Add(s);
                TongSoSachBan += s;
            }

            for (int i = 1; i <= 12; i++)
            {
                _listPN = new ObservableCollection<PhieuNhap>(DataProvider.Ins.DB.PhieuNhaps.Where(x => x.NgayNhap.Value.Month == i && x.NgayNhap.Value.Year == DateTime.Now.Year - 1));
                _listCTPN = new ObservableCollection<CTPhieuNhap>(DataProvider.Ins.DB.CTPhieuNhaps);
                int s = 0;
                foreach (var a in _listPN)
                {
                    foreach (var b in _listCTPN)
                    {
                        if (a.MaPN == b.MaPN) { s += b.SoLuongNhap; }
                    }
                }
                SeriesCollection[0].Values.Add(s);
                TongSoSachNhap += s;
            }





            Nam = 2020;
            ListCTBaoCaoCongNo = new ObservableCollection<CTBaoCaoCongNo>(DataProvider.Ins.DB.CTBaoCaoCongNoes);
            ListCTBaoCaoTon = new ObservableCollection<CTBaoCaoTon>(DataProvider.Ins.DB.CTBaoCaoTons);


            VisibilityBaoCaoTon = Visibility.Collapsed;
            VisibilityBCCongNo = Visibility.Collapsed;
            DGBaoCaoTon = new DataGrid();

            VisibilityBaoCaoTon = Visibility.Collapsed;
            VisibilityBCCongNo = Visibility.Visible;
            ShowBCCongNoCommand = new RelayCommand<Grid>((p) =>
            {
                //if (VisibilityBCCongNo != Visibility.Visible)
                return true;
            }, (p) =>
            {
                p.Children.Clear();
                showdgNo();
                VisibilityBaoCaoTon = Visibility.Collapsed;
                VisibilityBCCongNo = Visibility.Visible;
                p.Children.Clear();
                p.Children.Add(DGBaoCaoNo);
            });

            ShowBCTonCommand = new RelayCommand<Grid>((p) => { return true; }, (p) =>

            {
                p.Children.Clear();
                showdgTon();
                VisibilityBaoCaoTon = Visibility.Visible;
                VisibilityBCCongNo = Visibility.Collapsed;
                p.Children.Clear();
                p.Children.Add(DGBaoCaoTon);

            });

            datechange = new RelayCommand<Grid>((p) => { return true; }, (p) =>
            {


                if (VisibilityBaoCaoTon == Visibility.Visible)
                {
                    p.Children.Clear();
                    showdgTon();
                    p.Children.Clear();
                    p.Children.Add(DGBaoCaoTon);
                    TongSoNo = 0;
                    TongSoSachBan = 0;
                    TongSoSachNhap = 0;
                    TongSoTra = 0;

                    if ((Nam == DateTime.Now.Year && Thang < DateTime.Now.Month) || (Nam < DateTime.Now.Year))
                    {
                        try
                        {

                            _listHD = new ObservableCollection<HoaDon>(DataProvider.Ins.DB.HoaDons.Where(x => x.NgayBan.Value.Month == Thang && x.NgayBan.Value.Year == Nam));
                            _listPTT = new ObservableCollection<PhieuThuTien>(DataProvider.Ins.DB.PhieuThuTiens.Where(x => x.NgayThuTien.Value.Month == Thang && x.NgayThuTien.Value.Year == Nam));
                            _listCTHD = new ObservableCollection<CTHD>(DataProvider.Ins.DB.CTHDs.Where(x => x.HoaDon.NgayBan.Value.Month == Thang && x.HoaDon.NgayBan.Value.Year == Nam));

                            _listCTPN = new ObservableCollection<CTPhieuNhap>(DataProvider.Ins.DB.CTPhieuNhaps.Where(x => x.PhieuNhap.NgayNhap.Value.Month == Thang && x.PhieuNhap.NgayNhap.Value.Year == Nam));
                            foreach (HoaDon a in _listHD)
                            {
                                TongSoNo += (int)(a.TongTien - a.SoTienTra);
                            }
                            foreach (PhieuThuTien a in _listPTT)
                            {
                                TongSoTra += (int)a.SoTienThu;
                            }
                            foreach (CTHD a in _listCTHD)
                            {
                                TongSoSachBan += (int)a.SoLuong;
                            }
                            foreach (CTPhieuNhap a in _listCTPN)
                            {
                                TongSoSachNhap += (int)a.SoLuongNhap;
                            }

                        }
                        catch
                        {
                            MessageBox.Show("Tạm thời chưa có dữ liệu", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chọn khoảng tìm kiếm không hợp lệ!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }

                if (VisibilityBCCongNo == Visibility.Visible)
                {
                    p.Children.Clear();
                    showdgNo();
                    p.Children.Clear();
                    p.Children.Add(DGBaoCaoNo);
                    TongSoNo = 0;
                    
                    TongSoTra = 0;

                    if ((Nam == DateTime.Now.Year && Thang < DateTime.Now.Month) || (Nam < DateTime.Now.Year))
                    {
                        try
                        {

                            _listHD = new ObservableCollection<HoaDon>(DataProvider.Ins.DB.HoaDons.Where(x => x.NgayBan.Value.Month == Thang && x.NgayBan.Value.Year == Nam));
                            _listPTT = new ObservableCollection<PhieuThuTien>(DataProvider.Ins.DB.PhieuThuTiens.Where(x => x.NgayThuTien.Value.Month == Thang && x.NgayThuTien.Value.Year == Nam));
                            _listCTHD = new ObservableCollection<CTHD>(DataProvider.Ins.DB.CTHDs.Where(x => x.HoaDon.NgayBan.Value.Month == Thang && x.HoaDon.NgayBan.Value.Year == Nam));


                            _listCTPN = new ObservableCollection<CTPhieuNhap>(DataProvider.Ins.DB.CTPhieuNhaps.Where(x => x.PhieuNhap.NgayNhap.Value.Month == Thang && x.PhieuNhap.NgayNhap.Value.Year == Nam));
                            foreach (HoaDon a in _listHD)
                            {
                                TongSoNo += (int)(a.TongTien - a.SoTienTra);
                            }
                            foreach (PhieuThuTien a in _listPTT)
                            {
                                TongSoTra += (int)a.SoTienThu;
                            }
                            foreach (CTHD a in _listCTHD)
                            {
                                TongSoSachBan += (int)a.SoLuong;
                            }
                            foreach (CTPhieuNhap a in _listCTPN)
                            {
                                TongSoSachNhap += (int)a.SoLuongNhap;
                            }

                        }
                        catch
                        {
                            MessageBox.Show("Tạm thời chưa có dữ liệu", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Chọn khoảng tìm kiếm không hợp lệ!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                    }

                }
            });



            TimKiemCommand = new RelayCommand<Grid>((p) => { return true; }, (p) =>
            {
                TongSoNo = 0;
                

                TongSoTra = 0;

                if ((Nam == DateTime.Now.Year && Thang < DateTime.Now.Month) || (Nam < DateTime.Now.Year))
                {
                    try
                    {
                        _listHD = new ObservableCollection<HoaDon>(DataProvider.Ins.DB.HoaDons.Where(x => x.NgayBan.Value.Month == Thang && x.NgayBan.Value.Year == Nam));
                        _listPTT = new ObservableCollection<PhieuThuTien>(DataProvider.Ins.DB.PhieuThuTiens.Where(x => x.NgayThuTien.Value.Month == Thang && x.NgayThuTien.Value.Year == Nam));
                        _listCTHD = new ObservableCollection<CTHD>(DataProvider.Ins.DB.CTHDs.Where(x => x.HoaDon.NgayBan.Value.Month == Thang && x.HoaDon.NgayBan.Value.Year == Nam));

                        _listCTPN = new ObservableCollection<CTPhieuNhap>(DataProvider.Ins.DB.CTPhieuNhaps.Where(x => x.PhieuNhap.NgayNhap.Value.Month == Thang && x.PhieuNhap.NgayNhap.Value.Year == Nam));
                        foreach (HoaDon a in _listHD)
                        {
                            TongSoNo += (int)(a.TongTien - a.SoTienTra);
                        }
                        foreach (PhieuThuTien a in _listPTT)
                        {
                            TongSoTra += (int)a.SoTienThu;
                        }



                    }
                    catch
                    {
                        MessageBox.Show("Tạm thời chưa có dữ liệu", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Chọn khoảng tìm kiếm không hợp lệ!", "Thông báo", MessageBoxButton.OK, MessageBoxImage.Error);
                }


            });
        }
        public void showdgNo()
        {

            DGBaoCaoNo = new DataGrid();
            DGBaoCaoNo.AutoGenerateColumns = false;
            DGBaoCaoNo.IsReadOnly = true;
            ListCTBaoCaoCongNo = new ObservableCollection<CTBaoCaoCongNo>(DataProvider.Ins.DB.CTBaoCaoCongNoes.Where(x => x.BaoCaoCongNo.Thang == Thang && x.BaoCaoCongNo.Nam == Nam));
            Binding b = new Binding("ListCTBaoCaoCongNo")
            {

                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged

            };
            DGBaoCaoNo.SetBinding(DataGrid.ItemsSourceProperty, b);

            DataGridTextColumn _maKH = new DataGridTextColumn();
            _maKH.Header = "Mã Khách Hàng";
            _maKH.Binding = new Binding("MaKH");
            DGBaoCaoNo.Columns.Add(_maKH);

            DataGridTextColumn _tenKH = new DataGridTextColumn();
            _tenKH.Header = " Tên Khách Hàng";
            _tenKH.Binding = new Binding("KhachHang.TenKH");
            DGBaoCaoNo.Columns.Add(_tenKH);

            DataGridTextColumn _noDau = new DataGridTextColumn();
            _noDau.Header = "Số tiền nợ đầu";
            _noDau.Binding = new Binding("SoTienNoDau");
            DGBaoCaoNo.Columns.Add(_noDau);

            DataGridTextColumn _noCuoi = new DataGridTextColumn();
            _noCuoi.Header = "Số nợ cuối";
            _noCuoi.Binding = new Binding("SoTienNoCuoi");
            DGBaoCaoNo.Columns.Add(_noCuoi);

        }
        void showdgTon()
        {
            DGBaoCaoTon = new DataGrid();
            DGBaoCaoTon.AutoGenerateColumns = false;
            DGBaoCaoTon.IsReadOnly = true;
            /////////////////////////////////////////////////////////
            ListCTBaoCaoTon = new ObservableCollection<CTBaoCaoTon>(DataProvider.Ins.DB.CTBaoCaoTons.Where(x => x.BaoCaoTon.Nam == Nam && x.BaoCaoTon.Thang == Thang));

            Binding b = new Binding("ListCTBaoCaoTon")
            {
                Mode = BindingMode.TwoWay,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged
            };
            DataGridTextColumn _tenSach = new DataGridTextColumn();
            _tenSach.Header = "Tên Sách";
            _tenSach.Binding = new Binding("Sach.TenSach");
            DGBaoCaoTon.Columns.Add(_tenSach);
            DGBaoCaoTon.SetBinding(DataGrid.ItemsSourceProperty, b);
            DataGridTextColumn _maSach = new DataGridTextColumn();
            _maSach.Header = "Mã Sách";
            _maSach.Binding = new Binding("MaSach");
            DGBaoCaoTon.Columns.Add(_maSach);

            DataGridTextColumn _NXB = new DataGridTextColumn();
            _NXB.Header = " Nhà Xuất Bản";
            _NXB.Binding = new Binding("Sach.NhaXuatBan.TenNXB");
            DGBaoCaoTon.Columns.Add(_NXB);

            DataGridTextColumn _tonDau = new DataGridTextColumn();
            _tonDau.Header = "Số tồn đầu";
            _tonDau.Binding = new Binding("SoLuongTonDau");
            DGBaoCaoTon.Columns.Add(_tonDau);

            DataGridTextColumn _tonCuoi = new DataGridTextColumn();
            _tonCuoi.Header = "Số tồn cuối";
            _tonCuoi.Binding = new Binding("SoLuongTonCuoi");
            DGBaoCaoTon.Columns.Add(_tonCuoi);
        }

    }

}

