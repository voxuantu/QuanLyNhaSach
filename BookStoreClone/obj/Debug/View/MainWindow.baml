   M S B A M L   `   `   `  ����I  EBookStoreClone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:BookStoreCloneBookStoreClone  5      9!clr-namespace:BookStoreClone.ViewBookStoreClone.View  5
          BookStoreClone.MainWindow   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      (localclr-namespace:BookStoreClone  5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5	      ,view!clr-namespace:BookStoreClone.View  5
      -   5        $��
mainWindow��5        � WindowStartupLocation$  CenterScreen=�5       
  MainVM � DataContext# [  5       J� Opacity$ 90Q�5       � WindowStyle$
 None=�5       � WindowState$ 	Maximized=�5       � Title$ Thư Viện��6.   $	��900��6?   $	��200��6N   .  (System.Windows.Interactivity.Interaction   Triggers 5      /  )System.Windows.Interactivity.EventTrigger  5   
      	EventName$ Loaded��6   .  (System.Windows.Interactivity.TriggerBase   Actions. 5      6  0System.Windows.Interactivity.InvokeCommandAction  	   Command	 6$   �� *LoadedWindowCommand+
   CommandParameter
 6L   ��  �� ElementName$ 
mainWindow��5      .��5      ]� 
������ .+�5   
   #  MaterialDesignThemes.Wpf.Card  $��5,0,5,5q�6   $
��Left=�6/   .��5      9� 
������  9� ExpandDirection$ Right=�60   ��5      '  !MaterialDesignThemes.Wpf.PackIcon  5         Kind$
 Menu=�6.   .��5      � $	��255��6   $
��Left=�6#   .+�5       �� -   5         ��Name$ tabTinhNang��5!      $	��Top=�5"      *  $MaterialDesignThemes.Wpf.ThemeAssist   Theme$ Light=�5#      .+�5$      �� .+�5&      � $��70��6#   �� 5)      $��70��6)   .+�5*   "   �� $��15q�6-   .+�5+   &   �� -   5         ��Name$ 	txbSearch��5,   )   $
��auto��5-   )   $��Center=�5.   )   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tìm kiếm��5/   )    �� AcceptsReturn .  * &MaterialDesignOutlinedTextFieldTextBox#��[ 51   )    �� TextWrapping$
 Wrap=�53   )   " �� VerticalScrollBarVisibility$
 Auto=�54   )   ��52   )   �� *TextTimKiem+ �� UpdateSourceTrigger$ PropertyChanged=�.��54   L    55   *     56   .   $ TextChanged��6=   . 57   2     	 6H   �� *TextChangedCommand+
 6o   �� $ treeViewTinhNang��58   /   .��59   B   5:   '   5;   #   5<      R� 5>      -   5         R�Name$ treeViewTinhNang��5>   '   .@�5?   "   Q� $��Tìm kiếm sách��6/    Q� 
IsSelected . 6F   Q� 5@   "   $��
Quản Lý��6/   y�6@   �� *	SetQuanLy+.@�5B   &   Q� $��Dữ Liệu Sách��63   Q� 5C   &   $��Khách Hàng��63   5E   #   Q� 5F   "   ��6/   �� *	KinhDoanh+y�6L   �� *SetKinhDoanh+.@�5G   &   Q� $��Nhập Sách��63   y�6F   �� *SetKinhDoanh+Q� 5H   &   $0��*Lập Hóa Đơn Bán Sách/ Mượn Sách��63   Q� 5I   &   $+��%Lập Phiếu Thu Tiền/ Trả Sách��63   y�6Y   �� *SetKinhDoanh+5J   #   Q� 5K   "   $��	Báo Cáo��6/   y�6@   �� *	SetQuanLy+5M   #   Q� 5N   "   $��Quản Lý Hệ Thống��6/   y�6I   �� *
SetAdmin+ 5O   "     5P   &   $ SelectedItemChanged��65   . 5Q   *     	 6@   �� *ChonTinhNangCommand+
 6h   �� $ treeViewTinhNang��5R   '   5T      5U      5V      5W      5X      5Y      ]� 5[   
   $��0,0,5,0q�5\      
�������$	��Top=�5^      $��60��6"   .+�5`      �� $
��Left=�6   $��40,0,0,5q�6.   $��40(�6@   $��UTM Nyala fix v2)�6i   ���	#FF4725BB$��45��6�   $��Bottom=�6�   ��6N   �� *
TitleApp+6�   � 5a      $��50��5b      
������ $��Right=�5d      .+�5f      �� $��2��5g      $��Right=�5h       �� Orientation$ 
Horizontal=�5i      .+�5j      �  � Orientation$ 
Horizontal=�6    .+�5k      '	  !MaterialDesignThemes.Wpf.PopupBox	  -   5         	 Name$ pbChucNangTaiKhoan��5l      $��0��5m      $��0��5n      $��0,20,0,0q�5o       	  PlacementMode$ BottomAndAlignCentres=�5q       	  	StaysOpen .   	  IsPopupOpen 5p      �� *SetChucNang+ �� Mode$ OneTime=� 	  PopupContent. 5s      ]� 
�������.+�5u   "   �� $	��Top=�6)   ��6>   �� *ThongTinTKCommand+y�5v   )   �� *VisibilityThongTinTaiKhoan+��5w   )   �� $ pbThongTinTaiKhoan��.��5x   &   �� $ 
Horizontal=�62   .+�5y   *     $��22��5z   -   $��22��5{   -   $ FaceProfile=�5|   -   $��0,10,0,0q�5}   -   $	��Top=�5~   -   �� 5�   *   $��	10,10,0,0q�65   Thông tin tài khoản6^     5�   *   $��22��5�   -   $��22��5�   -   $ 
ArrowRight=�5�   -   $��	10,10,5,0q�5�   -   $	��Top=�5�   -   5�   '   5�   #   �� 5�   "   $	��Top=�6)   $��0,10,0,0q�6?   ��5�   )   �� *DangXuatCommand+��5�   )   �� $ 
mainWindow��.��5�   &   �� $ 
Horizontal=�62   .+�5�   *     $��22��5�   -   $��22��5�   -   $ ExitRun=�5�   -   $��0,10,0,0q�5�   -   $	��Top=�5�   -   �� 5�   *   $��	10,10,0,0q�65   $��Thoát��5�   5   $
��Top =�6B   5�   +   5�   '   5�   #   5�      5�      �� 5�      $��5q�5�        J� RenderTransformOrigin$  -4.018,0.113&�5�       . *MaterialDesignFloatingActionMiniDarkButton#��[ 5�      ��5�      �� *ChucNangTKCommand+��5�      �� $ pbChucNangTaiKhoan��.��5�      �� -   5        ! ��Name$! imgage��5�   $   $��40��64   $��40��6?   ��6K   �� *LinkAnhBiaava+$ PropertyChanged=�5�      	  5�      -   5        $ pbThongTinTaiKhoan��5�      $��0��5�      $��0��5�      $��	0,20,20,0q�5�      $ BottomAndAlignCentres=�5�       5�      �� *SetpbThongTinTK+$ OneWay=�" �� NotifyOnSourceUpdated" . . 5�      ]� .+�5�   "   � # � RowDefinitions# 5�   &   �� 5�   *   6:   �� 5�   *   6:   �� 5�   *   6:   �� 5�   *   6:   �� 5�   *   $
��Auto �68   6H   �� 5�   *   6:   �� 5�   *   6:   $ � ColumnDefinitions$ 5�   &   �� 5�   *   $	��200 �6;   6I   �� 5�   *   $
��250* �6;   6J   .+�5�   &   �� $��0��6,   $��0��69   $��Center=�6I   $��Center=�6f   $��14(�6�   $��	0,10,0,10q�6�   .��6�   
Họ Tên:6�   �� 5�   &   $��1��6,   $��0��69   $��Center=�6I   $��Center=�6f   $��14(�6�   $��	0,10,0,10q�6�   .��6�   Email:6�   �� 5�   &   $��2��6,   $��0��69   $��Center=�6I   $��Center=�6f   $��14(�6�   $��	0,10,0,10q�6�   .��6�   Số Điện Thoại:6�   �� 5�   &   $��3��6,   $��0��69   $��Center=�6I   $��Center=�6f   $��14(�6�   $��	0,10,0,10q�6�   .��6�   Giới Tính:6�   �� 5�   &   $��4��6,   $��0��69   $��Center=�6I   $��Center=�6f   $��14(�6�   $��	0,10,0,10q�6�   .��6�   Ngày Sinh:6�   �� 5�   &   -   5        $ NameTextBox��5�   .   $��0��5�   .   $��1��6;   $ 	Họ Tên��5�   .   $
��Left=�6V   
���   �$��14(�6�   $	��250��6�   $	��200��6�   $��30��6�   ��6�   �� *
User.TenND+$ TwoWay=�.��6�   5�   '   �� 5�   &   -	   5        $ txtEmail��5�   .   $��1��5�   .   $��1��6;   $ Email��5�   .   
���   �$
��Left=�6i   $��28��6�   $��
5,12,10,10q�6�   $��14(�6�   $	��250��6�   $	��200��6�   �� 5�   &   -
   5        $ txtSDT��5�   .   $��2��5�   .   $��1��6;   $ Số Điện Thoại��5�   .   $
��Left=�6]   
���   �$��28��6�   $��
5,12,10,10q�6�   $��14(�6�   $	��250��6�   $	��200��6�   ��6�   �� *
User.SDT+$ TwoWay=�.��6   5�   '   �� 5�   &   $ 
Horizontal=�61   $��3��6J   $��1��6W   .+�5�   *   	� $��17(�66   $��10,0,0,0q�6D   % d� 	IsChecked% 6V   �� *Nam+$ TwoWay=�.��6}   Nam6�   	� 5�   *   $��17(�66   $��20,0,0,0q�6D   % 6V   �� *Nu+$ TwoWay=�.��6{   Nữ6   5�   '   (
  "System.Windows.Controls.DatePicker
  5�   &   $ 
Ngày Sinh��64    $  MaterialDesignOutlinedDatePicker#��[ 6_   $��4��6�   $��1��6�   $
��Left=�6�   $��
5,12,10,10q�6�   $��12(�6�   $	��250��6�   $	��200��6  $��60��6  & 
  Text& 6  �� *User.NgaySinh+  5�   &   $��5��6:   $��0��6G   $��2��6W   $��30,10,30,10q�6k     MaterialDesignBackground#���  5�   :   .��5�   *   �� .+�5�   .   9� $��Stretch=�5�   1   $��Thay đổi mật khẩu��5�   1   .��5�   2   �� $ Vertical=�5�   5     MaterialDesignBody#���  5�   5   $��
24,8,24,16q�5�   5   .+�5�   6   �� $ 
Horizontal=�6A   .+�5�   :   �� $��14(�6@   .��6N   Mật Khẩu Cũ6[   G� 5�   :   -   5        ' G�Name$' pbMatKhauCu��5�   =   $ Mật Khẩu Cũ��5�   =   $��Center=�6j   $��Center=�6�   
���   �$	��228��6�   $��28��6�   $��
10,0,10,10q�6�   $��14(�6�    5�   >     5�   B   $ PasswordChanged��6Q   . 5�   F     	 6\   �� *PasswordCuChangedCommand+
 6�   �� $ pbMatKhauCu��5�   C   5�   ;   5�   7   �� 5�   6   $ 
Horizontal=�6A   .+�5�   :   �� $��14(�6@   $��0,3,0,0q�6N   .��6_   Mật Khẩu Mới6m   G� 5�   :   -   5        $' pbMatKhauMoi��5�   =   $ Mật Khẩu Mới��5   =   $��Center=�6k   $��Center=�6�   
���   �$	��228��6�   $��28��6�   $��
10,5,10,10q�6�   $��14(�6�    5  >     5  B   $ PasswordChanged��6Q   . 5  F     	 6\   �� *PasswordMoiChangedCommand+
 6�   �� $ pbMatKhauMoi��5  C   5  ;   5  7   �� 5  6   $ 
Horizontal=�6A   .+�5	  :   �� $��14(�6@   $��0,8,0,0q�6N   .��6`   Xác Nhận6j   G� 5
  :   -   5        $' pbXNMatKhauMoi��5  =   $ Mật Khẩu Mới��5  =   $��Center=�6k   $��Center=�6�   
���   �$	��228��6�   $��28��6�   $��
20,5,10,10q�6�   $��14(�6�    5  >     5  B   $ PasswordChanged��6Q   . 5  F     	 6\   �� *XNPasswordChangedCommand+
 6�   �� $ pbXNMatKhauMoi��5  C   5  ;   5  7   5  3   5  /   5  +   5  '   ]� 5  &   $	��124��60   $��0��6<   $��6��6L   $��2��6Y   $��	0,10,0,10q�6m   $��Center=�6�   $��Center=�6�   .+�5  *   ��  " MaterialDesignRaisedDarkButton#��[ 5  -   $��40��5  -   +  %MaterialDesignThemes.Wpf.ButtonAssist(   CornerRadius$( 25��5  -   ) � ToolTip$) Lưu những thay đổi��5  -   ��5  -   �� *CapNhatTKCommand+��5  -   �� $ pbThongTinTaiKhoan��.��5   .   �� $��Cập Nhật��5!  1   5"  +   5#  '   5$  #   5%     5&     5'     �� 5(     $��60��5)     $��40��5*     $��5q�5+     
������ 
������ ��5.     �� *
Minimize+��5/     �� $ 
mainWindow��.��50       $��22��51     $��22��52     $��Center=�53     $��Center=�54     
���  ��$ WindowMinimize=�56     57     �� 58     $��60��59     $��40��5:     $��5q�5;     
������ 
������ ��5>     �� *
Maximize+��5?     �� $ 
mainWindow��.��5A       $��22��5B     $��22��5C     $��Center=�5D     $��Center=�5E     
���  �� 5G     �� *Maximize_Icon+5H     �� 5I     $��60��5J     $��40��5K     $��5q�5L     
������ 
������ ��5O     �� *
CloseApp+��5P     �� $ 
mainWindow��.��5Q       $��22��5R     $��22��5S     $��Center=�5T     $��Center=�5U     
���  ��$ Close=�5W     5X     5Y     5Z     � 5[      5\       5]     $ MouseLeftButtonDown��6!   . 5^       	 6,   �� *MouseMoveWindowCommand+
 6W   �� $ 
mainWindow��5_     5a     � 5c  
   -   5        * �Name$* 
pnlContent��5c      5d       5e     $ Loaded��6!   . 5f       	 6,   �� *LoadContentCommand+
 6S   �� $ 
pnlContent��5g     5i     5j     5k     