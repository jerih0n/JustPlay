   M S B A M L   `   `   `  ����C  ?justPlay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:justPlayjustPlay  5   	   a ]PresentationFramework.Aero, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35gJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroMicrosoft.Windows.Themes 5   	       justPlay.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:justPlay     5   	   ]ThemesJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero     5   	     � Title$  	Just Play��5	   	   $��369.737��6   $��640.789��6,    � Icon$  /Resources/blue-purple.ico��5
   	    � 	Resources 5         ButtonFocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  ButtonNormalBackground �� EndPoint �� 
StartPoint	 � Color
 � Offset��%�  &	        &	 �     �� 5   
   .�5      ��  � �� 5      �� 5      .R�5      �� $��2q�6$    . #��� ��6J   $��1��6�   $	 1 2R�6�   5      5      5      �� 5   
   $	 0,1&�6=   $	 0,0&�6L   .��5      � $	 #F3F3F3��6   $
 0Q�6+   � 5      $	 #EBEBEB��6   $	
 0.5Q�6+   � 5      $	 #DDDDDD��6   $	
 0.5Q�6+   � 5      $	 #CDCDCD��6   $
 1Q�6+   5      5      .��5      � -   5         J� 	AllowDrop . ��5   
   �� 5      $ 0.5,1&�6"   $ 0.5,0&�63   .��5       � $	 Black��6   $
 0.902Q�6-   � 5!      $	 	#FFF70ACC��6   $

 0.99Q�61   � 5"      $	 	#FF4B033E��6   $
 0.945Q�61   � 5#      $	 	#FF740660��6   $
 0.965Q�61   5$       � RowDefinitions 5&   
   �� 5'      $
��281* �6   �� 5(      $	��23* �6   �� 5)      $	��36* �6    � ColumnDefinitions 5+   
   �� 5,      $
��141* �6   �� 5-      $
��373* �6   �� 5.      $
��119* �6   .+�50   
   r� -   5         r�Name$ screen��50      $��0��6'   $��3��64   $��Stretch=�6H   $��Stretch=�6d    r� Stretch$
 Fill=�6�   6�   �� 52   
   -   5         ��Name$ movie_slider��52      $��1��6'   $��3��64   
���   ����	#FF3626266r   �� 53   
   -   5         ��Name$
 open��53      $��2��6   $��0��6,   $��40��6<   $��25��6G   $��Bottom=�6S   $
��Left=�6n   $��7,0,0,5q�6�   |�.   � Cursor$
 Hand��6�   ��54      �� 55       �� ImageSource$ /Resources/openFolder.png��6   57      �� 58   
   -   5        $
 play��58      $��2��6   $��1��6,   $��60��6<   $��26��6G   $
��Left=�6S   $��77,0,0,9q�6n   $��Stretch=�6�   |�.  $
 Hand��6�   ��59      �� 5:      $ /Resources/Play.png��6   5<      �� 5=   
   -   5        $ pause��5=      $��2��6    $��1��6-   $��60��6=   $��25��6H   $��Center=�6T   $��Stretch=�6q   $��142,0,171,10q�6�   |�.  $
 Hand��6�   ��5>      �� 5?      $ /Resources/pause.png��6   5A      �� 5B   
   -   5        $
 stop��5B      $��2��6   $��1��6,   $��60��6<   $��25��6G   $��Right=�6S   $��Stretch=�6p   $��
0,0,106,10q�6�   |�.  $
 Hand��6�   ��5C      �� 5D      $ /Resources/stop.png��6   5F      �� 5G   
   -   5        $ volume_slider��5G      $��2��6(   $��2��65   $��90��6E   $��Bottom=�6Q   $��Right=�6m   $��0,0,0,13q�6�    � Minimum$ 0Q�6�    � Maximum$ 1Q�6�    � LargeChange$	 0.1Q�6�   $
 Hand��6�   $��22��6�   �� 5H   
   $��/Resources/soundPic.png��6   $��1��61   $��1��6>   $��Right=�6N   $��0,0,86,9q�6j   $��56��6|   $��Bottom=�6�   $��31��6�   $��2��6�   $��2��6�   5I      5J      