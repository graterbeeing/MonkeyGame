   M S B A M L   `   `   `  ����D  @MonkyGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:MonkyGame.ViewMonkyGame.View  5   	       MonkyGame.View.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:MonkyGame.View     5   	   -   5          �Name$  
HomeWindow��5   	    � Title$ 
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5      $��2* �6   .+�5   
   �� $��Center=�6   $	��200��6-   $��Center=�6:   $	��200��6U   $!��/Resources/monkyToRight.png��6a   �� 5   
   $��Center=�6   $	��400��6-   $��Center=�6:   $	��500��6U   $��1��6a   $��/Resources/chalkboard.png��6q   �� 5   
   $��1��6    �� Orientation$ 
Horizontal=�6%   $��Right=�6>   $��Bottom=�6Z   $��60,65q�6u   .+�5      	� -   5        $��addition��5       	� 	GroupName$ QuestionType��6-   $��19(�6F   $��Ink Free)�6T   
�������6}   	� 5      -   5        $��subtraction��5      $ QuestionType��60   $��19(�6I   $��Ink Free)�6W   
�������6�   	� 5      -   5        $��multiplication��5      $ QuestionType��63   $��19(�6L   $��Ink Free)�6Z   
�������6�   	� 5      -   5        $��deviding��5      $ QuestionType��6-   $��19(�6F   $��Ink Free)�6T   
�������6}   5      �� 5   
   $��1��6   $��Magic in numbers��6    $��Center=�6;   $��	0,100,0,0q�6X   $	��Top=�6k   $��Ink Free)�5      
�������$��35(�69   $
��Bold"�6G   �� 5   
   -   5         ��Name$ title��5      $��1��6!    �� TextWrapping$
 Wrap=�61   $��Center=�6E   $��0,0,0,60q�6b   $��Center=�6t   $	��200��6�    �� 
IsReadOnly . $��18(�6�   
�������$��Ink Free)�6�   ��6�   Z� ��6�   Z� 6�   �� 5   
   -   5        $��1��5      $��Rules��6!   $
��Left=�61   $��133,100,0,0q�6L   $��Center=�6a   $	��100��5      $��45��6   $��4,4,4,4q�6)   
���E�� � 	Resources 5      	 �� 
TargetType
 �� Property �� Value��%_   '��       �� 5      "	 ��6   .�5      �� 
 �@��CornerRadius$ 12��65   5      5       5!      �� 5"   
   -   5        $��1��5"      $
��Play��6!   $
��Left=�60   $��303,100,0,0q�6K   $��Center=�6`   $	��100��5#      $��45��6   $��4,4,4,4q�6)   
���E�� 5$      ��%_   '��       �� 5%      "	 ��6   .�5&      �� 
 �@��CornerRadius$ 12��65   5'      5(      5)      �� 5*   
   -	   5         ��Name$ Score��5*      $��1��6   $��your score:��6/   $��Center=�6E   $��	0,279,0,0q�6b   $	��Top=�6u   
�������$y�	Collapsed=�6�   5-      5/      