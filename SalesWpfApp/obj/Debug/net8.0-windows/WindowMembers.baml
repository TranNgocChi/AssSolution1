   M S B A M L   `   `   `  ����F  BSalesWpfApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:SalesWpfAppSalesWpfApp  5          SalesWpfApp.WindowMembers   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:SalesWpfApp     5        N� Title$  WindowMembers��5	      .��5      � .+�5   
   ]� $	��Top=�6   $��10q�6,   .+�5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $��4* �6   �� 5      $��* �6   .+�5   
   �� 
����ح� �� Orientation$ Vertical=�6,   $
��Left=�6C   $	��400��6^   .+�5      �� -   5        $��lbTitle��5      
���  ��$��DemiBold"�64   $��20(�5      $��Member Information��6   �� 5      -   5        $��
lbMemberId��5      $��	Member Id��6&   �� 5      -   5        $��txtMemberId��5      $��Stretch=�6+   $��25��6I   ��5      ��  �� Path$ MemberId� �� Mode$ OneWay=� � DataContext 5      ��  �� ElementName$ 	lvMembers��$ SelectedItem��� 5      -   5        $��lbEmail��5      $��Email��6#   �� 5       -   5        $��txtEmail��5       $��Stretch=�6&   $��25��5!      ��5"      �� $ Email�$ OneWay=� 5#      �� $ 	lvMembers��$ SelectedItem��� 5&      -   5        $��lbCompanyName��5&      $��Company Name��6)   �� 5'      -   5        $��txtCompanyName��5'      $��Stretch=�6,   $��25��5(      ��5)      �� $ CompanyName�$ OneWay=� 5*      �� $ 	lvMembers��$ SelectedItem��� 5-      -   5        $��lbCity��5-      $
��City��6"   �� 5.      -	   5        $��txtCity��5.      $��Stretch=�6%   $��25��5/      ��50      �� $
 City�$ OneWay=� 51      �� $ 	lvMembers��$ SelectedItem��� 54      -
   5        $��	lbCountry��54      $��Country��6%   �� 55      -   5        $��
txtCountry��55      $��Stretch=�6(   $��25��56      ��57      �� $ Country�$ OneWay=� 58      �� $ 	lvMembers��$ SelectedItem��� 5;      -   5        $��
lbPassword��5;      $��Password��6&   �� 5<      -   5        $��txtPassword��5<      $��Stretch=�6)   $��25��5=      ��5>      �� $ Password�$ OneWay=� 5?      �� $ 	lvMembers��$ SelectedItem�5A      �� 5D   
   $��1��6   $ 
Horizontal=�6"   $
��Left=�6;   .+�5E      �� -   5         ��Name$ btnLoad��5E      $��10q�6&   $��80��62   $
��Load��6=   5F   
   �� 5G      -   5        $ 	btnInsert��5G      $��10q�6(   $��80��64   $��Insert��6?   5H   
   �� 5I      -   5        $ 	btnUpdate��5I      $��10q�6(   $��80��64   $��Update��6?   5J   
   �� 5K      -   5        $ 	btnDelete��5K      $��10q�6(   $��80��64   $��Delete��6?   5L   
   5M      �� 5P      -   5        $��	lvMembers��5P   (   $��2��6   $
��Auto��69   $
��Auto��6F    �� View 5Q      �� 5R      .P�5S      �� $��	Member ID��6-   	 �� Width$		 100��6@   
 �� DisplayMemberBinding
 5T      �� $ MemberId��� 5U      $��Email��6-   $		 200��6<   
 5V   !   �� $ Email��� 5W      $��CompanyName��6-   $		 200��6B   
 5X      �� $ CompanyName��� 5Y      $
��City��6-   $		 200��6;   
 5Z      �� $
 City��� 5[      $��Country��6-   $		 200��6>   
 5\      �� $ Country��� 5]      $��Password��6-   $		 200��6?   
 5^      �� $ Password�5_      5a      5c      5d      5e      5f      