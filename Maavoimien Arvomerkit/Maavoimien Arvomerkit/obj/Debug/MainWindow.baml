   M S B A M L   `   `   `  ����P  LMaavoimien Arvomerkit, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null=#clr-namespace:Maavoimien_ArvomerkitMaavoimien_Arvomerkit  5   	   &     Maavoimien_Arvomerkit.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   5local#clr-namespace:Maavoimien_Arvomerkit     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ Maavoimien arvomerkit��5	   	   $	��400��6'   $	��525��64   .��5
      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ Black��6    � Offset$ 0Q�6-   � 5      $ White��6   $ 1Q�6-   � 5      $ 	#FEC7C7C7��6   5      .+�5   
   �� -   5         ��Name$ arvomerkki_image��5      $
��Left=�6*   $	��123��6E   $��
139,64,0,0q�6R   $	��Top=�6f   $	��322��6~   $��Resources/korpraali.png��6�   �� 5   
   -   5         ��Name$ guess_textbox��5      $
��Left=�6)   $��27��6D   $��
88,223,0,0q�6P    �� TextWrapping$
 Wrap=�6d   $�� ��6x   $	��Top=�6�   $	��322��6�   $
��Bold"�6�   $��18(�6�   �� 5   
   -   5        	 ��Name$	 guess_button��5      $��Arvaa��6'   $
��Left=�67   $��206,270,0,0q�6R   $	��Top=�6g   $	��100��6   $��40��6�   6�   �� 5   
   -   5        
 ��Name$
 label��5      $��Arvomerkki: ��6   $
��Left=�66   $��
10,335,0,0q�6Q   $	��Top=�6e   $��86��6}   $
��Bold"�6�   �� 5   
   -   5        $
 currentQuestionLabel��5      $��a��6.   $
��Left=�6:   $��
88,335,0,0q�6U   $	��Top=�6i   $
��Bold"�6�   5      5      