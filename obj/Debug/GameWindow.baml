   M S B A M L   `   `   `  ����D  @PongRemix, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PongRemix	PongRemix  5   	       PongRemix.GameWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:PongRemix     5   	   -   5          � Title$  
MainWindow��5   	   $	��650��6   $	��700��6)   .��5	      �� 
���   �$��10q�6!   ._�5
   
   � .+�5      �� -   5        $��myGameCanvas��5      $	��650��6)   $	��500��65    J� Opacity$	 0.6Q�6B   $��Right=�6P   $��
0,50,11,49q�6l   ��5      �� 5       �� ImageSource$ background_1.gif��6!   .+�5      A� -   5        $��gameBall��5      
��� � �$��30��68   $��30��6C    �� Left$ 30��6O   
 �� Top$	 465��6`   $ 1Q�6q   �� 5      -   5        $��
gamePaddle��5      $��25��6.   $	��100��69   $ 5��6F   $	 200��6V   $ 1Q�6g   ��5      �� 5      $ 
paddle.jpg��6%   5      5      �� 5      -   5         ��Name$ scoreCounter��5      $��Right=�6,    �� TextWrapping$
 Wrap=�6H   $��0��6\   $	��Top=�6e   $��45(�6}   $
��Bold"�6�   $��0q�6�   $��
0,50,342,0q�6�   $	 0.5Q�6�   {�.  6�   �� 5      -   5         ��Name$ btnStartGame��5      $��Start��6+   $
��Left=�6;   $��	11,24,0,0q�6V   $	��Top=�6i   $��75��6�   6�   �� 5      -   5        $ btnStopGame��5      $��Pause��6*   $
��Left=�6:   $��	93,24,0,0q�6U   $	��Top=�6h   $��75��6�   6�   �� 5      -   5        $ btnResetGame��5      $��Reset��6+   $
��Left=�6;   $��
173,24,0,0q�6V   $	��Top=�6j   $��75��6�   6�   5      5      5      