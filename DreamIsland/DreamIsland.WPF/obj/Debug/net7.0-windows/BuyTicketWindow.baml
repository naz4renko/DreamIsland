   M S B A M L   `   `   `  ����J  FDreamIsland.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DreamIsland.WPFDreamIsland.WPF  5      %    DreamIsland.WPF.BuyTicketWindow   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:DreamIsland.WPF     5      .��5	      � ���	#FF8383BF  � ColumnDefinitions  5
   
   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   �� 5      $��1* �6   .+�5   
   �� 
���   �$��0 0 1 0q�6%   ._�5      � .+�5      �� .+�5      �� -   5         ��Name$ AllInclusiveLabel��5       $��Всё включено!��6;   $��Center=�6S   $��0,60,0,0q�6p   
�������$��28(�6�   $
��Bold"�6�   $��Comic Sans MS)�6�   �� 5      -   5         ��Name$ AllInclusiveInfo��5       $��Center=�6:   $��0,15,0,0q�6W   $
��Wrap=�6i   
�������$��20(�6�   $
��Bold"�6�   $��Comic Sans MS)�6�    �� TextAlignment$ Center=�6�   �� 6�   $t�nБезлимитное посещение всех аттракционов на одного человека��6�   6,  �� 5      -   5        $ AllInclusivePrice1��5       $��Center=�6<   $��0,20,0,0q�6Y   $��	Цена:��6k   
�������$��20(�6�   $
��Bold"�6�   $��Comic Sans MS)�6�   �� 5      -   5        $ AllInclusivePrice2��5       $��Center=�6<   $��2500 руб.��6Y   
�������$��20(�6}   $
��Bold"�6�   $��Comic Sans MS)�6�   �� 5      -   5         ��Name$ AllInclusiveButton��5      $��Bottom=�69   $��Купить��6T   $	��120��6e   $��0,70,0,0q�6q   6�   5      5      5      �� 5   
   
���   �$��0 0 1 0q�6%   $��1��6?   ._�5      � $��1��6   .+�5      �� .+�5       �� -   5        $ SimpleAttractionLabel��5        $��Center=�6?   $��Обычный��6\   $��0,60,0,0q�6n   
�������$��28(�6�   $
��Bold"�6�   $��Comic Sans MS)�6�   �� 5!      -   5        $ SimpleAttractionInfo��5!       $��Center=�6>   $��0,15,0,0q�6[   $
��Wrap=�6m   
�������$��20(�6�   $
��Bold"�6�   $��Comic Sans MS)�6�   $ Center=�6�   �� 6�   $L�FПраво на посещение одного аттракциона��6�   6  �� 5"      -   5        $ SimpleAttractionPrice1��5"       $��Center=�6@   $��0,80,0,0q�6]   $��	Цена:��6o   
�������$��20(�6�   $
��Bold"�6�   $��Comic Sans MS)�6�   �� 5#      -	   5        $ SimpleAttractionPrice2��5#       $��Center=�6@   $"��Индивидуальная��6]   
�������$��20(�6�   $
��Bold"�6�   $��Comic Sans MS)�6�   �� 5$      -
   5        $ SimpleAttractionButton��5$      $��Bottom=�6=   $��Купить��6X   $	��120��6i   $��0,65,0,0q�6u   6�   5%      5&      5'      �� 5)   
   
���   �$��0 0 1 0q�6%   $��2��6?   ._�5*      � $��1��6   .+�5+      �� .+�5,      �� -   5        $ StudentTicketLabel��5,       $��Center=�6<   $��Студенческий��6Y   $��0,60,0,0q�6p   
�������$��28(�6�   $
��Bold"�6�   $��Comic Sans MS)�6�   �� 5-      -   5        $ StudentTicketInfo��5-       $��Center=�6;   $��0,15,0,0q�6X   $
��Wrap=�6j   
�������$��20(�6�   $
��Bold"�6�   $��Comic Sans MS)�6�   $ Center=�6�   �� 6�   $t�nБезлимитное посещение всех аттракционов на одного человека��6�   6-  �� 5.      -   5        $ StudentTicketPrice1��5.       $��Center=�6=   $��0,20,0,0q�6Z   $��	Цена:��6l   
�������$��20(�6�   $
��Bold"�6�   $��Comic Sans MS)�6�   �� 5/      -   5        $ StudentTicketPrice2��5/       $��Center=�6=   $��1500 руб.��6Z   
�������$��20(�6~   $
��Bold"�6�   $��Comic Sans MS)�6�   �� 50      -   5        $ StudentTicketButton��50      $��Bottom=�6:   $��Купить��6U   $	��120��6f   $��0,70,0,0q�6r   6�   51      52      53      �� 55   
   
���   �$��0 0 1 0q�6%   $��3��6?   ._�56      � $��1��6   .+�57      �� .+�58      �� -   5        $ FamilyTicketLabel��58       $��Center=�6;   $��Семейный��6X   $��0,60,0,0q�6k   
�������$��28(�6�   $
��Bold"�6�   $��Comic Sans MS)�6�   �� 59      -   5        $ FamilyTicketInfo��59       $��Center=�6:   $��0,15,0,0q�6W   $
��Wrap=�6i   
�������$��20(�6�   $
��Bold"�6�   $��Comic Sans MS)�6�   $`��ZБезлимитное посещение аттракционов до 3х человек��6�   $ Center=�6  �� 5:      -   5        $ FamilyTicketPrice1��5:       $��Center=�6<   $��0,20,0,0q�6Y   $��	Цена:��6k   
�������$��20(�6�   $
��Bold"�6�   $��Comic Sans MS)�6�   �� 5;      -   5        $ FamilyTicketPrice2��5;       $��Center=�6<   $��5500 руб.��6Y   
�������$��20(�6}   $
��Bold"�6�   $��Comic Sans MS)�6�   �� 5<      -   5        $ FamilyTicketButton��5<       $��Bottom=�6<   $��Купить��6W   $	��120��6h   $��0,70,0,0q�6t   6�   5=      5>      5?      �� 5@   
   -   5         ��Name$  SimpleAttractionStackPanel��5@      ���	#FF102233$y�	Collapsed=�6P   $��Center=�6g   $��Center=�6�   $
��Auto��6�   $
��Auto��6�   $��4��6�   .+�5A      &   System.Windows.Controls.DataGrid  -   5          Name$ SimpleAttracionDG��5A         AutoGenerateColumns$
 True��63   ��6N   �� *AttractionsCollection+�� 5B      -   5        $ AddAttraction��5B      $��Bottom=�6,   $��0 20 0 0q�6G   $��Добавить��6Y   $
��Bold"�6l   $��16(�6~   6�   5C      �� 5E   
   -   5        $ DialogStack��5E      $y�	Collapsed=�6*   $��4��6A   $	��120��6U   $	��220��6b   ���	#FF121D4A.+�5F      �� $��Подтвердить?��6   
�������$��Center=�6?   $��20q�6\   $��20(�6h   $
��Bold"�6v   $��Comic Sans MS)�6�   �� 5G       �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�5H      �� -   5        $ ComfirmButton��5H      $
��10 0q�60   $��80��6>   $
��Да��6I   6V   �� 5I      -   5        $ CancelButton��5I      $
��10 0q�6/   $��80��6=   $��Нет��6H   6V   5J      5K      5L      5M      