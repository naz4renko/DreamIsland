   M S B A M L   `   `   `  ����J  FDreamIsland.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DreamIsland.WPFDreamIsland.WPF  5           DreamIsland.WPF.CartWindow   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:DreamIsland.WPF     5      .��5	      �   � ColumnDefinitions  5
   
   �� 5      $��60 �6   �� 5      $��1* �6   �� 5      $��60 �6    � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��1* �6   �� 5      $	��150 �6   .+�5   
   �� -   5         ��Name$ YourCart��5      $��Ваша корзина��6&   $��1��6:   $��Center=�6J   $��Center=�6g   
�������$��28(�6�   $
��Bold"�6�   $��Comic Sans MS)�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ CartDataGrid��5      $��1��6)   $��1��66   ��6F   �� *TicketsCollection+�� 5   
    �� Orientation$ 
Horizontal=�6   $��2��6.   $��1��6;   $��Center=�6K   .+�5      �� -   5         ��Name$ RemoveTicketButton��5      $��50��61   $	��180��6=   $��22(�6I   $��Удалить��6W   $��0 0 20 0q�6m   6   �� 5      -   5        $ ComfirmCartButton��5      $��50��61   $	��180��6=   $��22(�6I   $��Подтвердить��6W   $��20 0 0 0q�6m   6   5      �� 5   
   -   5         ��Name$ CheckWindow��5      $��3��6&   $��3��6:   $	��320��6K   $	��320��6X   ���#3A5985$y�	Collapsed=�6y   ._�5      �� -   5         ��Name$ ClientCheck��5      $��3��6.   $��3��6B   $	��300��6S   $	��300��6`   $��Center=�6l   $��Center=�6�   $ Vertical=�6�   ���#89AFE0.+�5      �� $��ЧЕК��6   $��20(�6'   $��Comic Sans MS)�65   
�������$��Stretch=�6c   $
��Bold"�6�   ���#3A5985 �� TextAlignment$ Center=�6�   �� 5      $ 
Horizontal=�6   $	��5 5q�66   .+�5      �� -   5        $
 Name��5      
�������$��Имя: ��6=   $��16(�6J   $
��Bold"�6X   $��Comic Sans MS)�6j   $��20��6�   $
��Auto��6�   �� 5       -   5        $ 
ClientName��5       
�������$��16(�6C   $
��Bold"�6Q   $��Comic Sans MS)�6c   $��20��6~   $
��Auto��6�   5!      �� 5"      $ 
Horizontal=�6   $	��5 5q�62   .+�5#      �� -	   5        $	 Age��5#      
�������$��Возраст: ��6<   $��16(�6M   $
��Bold"�6[   $��Comic Sans MS)�6m   $��20��6�   $
��Auto��6�   �� 5$      -
   5        $ 	ClientAge��5$      
�������$��16(�6B   $
��Bold"�6P   $��Comic Sans MS)�6b   $��20��6}   $
��Auto��6�   5%        5&      -   5        $ EndedListOfTickets��5&      �� 5'      $ 
Horizontal=�6   $	��5 5q�62   .+�5(      �� -   5        $ 
TotalPrice��5(      
�������$��Итого: ��6C   $��16(�6R   $
��Bold"�6`   $��Comic Sans MS)�6r   $��20��6�   $
��Auto��6�   �� 5)      -   5        $ ClientTotalPrice��5)      
�������$��16(�6I   $
��Bold"�6W   $��Comic Sans MS)�6i   $��20��6�   $
��Auto��6�   5*      5+      5,      �� 5-   
   -   5        $ DialogStack��5-      $y�	Collapsed=�6*   $��4��6A   $��3��6U   $	��120��6f   $	��220��6s   ���	#FF121D4A.+�5.      �� $��Подтвердить?��6   
�������$��Center=�6?   $��20q�6\   $��20(�6h   $
��Bold"�6v   $��Comic Sans MS)�6�   �� 5/      $ 
Horizontal=�6   $��Center=�62   .+�50      �� -   5        $ ComfirmButton��50      $
��10 0q�60   $��80��6>   $
��Да��6I   6V   �� 51      -   5        $ CancelButton��51      $
��10 0q�6/   $��80��6=   $��Нет��6H   6V   52      53      54      55      