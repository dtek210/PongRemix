   M S B A M L   `   `   `  ����D  @PongRemix, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PongRemix	PongRemix  5   	       PongRemix.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:PongRemix     5   	   -   5          �Name$  
HomeScreen��5   	    � Title$ gameHome��5   	   $	��450��6   $	��800��6'   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0.901Q�6-   � 5      $ 	#FFDC6A6A��6   5      .+�5   
   o� $	��Top=�6   $��30��6'   ��63   Z� .@�5      m� -   5         m�Name$ mnuFile��5      $��_File��6(   $��32��67   $��45��6C   $��11(�6N   ��6\   Z� .@�5      m� -   5        $ mnuFileStart��5      $#��_Start                ALT + S��61   $��32��6Y   $��11(�6e   6t   m� 5      -   5        $ mnuScoresDB��5      $��Score _DB        ALT + D��60   $��32��6S   $��11(�6_   6m   m� 5      -   5        $ mnuFileExit��5      $$��_Exit                  ALT + E��60   $��32��6Y   $��11(�6e   5      m� 5      -   5        $ mnuEdit��5      $��_Edit��6(   $��32��67   $��45��6C   $��11(�6N   ��6\   Z� .@�5      m� -   5        $ mnuEditRestart��5      $��_Restart        ALT + R��63   $��32��6U   $��11(�6a   5      m� 5      -   5        $ mnuHelp��5      $��_Help��6(   $��32��67   $��45��6C   $��11(�6N   ��6\   Z� .@�5      m� -	   5        $ mnuHelpAbout��5      $��_About         ALT + A��61   $��32��6R   $��11(�6^   5      5      �� 5    
   -
   5         ��Name$ btnStartGame��5       $��Start��6'   $
��Left=�67   $��335,254,0,0q�6R   $	��Top=�6g   $��75��6    �� 	IsDefault . 6�   �� 5!   
   -   5        	 ��Name$	 txtInputName��5!      $
��Left=�6(   $��320,189,0,0q�6C   
 �� TextWrapping$

 Wrap=�6X   $	��Top=�6l   $��22��6�   $	��125��6�   $��2q�6�   ��6�   Z� 6�   �� 5"   
   $��Enter name:��6   $
��Left=�6&   $��240,185,0,0q�6A   $	��Top=�6V   $
��Bold"�6n   �� 5#   
   $��PONG ��6   $
��Left=�6    $��
285,31,0,0q�6;   $	��Top=�6O   $
��Bold"�6g   $��60��6y   $	��173��6�   $��45(�6�   �� 5$   
   $��By Daniel Tekle��6   $
��Left=�6*   $��
420,70,0,0q�6E   $	��Top=�6Y   $
��Bold"�6q   $��Prestige Elite Std)�6�   5&      5'      