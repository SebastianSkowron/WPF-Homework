   M S B A M L   `   `   `  ����  Laboratorium5    UserInput.Wpf.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  
MainWindow��5   	   $	��480��5   	   $	��640��5	   	   ��5
      �� 5   
    �� ImageSource$ 	backg.png��6   .��5      � .+�5   
   �� -   5         ��Name$ CalculationGrid��5      $��Center=�6.   $��Center=�6I   .+�5      �� -   5         ��Name$ FirstNumberBox��5      $��0��6.   $	��200��67   
����  �$��24(�6U   $��Consolas)�6c    �� TextAlignment$ Center=�6y   $��Center=�6�   6�   �� 5      $��10q�6   $��Center=�6%    � 	Resources 5       �� 
TargetType �� Property �� Value��%T   '	�       �� 5      " 	�6   .�5      ��  � ��
 � ���67   5      5      .+�5      	� -   5        $	��Add��5      	 d� 	IsChecked$
	 TrueY�6,   
 	� 	GroupName$
 MathOperator��6=   6V   	� 5      -   5        $��Subtract��5      $
 MathOperator��61   6J   	� 5      -   5        $��Multiply��5      $
 MathOperator��61   6J   	� 5      -   5        $��Divide��5      $
 MathOperator��6/   6H   5      �� 5"      $"��Use Slider to set 2nd number��6   $��24(�6<   $��Center=�6J   �� 5$      -   5        $ SecondNumberBox��5$      $��0��6/   $��24(�68   
����  �$	��200��6X    �� 
IsReadOnly . $��Consolas)�6v   $ Center=�6�   $��Center=�6�   6�   �� 5&      -   5         ��Name$ SecondNumberSlider��5&       � Minimum$	 -10Q�61    � Maximum$ 10Q�6?    �� TickFrequency$
 0.01Q�6L   $	��200��6a   $��0,5,0,10q�6m   6   ]� 5(       5)      ��%~   '��       �� 5*      " ��6   .�5+      ��  � �� �#c0c0c067   �� 5,       � ��
 � ���67   5-      5.      .+�5/      �� -	   5         ��Name$ IncludeDateCheckBox��5/      $&�� Include Date and Time in results��68   $��Center=�6�   50      (  "System.Windows.Controls.DatePicker  52      -
   5          Name$ CalculationDatePicker��52      $y�	Collapsed=�68   $��Center=�6O   $��	0,10,0,10q�6l   �� 54      -   5        $��Calculate Results��54      $��Center=�61   $
��0,10q�6k   �� 56      -   5         ��Name$ ResultsTextBlock��56      $	��---��62   $��22(�6=   $
��Bold"�6K   $��Consolas)�6]   $��Center=�6s   $��Center=�6�   57      58      59      