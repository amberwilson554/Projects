   M S B A M L   `   `   `  ����F  BCoffeeOrder, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:CoffeeOrderCoffeeOrder  5   	       CoffeeOrder.MainWindow   5   	   W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:CoffeeOrder     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��40* �6   �� 5      $	��40* �6   �� 5      $	��37* �6   .+�5   
   �� -   5         ��Name$ Combo��5      $
��Left=�6"   $��4,68,0,0q�6=   $	��Top=�6O   $	��120��6g   $��1��6s   .@�5      �� -   5         ��Name$ Latte��5      $��Latte��6*    �� 
IsSelected$
 True��6:   6L   �� 5      -   5        $ 	Capuccino��5      $��
Cappuccino��6/   $ False��6D   6W   �� 5      -   5        $ 	Americano��5      $��	Americano��6/   $ False��6C   6V   �� 5      -   5        $ Espresso��5      $��Espresso��6.   $ False��6A   6T   5      �� 5   
   $��Type of Coffee: ��6   $
��Left=�6+   $��	97,66,0,0q�6F   $	��Top=�6Y   $��0��6q   �� 5   
   $��Size:��6   $��0��6    $��1��6-   $��207,56,10,25q�6=   	� 5    
   -   5         	�Name$ Small��5       $��Small��6%   $��2��65   $��0��6E   $��10,62,135,20q�6R   6h   	� 5!   
   -   5        $ Medium��5!      $��Medium��6&    d� 	IsChecked$ FalseY�67   $��2��6I   $��0��6Y   $��83,63,41,19q�6f   6{   	� 5"   
   -   5        $ Large��5"      $��Large��6%   $ FalseY�65   $��2��6G   $��0��6W   $��167,63,-43,19q�6d   6{   �� 5$   
   -	   5         ��Name$ Sugar��5$      $��Sugar��6"   $ FalseY�62   $��2��6E   $
��Left=�6U   $��	16,18,0,0q�6p   $��1��6�   $	��Top=�6�   6�   �� 5%   
   -
   5        $ Cream��5%      $��Cream��6"   $ FalseY�62   $��2��6E   $��Center=�6U   $��1��6r   $	��Top=�6   $��0,18,0,0q�6�   6�   �� 5'   
   $��Order Summary:��6   $��1��6)   $��1��69   $��160,66,10,10q�6F   $
��Bold"�6\   �� 5(   
   -   5        	 ��Name$	 TextBlock_1��5(      $��1��6)   $��1��66   $��2��6F   $��273,108,0,108q�6Z   $��3��6q   ��6�   �� 
 �� Path$
 CoffeeOrder� �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�5)      �� 5*   
   -   5         ��Name$ 
PlaceOrder��5*      $��Order Coffee��6%   $��1��6<   $��3��6L   $��50,35,50,35q�6Y   6n   5,      51      