   M S B A M L   `   `   `  ����I  EBookStoreClone, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:BookStoreClone.ViewBookStoreClone.View  5           BookStoreClone.View.SachUC   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      c _System.Windows.Interactivity, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35Bi:http://schemas.microsoft.com/expression/2010/interactivity  5      -local!clr-namespace:BookStoreClone.View  5      V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      Dmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5	      
������    MaterialDesignFont#���   5      $��13(�5      $��Regular"�5        MaterialDesignBody#���  5      &   System.Windows.Media.TextOptions    TextFormattingMode$  Ideal=�5         TextRenderingMode$
 Auto=�5      $
��Auto=�5      .��5      �� $	��200��5   	   $	��320��5   	   
������   btnLoginStyle#��[ 5   	   $
��Auto=�60   ��5   	   �� *HienThiThongTinSachCommand+��5   	   ��  �� ElementName$ 	tbTenSach��.��5   
   � .+�5      #  MaterialDesignThemes.Wpf.Card  -   5          Name$
 card��5       $	��180��5!      $	��300��5"      $��0,0,9,9q�5#   R   $��Bottom=�6c   $��Right=�6~   $
��Auto=�6�   ��. +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth 6   �� *ShadowDepthA+.  (System.Windows.Interactivity.Interaction   Triggers 5$      /  )System.Windows.Interactivity.EventTrigger  5%         	EventName$ 
MouseEnter��6%   .  (System.Windows.Interactivity.TriggerBase   Actions. 5&      6  0System.Windows.Interactivity.InvokeCommandAction     Command 60   �� *MouseEnterCommand+	   CommandParameter	 6V   �� $
 card��5'        5(      $ 
MouseLeave��6%   . 5)         60   �� *MouseLeaveCommand+	 6V   �� $
 card��5*      .��5-      ]� $��0q�6   $	��300��6'   $	��180��64   $��Bottom=�6@   .+�5/      �� -   5        
 ��Name$
 
imgAnhSach��50   !   $	��166��51   !   $	��220��52   !   $��10q�53   !   $��Center=�54   !   $��Center=�55   !   $	��Top=�56   !   $
��Fill=�57   !    K� ZIndex$ 83��60   $��83��6B   $	��110��6P   ]� 58      $��Bottom=�6    $��18��68   $	��180��6D   .+�59      �� -   5         ��Name$ tbDonGia��5:   !   $��50��5;   !   $��2q�5<   !   $��Center=�5=   !   $��Right=�5>   !   $��12(�5?   !   
���   �5@   !   � 5A      5B      �� 5D      -   5        $ 	tbTenSach��5F   !   $��32��5E   !   $	��160��5G   !   $	��160��5H   !   $��	10,0,10,5q�5I   !   $��Center=�5J   !   $��Center=�5K   !   
���   � �� TextAlignment$ Center=�5M   !   $
��Wrap=�5N   !   � 5O      5P      5Q        5R      -   5        $ cardHetHang��5S      $	��120��5U      $��-4,34,82,251q�5V      $��8q�5W      
������ J� Opacity$	 0.8Q�5Y      
�������.��5[      �� $��14(�6   Hết hàng5]      5^      5_      5`      5a      