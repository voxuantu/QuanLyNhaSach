   M S B A M L   `   `   `  ����I  EBookStoreClone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:BookStoreClone.ViewBookStoreClone.View  5      '    !BookStoreClone.View.TimKiemSachUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      -local!clr-namespace:BookStoreClone.View  5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5	      -   5          >�Name$  timKiemSachUC��5
      .��5      ]� .+�5   
   #  MaterialDesignThemes.Wpf.Card  -   5          Name$ pnlThongTinSach��5      $	��426��5      $��Right=�5      $y�	Collapsed=�5      
 � Tag 5      �� *IDSach+ �� UpdateSourceTrigger$ PropertyChanged=�.��5      � .+�5      �� .��5      �� .+�5      �� $	��364��6   $	��Top=�6*   .+�5      ��  �� Left$ 42��5      
 �� Top$ 10��5      $	��350��5      $	��345��5       ��5!      �� *AnhBia+�� 5"      $ 10��5$      $ 10��5%       J� RenderTransformOrigin$ 1.15,0.6&�5(       /  +MaterialDesignFloatingActionMiniLightButton#��[  5)       c� OverflowMode$ AsNeeded=�5*       � ToolTip$1 +MaterialDesignFloatingActionMiniLightButton��5+      ��5&      �� *AnSachCommand+��5'      �� 	 �� ElementName$	 pnlThongTinSach��.��5,      '  !MaterialDesignThemes.Wpf.PackIcon  $��24��5-   !   $��24��5.   !   
   Kind$
 Close=�5/   !   $ 1.583,2.583&�50   !   .  (System.Windows.Interactivity.Interaction   Triggers 51      /  )System.Windows.Interactivity.EventTrigger  52   "      	EventName$ Click��61   .  (System.Windows.Interactivity.TriggerBase   Actions. 53   &   6  0System.Windows.Interactivity.InvokeCommandAction     Command 6<   �� *AnSachCommand+   CommandParameter 6^   �� $	 pnlThongTinSach��54   #   56        57      -   5        $ cardHetHang��58      $	��200��59      $��50��5:      $��10,63,216,687q�5;      $��8q�5<      
������
������� J� Opacity$	 0.8Q�5?      .��5@      �� $��25(�6(   Hết hàng5B       5C        5D   "   $ Loaded��61   . 5E   &      6<   �� *LoadedCardHetHangCommand+ 6j   �� $	 cardHetHang��6�   5F   #   5H      5I      �� 5J      $	��350��5K      $��10q�5L      $	��Top=�5M      ��. $��Visible=�6S    �� CanVerticallyScroll . $
��Auto=�6�   .+�5O      �� $��Center=�5P      $��Center=�5Q      $��25(�5R      
���   � �� TextAlignment$ Center=�5U      $
��Wrap=�5V      ��5T      �� *	TenSach+5V      �� 5X      $��25(�5Y      
���   �$ 0.365,1.083&�5[      $ Center=�5]      ��5\      �� *	GiaSach+5]      �� 5_      $��17(�5`      
���   �$ Right=�5c      ��5b      �� *
SoLuongTon+5d      �� 5f      $��17(�5g      
���   �$
��Wrap=�5j      ��5i      �� *	TheLoai+5j      �� 5k      $��17(�5m      
���   �$
��Wrap=�5p      ��5o      �� *TacGia+5p      �� 5q      $��17(�5s      
���   �$
��Wrap=�5v      ��5u      �� *NhaXB+5v      5w      �� 5z      .��5{      ]� $
��Auto=�6$   ��. .+�5}      �� $��0,10,0,0q�5~      $��Center=�5      $	��Top=�5�      $��17(�5�      ��. $
��Auto=�6P    ----------Mô tả------------5�      �� 5�      $��
38,10,0,10q�5�      $��15(�5�      $
��Wrap=�5�      ��. $
��Auto=�6V   ��5�      �� *
MoTaSach+5�   V   5�      5�      5�      5�      5�      5�      ]� 5�   
   .+�5�      ]� $	��Top=�6   ��. $��10q�6B   .+�5�      �� $��Right=�5�      $��Center=�5�      $��Right=�5�       �� Orientation$ 
Horizontal=�5�      .+�5�      �� $��Center=�6    $��Hiển thị:     ��6;   �� 5�      -   5         ��Name$ cbSoTrangHienThi��5�      $��0,0,30,0q�5�      $��Right=�5�      .  (MaterialDesignThemes.Wpf.ColorZoneAssist   Mode$ Standard=�5�        MaterialDesignPaper.  (MaterialDesignThemes.Wpf.TextFieldAssist   UnderlineBrush# �  5�      #���  5�      $��0q�5�       �� SelectedIndex$ 0��5�      .@�5�      �� .��6'   165�      �� 5�      .��6'   325�      �� 5�      .��6'   645�       5�        5�      $ SelectionChanged��6-   . 5�   "      68   �� *ThayDoiSoLuongHienThiCommand+ 6i   �� $	 cbSoTrangHienThi��5�      5�      5�      �� 5�      $��44��5�      $��Center=�5�      $��Center=�5�      +	  %MaterialDesignThemes.Wpf.RippleAssist 	  
IsCentered . $ 
Horizontal=�5�      .+�5�      �� -   5        $ combotimkiem��5�      $��8,0,0,0q�5�      $ Standard=�5�      # �  5�      #���  5�      $��0q�5�      $ 0��5�      .@�5�      �� .��6'   
Tên sách5�      �� 5�      .��6'   
Tác giả5�      �� 5�      .��6'   Thể Loại5�       5�        5�      $ SelectionChanged��6-   . 5�   "      68   �� *ChontimkiemCommand+ 6_   �� $	 combotimkiem��5�      5�      (
  "MaterialDesignThemes.Wpf.ColorZone
  5�      $��16,0,0,0q�5�      $��8,4,8,4q�5�       K� ZIndex$ 1��5�      +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth1=�5�       
  CornerRadius$ 2��5�       
  Mode$ Standard=�5�      .��5�      �  � ColumnDefinitions 5�      �� 5�   "   $
��Auto �63   �� 5�   "   $	��80* �63   �� 5�   "   $	��99* �63   �� 5�   "   $
��Auto �63   .+�5�      ��   MaterialDesignToolButton#���  5�   !   ��5�   !   �� *TimKiemCommand+��5�   !   �� $	 pnlHienThiSach��.��5�   "     $
 Magnify=�6:   $	 .56Q�6I   5�      �� 5�      $��1��5�   !   $��8,4,0,4q�5�   !   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Tìm Kiếm Sách��5�   !      DecorationVisibility$ Hidden=�5�   !   $��0q�5�   !   $��2��5�   c   $��Center=�6w   ��6!   �� *TextTimKiem+$ PropertyChanged=�6w   5�      5�      5�      5�        5�      $��0,0,5,0q�6"   $	��Top=�63   .��5�      �� .��5�      ]� .+�5�      �� $��50��5�      $��Center=�5�      $��Center=�5�      
�������$��Bottom=�5�      $ 
Horizontal=�5�      .+�5�      � $��Center=�6(   $��Center=�6E   .+�5�   "   �� $��	10,5,10,5q�6)   ��6<   �� *TrangDauCommand+.��5�   &     $
 ChevronDoubleLeft=�6>   5�   #   �� 5   "   $��	10,5,10,5q�6)   ��6<   �� *TrangTruocDoCommand+.��5  &     $
 ChevronLeft=�6>   5  #   � 5  "    5  &   �� 5  *   �� 5  *   .+�5	  &   �� $��1��5
  )   $��Center=�5  )   ��5  )   �� *TrangThaiSoTrang+5  #   �� 5  "   $��	10,5,10,5q�6)   ��6<   �� *TrangTiepTheoCommand+.��5  &     $
 ChevronRight=�6>   5  #   �� 5  "   $��	10,5,10,5q�6)   ��6<   �� *TrangCuoiCommand+.��5  &     $
 ChevronDoubleRight=�6>   5  #   5     5     � 5     -   5          �Name$  pnlHienThiSach��5  $   $��Center=�6<    5       5  "   $ Loaded��61   . 5  &      6<   �� *
LoadSach+ 6Y   �� $	 pnlHienThiSach��5  #   5     5     5     5     5      5!     5"     