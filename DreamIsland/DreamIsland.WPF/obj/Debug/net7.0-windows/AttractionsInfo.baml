   M S B A M L   `   `   `  ����J  FDreamIsland.WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:DreamIsland.WPFDreamIsland.WPF  5      %    DreamIsland.WPF.AttractionsInfo   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:DreamIsland.WPF     5        � 	Resources  5	         SlideDownStoryboard g� Duration	 W� To �� TargetProperty �� 
TargetName  SlideUpStoryboard  SlideDownStoryboard1  SlideUpStoryboard1  SlideDownStoryboard2  SlideUpStoryboard2  SlideDownStoryboard3  SlideUpStoryboard3��%�  &	        &	 �     &	 P    &	 �    &	 �    &	 L    &	 �    &	 �    �� 5
   
   .��5      W� $ 0:0:0.25D�6    49062   $8 2(UIElement.RenderTransform).(TranslateTransform.Y)�5      $ AnimatedBorder��5      5      �� 5   
   .��5      W� $ 0:0:0.25D�6    062   $8 2(UIElement.RenderTransform).(TranslateTransform.Y)�5      $ AnimatedBorder��5      5      �� 5   
   .��5      W� $ 0:0:0.25D�6    49062   $8 2(UIElement.RenderTransform).(TranslateTransform.Y)�5      $ AnimatedBorder1��5      5      �� 5   
   .��5      W� $ 0:0:0.25D�6    062   $8 2(UIElement.RenderTransform).(TranslateTransform.Y)�5      $ AnimatedBorder1��5      5      �� 5    
   .��5!      W� $ 0:0:0.25D�6    49062   $8 2(UIElement.RenderTransform).(TranslateTransform.Y)�5"      $ AnimatedBorder2��5#      5$      �� 5%   
   .��5&      W� $ 0:0:0.25D�6    062   $8 2(UIElement.RenderTransform).(TranslateTransform.Y)�5'      $ AnimatedBorder2��5(      5)      �� 5+   
   .��5,      W� $ 0:0:0.25D�6    49062   $8 2(UIElement.RenderTransform).(TranslateTransform.Y)�5-      $ AnimatedBorder3��5.      5/      �� 50   
   .��51      W� $ 0:0:0.25D�6    062   $8 2(UIElement.RenderTransform).(TranslateTransform.Y)�52      $ AnimatedBorder3��53      54      55      .��56      �  � ColumnDefinitions 57   
   �� 58      $��* �6   �� 59      $��* �6   �� 5:      $��* �6   �� 5;      $��* �6   .+�5?   
   � ���	#FF8383BF.+�5@      �� $��Center=�6   $��Center=�66   .+�5A      �� -   5         ��Name$ FirstZoneLabel��5A      
�������$��17(�6G   $
��Bold"�6U   $��Comic Sans MS)�6g   $��Center=�6�   $��Center=�6�   $��	0 10 0 10q�6�   �� 5B      -   5        $ FirstZoneList��5B      $��Center=�63   
�������$��14(�6c   $
��Bold"�6q   $��Comic Sans MS)�6�   5C      5D      � 5E   
   $��1��6   ���	#FF8383BF.+�5F      �� $��Center=�6   .+�5G      �� -   5        $ SecondZoneLabel��5G      
�������$��17(�6H   $
��Bold"�6V   $��Comic Sans MS)�6h   $��Center=�6�   $��Center=�6�   $��	0 10 0 10q�6�   �� 5H      -   5        $ SecondZoneList��5H      $��Center=�64   
�������$��14(�6d   $
��Bold"�6r   $��Comic Sans MS)�6�   5I      5J      � 5K   
   $��2��6   ���	#FF8383BF.+�5L      �� $��Center=�6   .+�5M      �� -   5        $ ThirdZoneLabel��5M      
�������$��17(�6G   $
��Bold"�6U   $��Comic Sans MS)�6g   $��Center=�6�   $��Center=�6�   $��	0 10 0 10q�6�   �� 5N      -   5        $ ThirdZoneList��5N      $��Center=�63   
�������$��14(�6c   $
��Bold"�6q   $��Comic Sans MS)�6�   5O      5P      � 5Q   
   $��3��6   ���	#FF8383BF.+�5R      �� $��Center=�6   .+�5S      �� -   5        $ FourthZoneLabel��5S      
�������$��17(�6H   $
��Bold"�6V   $��Comic Sans MS)�6h   $��Center=�6�   $��Center=�6�   $��	0 10 0 10q�6�   �� 5T      -   5        $ FourthZoneList��5T      $��Center=�64   
�������$��14(�6d   $
��Bold"�6r   $��Comic Sans MS)�6�   5U      5V      � 5Y   
   
������ $��0��6(    � Triggers 5Z      :� 5[       :� RoutedEvent$ UIElement.MouseEnter��6   .[�5\      �� #��[  6&   5]      :� 5^      $ UIElement.MouseLeave��6   .[�5_      �� #��[ 6&   5`      .+�5d      �� �� 5g      -	   5        	 ��Name$	 AnimatedBorder��5g      
 J� Opacity$	
 0.9Q�6-   ��5h      �� 5i       �� ImageSource$3 -/ЗамокСнежнойКоролевы.png��6!   z�5k      T� 5l       T� Y$ 0Q�6)   5o      5p      � 5r   
   
������ $��1��6(    5s      :� 5t      $ UIElement.MouseEnter��6   .[�5u      �� #��[ 6&   5v      :� 5w      $ UIElement.MouseLeave��6   .[�5x      �� #��[ 6&   5y      .+�5}      �� $��1��6   �� 5�      -
   5        $	 AnimatedBorder1��5�      $��1��6.   $	
 0.9Q�6>   ��5�      �� 5�      $ /ГонкаМечты.png��6!   z�5�      T� 5�      $ 0Q�6)   5�      5�      � 5�   
   
������ $��2��6(    5�      :� 5�      $ UIElement.MouseEnter��6   .[�5�      �� #��[ 6&   5�      :� 5�      $ UIElement.MouseLeave��6   .[�5�      �� #��[ 6&   5�      .+�5�      �� $��2��6   �� 5�      -   5        $	 AnimatedBorder2��5�      $��1��6.   $	
 0.9Q�6>   ��5�      �� 5�      $% /ГородБудущего.png��6!   z�5�      T� 5�      $ 0Q�6)   5�      5�      � 5�   
   
������ $��3��6(    5�      :� 5�      $ UIElement.MouseEnter��6   .[�5�      �� #��[ 6&   5�      :� 5�      $ UIElement.MouseLeave��6   .[�5�      �� #��[ 6&   5�      .+�5�      �� $��3��6   �� 5�      -   5        $	 AnimatedBorder3��5�      $��3��6.   $	
 0.9Q�6>   ��5�      �� 5�      $' !/ОстровСокровищ.png��6!   z�5�      T� 5�      $ 0Q�6)   5�      5�      5�      5�      