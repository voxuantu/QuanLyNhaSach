using BookStoreClone.Model;
using BookStoreClone.View;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BookStoreClone.ViewModel
{
    internal class QuanLyHoaDonViewModel : BaseViewModel
    {
        public bool isdangnhap = false;
        private ObservableCollection<HoaDon> _listHoaDon;
        private ObservableCollection<CTHD> _listCTHD_BanSach;
        public ObservableCollection<HoaDon> ListHoaDon { get => _listHoaDon; set { _listHoaDon = value; OnPropertyChanged(); } }
        public ObservableCollection<CTHD> ListCTHD_BanSach { get => _listCTHD_BanSach; set { _listCTHD_BanSach = value; OnPropertyChanged(); } }
        public ObservableCollection<int> ListChonSoLuong
        {
            get => _ListChonSoLuong; set
            {
                _ListChonSoLuong = value; OnPropertyChanged();
            }
        }
        public ObservableCollection<string> ListChonPhuongThuc { get; set; }
        public ObservableCollection<int> ListChonTinhTrang
        {
            get => _ListChonTinhTrang; set { _ListChonTinhTrang = value; OnPropertyChanged(); }
        }

        private DateTime _selectedDateTime;
        public DateTime SelectedDateTime { get => _selectedDateTime; set { _selectedDateTime = value; OnPropertyChanged(); } }

        DateTime _DateTimeStart;
        DateTime _DateTimeEnd;
        public DateTime DateTimeStart { get => _DateTimeStart; set { _DateTimeStart = value; OnPropertyChanged(); CapNhatHoaDonVaTimKiem(); } }
        public DateTime DateTimeEnd { get => _DateTimeEnd; set { _DateTimeEnd = value; OnPropertyChanged(); CapNhatHoaDonVaTimKiem(); } }


        string _TimKiemHoaDon;
        public string TextTimKiemHoaDon { get => _TimKiemHoaDon; set { _TimKiemHoaDon = value; OnPropertyChanged(); CapNhatHoaDonVaTimKiem(); } }
        #region Thêm Sách done

        private int _tongGiaBan;
        private int _tongSachMuon;
        private CTHD _selectedItemCTHD;
        private QuanLyDuLieuSachViewModel QuanLyDuLieuSachVM;
        public ICommand LoadCardThemSach { get; set; }
        public ICommand ThemSachVaoHoaDonCommand { get; set; }
        public ICommand CellEditEndingThemSachCommand { get; set; }

        public ICommand XoaChonSachCommand { get; set; }
        public ICommand ShowListChonSachCommnad { get; set; }
        public ICommand AnListChonSachComamnd { get; set; }

        public int TongGiaBan
        {
            get => _tongGiaBan; set
            {
                _tongGiaBan = value; OnPropertyChanged();
                //TongSachMuon = 0;
                foreach (CTHD hd in ListCTHD_BanSach)
                    if (hd.PhuongThuc == "Mua")
                        hd.ThanhTien = (int)hd.SoLuong * (int)hd.DonGiaBan * hd.TinhTrang / 100;
                    else
                    {
                        hd.ThanhTien = ((int)hd.SoLuong * (int)hd.DonGiaBan * Const.QuyDinh_HeSoDonGiaMuon / 100 * hd.TinhTrang / 100);
                        //TongSachMuon += (int)hd.SoLuong;
                    }
                SoTienTra = TongGiaBan.ToString();
            }
        }
        public int TongSachMuon { get => _tongSachMuon; set { _tongSachMuon = value; OnPropertyChanged(); } }
        public CTHD SelectedItemCTHD
        {
            get => _selectedItemCTHD;
            set
            {
                _selectedItemCTHD = value;
                OnPropertyChanged();
                if (SelectedItemCTHD == null)
                    return;

                for (int i = 2; i < SelectedItemCTHD.Sach.SoLuongTon - Const.QuyDinh_TonToiThieuSauKhiBan; i++)
                {
                    ListChonSoLuong.Add(i);
                }
                for (int i = 1; i < 100; i++)
                    ListChonTinhTrang.Add(i);
            }
        }

        #endregion Thêm Sách done



        #region Khách hàng done

        public QuanLyKhachHangViewModel QuanLyKhachHangVM;
        private KhachHang _selectedKhachHang;
        public KhachHang SelectedKhachHang { get => _selectedKhachHang; set { _selectedKhachHang = value; OnPropertyChanged(); } }
        public ICommand ChonKhachHangCommand { get; set; }
        public ICommand ShowListChonKhachHangCommand { get; set; }
        public ICommand AnListChonKhachHangCommad { get; set; }
        public ICommand LoadCardKhachHang { get; set; }

        #endregion Khách hàng done

        #region Lưu hóa đơn

        private string _soTienTra;
        private HoaDon _SelectedHoaDon;
        public ICommand LuuHoaDonCommand { get; set; }
        public ICommand InHoaDonCommand { get; set; }

        public ICommand TaoMoiHoaDonCommand { get; set; }
        public string SoTienTra { get => _soTienTra; set { _soTienTra = value; OnPropertyChanged(); } }
        public string DisCount
        {
            get => _DisCount; set
            {
                _DisCount = value; OnPropertyChanged(); try
                {
                    TongSachMuon = 0;
                    foreach (CTHD hd in ListCTHD_BanSach)
                        if (hd.PhuongThuc == "Mua")
                            hd.ThanhTien = (int)hd.SoLuong * (int)hd.DonGiaBan * hd.TinhTrang / 100;
                        else
                        {
                            hd.ThanhTien = ((int)hd.SoLuong * (int)hd.DonGiaBan * Const.QuyDinh_HeSoDonGiaMuon / 100 * hd.TinhTrang / 100);
                            TongSachMuon += (int)hd.SoLuong;
                        }
                    TongGiaBan = ListCTHD_BanSach.Sum(x => (int)x.ThanhTien);
                    try { TongGiaBan = (TongGiaBan * (100 - int.Parse(DisCount))) / 100; } catch { }
                    TongGiaBan = (TongGiaBan * (100 - int.Parse(DisCount))) / 100;
                }
                catch { }
            }
        }
        public HoaDon SelectedHoaDon { get => _SelectedHoaDon; set { _SelectedHoaDon = value; OnPropertyChanged(); XulyHienThemHoaDon(-1); } }

        #endregion Lưu hóa đơn

        #region Người dùng

        private NguoiDung _user;
        public NguoiDung User { get => _user; set { _user = value; OnPropertyChanged(); } }

        #endregion Người dùng

        #region Giao diện

        private Visibility _visibilityChonKhachHang;
        private Visibility _visibilityChonSach;
        private Visibility _visibilityXemHoaDon;
        private Visibility _visibilityTaoHoaDon;

        private Visibility _visibilitBtnChonSach;
        private Visibility _visibilitBtnChonKhachHang;
        private Visibility _nhanvienhien;
        private bool _btnThemMoiKhachHang;
        private bool _iea;

        private bool _btnThemHoaDonMoi;
        private string _DisCount;
        private ObservableCollection<int> _ListChonSoLuong;
        private ObservableCollection<int> _ListChonTinhTrang;

        public Visibility VisibilityChonKhachHang { get => _visibilityChonKhachHang; set { _visibilityChonKhachHang = value; OnPropertyChanged(); VisibilitBtnChonKhachHang = VisibilityChonKhachHang == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible; } }
        public Visibility VisibilityChonSach { get => _visibilityChonSach; set { _visibilityChonSach = value; OnPropertyChanged(); VisibilitBtnChonSach = VisibilityChonSach == Visibility.Visible ? Visibility.Collapsed : Visibility.Visible; } }
        public Visibility VisibilityXemHoaDon { get => _visibilityXemHoaDon; set { _visibilityXemHoaDon = value; OnPropertyChanged(); } }
        public Visibility VisibilityTaoHoaDon { get => _visibilityTaoHoaDon; set { _visibilityTaoHoaDon = value; OnPropertyChanged(); BtnThemHoaDonMoi = VisibilitBtnChonSach == Visibility.Visible ? true : false; } }
        public Visibility eniea { get; set; }
        public Visibility VisibilitBtnChonSach { get => _visibilitBtnChonSach; set { _visibilitBtnChonSach = value; OnPropertyChanged(); } }
        public Visibility VisibilitBtnChonKhachHang { get => _visibilitBtnChonKhachHang; set { _visibilitBtnChonKhachHang = value; OnPropertyChanged(); } }
        public Visibility nhanvienhien { get => _nhanvienhien; set { _nhanvienhien = value; OnPropertyChanged(); } }
        public bool iea
        {
            get => _iea; set
            {
                _iea = value; OnPropertyChanged();
                if (iea == true)
                    eniea = Visibility.Visible;
                else eniea = Visibility.Collapsed;
            }
        }
        public bool BtnThemMoiKhachHang { get => _btnThemMoiKhachHang; set { _btnThemMoiKhachHang = value; OnPropertyChanged(); } }
        public bool BtnThemHoaDonMoi { get => _btnThemHoaDonMoi; set { _btnThemHoaDonMoi = value; OnPropertyChanged(); } }



        private void XulyHienThemHoaDon(int n)
        {
            if (n == 0)
            {
                VisibilityChonSach = Visibility.Collapsed;
                VisibilityTaoHoaDon = Visibility.Visible;
                VisibilityXemHoaDon = Visibility.Collapsed;
                VisibilityChonKhachHang = Visibility.Visible;
                BtnThemHoaDonMoi = false;
            }
            if (n == 1)
            {
                VisibilityChonSach = Visibility.Visible;
                VisibilityTaoHoaDon = Visibility.Visible;
                VisibilityXemHoaDon = Visibility.Collapsed;
                VisibilityChonKhachHang = Visibility.Collapsed;
                BtnThemHoaDonMoi = true;
            }
            if (n == -1)
            {
                VisibilityChonSach = Visibility.Collapsed;
                VisibilityTaoHoaDon = Visibility.Collapsed;
                VisibilityXemHoaDon = Visibility.Visible;
                try
                {
                    if (SelectedHoaDon != null)
                        foreach (CTHD hd in SelectedHoaDon.CTHDs)
                            if (hd.PhuongThuc == null)
                                hd.PhuongThuc = "Mua";
                }
                catch { }
                VisibilityChonKhachHang = Visibility.Collapsed;
                iea = true;
                BtnThemHoaDonMoi = false;
            }
            if (n == 2)
            {
                VisibilityChonSach = Visibility.Collapsed;
                VisibilityTaoHoaDon = Visibility.Visible;
                VisibilityXemHoaDon = Visibility.Collapsed;
                VisibilityChonKhachHang = Visibility.Collapsed;
                BtnThemHoaDonMoi = true;
            }
            SelectedDateTime = System.DateTime.Now;
        }

        #endregion Giao diện

        public QuanLyHoaDonViewModel()
        {
            DateTimeStart = new DateTime(2020, 01, 01, 01, 01, 01);
            DateTimeEnd = System.DateTime.Now;
            TextTimKiemHoaDon = "";
            //ListHoaDon = new ObservableCollection<HoaDon>(DataProvider.Ins.DB.HoaDons);
            ListCTHD_BanSach = new ObservableCollection<CTHD>();
            DisCount = "0";

            ListChonSoLuong = new ObservableCollection<int>();
            ListChonPhuongThuc = new ObservableCollection<string>();
            ListChonTinhTrang = new ObservableCollection<int>();
            ListChonSoLuong.Add(1);
            ListChonPhuongThuc.Add("Mua");
            ListChonPhuongThuc.Add("Mượn");
            ListChonTinhTrang.Add(100);
            XulyHienThemHoaDon(-1);
            try { User = DataProvider.Ins.DB.NguoiDungs.Where(x => x.TenDangNhap == Const.IDNguoiDung).First(); isdangnhap = true; } catch { isdangnhap = false; }
            if (isdangnhap)
            { nhanvienhien = Visibility.Visible; }
            else nhanvienhien = Visibility.Collapsed;
            #region Thêm sách done

            ThemSachVaoHoaDonCommand = new RelayCommand<Sach>((p) => { return true; }, (p) =>
            {
                for (int i = 0; i < ListCTHD_BanSach.Count; i++)
                {
                    if (p.MaSach == ListCTHD_BanSach[i].Sach.MaSach)
                        return;
                }
              
                ListCTHD_BanSach.Add(new CTHD() { Sach = DataProvider.Ins.DB.Saches.Where(x => x.MaSach == p.MaSach).First(), DonGiaBan = p.DonGia, SoLuong = 1, PhuongThuc = "Mua", TinhTrang = 100 });
                //TongGiaBan = ListCTHD_BanSach.Sum(x => (int)x.SoLuong * (int)x.DonGiaBan);
                TongSachMuon = 0;
                foreach (CTHD hd in ListCTHD_BanSach)
                    if (hd.PhuongThuc == "Mua")
                        hd.ThanhTien = (int)hd.SoLuong * (int)hd.DonGiaBan * hd.TinhTrang / 100;
                    else
                    {
                        hd.ThanhTien = ((int)hd.SoLuong * (int)hd.DonGiaBan * Const.QuyDinh_HeSoDonGiaMuon / 100 * hd.TinhTrang / 100);
                        TongSachMuon += (int)hd.SoLuong;
                    }
                TongGiaBan = ListCTHD_BanSach.Sum(x => (int)x.ThanhTien);
                try { TongGiaBan = (TongGiaBan * (100 - int.Parse(DisCount))) / 100; } catch { }


                Const.IDNguoiDung = DataProvider.Ins.DB.NguoiDungs.ToList()[1].TenDangNhap;

            });

            CellEditEndingThemSachCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                foreach (CTHD a in ListCTHD_BanSach)
                {
                    if (a.Sach.SoLuongTon - a.SoLuong < Const.QuyDinh_TonToiThieuSauKhiBan)
                        a.SoLuong = a.Sach.SoLuongTon - Const.QuyDinh_TonToiThieuSauKhiBan;
                };
                try
                {
                    TongSachMuon = 0;
                    foreach (CTHD hd in ListCTHD_BanSach)
                        if (hd.PhuongThuc == "Mua")
                            hd.ThanhTien = (int)hd.SoLuong * (int)hd.DonGiaBan * hd.TinhTrang / 100;
                        else
                        {
                            hd.ThanhTien = ((int)hd.SoLuong * (int)hd.DonGiaBan * Const.QuyDinh_HeSoDonGiaMuon/100 * hd.TinhTrang / 100);
                            TongSachMuon += (int)hd.SoLuong;
                        }
                    TongGiaBan = ListCTHD_BanSach.Sum(x => (int)x.ThanhTien);
                    try { TongGiaBan = (TongGiaBan * (100 - int.Parse(DisCount))) / 100; } catch { }

                }
                catch { }
                ListCTHD_BanSach = new ObservableCollection<CTHD>(ListCTHD_BanSach);
            });
            ShowListChonSachCommnad = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                XulyHienThemHoaDon(1);
            });
            AnListChonSachComamnd = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                VisibilityChonSach = Visibility.Collapsed;
            });
            XoaChonSachCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                MessageBoxResult result = MessageBox.Show("Bạn có muốn xóa sách đang chọn?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Information);
                if (result == MessageBoxResult.Yes)
                    for (int i = 0; i < ListCTHD_BanSach.Count; i++)
                    {
                        if (ListCTHD_BanSach[i].Sach.MaSach == SelectedItemCTHD.Sach.MaSach) try { SoTienTra = (TongGiaBan * (100 - int.Parse(DisCount)) / 100).ToString(); } catch { }
                        {
                            ListCTHD_BanSach.Remove(ListCTHD_BanSach[i]);
                            TongSachMuon = 0;
                            foreach (CTHD hd in ListCTHD_BanSach)
                                if (hd.PhuongThuc == "Mua")
                                    hd.ThanhTien = (int)hd.SoLuong * (int)hd.DonGiaBan * hd.TinhTrang / 100;
                                else
                                {
                                    hd.ThanhTien = ((int)hd.SoLuong * (int)hd.DonGiaBan * Const.QuyDinh_HeSoDonGiaMuon / 100 * hd.TinhTrang / 100);
                                    TongSachMuon += (int)hd.SoLuong;
                                }
                            TongGiaBan = ListCTHD_BanSach.Sum(x => (int)x.ThanhTien);
                            try { TongGiaBan = (TongGiaBan * (100 - int.Parse(DisCount))) / 100; } catch { }

                            return;
                        }
                    }
            });
            LoadCardThemSach = new RelayCommand<Card>((p) => { return true; }, (p) =>
            {
                QuanLyDuLieuSachVM = p.DataContext as QuanLyDuLieuSachViewModel;
            });

            #endregion Thêm sách done

            #region Chọn khách hàng done

            ChonKhachHangCommand = new RelayCommand<KhachHang>((p) => { return true; }, (p) =>
            {
                SelectedKhachHang = p;
            });

            ShowListChonKhachHangCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                XulyHienThemHoaDon(0);
            });
            AnListChonKhachHangCommad = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                VisibilityChonKhachHang = Visibility.Collapsed;
            });
            LoadCardKhachHang = new RelayCommand<Card>((p) => { return true; }, (p) =>
            {
                QuanLyKhachHangVM = p.DataContext as QuanLyKhachHangViewModel;
            });

            #endregion Chọn khách hàng done

            #region Hóa đơn

            LuuHoaDonCommand = new RelayCommand<DockPanel>(
                (p) =>
                {
                    //QuanLyHoaDonUC.pnlhoadon
                    //if (ListCTHD_BanSach.Count == 0) return false;
                    //if (!isdangnhap)
                    //{
                    //    p.IsEnabled = true; return true;
                    //}
                    //p.IsEnabled = false;

                    //if (SelectedKhachHang == null) return false;

                    //if (User == null) return false;

                    //if (KiemTraSo(SoTienTra) == false) return false;

                    //if (KiemTraSo(DisCount) == false) return false;

                    //if (int.Parse(SoTienTra) > TongGiaBan) return false;

                    //for (int i = 0; i < ListCTHD_BanSach.Count; i++)
                    //    if (ListCTHD_BanSach[i].SoLuong < 1) return false;

                    //p.IsEnabled = true;
                    return true;
                },
                (p) =>
                {
                    if (ListCTHD_BanSach.Count == 0 && SelectedKhachHang == null)
                    {
                        MessageBox.Show("Vui lòng điền đủ thông tin.");
                        return;
                    }
                    if (SelectedKhachHang == null)
                    {
                        MessageBox.Show("Vui lòng chọn khách hàng để tạo hóa đơn.");
                        return;
                    }
                    if (ListCTHD_BanSach.Count == 0)
                    {
                        MessageBox.Show("Vui lòng chọn sách để tạo hóa đơn.");
                        return;
                    }
                    MessageBoxResult result1 = MessageBox.Show("In hóa đơn để xem trước?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Information);
                    if (result1 == MessageBoxResult.Yes)
                    {
                        if (nhanvienhien == Visibility.Visible)
                            try
                            {
                                
                                PrintDialog printDialog = new PrintDialog();
                                if (printDialog.ShowDialog() == true)
                                {
                                    printDialog.PrintVisual(p, "Hóa đơn");
                                }
                            }
                            catch
                            {

                            }
                    }
                    if (isdangnhap)
                    {
                        MessageBoxResult result = MessageBox.Show("Bạn có muốn thanh toán?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Information);
                        if (result == MessageBoxResult.Yes)
                            while (true)
                                try
                                {

                                    HoaDon hoaDon = new HoaDon() { CTHDs = new ObservableCollection<CTHD>(ListCTHD_BanSach), KhachHang = SelectedKhachHang, NguoiDung = User, TongTien = TongGiaBan, NgayBan = SelectedDateTime };
                                    hoaDon.SoTienTra = int.Parse(SoTienTra);
                                    int discount = int.Parse(DisCount);
                                    foreach (CTHD hd in ListCTHD_BanSach)
                                    {
                                        if (hd.PhuongThuc == "Mượn")
                                            hd.TrangThai = "Chưa trả";
                                    }
                                    hoaDon.SoSachMuon = TongSachMuon;
                                    DataProvider.Ins.DB.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[HoaDon] ON");
                                    DataProvider.Ins.DB.HoaDons.Add(hoaDon);
                                    DataProvider.Ins.DB.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[HoaDon] OFF");
                                    SelectedKhachHang.SoTienNo += TongGiaBan - int.Parse(SoTienTra);
                                    SelectedKhachHang.SoSachChuaTra += TongSachMuon;
                                    // SelectedKhachHang.SoSachChuaTra +=  - int.Parse(SoTienTra);
                                    for (int i = 0; i < ListCTHD_BanSach.Count; i++)
                                        ListCTHD_BanSach[i].Sach.SoLuongTon -= ListCTHD_BanSach[i].SoLuong;
                                    DataProvider.Ins.DB.SaveChanges();
                                    SoTienTra = 0 + "";
                                    SelectedKhachHang = new KhachHang();
                                    ListCTHD_BanSach.Clear();
                                    SelectedDateTime = new DateTime();
                                    QuanLyDuLieuSachVM.TimKiemSach();
                                    QuanLyKhachHangVM.TimKiemKhachHang();
                                    SelectedHoaDon = hoaDon;
                                    CapNhatHoaDonVaTimKiem();

                                    XulyHienThemHoaDon(-1);
                                    return;
                                }
                                catch { }
                    }
                });

            TaoMoiHoaDonCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                XulyHienThemHoaDon(2);
            });

            #endregion Hóa đơn

        }

        #region Kiểm tra số

        private bool KiemTraSo(string str)
        {
            try
            {
                int.Parse(str);
                return true;
            }
            catch { return false; }
        }

        #endregion Kiểm tra số

        #region Cập nhật dữ liệu

        private void CapNhatHoaDonVaTimKiem()
        {
            var date = DateTimeEnd.AddDays(1);
            if (TextTimKiemHoaDon == "")
                ListHoaDon = new ObservableCollection<HoaDon>(DataProvider.Ins.DB.HoaDons.Where(x => x.NgayBan >= DateTimeStart && x.NgayBan <= date));
            else
                ListHoaDon = new ObservableCollection<HoaDon>(DataProvider.Ins.DB.HoaDons.Where(x => x.NgayBan >= DateTimeStart && x.NgayBan <= date && x.KhachHang.TenKH.ToLower().Contains(TextTimKiemHoaDon.ToLower())));

        }

        #endregion Cập nhật dữ liệu
    }
}