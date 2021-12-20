using BookStoreClone.Model;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace BookStoreClone.ViewModel
{
    public class QuanLyKhachHangViewModel : BaseViewModel
    {
        private ObservableCollection<KhachHang> _listKH;
        private KhachHang _selectedKhachHang;
        private int _tongHoaDon;

        #region Cập nhật

        private string _suaTen;
        private string _suaEmail;
        private string _suaSDT;
        private string _suaDiaChi;
        private bool _IconSuaKhachHang;
        public string TextSuaTen { get => _suaTen; set { _suaTen = value; OnPropertyChanged(); } }
        public string TextSuaEmail { get => _suaEmail; set { _suaEmail = value; OnPropertyChanged(); } }
        public string TextSuaSDT { get => _suaSDT; set { _suaSDT = value; OnPropertyChanged(); } }
        public string TextSuaDiaChi { get => _suaDiaChi; set { _suaDiaChi = value; OnPropertyChanged(); } }
        public ICommand LuuCapNhatCommand { get; set; }
        public ICommand CapNhatCommand { get; set; }
        public bool IconSuaKhachHang { get => _IconSuaKhachHang; set { _IconSuaKhachHang = value; OnPropertyChanged(); } }

        #endregion Cập nhật

        #region Thêm khách hàng

        private string _TextTimKiem;
        private string _textThemTen;
        private string _textThemDiaChi;
        private string _textThemSDT;
        private string _textThemEmail;
		private bool isdangnhap;

		public string TextThemTen { get => _textThemTen; set { _textThemTen = value; OnPropertyChanged(); } }
        public string TextThemDiaChi { get => _textThemDiaChi; set { _textThemDiaChi = value; OnPropertyChanged(); } }
        public string TextTimKiem { get => _TextTimKiem; set { _TextTimKiem = value; OnPropertyChanged(); TimKiemKhachHang(); } }
        public string TextThemSDT { get => _textThemSDT; set { _textThemSDT = value; OnPropertyChanged(); } }
        public string TextThemEmail { get => _textThemEmail; set { _textThemEmail = value; OnPropertyChanged(); } }
        public ICommand ThemMoiCommand { set; get; }
        public ICommand LuuThemMoiCommand { set; get; }

        #endregion Thêm khách hàng

        public ObservableCollection<KhachHang> ListKH { get => _listKH; set { _listKH = value; OnPropertyChanged(); } }

        public KhachHang SelectedKhachHang
        {
            get => _selectedKhachHang;

            set
            {
                _selectedKhachHang = value;
                if (SelectedKhachHang == null) return;
                TongHoaDon = (int)SelectedKhachHang.HoaDons.Sum(x => x.TongTien);
                TextSuaTen = SelectedKhachHang.TenKH;
                TextSuaSDT = SelectedKhachHang.SDT;
                TextSuaEmail = SelectedKhachHang.Email;
                TextSuaDiaChi = SelectedKhachHang.DiaChi;
                OnPropertyChanged();
            }
        }

        public int TongHoaDon { get => _tongHoaDon; set { _tongHoaDon = value; OnPropertyChanged(); } }

		public NguoiDung User { get; private set; }
        public QuanLyKhachHangViewModel(int a) { }
		public QuanLyKhachHangViewModel()
        {
            TimKiemKhachHang();
            try { User = DataProvider.Ins.DB.NguoiDungs.Where(x => x.TenDangNhap == Const.IDNguoiDung).First(); isdangnhap = true; } catch { isdangnhap = false; }
            SelectedKhachHang = ListKH.Count > 0 ? ListKH[0] : new KhachHang();
            IconSuaKhachHang = false;

            CapNhatCommand = new RelayCommand<DockPanel>((p) => { return p == null ? false : true; }, (p) =>
            {
                TextSuaTen = SelectedKhachHang.TenKH;
                TextSuaSDT = SelectedKhachHang.SDT;
                TextSuaEmail = SelectedKhachHang.Email;
                TextSuaDiaChi = SelectedKhachHang.DiaChi;

                IconSuaKhachHang = true;
                for (int i = 1; i < 5; i++)
                {
                    StackPanel stackPanel = p.Children[i] as StackPanel;
                    stackPanel.Children[1].Visibility = Visibility.Collapsed;
                    stackPanel.Children[2].Visibility = Visibility.Visible;
                }
                (p.Children[5] as Canvas).Visibility = Visibility.Visible;
            });
            LuuCapNhatCommand = new RelayCommand<DockPanel>((p) => { return p == null ? false : true; }, (p) =>
            {
                if (ValidateSuaKhachHang())
                {
                    SelectedKhachHang.TenKH = TextSuaTen;
                    SelectedKhachHang.SDT = TextSuaSDT;
                    SelectedKhachHang.Email = TextSuaEmail;
                    SelectedKhachHang.DiaChi = TextSuaDiaChi;
                    DataProvider.Ins.DB.SaveChanges();

                    TimKiemKhachHang();
                    for (int i = 1; i < 5; i++)
                    {
                        StackPanel stackPanel = p.Children[i] as StackPanel;
                        stackPanel.Children[2].Visibility = Visibility.Collapsed;

                        stackPanel.Children[1].Visibility = Visibility.Visible;
                        //(stackPanel.Children[1] as TextBlock).Text = (stackPanel.Children[2] as TextBox).Text;
                    }
                    IconSuaKhachHang = false;
                    (p.Children[5] as Canvas).Visibility = Visibility.Collapsed;
                    MessageBox.Show("Cập nhập thông tin khách hàng thành công.");
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập lại thông tin.");
                }
                
            });

            ThemMoiCommand = new RelayCommand<PopupBox>((p) => { return p == null ? false : true; }, (p) =>
            {
                p.IsPopupOpen = true;
            });
            LuuThemMoiCommand = new RelayCommand<PopupBox>((p) => { return true; }, (p) =>
            {
                if(ValidateThemKhachHang())
                {
                    DataProvider.Ins.DB.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[KhachHang] ON");
                    DataProvider.Ins.DB.KhachHangs.Add(new KhachHang() { TenKH = TextThemTen, DiaChi = TextThemDiaChi, Email = TextThemEmail, SDT = TextThemSDT, SoSachChuaTra = 0 });
                    DataProvider.Ins.DB.Database.ExecuteSqlCommand("SET IDENTITY_INSERT [dbo].[KhachHang] OFF");
                    DataProvider.Ins.DB.SaveChanges();
                    TimKiemKhachHang();
                    p.IsPopupOpen = false;
                    MessageBox.Show("Thêm khách hàng thành công.");
                }
                else
                {
                    if (TextThemTen == null || TextThemSDT == null)
                    {
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                        return;
                    }
                    if( TextThemEmail !=null)
                    {
                        if (!CheckEmailValid(TextThemEmail))
                        {
                            MessageBox.Show("Vui lòng nhập lại email!");
                            return;
                        }
                    }
                    if(TextThemSDT != null)
                    {
                        if (!CheckPhoneNumberValid(TextThemSDT))
                        {
                            MessageBox.Show("Vui lòng nhập lại số điện thoại!");
                        }
                    }
                }               
            });
        }

        public void TimKiemKhachHang()
        {
            if (TextTimKiem == null)
                ListKH = new ObservableCollection<KhachHang>(DataProvider.Ins.DB.KhachHangs);
            else
                ListKH = new ObservableCollection<KhachHang>(DataProvider.Ins.DB.KhachHangs.Where(x => x.TenKH.ToLower().Contains(TextTimKiem.ToLower()) || x.SDT.Contains(TextTimKiem)));
            for (int i = 0; i < ListKH.Count; i++)
            {
                ListKH[i].TongSoTien = (int)ListKH[i].HoaDons.Sum(x => x.TongTien);
                ListKH[i].IsEnable_BanSach = ListKH[i].SoTienNo >= Const.QuyDinh_TienNoToiDa ? false : true;
            }
        }

        public bool CheckEmailValid(string a)
        {
            if(a == null ||a.Length == 0)
            {
                return false;
            }
            string emailformat = "@gmail.com";
            if (a.Contains(emailformat) && a.Length>emailformat.Length && !a.Contains(" ") && !a.Contains("!") &&
                !a.Contains("#") && !a.Contains("%") && !a.Contains("^") && !a.Contains("*") && !a.Contains("(") &&
                !a.Contains(")") && !a.Contains("+") && !a.Contains("=") && !a.Contains(";") && !a.Contains(",") && !a.Contains("/"))
            {
                return true;
            }
            return false;
        }
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }
        public bool CheckPhoneNumberValid(string a)
        {
            if (IsNumber(a) && a.Length == 10)
            {
                return true;
            }
            return false;
        }
        public bool ValidateThemKhachHang()
        {
            if (TextThemTen == null) return false;
            if (TextThemTen == "") return false;
            if (TextThemSDT == null || TextThemSDT.Length == 0)
            {
                return false;
            }
            if (TextThemSDT.Length > 0 && !CheckPhoneNumberValid(TextThemSDT))
            {
                return false;
            }
            if(TextThemEmail == null || TextThemEmail == "")
            {
                return true;
            }
            if(TextThemEmail != null || TextThemEmail != "")
            {
                if (!CheckEmailValid(TextThemEmail))
                {
                    return false;
                }
            }
            return true;
        }
        public bool ValidateSuaKhachHang()
        {
            if (TextSuaTen == null) return false;
            if (TextSuaTen == "") return false;
            if (TextSuaSDT.Length > 0 && !CheckPhoneNumberValid(TextSuaSDT))
            {
                return false;
            }
            if(TextSuaSDT.Length == 0 || TextSuaSDT == null)
            {
                return false;
            }
            if (TextSuaEmail != null)
            {
                if (TextSuaEmail.Length > 0 &&!CheckEmailValid(TextSuaEmail))
                {
                    return false;
                }
            }
            return true;
        }
    }
}