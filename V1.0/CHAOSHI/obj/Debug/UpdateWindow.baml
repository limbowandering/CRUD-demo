   M S B A M L   `   `   `  ����B  >CHAOSHI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:CHAOSHICHAOSHI  5   	       CHAOSHI.UpdateWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:CHAOSHI     5   	   -   5          � Title$  更新商品��5   	   $	��450��6   $	��800��6#    � Icon$ shop_easyicon.ico��5	   	    � WindowStartupLocation$ CenterScreen=�6"   .��5
      �  � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   �� 5      6!   .+�5    
   &   System.Windows.Controls.DataGrid  -   5        $��DataGridGoods��5       $��0��5!      $��6��5"      $��0��5#      $��4��5$         CanUserAddRows .     RowDetailsVisibilityMode$ VisibleWhenSelected=�5&         SelectionMode$ Single=�5'         AutoGenerateColumns .  	   AlternatingRowBackground	 �	#FFF7F3F3
   RowHeaderWidth$
 80Q�5*         
IsReadOnly .     RowStyle 5.      �� 5/       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6    �� Triggers 50      P� 51       P� Property �@J�IsMouseOver P� Value . . �54      ��  �� Property � �� �� Value
 �  ��6I   55      57         Columns 5:      0  *System.Windows.Controls.DataGridTextColumn  5;      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ 80 6%      Header$ 商品编号��6p      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 60   �� *	goodsID+ �� UpdateSourceTrigger$ PropertyChanged=�6�     5<      $ 80 6%   $ 商品名称��6r    .  60   �� *	goodsName+$ PropertyChanged=�6�     5=      $ 80 6%   $ 商品价格��6v    .  60   �� *goodsPriceOut+$ PropertyChanged=�6�     5>      $ 80 6%   $ 商品库存��6t    .  60   �� *goodsAmount+$ PropertyChanged=�6�     5?      $ 80 6%   $ 商品进价��6u    .  60   �� *goodsPriceIn+$ PropertyChanged=�6�     5@      $ 80 6%   $ 商品单位��6r    .  60   �� *	goodsUnit+$ PropertyChanged=�6�   5B      �� 5C   
   $
��Left=�6   $��	10,26,0,0q�6/   $��4��6B   $
��Wrap=�6O   $��商品ID：��6c   $	��Top=�6p   $��20��6�   $��50��6�   �� 5D   
   -   5        $��TxtBoxId��5D   -   $
��Left=�6    �� TextAlignment$ Center=�6=   $��20��6T   $��
0.4,26,0,0q�6`   $��4��6t    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��110��6�   $��1��6�   �� 5E   
   $��2��6   $
��Left=�6$   $��22.8,26,0,0q�6?   $��4��6T   $
��Wrap=�6a   $��	售价：��6u   $	��Top=�6�   $��20��6�   $��64��6�   �� 5F   
   -   5        $��TxtBoxPriceOut��5F      $ Center=�6(   $��3��6?   $
��Left=�6O   $��20��6j   $��32.2,26,0,0q�6v   $��4��6�   $
 Wrap=�6�   $	��Top=�6�   $��71��6�   �� 5G   
   -   5        $��	BtnUpdate��5G      $��修改��6"   $��4��6/   $
��Left=�6?   $��27.6,28,0,0q�6Z   $��4��6o   $	��Top=�6|   $��75��6�   6�   5I      5J      