   M S B A M L   `   `   `  ����M  ICryptoCurrencyTool, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:CryptoCurrencyTool.ViewsCryptoCurrencyTool.Views  5      M+clr-namespace:CryptoCurrencyTool.ViewModelsCryptoCurrencyTool.ViewModels  5      _4clr-namespace:CryptoCurrencyTool.Resources.Languages&CryptoCurrencyTool.Resources.Languages  5	      '    !CryptoCurrencyTool.Views.HomeView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      8local&clr-namespace:CryptoCurrencyTool.Views     5      :vm+clr-namespace:CryptoCurrencyTool.ViewModels     5      X TFontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10fFfa=http://schemas.awesome.incremented/wpf/xaml/fontawesome.sharp  5      ?lang4clr-namespace:CryptoCurrencyTool.Resources.Languages  5	      .��5      �   � RowDefinitions  5   
   �� 5      $��50 �6   �� 5      .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      $��* �6#   �� 5      $	��120 �6#   .+�5      ��  �� Orientation$ 
Horizontal=�6   $	��Top=�5      $��0��5       .+�5!      !  FontAwesome.Sharp.IconImage  �  �FontAwesome.Sharp.IconImageBase`1[[FontAwesome.Sharp.IconChar, FontAwesome.Sharp, Version=6.3.0.0, Culture=neutral, PublicKeyToken=d16d1e4e568ec10f]]   Icon$ Search=�6   $��20��6-   $��20��69      plainTextColor3   
Foreground# [  6D   �� 5"      $��13(�5#      $��24��5$      $	��300��5%      
������ $��Medium"�5'      $��
Montserrat)�5(      #��[  5)       �� 
CaretBrush# [  5*      #��[  5+      $��0,0,0,1q�5,      $��Center=�5-      $��5,5,0,0q�5.      ��5"      �� *
SearchText+ �� UpdateSourceTrigger$ PropertyChanged=�5.   -   5/      �� 50      $��1��6   1   +CryptoCurrencyTool.Resources.Languages.Lang   search#��Z 53      $��12(�54      $��
Montserrat)�55       � Cursor$
 Hand��56      $��0q�57      
�������$	��Top=�59      ��51      �� *SearchCommand+��5:      �� 5;      	 �� 
TargetType"	 ��6   .�5<      �� 
 �� Property
 � �� �� Value �#773DFF67   �� 5=      
 � �� 5>      �� 5?   "    �� 
TargetType" ��62   .R�5@   &   �� $��30��6-    �� CornerRadius$ 15��5A   -   #��z��5B   -   ._�5C   *   �� $��Center=�6;   $��Center=�6V   5D   '   5E   #   5G       �� Triggers 5H      P� 5I       P� Property �@J�IsMouseOver P� Value$
 True��6=   . �5J   "   �� 
 � �� �#836EFB6?   5K      5M      5O      5P      �� 5R   
   $��1��5S      ���#200F53$ 10��5U       �� Padding$ 10q�5V      ._�5X      &   System.Windows.Controls.DataGrid    DataGridRowStyle1   RowStyle# �  6   ���#200F53
�������  DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  5[        DataGridCellStyle1   	CellStyle# �  5\        DataGridStyle1#���  5]         
IsReadOnly$
 True��5^         AutoGenerateColumns$ False��5_      ��5`      �� *CryptoCurrencies+   Columns 5a      0  *System.Windows.Controls.DataGridTextColumn  5c         rank,  &System.Windows.Controls.DataGridColumn   Header# Z 6)   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6L   �� *Rank+  5d      	   id# Z 6)    6J   �� *Id+  5e         symbol# Z 6)    6N   �� *Symbol+  5f         name# Z 6)    6L   �� *Name+  5g         	price_usd# Z 6)    6Q   �� *
PriceUsd+  5h      $ Explorer��6)    6;   �� *
Explorer+4  .System.Windows.Controls.DataGridTemplateColumn  5i         controls# Z 6-       CellTemplate  5j      �� 5k      .R�5m   "   �� $ 
Horizontal=�6-   $��Center=�6F   .+�5o   &   ��   CustomButtonStyle#���  5q   -   ���	#FF2D39FB��5o   -   �� *DataContext.OpenUrlCommand+! �� RelativeSource! �� " �� AncestorType""  ��5p   -   �� *
Explorer+.��5t   *     $ Globe=�67   $��15��6D   
 �����6P   5v   '   �� 5x   &   #   history#��Z# 6-   ��6T   �� *$"DataContext.NavigateHistoryCommand+! �� ""  ��6�   �� *Id+5{   #   5|      5~      5�      5�      5�      5�      