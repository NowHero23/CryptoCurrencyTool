   M S B A M L   `   `   `  ����b  ^PresentationFramework.Aero2, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35hKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2Microsoft.Windows.Themes  5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089   ColumnHeaderGripperStyle  �� 
TargetType �� Property �� Value �� 
TargetType �� Padding  DataGridRowStyle1)   #System.Windows.Controls.DataGridRow  panelOverColor  
Montserrat ��Name J� SnapsToDevicePixels �� CornerRadius?  9System.Windows.Controls.Primitives.SelectiveScrollingGrid � ColumnDefinitions	 � RowDefinitions?  9System.Windows.Controls.Primitives.DataGridCellsPresenter
    
ItemsPanelA  ;System.Windows.Controls.Primitives.DataGridDetailsPresenter    DetailsVisibility$   SelectiveScrollingOrientation;  5System.Windows.Controls.SelectiveScrollingOrientation   Vertical �� ConverterParameter&   System.Windows.Controls.DataGrid#   RowDetailsScrollingConverter �� 	Converter �� RelativeSource �� AncestorType:  4System.Windows.Controls.Primitives.DataGridRowHeader7  1System.Windows.Controls.DataGridHeadersVisibility
   Row!   HeadersVisibilityConverter �� Triggers P� Property P� Value  panelActiveColor  selectedRowColor ]� 
Conditions �� Property �� Value  DataGridColumnHeaderStyle1=  7System.Windows.Controls.Primitives.DataGridColumnHeader3	   -Microsoft.Windows.Themes.DataGridHeaderBorder 	  	IsPressed J� IsMouseOver 	  	IsHovered   CanUserSort 	  IsClickable    SortDirection! 	  SortDirection"   SeparatorVisibility# 	  SeparatorVisibility$   SeparatorBrush% 	  SeparatorBrush& n�Name  DataGridCellStyle1*
  $System.Windows.Controls.DataGridCell' �� 
ResourceId( �� TypeInTargetAssembly) ��Name* �Name+ J� Opacity, � Points- �� Stretch. �� Triggers/ �� 
TargetName  DataGridStyle15  /System.Windows.Controls.DataGridLengthConverter0 ��Name1   SelectAllCommand
2   AllG  ASystem.Windows.Controls.Primitives.DataGridColumnHeadersPresenter3  Name4   Column5 ��Name6 �� CanContentScroll7 ��Name8 �� ScrollableHeight9 � Maximum: �� Orientation; �� ViewportHeight< �� ViewportSize*= �� #ComputedVerticalScrollBarVisibility 	 MyCustomScrollBar> � Value? �� Mode@ �� ScrollableWidthA �� ViewportWidth,B �� %ComputedHorizontalScrollBarVisibility 
 ScrollThumbsC �NameD �� RadiusXE �� RadiusY  
trackColor  trackThumbColorF ��Name  scrollButtonsColor  ScrollButtonsG F�NameH ]�NameI ]� Thumb  CustomButtonStyle1�� 5      H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      :x,http://schemas.microsoft.com/winfx/2006/xaml     5      UthemeKclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero2  5      %�%  &	        &	     7  7  7  7  &	 c    7   7   &	 �
    (�� p    5�      $"' DataGridSelectAllButtonStyle��"(  )&	 M    7  &	
 �    &		 b    7  7  7  7  7  7  7  7  &	 j!    �� 5      "  n�6-   .�5	   
   ��  � ��$ 8��6"   �� 5
   
    � ��
 ���� 6'   �� 5   
    �@�Cursor$ SizeWE��6#   �� 5   
    � �� 5      �� 5      " n�6"   .R�5      �� #��z��6   # z��6G   5      5      5      �� 5      "    6&   .�5   
   ��  � ��8   6'   �� 5   
    � ��
 ���� 6'   �� 5   
    � ��$ 0 2 0 0q�6#   �� 5   
    � ��$ 12(�6%   �� 5   
    � ��8  6'   �� 5   
    � ��$
 auto��6"   �� 5!   
    �@J�SnapsToDevicePixels$
 true��60   �� 5"   
    �@=�ErrorTemplate 65   Z� �� 5#   
    �@  ValidationErrorTemplate 5$      �� 5%      .R�5&      �� 
���  ��$��2,0,0,0q�61   $��!��6B   $��Center=�6K   5'      5)      �� 5*   
    � �� 5+      �� 5,      "   6"   .R�5-      �� $ 
DGR_Border��6   #��z��5.      $��0q�5/      $
 True��50      $	 0 8q�51      $ 5��52      ._�53         54      �� 55   "   $
��Auto �63   �� 56   "   $��* �63   	 58      �� 59   "   $��* �60   �� 5:   "   $
��Auto �60   .+�5<        $��1��65   #��z
 5=   5   # z 5>   5     5?      $��1��67   $��1��5@   7   #y�z 5B   7    5A   7   �� *AreRowDetailsFrozen+# Z # Z  �� "  5B   7     5C      $��2��60   $ Vertical=�5D   0   y�5E   0   �� *HeadersVisibility+# Z # Z  �� "  5F      5G      5H      5J       5M   
   P� 5N       �@J�IsMouseOver$
 True��6-   . �5O      ��  � ��8  6/   �� 5P       �@�Cursor$
 Hand��6+   5Q      P� 5R       �@  
IsSelected$
 True��6,   . �5S      ��  � ��8  6/   5T      ]� 5U       5V      �� 5W       �@  
IsSelected$
 True��66   �� 5X       �@��IsSelectionActive$ False��6F   5Z      5]      �� 5^      "   6/   .�5_   
   ��  � ��$ Center=�65   �� 5b   
    � ��
 ���� 6'   �� 5c   
    � �� �#BCBEE06'   �� 5d   
    � ��$ 	10,0,0,10q�6$   �� 5e   
    � ��$ 
Montserrat)�6'   �� 5f   
    � ��$ 16(�6%   �� 5h   
    � ��$ 15 10q�6#   �� 5i   
    � �� 5j      �� 5k      "  6"   .R�5l      � .+�5m      	  #��z��65   #��z��5n   5   #��z��5o   5   # z��5p   5   # z 5q   5   # z 5r   5   # z��5s   5   #! z  5t   5   ## z" 5u   5   #% z$ 5v   5   ._�5w      �� #��z��6/   $
��True��5x   /   # z 5y   /   #��z��5z   /   5{      n� 5|      $& PART_LeftHeaderGripper��6    $
��Left=�6@   8��  6[   n� 5}      $& PART_RightHeaderGripper��6    $��Right=�6A   8�� 6]   5~      5      5�      5�      �� 5�      "  
 6'   .�5�   
   ��  � ��
 ���� 6'   �� 5�   
    � ��
 �����6'   �� 5�   
    � ��$ Center=�6.   �� 5�   
    �@�FocusVisualStyle 6-   Z� �� 5�   
    � ��$
 15 0q�6#   �� 5�   
    � ��$ 1q�6,   �� 5�   
    � �� 5�      �� 5�      " 
 6"   .R�5�      �� #��z��6   $��1q�5�      $
 True��5�      ._�5�      �� # z 6+   5�      5�      5�      5�      �� 5�      "  ��6{   .�5�   
   ��  � �� 5�      �� 5�      " ��6"   .R�5�      � .+�5�      �� $) Border��6$   #��� ��5�   $   $
 True��5�   $   � 5�      $* Arrow��6"   
���   �$��Right=�5�   "   $��8,8,3,3q�5�   "   $
+ 0.15Q�5�   "   , �   ��� ��� ��� ��� $- Uniform=�5�   "   $��Bottom=�5�   "   5�      . 5�      P� 5�       �@J�IsMouseOver$
 True��69   . �5�      �� $/ Border��67   # � ��6K    � ��5�      P� 5�       � ��$
 True��67   . �5�      �� $/ Border��65   # � ��6I    � ��5�      P� 5�       � {�$ False��67   . �5�      �� $/ Arrow��6;    � y�$ 	Collapsed=�6N   5�      5�      5�      5�      �� 5�      "   6#   .�5�   
   ��  � �� �#200F536'   �� 5�   
    � ��
 ���� 6'   �� 5�   
    � ��$ 0q�6,   �� 5�   
     �@ RowDetailsVisibilityMode$ VisibleWhenSelected=�65   �� 5�   
    � ��$
 true��6:   �� 5�   
    �@��PanningMode$ VerticalOnly=�65   �� 5�   
    �@��IsFlicksEnabled$ False��63   �� 5�   
    �@ AutoGenerateColumns$ False��60   �� 5�   
    �@ HeadersVisibility$ Column=�6.   �� 5�   
    �@ ColumnWidth$ * 6(   �� 5�   
    � ��8   6'   �� 5�   
    � ��$ 14(�6%   �� 5�   
    � ��$ 	0 10 0 10q�6#   �� 5�   
    �@ GridLinesVisibility$
 None=�60   �� 5�   
    �@ SelectionMode$ Single=�6*   �� 5�   
    �@ SelectionUnit$ FullRow=�6*   �� 5�   
    �@ CanUserAddRows$ False��6+   �� 5�   
    �@ CanUserDeleteRows$ False��6.   �� 5�   
    �@ CanUserReorderColumns$ False��62   �� 5�   
    �@ CanUserResizeColumns$ False��61   �� 5�   
    � �� 5�      �� 5�      "  6"   .R�5�      �� #��z��6   #��z��5�      #��z��5�      $ 10��5�      # z��5�      $
 True��5�      ._�5�      �� $0 DG_ScrollViewer��6'   $|�false��6@   ��5�      �� 5�   "   " ��62   .R�5�   &   �  5�   *   �� 5�   .   $
��Auto �6?   �� 5�   .   $��* �6?   �� 5�   .   $
��Auto �6?   	 5�   *   �� 5�   .   $
��Auto �6<   �� 5�   .   $��* �6<   �� 5�   .   $
��Auto �6<   .+�5�   *   �� #��Z1 61   $|�false��5�   1   ��6C   C� *�� $"' DataGridSelectAllButtonStyle��"(  +y�5�   1   �� *HeadersVisibility+# Z2 # Z  �� "  ��5�   1   �� *CellsPanelHorizontalOffset+ �� "    5�   *   $!3 PART_ColumnHeadersPresenter��6I   $��1��5�   I   y�5�   I   �� *HeadersVisibility+# Z4 # Z  �� "  �� 5�   *   $!5 PART_ScrollContentPresenter��6A   #6 z��5�   A   $��2��5�   A   $��1��5�   A   �� 5�   *   $7 PART_VerticalScrollBar��64   $��2��5�   4   #9 z8 5�   4   $: Vertical=�5�   4   $��1��5�   4   #< z; 5   4   #y�z= 5  4   #��� 	 5  4   > 5�   4   �� *VerticalOffset+$? OneWay=� �� *TemplatedParent+5  4   � 5  *   $��1��6/   $��2��6?    5  .   �� 5  2   ��6C   �� **(NonFrozenColumnsViewportHorizontalOffset+ �� "  �� 5  2   $��* �6C   .+�5	  .   �� $7 PART_HorizontalScrollBar��68   $��1��5
  8   #9 z@ 5  8   $: 
Horizontal=�5  8   #< zA 5  8   #y�zB 5  8   > 5  8   �� *HorizontalOffset+$? OneWay=� �� *TemplatedParent+5  8   5  +   5  '   5  #   .��5     �� # z 6-   5     5     5     5      5  
   ]� 5      5     �� 5      �@��
IsGrouping$
 true��66   �� 5     " �@%�IsVirtualizingWhenGrouping$ false��6X   ./�5      ��  � ��$ false��6B   5!     5#     �� 5%     "  n�6!   .�5&  
   ��  � ��
 � ���6'   �� 5'  
    � �� 5(     �� 5)     " n�6"   .R�5*     � $
C Grid��6   .+�5+     �� $��
Rectungle1��6$   $��10��5,  $   $
��auto��5-  $   $��Stretch=�5.  $   $��Stretch=�5/  $   #��z��50  $   $D 8��51  $   $E 8��52  $   53     54     56     57     �� 59     "  ��6&   .�5:  
   ��  � ��
 �  ��6'   �� 5;  
    � ��$ 12��6"   �� 5<  
    �@�Cursor$
 Hand��6#   �� 5=  
    � �� 5>     �� 5?     " ��6"   .R�5@     �� 8��  $ 8��6F   ._�5C     � $C GridRoot��6   #��� ��5D     
������ 	 5F     �� 5G     $��18��6,   �� 5H     $��0.00001* �6,   �� 5I     $��18��6,   .+�5L     �� $ 8��6%   8�� ._�5M  "   �� $F DecreaseRepeat��6/   
������ $��0q�5O  /   $��ScrollBar.LineUpCommand��5P  /   8�� #���  5R  /   .��5S  &   F� $G DecreaseArrow��6+   $��Center=�5T  +   $��Center=�5U  +   +�����g5     �    ��j ���j ��j ��g5     8�� 5W  +   5X  #   5Y     ]� 5Z     $H 
PART_Track��6$   $��1��5[  $   $|�False��5\  $   $
��True��5]  $   I 5^  "   n� 5_  &   $& Thumb��6,   8�� #��� 
 5a  ,   5c     �� 5e     $ 8��6%   8�� $��2��6d   ._�5f  "   �� $F IncreaseRepeat��6/   
������ $��0q�5h  /   $��ScrollBar.LineDownCommand��5i  /   8�� #���  5k  /   .��5l  &   F� $G IncreaseArrow��6+   $��Center=�5m  +   $��Center=�5n  +   +�����g5 ��j ���j     �        ��g5 ��j 8�� 5p  +   5r  #   5s     5t     5u     5v     5x     5y     �� 5}     "  ��6'   .�5~  
   ��  � ��
 � � �6'   �� 5  
    � ��
 �����6'   �� 5�  
    � ��$ 12(�6%   �� 5�  
    � ��$ 4q�6$   �� 5�  
    � �� 5�     �� 5�     " ��6"   .R�5�     �� $ ButtonBorder��6   #��z��5�     
���   �$��0q�5�     # z��5�     $ 12��5�     $	��2 0q�5�     ._�5�     �� $��Center=�6+   $��Center=�5�  '   5�     . 5�     P� 5�      � {�$ False��67   . �5�     �� $/ ButtonBorder��6%    � ��
 �����6U   �� 5�     $/ ButtonBorder��6%    � ��
 �����6V   �� 5�      � ��
 �����6;   5�     P� 5�      �@J�IsMouseOver$
 True��69   . �5�     �� $/ ButtonBorder��6%    � �� �	#FF1E27A56U   �� 5�     $/ ButtonBorder��6%    � ��
 ��  �6V   �� 5�      � ��
 � ���6;   5�     5�     5�     5�     5�     