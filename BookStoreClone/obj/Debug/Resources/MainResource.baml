   M S B A M L   `   `   `  ����I  EBookStoreClone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:BookStoreClone.ResourcesBookStoreClone.Resources  5      C&clr-namespace:BookStoreClone.ViewModelBookStoreClone.ViewModel  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089,    &BookStoreClone.ViewModel.MainViewModel 
  MainVM,  &BookStoreClone.ViewModel.SachViewModel 
 SachVM4  .BookStoreClone.ViewModel.QuanLyHoaDonViewModel  QuanLyHoaDonVM8   2BookStoreClone.ViewModel.QuanLyDuLieuSachViewModel  QuanLyDuLieuSachVM7   1BookStoreClone.ViewModel.QuanLyKhachHangViewModel  QuanLyKhachHangVM.  (BookStoreClone.ViewModel.BaoCaoViewModel  BaoCaoVM6  0BookStoreClone.ViewModel.QuanLyNhapSachViewModel  QuanLyNhapSachVM4  .BookStoreClone.ViewModel.PhieuThuTienViewModel  PhieuThuTienVM5   /BookStoreClone.ViewModel.QuanLyHeThongViewModel  QuanLyHeThongVM-	   'BookStoreClone.ViewModel.LoginViewModel 	 LoginVM 
 btnLoginStyle  �� 
TargetType �� Property  btnLoginImgIdle �� Value �� 
TargetType J� SnapsToDevicePixels �� Triggers P� Property P� Value  btnLoginImgHover  btnLoginImgClick  ScrollBarThumb ��Name	 �� CornerRadius
 �� RelativeSource �Name �� Padding ]�Name J� IsMouseOver ]� DecreaseRepeatButton �� PageUpCommand J� Opacity ]� IncreaseRepeatButton �� PageDownCommand ]� Thumb �� Triggers �� PageLeftCommand �� PageRightCommand � ColumnDefinitions � RowDefinitions ��Name ��Name �� CanContentScroll �� CanHorizontallyScroll �� CanVerticallyScroll ��Name4
  .System.Windows.Automation.AutomationProperties  
  AutomationId! � Cursor" �� ScrollableHeight# � Maximum$ � Minimum% �� ViewportHeight& �� ViewportSize*' �� #ComputedVerticalScrollBarVisibility( � Value) �� Mode* �� ScrollableWidth+ �� Orientation, �� ViewportWidth,- �� %ComputedHorizontalScrollBarVisibility. :� RoutedEvent/ �� 
TargetName0 �� TargetProperty	1 W� To2 g� Duration�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      0local&clr-namespace:BookStoreClone.Resources  5      4	viewmodel&clr-namespace:BookStoreClone.ViewModel  5      %{  &	        &	      &	 &     &	 9     &	 L     &	 _     &	 r     &	 �     &	 �     &		 �     &	
 �     &	 �    '�� 3    7  7  '�� �	       5      6     5	      6     5      6&     5      6*     5      6)     5      6      5      6(     5      6?     5      6'   	  5      6   �� 5      "  ��6"   .�5   
   ��  � ��# �  6'   �� 5   
    � ��$ 0q�6,   �� 5   
    �@�Cursor$
 Hand��6#   �� 5   
    � �� 5      �� 5      " ��6"   .R�5      �� #��z��5      #��z��5      #��z��5      ._�5      �� #��z��5       #��z��5!      #��z��5"      ��. # z 5$      5%       5&      P� 5'       �@J�IsMouseOver . . �5(      �� # �  6;    � ��5)      P� 5*       � �� . . �5+      �� # �  6;    � ��5,      5.      50      51      �� 52      "  n�6#   .�53   
   ��  �@�OverridesDefaultStyle . 62   �� 54   
    � �� .  6&   �� 55   
    � �� 56      �� 57      " n�6"   .R�58      �� $ 	rectangle��59      #��z��5:      #��z��5;      
�������$	 3��5=       . 5>      5?      5A      5B      �� 5D      "  ��6   .�5E   
   ��  �@��IsPressAndHoldEnabled .  69   �� 5F   
    �@��IsFlicksEnabled .  63   �� 5G   
    � ��$ 14��6"   �� 5H   
    � ��$ 	-14,0,0,0q�6#   �� 5I   
    � �� 6%   �� *Width+
 �� *Self+�� 5J   
    � �� 5K      �� 5L      " ��6"   .R�5M      � $ Bg��5N      
������  . .+�5R      �� $	 0,4q�6!   ._�5S      ]� $ 
PART_Track��5T   !   $��6��5U   !   $��Center=�5V   !   ��. #{�z 5X   !    5Y   "   �� 5Z   &   #��Z 63   $ 0Q�6`    5\   "   �� 5]   &   #��Z 63   $ 0Q�6b    5_   "   n� 5`   &   8��  6,   5b      5c      5d      5e      5g       5h   
   P� 5i       �@��Orientation$ 
Horizontal=�6-   . �5j      ��  � ��$
 Auto��6*   �� 5k       � ��$ 0��6-   �� 5l       � ��$ 14��6+   �� 5m       � �� 6.   �� *Height+
 �� *Self+�� 5n       � ��$ 	0,-14,0,0q�6+   �� 5p       � �� 5q      �� 5r      " ��6*   .R�5s      � $ Bg��6#    . .+�5t   "   ]� $ 
PART_Track��5u   %   $��6��5v   %   #{�z 5w   %    5x   &   �� 5y   *   #��Z 67   $ 0Q�6f    5{   &   �� 5|   *   #��Z 67   $ 0Q�6g    5~   &   n� 5   *   8�� 60   5�   #   5�      5�      5�      5�      5�      �� 5�      "  ��6   .�5�   
   ��  � �� 5�      �� 5�      " ��6"   .R�5�      � $
 Grid��6   #��z��6)    5�      �� 5�      $��* �6/   �� 5�      $
��Auto �6/    5�      �� 5�      $��* �6,   �� 5�      $
��Auto �6,   .+�5�      �� $ Corner��5�      $��1��5�      $��1��5�      #��� ��5�      �� 5�      $! PART_ScrollContentPresenter��5�      $��0��5�      $��0��5�      #��z��5�      # z��5�       .   .  #��z��5�      #��z��5�      �� 5�      $ PART_VerticalScrollBar��5�      $��0��5�      $��1��5�      $  VerticalScrollBar��5�      $! Arrow��5�      ## z" 5�      $$ 0Q�5�      $	 0.2Q�5�      #& z% 5�      #y�z' 5�      ( 5�      �� *VerticalOffset+$) OneWay=�
 �� *TemplatedParent+�� 5�      $ PART_HorizontalScrollBar��5�      $��1��5�      $��0��5�      $  HorizontalScrollBar��5�      $! Arrow��5�      ## z* 5�      $$ 0Q�5�      $	 0.2Q�5�      $+ 
Horizontal=�5�      #& z, 5�      #y�z- 5�      ( 5�      �� *HorizontalOffset+$) OneWay=�
 �� *TemplatedParent+5�       5�      :� 5�      $. 
MouseEnter��6'   .[�5�      �� .��5�   "   �� .��5�   &   W� $/ PART_VerticalScrollBar��5�   )   $0 Opacity�5�   )   $1 1X�5�   )   $2 0:0:0.3D�5�   )   W� 5�   &   $/ PART_HorizontalScrollBar��5�   )   $0 Opacity�5�   )   $1 1X�5�   )   $2 0:0:0.3D�5�   )   5�   #   5�      5�      :� 5�      $. 
MouseLeave��6'   .[�5�      �� .��5�   "   �� .��5�   &   W� $/ PART_VerticalScrollBar��5�   )   $0 Opacity�5�   )   $	1 0.2X�5�   )   $2 0:0:0.3D�5�   )   W� 5�   &   $/ PART_HorizontalScrollBar��5�   )   $0 Opacity�5�   )   $	1 0.2X�5�   )   $2 0:0:0.3D�5�   )   5�   #   5�      5�      5�      5�      5�      5�      