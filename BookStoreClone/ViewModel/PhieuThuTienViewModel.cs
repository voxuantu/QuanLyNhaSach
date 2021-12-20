using BookStoreClone.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BookStoreClone.ViewModel
{
    class PhieuThuTienViewModel : BaseViewModel
    {
        DateTime _SelectedDateTime;
        private CTHD _SelectedCTHD;
        private Visibility _visibilityXemHoaDon;
        private HoaDon _SelectedHoaDon;
        private KhachHang _SelectedKhachHang;
        QuanLyKhachHangViewModel quanLyKhachHangViewModel;
        Visibility visibilityPnlThuTien;
        public Visibility VisibilityXemHoaDon { get => _visibilityXemHoaDon; set { _visibilityXemHoaDon = value; OnPropertyChanged();
               
            }
        }
        string soTienTra;
        public ICommand XacNhanThuTienCommand { get; set; }
        public HoaDon SelectedHoaDon
        { get => _SelectedHoaDon; set
            { _SelectedHoaDon = value; OnPropertyChanged();
                if (SelectedHoaDon == null)
                {
                    VisibilityXemHoaDon = Visibility.Collapsed;
                    return;
                }
                else VisibilityXemHoaDon = Visibility.Visible;
                foreach (CTHD hd in SelectedHoaDon.CTHDs)
                {
                    if (hd.PhuongThuc == null)
                    {
                        hd.PhuongThuc = "Mua";
                        hd.isenabletra = false;
                        DataProvider.Ins.DB.SaveChanges();
                    }
                    if (hd.PhuongThuc == "Mua")
                    {
                        hd.PhuongThuc = "Mua";
                        hd.isenabletra = false;
                        DataProvider.Ins.DB.SaveChanges();
                    }
                    if (hd.PhuongThuc == "Mượn")
                    {
                        hd.isenabletra = true;
                        if (hd.TrangThai == null)
                        {
                            hd.TrangThai = "Đã trả";
                            hd.isenabletra = false;
                            DataProvider.Ins.DB.SaveChanges();
                        }
                        DataProvider.Ins.DB.SaveChanges();
                    }
                    
                }
				return;

            }
        }

        public ICommand GetViewModelQuanLyKhachHang { get; set; }
        public ICommand Trasach { get; set; }
        public Visibility VisibilityPnlThuTien { get => visibilityPnlThuTien; set { visibilityPnlThuTien = value; OnPropertyChanged(); } }
        public string SoTienTra { get => soTienTra; set { soTienTra = value; OnPropertyChanged(); } }
        public KhachHang SelectedKhachHang
        {
            get => _SelectedKhachHang; set
            {
                _SelectedKhachHang = value; OnPropertyChanged();
                if (SelectedKhachHang == null)
                    return;
                if (SelectedKhachHang.SoTienNo > 0)
                    VisibilityPnlThuTien = Visibility.Visible;
                else VisibilityPnlThuTien = Visibility.Collapsed;
                SelectedKhachHang.SoTienPhat = 0;
                foreach (HoaDon hd in SelectedKhachHang.HoaDons)
                    foreach (CTHD cthd in hd.CTHDs)
                    {
                        TimeSpan Time = ((TimeSpan)(SelectedDateTime - hd.NgayBan));
                        int TongSoNgay = Time.Days;
                        if (cthd.TrangThai == "Chưa trả")
                            if (TongSoNgay > 30)
                                SelectedKhachHang.SoTienPhat += (int)cthd.ThanhTien * TongSoNgay / 30;
                    }
            }
        }
        public CTHD SelectedCTHD
        {
            get => _SelectedCTHD;
            set
            {
                _SelectedCTHD = value;
                OnPropertyChanged();
				if (SelectedCTHD == null)
					return;
			}
        }

        public DateTime SelectedDateTime { get => _SelectedDateTime; set { _SelectedDateTime = value; OnPropertyChanged(); } }

        public PhieuThuTienViewModel()
        {
            SelectedDateTime = System.DateTime.Now;
            VisibilityXemHoaDon = Visibility.Collapsed;
            Trasach = new RelayCommand<Button>((p) =>
            {
                //if (p == null)
                //    return false;
                //p.IsEnabled = false;
                //foreach (CTHD a in SelectedHoaDon.CTHDs)
                //    if (a.TrangThai == "Mượn")
                //        if (a.TrangThai == "Chưa trả")
                //            p.IsEnabled = true;
                return true;

            }, (p) =>
            {
                MessageBoxResult result = MessageBox.Show("Bạn có muốn trả sách?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Information);
                if (result == MessageBoxResult.Yes)
                    try
                    {
                        if (SelectedCTHD.PhuongThuc == "Mượn")
                            if (SelectedCTHD.TrangThai == "Chưa trả")
                            {
                                SelectedCTHD.TrangThai = "Đã trả";
                                SelectedCTHD.isenabletra = false;
                                SelectedKhachHang.SoSachChuaTra -= (int)SelectedCTHD.SoLuong;
                                SelectedCTHD.Sach.SoLuongTon += SelectedCTHD.SoLuong;
                                SelectedHoaDon.SoSachMuon-= SelectedCTHD.SoLuong;
                                SelectedKhachHang.SoTienNo += (int)SelectedKhachHang.SoTienPhat;
                                SelectedKhachHang.SoTienPhat = 0;
                                DataProvider.Ins.DB.SaveChanges();
                            }
                        SelectedCTHD.isenabletra = false;
						//SelectedCTHD = = new ObservableCollection<CTHD>(SelectedCTHD);
                        DataProvider.Ins.DB.SaveChanges();
                    }
                    catch { }
            });
            XacNhanThuTienCommand = new RelayCommand<Button>((p) => {
                if (p == null) return false;
                p.IsEnabled = false;

                if (SelectedKhachHang == null) return false;

                if (KiemTraSo(SoTienTra) == false) return false;

                if (int.Parse(soTienTra) > SelectedKhachHang.SoTienNo || int.Parse(soTienTra) <= 0) return false;

                p.IsEnabled = true;
                return true;
            }, (p) =>
            {
                MessageBoxResult result = MessageBox.Show("Xác nhận thu tiền?", "Thông báo", MessageBoxButton.YesNo, MessageBoxImage.Information);
                if (result == MessageBoxResult.Yes)
                {
                    DataProvider.Ins.DB.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[PhieuThuTien] ON");
                    DataProvider.Ins.DB.PhieuThuTiens.Add(new PhieuThuTien() { KhachHang = SelectedKhachHang, SoTienThu = int.Parse(soTienTra), NguoiDung = DataProvider.Ins.DB.NguoiDungs.Where(x => x.TenDangNhap == Const.IDNguoiDung).First(), NgayThuTien = SelectedDateTime });
                    DataProvider.Ins.DB.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[PhieuThuTien] OFF");
                    SelectedKhachHang.SoTienNo -= int.Parse(soTienTra);
                    DataProvider.Ins.DB.SaveChanges();
                    int idKhach = SelectedKhachHang.MaKH;
                    SelectedKhachHang = new KhachHang();
                    SelectedKhachHang = DataProvider.Ins.DB.KhachHangs.Where(x => x.MaKH == idKhach).First();
                    SoTienTra = "";
                    quanLyKhachHangViewModel.TimKiemKhachHang();
                    SelectedDateTime = System.DateTime.Now;
                }
            });
          

            GetViewModelQuanLyKhachHang = new RelayCommand<DockPanel>((p) => {

                return true;
            }, (p) =>
            {
                quanLyKhachHangViewModel = p.DataContext as QuanLyKhachHangViewModel;
            });
         
        }
       
        private bool KiemTraSo(string str)
        {
            try
            {
                int.Parse(str);
                return true;
            }
            catch { return false; }
        }
    }
}
