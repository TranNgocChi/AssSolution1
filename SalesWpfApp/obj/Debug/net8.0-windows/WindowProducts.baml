   M S B A M L   `   `   `  ����F  BSalesWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SalesWpfAppSalesWpfApp  5           SalesWpfApp.WindowProducts   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:SalesWpfApp     5        N� Title$  WindowProducts��5	      .��5      � .+�5   
   ]� $	��Top=�6   $��10q�6,   .+�5      �  � RowDefinitions 5      �� 5      $
��Auto �6$   �� 5      $��* �6$   �� 5      $��4* �6$   �� 5      $��* �6$   .+�5      �� 
����ح� �� Orientation$ Vertical=�64   $
��Left=�6K   $	��400��6f   .+�5      �� -   5        $��lbTitle��5      
���  ��$��DemiBold"�6<   $��20(�5      $��Product Information��6   �� 5      -   5        $��lbProductId��5      $��
Product Id��6/   �� 5      -   5        $��txtProductId��5       $��Stretch=�64   $��25��6R   ��5      ��  �� Path$ 	ProductId� �� Mode$ OneWay=� � DataContext 5      ��  �� ElementName$ 
lvProducts��$ SelectedItem��� 5      -   5        $��lbProductName��5      $��Product Name��61   �� 5       -   5        $��txtProductName��5       $��Stretch=�64   $��25��5!      ��5"      �� $ ProductName�$ OneWay=� 5#      �� $ 
lvProducts��$ SelectedItem��� 5&      -   5        $��lbCategoryId��5&      $��
CategoryId��60   �� 5'      -   5        $��txtCategoryId��5'      $��Stretch=�63   $��25��5(      ��5)      �� $ 
CategoryId�$ OneWay=� 5*      �� $ 
lvProducts��$ SelectedItem��� 5-      -   5        $��lbWeight��5-      $��Weight��6,   �� 5.      -	   5        $��	txtWeight��5.      $��Stretch=�6/   $��25��5/      ��50      �� $ Weight�$ OneWay=� 51      �� $ 
lvProducts��$ SelectedItem��� 54      -
   5        $��lbUnitPrice��54      $��	UnitPrice��6/   �� 55      -   5        $��txtUnitPrice��55      $��Stretch=�62   $��25��56      ��57      �� $ 	UnitPrice� �� StringFormat$ {0:N3}��$ OneWay=� 59      �� $ 
lvProducts��$ SelectedItem��� 5<      -   5        $��lbUnitsInStock��5<      $��UnitsInStock��62   �� 5=      -   5        $��txtUnitsInStock��5=      $��Stretch=�65   $��25��5>      ��5?      �� $ UnitsInStock�$ OneWay=� 5@      �� $ 
lvProducts��$ SelectedItem�5B      �� 5E      $��1��6   $ 
Horizontal=�6*   $
��Left=�6C   .+�5F      �� -   5         ��Name$ btnLoad��5F      $��10q�6.   $��80��6:   $
��Load��6E   5G   
   �� 5H      -   5        $ 	btnInsert��5H      $��10q�60   $��80��6<   $��Insert��6G   5I   
   �� 5J      -   5        $ 	btnUpdate��5J      $��10q�60   $��80��6<   $��Update��6G   5K   
   �� 5L      -   5        $ 	btnDelete��5L      $��10q�60   $��80��6<   $��Delete��6G   5M   
   5N      �� 5Q      -   5        $��
lvProducts��5Q   (   $��2��6   $
��Auto��6:   $
��Auto��6G   	 �� View	 5R      �� 5S      .P�5T      �� $��	ProductId��6-   
 �� Width$	
 200��6@    �� DisplayMemberBinding 5U      �� $ 	ProductId��� 5V      $��ProductName��6-   $	
 200��6B    5W   !   �� $ ProductName��� 5X      $��
CategoryId��6-   $	
 200��6A    5Y      �� $ 
CategoryId��� 5Z      $��Weight��6-   $	
 200��6=    5[      �� $ Weight��� 5\      $��	UnitPrice��6-   $	
 200��6@    5]      �� $ 	UnitPrice��� 5^      $��UnitsInStock��6-   $	
 200��6C    5_      �� $ UnitsInStock�5`      5b      5d      5e      5f      5g      