   M S B A M L   `   `   `  ����C  ?MathGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:MathGame.PlayersMathGame.Players  5      I EMathGame.Model, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG4clr-namespace:MathGame.Model;assembly=MathGame.ModelMathGame.Model 5      9!clr-namespace:MathGame.ConvertersMathGame.Converters  5	      "    MathGame.Players.AddEditView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:MathGame.Players     5      FModel4clr-namespace:MathGame.Model;assembly=MathGame.Model     5      2conv!clr-namespace:MathGame.Converters     5	        � 	Resources  5      ?   9MathGame.Converters.NegatableBooleanToVisibilityConverter   VisConverter  NegVisConverter   Negate �� 
TargetType �� Triggers P� Property P� Value �� Property �� Value �� Self	 �� RelativeSource
 �� Path��%  &	        &	      '�� 1       5   
   65     5   
    . 5   5   �� 5   
   " ��6    5      P� 5       �@=�HasError . . �5      ��  �@�ToolTip 5      �� #	 Z $2
 ,(Validation.Errors).CurrentItem.ErrorContent�5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5!      � -   5         �Name$ grid1��5!      $
��Left=�6A    � DataContext 6"   �� *Player+ � ColumnDefinitions 5"      �� 5#      $
��Auto �6'   �� 5$      $
��Auto �6'    5&      �� 5'      $
��Auto �6$   �� 5(      $
��Auto �6$   .+�5*      �� $��First Name:��6   $��0��6.   $
��Left=�6>   $��3q�6Y   $��0��6d   $��Center=�6q   �� 5+      -   5         ��Name$ firstNameTextBox��5+      $��1��64   $
��Left=�6D   $��23��6_   $��3q�6k   $��0��6v   $��Center=�6�   $	��120��6�   ��6�   �� *	FirstName+" �� ValidatesOnNotifyDataErrors . 6�   �� 5,      $��
Last Name:��6   $��0��6-   $
��Left=�6=   $��3q�6X   $��1��6c   $��Center=�6p   �� 5-      -   5        $ lastNameTextBox��5-      $��1��6/   $
��Left=�6?   $��23��6Z   $��3q�6f   $��1��6q   $��Center=�6�   $	��120��6�   ��6~   �� *
LastName+ . 6�   5.      � 5/   
   $��1��6   .+�50      �� $
��Save��6   $
��Left=�52      $��25,5,0,0q�60   $	��Top=�53      $��75��6-   ��50   $   �� *SavePlayerCommand+y�51      �� *
EditMode+ �� 	Converter# [  53   -   �� 54      $	��Add��6   $
��Left=�56      $��25,5,0,0q�60   $	��Top=�57      $��75��6-   ��54   #   �� *SavePlayerCommand+y�55      �� *
EditMode+# [ 57   -   �� 58      $��Cancel��6   $
��Left=�6N   $��	150,5,0,0q�6i   $	��Top=�6|   $��75��6�   ��6&   �� *CancelPlayerCommand+6�   59      5:      5;      