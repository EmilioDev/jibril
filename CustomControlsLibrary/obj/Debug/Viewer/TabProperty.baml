   M S B A M L   `   `   `  ����P  LCustomControlsLibrary, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:CustomControlsLibrary.ViewerCustomControlsLibrary.Viewer  5   	   .    (CustomControlsLibrary.Viewer.TabProperty   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   <local*clr-namespace:CustomControlsLibrary.Viewer     5   	     � Title$  TabProperty��5   	   $	��300��6   $	��300��6*   .��5	      �  � RowDefinitions 5
   
   �� 5      6   �� 5      6    � ColumnDefinitions 5   
   �� 5      $
��60px �6   6.   �� 5      6!    � 	Resources 5   
    �� 
TargetType �� Property �� Value��%Z   '��       �� 5      " ��6   .�5      ��  � ��$ Right=�68   6H   5      5      .+�5   
   �� $��
Tab Title:��6   $��0��6%   $��0��62   $��25��6B   �� 5   
   -   5        $��txtTitle��5      $��0��6"   $��1��6/   $��25��6?   �� 5   
   $��1��6   $��2��6"    �� Orientation$ 
Horizontal=�66   .+�5      �� -   5        $��btnOK��5   "   $��OK��6    �� 	IsDefault . $��23��6@   6b   �� 5      -   5        $��	btnCancel��5   &   $��Cancel��6   	 �� IsCancel	 . $��23��6G   6U   5      5      5      