   M S B A M L   `   `   `  ����B  >CHAOSHI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CHAOSHICHAOSHI  5   	       CHAOSHI.POSWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:CHAOSHI     5   	   -   5          � Title$  收银��5   	   $	��450��6   $	��800��6!    � WindowStartupLocation$ CenterScreen=�6-    � Icon$ shop_easyicon.ico��5	   	   .��5
      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   .+�5   
   �� $��15 20 90 20q�6   $��商品编号:��6)    �� TextAlignment$ Center=�66   $��20(�6M   6]   �� 5   
   -   5        $��TxtBoxId��5      $��0��6#   $��2��63   $��120 20 100 20q�6G    �� TextAlignment$ Center=�6^   6w   �� 5   
   $��110 20 0 20q�6   $��商品数量:��6)   $ Center=�66   $��20(�6M   $��1��6[   6m   �� 5   
   -   5        $��TxtBoxAmount��5      $��2��6&   $��12 20 90 20q�66   $ Center=�6K   6d   �� 5   
   -   5        $��BtnAdd��5      $��3��6   $��10 20 80 20q�6/   $��添加��6D   $��20(�6Q    �� 	IsDefault . 6�   �� 5   
   -   5        $��	txtBlkPdf��5      $��1��6%   $��4��62   $��4��6F   $��15q�6W   ���	#FFD7D5D5���	#FF6A8DF06�   �� 5    
   $��5��6   $��15 15 120 15q�6!   $��
会员号:��67   $��20(�6C   $ Center=�6Q   6k   �� 5!   
   -   5        $��	TxtBoxVip��5!      $��5��6#   $��90,14.6,0.4,27q�60   $ Center=�6H   6a   �� 5"   
   -   5        $��BtnDiscount��5"      $��5��6%   $��1��62   $��15 15 130 15q�6B   $��折扣��6X   $��20(�6e   6�   �� 5#   
   $��5��6   $��1��6!   $��80 15 50 15q�61   $��总价格：��6F   $��20(�6R   $ Center=�6`   6y   �� 5$   
   -   5        $��TxtBoxTotalPrice��5$      $��0��6   $��5��63   $��2��6@   $��15.2,14.6,15.2,27q�6P   $ Center=�6k   6�   �� 5%   
   -	   5        $��
BtnCheckIn��5%      $��5��6#   $��3��60   $��15 15 120 15q�6@   $��确认付款��6V   6�   �� 5&   
   -
   5        $��BtnPrint��5&      $��5��6!   $��3��6.   $��120 15 15 15q�6>   $��打印小票��6T   6|   5L      5N      