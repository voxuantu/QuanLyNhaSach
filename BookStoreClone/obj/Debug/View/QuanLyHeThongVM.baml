   M S B A M L   `   `   `  ����I  EBookStoreClone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:BookStoreClone.ViewBookStoreClone.View  5      )    #BookStoreClone.View.QuanLyHeThongVM   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      3local!clr-namespace:BookStoreClone.View     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	         QuanLyHeThongVM  � DataContext#  [  5
      .��5      ]� .+�5   
   � $��5q�6    � Orientation$ Vertical=�6   $��Right=�66   .+�5      �� $��30��5      $��30��5      $��
5,100,5,10q�5      3  -MaterialDesignThemes.Wpf.ButtonProgressAssist   IsIndicatorVisible .    Value$ -1Q�5       & "MaterialDesignFloatingActionButton#��[ 5       � ToolTip$ Sửa đổi quy định��5       ^� 	Placement$ Right=�5         IsIndeterminate 5      �� *	IsVisible+ �� ElementName$ pnlThayDoiQuyDinh����5      �� *ShowSuaDoiQuyDinhCommand+��5      0  *MaterialDesignThemes.Wpf.PackIconExtension     Kind$ Alert=�5      �� 5      $��30��5      $��30��5      $��	5,10,5,10q�5       . $ -1Q�5       #��[ 5$      $ Thêm nhân viên��5%      $ Right=�5&       5      �� *	IsVisible+$ pnlThemNhanVien����5!      �� *ShowThemNhanVienCommand+��5"      �� $ dataNhanVien����5#        $ 	PeopleAdd=�5&      5'      #  MaterialDesignThemes.Wpf.Card  5)   
   -   5        	  Name$	 pnlThayDoiQuyDinh��5+      $��5q�5)      $��Right=�5*      $	��426��65   y�5,      �� *VisibilityThayDoiQuyDinh+.��5.      ]� .+�5/      �� $��	24,20,0,0q�50      $	��Top=�51      $��Center=�52      $��Center=�53      $��24(�54      $��Thay đổi quy định��55      �� 56      $��
20,110,5,5q�57      $	��Top=�58      
 �� Orientation$
 
Horizontal=�59      .+�5:      �� $��15(�6    $��5q�6.   $8��2Số Lượng tồn được phép nhập tiếp: ��69   �� 5;      $��15(�6   
���   �$	��100��6�   ��6B   �� *SoLuongSachTonToiThieuDeNhap+ �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5<      $��15(�6    $��5q�6.   $��quyển��69   6H   5=      �� 5>      $��20,5,5,5q�5?      $	��Top=�5@      $
 
Horizontal=�5A      .+�5B      �� $��15(�6    $��5q�6.   $*��$Số lượng nhập tối thiểu: ��69   �� 5C      $��15(�6   
���   �$	��100��6�   ��6A   �� *SoLuongSachNhapToiThieu+$ PropertyChanged=�6�   �� 5D      $��15(�6    $��5q�6.   $��quyển��69   6H   5E      �� 5F      $��20,5,5,5q�5G      $	��Top=�5H      $
 
Horizontal=�5I      .+�5J      �� $��15(�6    $��5q�6.   $6��0Tiền nợ tối đa của mỗi khách hàng: ��69   �� 5K      $��15(�6   
���   �$	��100��6�   ��6@   �� *TienNoToiDa+ �� Mode$ TwoWay=�$ PropertyChanged=�6�   �� 5L      $��15(�6    $��5q�6.   $
��VNĐ��69   6F   5M      �� 5N      $��20,5,5,5q�5O      $	��Top=�5P      $
 
Horizontal=�5Q      .+�5R      �� $��15(�6    $��5q�6.   $6��0Số lượng tồn tối thiểu sau khi bán: ��69   �� 5S      $	��320��5T      $	��100��5U      $��15(�5V      
���   � �� TextWrapping$
 Wrap=�5Y      ��5X      �� *!SoLuongSachTonToiThieuSauKhiBan+$ PropertyChanged=�5Y      �� 5Z      $��15(�6    $��5q�6.   $��quyển��69   6H   5[      �� 5\      $��20,5,5,5q�5]      $	��Top=�5^      $
 
Horizontal=�5_      .+�5`      �� $��15(�6    $��5q�6.   $$��Lợi nhuận khi bán sách: ��69   �� 5a      $	��320��5b      $	��100��5c      $��15(�5d      
���   �$
 Wrap=�5g      ��5f      �� *
HeSoDonGia+$ PropertyChanged=�5g      �� 5h      $��15(�6    $��5q�6.   $��%��69   6D   5i      �� 5j      $��20,5,5,5q�5k      $	��Top=�5l      $
 
Horizontal=�5m      .+�5n      �� $��15(�6    $��5q�6.   $+��%Lợi nhuận khi cho mượn sách: ��69   �� 5o      $	��320��5p      $	��100��5q      $��15(�5r      
���   �$
 Wrap=�5u      ��5t      �� *HeSoDonGiamuon+$ PropertyChanged=�5u      �� 5v      $��15(�6    $��5q�6.   $��%��69   6D   5w      �� 5x      $��20,5,5,5q�6   $	��Top=�5y      $
 
Horizontal=�5z      .+�5|      �� $��15(�6    $��5q�6.   $;��5Cho phép thu vượt số tiền nợ của khách: ��69   	� 5}      $��Center=�6"   $	��Top=�6?   $��15(�5~   "   $	��Có��60    d� 	IsChecked 6=   �� *	CheckCo+$ TwoWay=�$ PropertyChanged=�6�   	� 5      $��Center=�6"   $	��Top=�6?   $��10,0,0,0q�6W   $��15(�5�   "   $��Không��60    6@   �� *
CheckKhong+$ TwoWay=�$ PropertyChanged=�6�   5�      �� 5�      -   5         ��Name$ btnLuuHoaDon��5�      $ -1Q�5�      $	��Top=�5�      $
��40,0q�5�        MaterialDesignRaisedButton#��[ 5�       .  . $ Cập nhật quy định��5�      ��5�      �� *CapNhatQuyDinhCommand+.��5�   1   Cập nhật5�      5�      5�        5�   
   -   5        $	 pnlThemNhanVien��5�      $��5q�5�      $��Right=�5�      $	��426��65   y�5�   7   �� *VisbilityThemNhanVien+.��5�      ]� 
 � Tag 6   �� *SelectedNhanVien+$ PropertyChanged=�.+�5�      �� $
 
Horizontal=�6   $��	24,20,0,0q�66   $	��Top=�5�      $��Center=�5�      $��Center=�5�      .+�5�      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ AccountMultiplePlus=�6.   $��34��6J   $��34��5�   .   $��	10,6,10,0q�5�   .   �� 5�      $��24(�5�      $��	10,6,10,0q�5�   9   ��6   �� *Labelnhanvien+69   5�      �� 5�      $��	20,20,5,5q�5�      $	��Top=�5�      $
 
Horizontal=�5�      .+�5�        $��24��5�      $��24��5�      $��	10,6,10,0q�5�      $ People=�5�      �� 5�      $��15(�6   
���   �$	��250��6A   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tên Nhân Viên��5�      ��5�   M   �� *SelectedNhanVien.TenND+$ PropertyChanged=�5�      5�      �� 5�      $��	20,10,5,5q�5�      $	��Top=�5�      $
 
Horizontal=�5�      .+�5�        $��24��5�      $��24��5�      $��	10,6,10,0q�5�      $ Phone=�5�      �� 5�      $��15(�6   
���   �$	��100��6�   $ Số Điện Thoại��6�   ��6A   �� *SelectedNhanVien.SDT+$ PropertyChanged=�6�     5�      $ GenderMaleFemale=�6.   $��30��6G   $��30��5�   .   $��	30,6,10,0q�5�   .   	� 5�      $��Center=�6"   $	��Top=�6?   $��10,5,0,0q�6W   $��15(�5�   "   $	��Nam��60    �� 
IsSelected .  6>   �� *Nam+$ TwoWay=�6�   	� 5�      $��Center=�6"   $	��Top=�6?   $��10,5,0,0q�6W   $��15(�5�   "   $
��Nữ��60    6=   �� *Nu+$ TwoWay=�6d   5�      �� 5�      $��	20,10,5,5q�5�      $	��Top=�5�      $
 
Horizontal=�5�      .+�5�        $��24��5�      $��24��5�      $��	10,6,10,0q�5�      $ AddressMarker=�5�      �� 5�      $��15(�6   
���   �$	��250��6u   $��50��6�   $
 Wrap=�6�   $	��250��6�   $ Địa Chỉ��6�   ��6@   �� *SelectedNhanVien.DiaChi+$ TwoWay=�6�   5�      �� 5�      $��	20,10,5,5q�5�      $	��Top=�5�      $
 
Horizontal=�5�      .+�5�        $ CalendarMonthOutline=�6.   $��24��6K   $��24��5�   .   $��	10,6,10,0q�5�   .   (  "System.Windows.Controls.DatePicker  5�      $	��320��5�      $	��100��5�      $��14(�5�      $��30��5�      
���   �$ 
Ngày Sinh��5�      $	��250��5�         Text 5�      �� *SelectedNhanVien.NgaySinh+$ PropertyChanged=�5�      5�      �� 5�      $��	20,10,5,5q�5�      $	��Top=�5�      $
 
Horizontal=�5�      .+�5�        $ AccountHardHat=�6.   $��24��5�   .   $��24��6;   $��	10,6,10,0q�5�   .   	� 5�      $��Center=�6"   $	��Top=�6?   $��10,5,0,0q�6W   $��15(�5�   "   $��Admin��60    .  6@   �� *Admin+$ TwoWay=�6�   	� 5�      $��Center=�6"   $	��Top=�6?   $��10,5,0,0q�6W   $��15(�5�   "   $��Quản Lý Kho��60    6F   �� *	QuanLyKho+$ TwoWay=�6t   	� 5�      $��Center=�6"   $	��Top=�6?   $��10,5,0,0q�6W   $��15(�5�   "   $��Nhân Viên bán��60    6H   �� *CNV+$ TwoWay=�6p   5�      �� 5�      $��	90,50,5,5q�5�      $	��Top=�5�      $
 
Horizontal=�5�      .+�5�        $ AccountEditOutline=�6.   $��28��6I   $��28��6V   $��	10,6,10,0q�5�   .   �� 5�      $��15(�6   
���   �$	��200��6C   $ Tên Đăng Nhập��6�   ��6O   �� *SelectedNhanVien.TenDangNhap+$ TwoWay=�6�   5�      �� 5      $��	90,10,5,5q�5     $	��Top=�5     $
 
Horizontal=�5     .+�5       $ LockQuestion=�6.   $��24��6D   $��24��6Q   $��	10,6,10,0q�5  .   �� 5     $��15(�6   
���   �$	��200��6�   $ Mật Khẩu��6�   ��6B   �� *
Password+$ PropertyChanged=�6�   5     �� 5	      �� Left$ 42��5
  !   
 �� Top$ 10��5  !   
������ $	��Top=�5  !     btnLoginStyle#��[ 5  !   $	��213��6H   $��40,0,39.6,0q�6U   ��5  !   �� *ChonAnhCommmand+��5  !   �� $ imgage��.��5     �� -   5         ��Name$ imgage��5     ��6,   �� *
LinkAnhBia+$ PropertyChanged=�5     �� 5     $��Bottom=�5     #��[ 5     $ -1Q�5     $ 
Ngày Sinh��5      .  . $��Cập Nhật��5     $
��40,0q�5     $" Cập Thông tin nhân viên��5     ��5     �� *LuuNguoiDungCommand+��5     �� $ dataNhanVien��5     5     5      ]� 5"  
   ��. $y�Visible=�5#  "   .+�5$     �� $	��Top=�6   $
 
Horizontal=�6.   .+�5&     (  "MaterialDesignThemes.Wpf.ColorZone  $	��250��5'     $��
250,30,0,0q�5(      K� ZIndex$ 1��5)     +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�5*        CornerRadius$ 2��5+     $	��Top=�5,        Mode$ Standard=�5-     .��5.     �  � ColumnDefinitions 5/     �� 50     $
��Auto �6/   �� 51     $��* �6/   �� 52     $
��Auto �6/   .+�54     ��   MaterialDesignToolButton#���  57     ��55     �� *TimKiemCommand+��56     �� $ pnlHienThiSach��.��58       $ 
UserSearch=�66    J� Opacity$	 .56Q�6H   59     �� 5:     $��1��5;     $	��200��5<     $��8,0,0,0q�5=     $��Center=�5>     $ Tìm kiếm nhân viên��5?     .	  (MaterialDesignThemes.Wpf.TextFieldAssist 	  DecorationVisibility$ Hidden=�5@     $��0q�5A     ��5B     �� *TextTimKiemNhanVien+$ PropertyChanged=�5C     5D     5F     �� 5G     $��5q�6   $��	10,0,10,0q�6&   .��5H     &
   System.Windows.Controls.DataGrid
  -   5         
 Name$ dataNhanVien��5J     $	��Top=�5K       
  AutoGenerateColumns  .  
������ ! 
  CanUserAddRows! .  " 
  CanUserSortColumns" . # 
  HeadersVisibility$	# All=�5P     $ 
  
IsReadOnly$ . % �� SelectedIndex$% 0��5R     & 
  SelectionMode$& Single=�5T     ��5S     �� *ListNV+' 
  Columns' 5V     0  *System.Windows.Controls.DataGridTextColumn  5W     ,  &System.Windows.Controls.DataGridColumn(   Header$( Mã nhân viên��5Y     )   
IsReadOnly) .  1  +System.Windows.Controls.DataGridBoundColumn*   Binding* 5X     �� *MaND+5Z       5[     $( Tên nhân viên��5]     ) .  * 5\     �� *TenND+5^       5_     $( Số điện thoại��5a     ) .  * 5`     �� *SDT+5b     4  .System.Windows.Controls.DataGridCheckBoxColumn  5c     $( Admin��61   * 6@   �� *Admin+  5d     $( Quản Lí Kho��61   * 6F   �� *NhanVienKho+  5e     $( 
Kinh doanh��61   * 6E   �� *NhanVienBan+4  .System.Windows.Controls.DataGridTemplateColumn  5f     +   CellTemplate+ 5g     �� 5h  "   .R�5j  &   �� $��25��5k  )   $��25��5l  )   $��5,0,5,0q�5m  )   #  [  5p  )    * &MaterialDesignFloatingActionMiniButton#��[ 5q  )   $* $Chỉnh sửa thông tin nhân viên��5r  )   ��5n  )   �� *LoadChiTietNhanVienCommand+��5o  )   �� $ dataNhanVien��.��5t  *     $��20��5u  -   $��20��5v  -   $
 Edit=�5w  -   5x  '   5z  #   5|       5}     + 5~     �� 5  "   .R�5�  &   �� $��25��5�  )   $��25��5�  )   $��5,0,5,0q�5�  )   #  [  5�  )   #��[ 5�  )   $ Xóa nhân viên��5�  )   ��5�  )   �� *XoaNhanVienCommand+��5�  )   �� $ dataNhanVien��.��5�  *     $��20��5�  -   $��20��5�  -   $ DeleteForever=�5�  -   5�  '   5�  #   5�     5�     5�     5�     5�     5�     