   M S B A M L   `   `   `  ����D  @PongRemix, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PongRemix	PongRemix  5   	       PongRemix.DBWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:PongRemix     5   	     � Title$  Database Window Stuff��5   	   $	��350��6'   $	��409��64   .��5	      � $��0,0,2,0q�6    � ColumnDefinitions 5
   
   �� 5      �� 5      $��0* �6   �� 5      $��0* �6   .+�5   
   �� -   5         ��Name$ btnAddToListBox��5      $��View Scores��6*   $
��Left=�6@   $��	20,12,0,0q�6[   $	��Top=�6n   $	��175��6�   $��21��6�    �� 	IsDefault . ��5      
� 5      .��5      �  � Color$ 	#FF2396B8��6#    � Offset$ 1Q�65   � 5      $ 	#FF99B4D1��6#   5      ��5      �� 5      5      �� 5   
   -   5        $ btnExitDone��5      $
��Done��6&   $
��Left=�65   $��297,284,0,0q�6P   $	��Top=�6e    J� RenderTransformOrigin$ 
0.47,0.221&�6}   $��78��6�    �� IsCancel . $��21��6�   ��5      
� 5      .��5      � $ 	#FF2396B8��6#   $ 1Q�65   � 5      $ 	#FF99B4D1��6#   5      ��5!      �� 5"      5$      �� 5'   
   -   5         ��Name$ 	lvResults��5'      $��center=�6&   $	��232��6C   $��
20,38,24,0q�6P   $	��Top=�6d   $	��355��6|   	 �� View	 5(      �� 5)      .P�5*      �� 
 �� Width$	
 120��6%    �� DisplayMemberBinding 61   �� *Place+��5+      �� 5,      .��63   Place6:   5.      �� 5/      $
 80��6%    60   �� *Name+��50      �� 51      .��64   Name6:   53      �� 54      $
 80��6%    60   �� *Score+��55      �� 56      .��64   Score6;   58      59      5;      5>      5?      