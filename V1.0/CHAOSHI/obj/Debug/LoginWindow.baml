   M S B A M L   `   `   `  ����B  >CHAOSHI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CHAOSHICHAOSHI  5   	       CHAOSHI.LoginWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:CHAOSHI     5   	   -   5          � Title$  登录��5   	   $	��200��6   $	��400��6!    � WindowStartupLocation$ CenterScreen=�6-    � Icon$ shop_easyicon.ico��5	   	   .��5
      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   �� $��	工号：��6   $��Center=�6   $��Center=�6;   $��15(�6V   6f   �� 5   
   $��	密码：��6   $��Center=�6   $��Center=�6;   $��1��6V   $��15(�6c   6s   �� 5   
   -   5        $
��User��5       $��15(�6   $��	1 15 1 10q�6,   $��1��6?   $��2��6O   ���	#FFB3B4B9 �� TextWrapping$
 Wrap=�6{   6�   G� 5   
   -   5        $	��Pwd��5   $   $��15(�6   $��	1 15 1 10q�6/   $��1��6B   $��1��6R   $��2��6_   
����������	#FFB0B2B96�   �� 5   
   -   5        $��btnLog��5      $��登录��6   $��2��6,   $��5 5 5 5 q�69   $��12(�6K    �� 	IsDefault . 6�   �� 5   
   -   5        $��	btnCancel��5      $��取消��6"   $��2��6/   $��2��6<   $��5 5 5 5q�6L   $��12(�6]   6�   5      5      