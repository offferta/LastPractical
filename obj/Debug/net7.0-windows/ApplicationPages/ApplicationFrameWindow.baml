   M S B A M L   `   `   `  ����H  DLastPractical, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:LastPracticalLastPractical  5   	   *    $LastPractical.ApplicationFrameWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   -localclr-namespace:LastPractical     5   	     � Title$  Заявки��5   	   $
��1600��6    � WindowState$ 	Maximized=�6%   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��150 �6   �� 5       � ColumnDefinitions 5   
   �� 5      $��70 �6   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      $��70 �6   .+�5   
   �� $��0��6   $��0,0,0,1q�6   $��7��68   
���   �6L    � 5   
   -   5          �Name$ ApplicationFrame��5      $��1��6   $��7��67     � NavigationUIVisibility$ Hidden=�6K   $
��Left=�6k   $
��Left=�6�   ���#FFFFFF6�   �� 5   
   -   5         ��Name$ ApplicationButton��5      $��1��6,   $	��250��6<   $#��Добавить заявку��6J   6e   �� 5   
   -   5        $ ListApplicationButton��5      $��2��60   $	��250��6@   $��Список заявок��6N   6g   �� 5   
   -   5         ��Name$ FullName��5   f   $��4��6   $��Center=�6    $��Center=�6D   6x   5      5      