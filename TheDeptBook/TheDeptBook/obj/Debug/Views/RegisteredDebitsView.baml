   M S B A M L   `   `   `  ����F  BTheDeptBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:TheDeptBookTheDeptBook  5      &     TheDeptBook.RegisteredDebitsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:TheDeptBook     5      .��5	      �   � RowDefinitions  5
   
   �� 5      $	��11* �6   �� 5      $	��69* �6    � ColumnDefinitions 5   
   �� 5      $
��222* �6   �� 5      $
��223* �6   .+�5   
   �� .+�5      �� $��Center=�6   $��Center=�65   $��0,0,0,10q�6P   ��6b   ��  �� Path$ 
SearchName�6�   �� 5       �� Orientation$ 
Horizontal=�6   .+�5      �� $��20,0,0,0q�6   .��6*   	Amount:63   �� 5      $��
180, 0,0,0q�6   .��6,   Date:63   5      5      �� 5   
   $��Center=�6   $ 
Horizontal=�60   $��1��6I   $��9.6,14,10,14.8q�6Y   .+�5      �� .��6   Name:6   �� 5      -   5        $��tbSearchName��5      $	��100��6*   $��	10,0,10,0q�69   ��6L   �� $ 
SearchName�6o   �� 5      $��20��6   ��6$   �� *SearchDebtorCommand+.��6L   Search6T   5      �� 5   
   $��10q�6   $��1��6   ��6+   �� *Transactions+��5      �� 5       .R�5!      �� 
�������
�������$��2q�6K   ._�5"      �� $ 
Horizontal=�6%   $��Center=�6>   .+�5#      �� $��5,5,70,5q�6(   ��6:   �� *Amount+�� 5$      $��70,5,5,5q�6(   ��6:   �� *Date+5%      5&      5'      5)      �� 5*   
   $��1��6   $��1��6"   .+�5+      �� $ 
Horizontal=�6   .+�5,      �� $��
10,10,0,10q�6   .��6,   Value:64   �� 5-      $	��120��66   $��10q�6E   ��6   �� $ Value�6S   5.      �� 5/      $��40, 10, 40, 0q�6   ��6,   �� *AddValueCommand+.��6P   	Add Value6[   50      51      52      