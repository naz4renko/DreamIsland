   M S B A M L   `   `   `  ����J  FDreamIsland.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DreamIsland.WPFDreamIsland.WPF  5   	        DreamIsland.WPF.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   c _MaterialDesignThemes.MahApps, Version=0.3.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962a_ [MaterialDesignThemes.Wpf, Version=4.9.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aHmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes   5   	   +localclr-namespace:DreamIsland.WPF   5   	     � Title$  
MainWindow��5	   	   $	��600��6   $
��1000��6)    � 
ResizeMode$ NoResize=�66    � WindowStyle$
 None=�6L    � WindowStartupLocation$ CenterScreen=�6_   .��5
      � -   5         �Name$ MainGrid��5
      ���#B2CAEE � ColumnDefinitions 5   
   �� 5      $��55 �6   �� 5      $��1* �6   �� 5      $��55 �6    � RowDefinitions 5   
   �� 5      $��55 �6   �� 5      $��1* �6   �� 5      $��55 �6   .+�5   
   �� $��0��6   $��3��6   ���	#FF121D4A$	��1.5q�6J   ._�5      � ���#3A5985$��0��6(   $��3��65   5      �� 5   
   $��2��6   $��3��6   ���	#FF121D4A$	��1.5q�6J   ._�5      � ���#3A5985$��2��6(   $��3��65   5      �� 5   
   $��1��6   $��0��6   ���	#FF121D4A$��1,0,1,0q�6F   ._�5      � $��1��6   $��0��6    ���#89AFE0.+�5      �� -   5         ��Name$
 Back��5   0   $y�	Collapsed=�6   
������ 
������ $
��Auto��6q   $��55��6   $��Right=�6�   $��0q�6�   .��5      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ 	ArrowLeft=�6.   $��40��6?   $��40��6K   $��Center=�6V   $��Center=�6q   $��20(�6�   5      5       5!      �� 5"   
   $��1��6   $��2��6   ���	#FF121D4A$��1,0,1,0q�6F   ._�5#      � $��1��6   $��2��6    ���#89AFE060   5$      � 5&   
   $��3��6   .+�5'      �� -   5        $
 Exit��5'      
������ 
������ $��55��6i   $��55��6u   $��Right=�6�   $��0q�6�   .��5(        $ CloseBoxOutline=�6*   $��40��6A   $��40��6M   $��Center=�6X   $��Center=�6s   $��20(�6�   5)      5*      >� 5+   
   -   5        	 >�Name$	 UserController��5+      $��1��6.   $��1��6>   � 5,   
   $��0��6   $��1��6   .+�5-      �� 
 �� Orientation$
 
Horizontal=�6   $��Center=�62   .+�5.      �� -   5        $
 Info��5.   0   $y�	Collapsed=�6   $
��Auto��6D   $��50��6Q   $��20(�6]   
�������$��Информация��6~   
������  "  MaterialDesignFlatAccentButton#��[  6�   $
��Bold"�6�   �� 5/      -   5        $ 	BuyTicket��5/   0   $y�	Collapsed=�6   $
��Auto��6D   $��50��6Q   $��20(�6]   
�������$��Купить билет��6~   
������ #��[  6�   $
��Bold"�6�   6�   �� 50      -   5        $ 	CheckCart��50   0   $y�	Collapsed=�6   $
��Auto��6C   $��50��6P   $��20(�6\   
�������$��Корзина��6}   
������ #��[  6�   $
��Bold"�6�    � Cursor$
 Hand��6
  51      52      53      54      